#!/usr/bin/env python3
"""Small live Mercury 3 TTFT probe; credentials come only from the environment."""
import argparse
import datetime
import json
import os
import statistics
import time
import urllib.error
import urllib.request


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--route', choices=['direct', 'openrouter'], default='direct')
    parser.add_argument('--effort', choices=['instant', 'low', 'medium', 'high'], default='low')
    parser.add_argument('--samples', type=int, choices=range(1, 11), default=5)
    args = parser.parse_args()
    if args.route == 'openrouter' and args.effort == 'instant':
        parser.error('instant is a direct Inception setting; use low for OpenRouter')
    variable = 'INCEPTION_API_KEY' if args.route == 'direct' else 'OPENROUTER_API_KEY'
    key = os.environ.get(variable)
    if not key:
        parser.error(f'{variable} is missing or empty')
    base = 'https://api.inceptionlabs.ai/v1' if args.route == 'direct' else 'https://openrouter.ai/api/v1'
    model = 'mercury-3' if args.route == 'direct' else 'inception/mercury-3'
    payload = {'model': model, 'messages': [{'role': 'user', 'content': 'In one short sentence, explain why the sky is blue.'}],
               'stream': True, 'max_tokens': 128, 'temperature': 0, 'reasoning_effort': args.effort}
    rows = []
    for index in range(args.samples):
        request = urllib.request.Request(base + '/chat/completions', data=json.dumps(payload).encode(),
                                         headers={'Authorization': 'Bearer ' + key, 'Content-Type': 'application/json'})
        start = time.perf_counter()
        row = {'sample': index + 1}
        answer = ''
        event_lines = []
        finished = False

        def process_event():
            nonlocal answer, finished
            if not event_lines:
                return
            data = '\n'.join(event_lines)
            elapsed = round((time.perf_counter() - start) * 1000, 2)
            row.setdefault('first_event_ms', elapsed)
            if data == '[DONE]':
                finished = True
                return
            event = json.loads(data)
            if 'error' in event:
                raise ValueError('API returned an error event')
            for choice in event.get('choices', []):
                text = choice.get('delta', {}).get('content')
                if text:
                    row.setdefault('ttft_ms', elapsed)
                    answer += text
                if choice.get('finish_reason'):
                    row['finish_reason'] = choice['finish_reason']
            if event.get('usage'):
                row['usage'] = event['usage']

        try:
            with urllib.request.urlopen(request, timeout=45) as response:
                row['headers_ms'] = round((time.perf_counter() - start) * 1000, 2)
                if 'text/event-stream' not in response.headers.get('Content-Type', ''):
                    raise ValueError('Expected an SSE response')
                for raw in response:
                    line = raw.decode('utf-8').rstrip('\r\n')
                    if not line:
                        process_event()
                        event_lines.clear()
                        if finished:
                            break
                    elif line.startswith('data:'):
                        event_lines.append(line[5:].lstrip(' '))
                process_event()
            row['total_ms'] = round((time.perf_counter() - start) * 1000, 2)
            row['answer_characters'] = len(answer)
            row['success'] = bool(answer) and (finished or bool(row.get('finish_reason')))
        except urllib.error.HTTPError as error:
            row.update(success=False, http_status=error.code)
        except urllib.error.URLError as error:
            row.update(success=False, error_type=type(error.reason).__name__)
        except Exception as error:
            # Do not print error messages or response bodies that could expose credentials.
            row.update(success=False, error_type=type(error).__name__)
        rows.append(row)
        print(json.dumps(row), flush=True)
        if not row['success']:
            break
    values = [row['ttft_ms'] for row in rows if row['success']]
    summary = {'utc': datetime.datetime.now(datetime.timezone.utc).isoformat(), 'route': args.route,
               'model': model, 'effort': args.effort, 'requested_samples': args.samples,
               'successful_samples': len(values), 'connection': 'fresh per request', 'samples': rows}
    if values:
        summary.update(ttft_min_ms=min(values), ttft_median_ms=statistics.median(values), ttft_max_ms=max(values))
    print(json.dumps(summary, indent=2))
    return 0 if len(values) == args.samples else 1


if __name__ == '__main__':
    raise SystemExit(main())
