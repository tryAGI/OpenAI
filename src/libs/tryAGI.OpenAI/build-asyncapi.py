#!/usr/bin/env python3
"""Synthesize asyncapi.json from openapi.yaml.

OpenAI doesn't publish an AsyncAPI spec for the Realtime WebSocket API, but the
OpenAPI spec already contains every event payload as a `Realtime{Client,Server}Event*`
schema. This script stitches those schemas into a self-contained AsyncAPI 3.0
document so AutoSDK's WebSocket generator can consume them.

Run after fetching openapi.yaml; invoked by generate.sh.
"""
from __future__ import annotations

import argparse
import json
import re
import sys
from pathlib import Path

import yaml

HERE = Path(__file__).resolve().parent
DEFAULT_OPENAPI_PATH = HERE / "openapi.yaml"
DEFAULT_ASYNCAPI_PATH = HERE / "asyncapi.json"


def find_refs(node, refs: set[str] | None = None) -> set[str]:
    if refs is None:
        refs = set()
    if isinstance(node, dict):
        for k, v in node.items():
            if k == "$ref" and isinstance(v, str) and v.startswith("#/components/schemas/"):
                refs.add(v.rsplit("/", 1)[-1])
            else:
                find_refs(v, refs)
    elif isinstance(node, list):
        for item in node:
            find_refs(item, refs)
    return refs


def transitive_closure(all_schemas: dict, seed: set[str]) -> set[str]:
    included = set(seed)
    pending: set[str] = set()
    for name in seed:
        pending |= find_refs(all_schemas.get(name, {}))
    pending -= included
    while pending:
        next_batch: set[str] = set()
        for name in pending:
            if name in all_schemas:
                included.add(name)
                next_batch |= find_refs(all_schemas[name])
        pending = next_batch - included
    return included


def type_string_of(schema: dict) -> str | None:
    props = (schema or {}).get("properties") or {}
    type_prop = props.get("type") or {}
    enum = type_prop.get("enum") or []
    return enum[0] if enum else None


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--input", type=Path, default=DEFAULT_OPENAPI_PATH,
                        help=f"Path to openapi.yaml (default: {DEFAULT_OPENAPI_PATH})")
    parser.add_argument("--output", type=Path, default=DEFAULT_ASYNCAPI_PATH,
                        help=f"Path to write asyncapi.json (default: {DEFAULT_ASYNCAPI_PATH})")
    args = parser.parse_args()

    spec = yaml.safe_load(args.input.read_text())
    all_schemas: dict = spec["components"]["schemas"]

    client_events: dict[str, tuple[str, str]] = {}
    server_events: dict[str, tuple[str, str]] = {}

    for name, schema in all_schemas.items():
        m = re.match(r"^Realtime(Client|Server)Event(.+)$", name)
        if not m:
            continue
        kind, rest = m.group(1), m.group(2)
        if schema.get("anyOf") or schema.get("oneOf"):
            continue
        type_str = type_string_of(schema)
        if not type_str:
            continue
        target = client_events if kind == "Client" else server_events
        target[rest] = (name, type_str)

    seed = {"RealtimeServerEvent", "RealtimeClientEvent"}
    seed |= {s for s, _ in client_events.values()}
    seed |= {s for s, _ in server_events.values()}
    seed = {s for s in seed if s in all_schemas}

    included = transitive_closure(all_schemas, seed)
    inline_schemas = {k: all_schemas[k] for k in sorted(included)}

    channel_messages: dict = {}
    component_messages: dict = {}
    operations: dict = {}

    for rest in sorted(client_events, key=lambda r: client_events[r][1]):
        schema_name, type_str = client_events[rest]
        msg_name = rest
        component_messages[msg_name] = {
            "name": msg_name,
            "title": type_str,
            "payload": {"$ref": f"#/components/schemas/{schema_name}"},
        }
        channel_messages[msg_name] = {"$ref": f"#/components/messages/{msg_name}"}
        operations[f"send{rest}"] = {
            "action": "send",
            "channel": {"$ref": "#/channels/realtime"},
            "messages": [{"$ref": f"#/channels/realtime/messages/{msg_name}"}],
        }

    for rest in sorted(server_events, key=lambda r: server_events[r][1]):
        schema_name, type_str = server_events[rest]
        msg_name = rest
        component_messages[msg_name] = {
            "name": msg_name,
            "title": type_str,
            "payload": {"$ref": f"#/components/schemas/{schema_name}"},
        }
        channel_messages[msg_name] = {"$ref": f"#/components/messages/{msg_name}"}

    component_messages["ServerEvent"] = {
        "name": "ServerEvent",
        "title": "Realtime Server Event",
        "summary": "Discriminated union of all server-sent realtime events.",
        "payload": {"$ref": "#/components/schemas/RealtimeServerEvent"},
    }
    channel_messages["ServerEvent"] = {"$ref": "#/components/messages/ServerEvent"}
    operations["receiveServerEvent"] = {
        "action": "receive",
        "channel": {"$ref": "#/channels/realtime"},
        "messages": [{"$ref": "#/channels/realtime/messages/ServerEvent"}],
    }

    doc = {
        "asyncapi": "3.0.0",
        "info": {
            "title": "OpenAI Realtime API",
            "version": "1.0.0",
            "description": (
                "OpenAI Realtime API for bidirectional audio/text conversations over "
                "WebSocket.\n\nAuto-generated from openapi.yaml by build-asyncapi.py "
                "— do not edit by hand."
            ),
        },
        "servers": {
            "production": {
                "host": "api.openai.com",
                "pathname": "/v1/realtime",
                "protocol": "wss",
                "description": "OpenAI Realtime WebSocket server",
                "security": [{"$ref": "#/components/securitySchemes/bearer"}],
            }
        },
        "channels": {
            "realtime": {"address": "/v1/realtime", "messages": channel_messages}
        },
        "operations": operations,
        "components": {
            "securitySchemes": {
                "bearer": {
                    "type": "http",
                    "scheme": "bearer",
                    "description": "OpenAI API key as a Bearer token.",
                }
            },
            "messages": component_messages,
            "schemas": inline_schemas,
        },
    }

    args.output.write_text(json.dumps(doc, indent=2) + "\n")
    print(
        f"Wrote {args.output}: "
        f"{len(client_events)} client events, "
        f"{len(server_events)} server events, "
        f"{len(inline_schemas)} schemas"
    )
    return 0


if __name__ == "__main__":
    sys.exit(main())
