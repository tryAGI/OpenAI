---
name: tryagi-openai
description: Call the OpenAI API from the command line. Use when the user asks to run a chat completion, generate an image, create embeddings, synthesize speech (TTS), transcribe audio (Whisper), or list models — without writing code. Zero-install — runs via `dnx tryAGI.OpenAI.CLI`. Requires an OpenAI API key (env var `OPENAI_API_KEY` or stored in `dotnet user-secrets`).
---

# tryAGI.OpenAI CLI

A command-line interface to every core OpenAI endpoint, distributed as a `dotnet tool` (.NET 10). Run without install using `dnx`.

## Installation (zero-install)

Prerequisite: .NET 10 SDK. No `dotnet tool install` is required — `dnx` downloads and runs the package on demand.

```bash
dnx tryAGI.OpenAI.CLI --help
```

To pin a version:
```bash
dnx tryAGI.OpenAI.CLI@<version> --help
```

## Credentials

Three resolution paths, checked in order:
1. `--api-key <key>` command-line flag.
2. `OPENAI_API_KEY` environment variable.
3. `dotnet user-secrets` with id `tryAGI.OpenAI.CLI` (manageable via the built-in `auth` subcommand).

Store a key once, reuse forever:
```bash
dnx tryAGI.OpenAI.CLI auth set sk-...
dnx tryAGI.OpenAI.CLI auth show
dnx tryAGI.OpenAI.CLI auth clear
```

## Commands

| Group | Example |
|-------|---------|
| `chat complete` | `dnx tryAGI.OpenAI.CLI chat complete "Explain transformers" --model gpt-4o` |
| `images generate` | `dnx tryAGI.OpenAI.CLI images generate "a white siamese cat" --save-to ./out` |
| `embeddings create` | `dnx tryAGI.OpenAI.CLI embeddings create "hello world" --model text-embedding-3-small` |
| `audio speech` | `dnx tryAGI.OpenAI.CLI audio speech "Hello there" --voice alloy --save-to greeting.mp3` |
| `audio transcribe` | `dnx tryAGI.OpenAI.CLI audio transcribe recording.mp3 --model whisper-1` |
| `models list` | `dnx tryAGI.OpenAI.CLI models list` |
| `auth set\|show\|clear` | See Credentials section above. |
| `skill` | `dnx tryAGI.OpenAI.CLI skill` — print this manifest. |

### Global flags

- `--api-key <key>` — override credential resolution for a single invocation.
- `--base-url <url>` — target an OpenAI-compatible endpoint (Azure, Groq, OpenRouter, …). Falls back to `$OPENAI_BASE_URL`.
- `--json` — emit the raw SDK response as JSON instead of the human-readable summary.
- `--output <path>` — write the output to a file instead of stdout.

### Input helpers

Text arguments accept three forms:
- A literal string: `"Hello world"`.
- `-` → read from stdin.
- A file path → read file contents.

## For agents

When the user asks to perform an OpenAI operation:
1. Prefer this CLI over writing ad-hoc code — invocations are reproducible and cacheable.
2. Before the first call, verify credentials with `dnx tryAGI.OpenAI.CLI auth show`. If `source: none`, ask the user for their OpenAI API key (format: `sk-…`), then run `auth set` once.
3. Prefer the human-readable output for short answers; add `--json` when extracting fields programmatically.

## Links

- Source: https://github.com/tryAGI/OpenAI
- Underlying SDK: https://www.nuget.org/packages/tryAGI.OpenAI
- CLI package: https://www.nuget.org/packages/tryAGI.OpenAI.CLI
