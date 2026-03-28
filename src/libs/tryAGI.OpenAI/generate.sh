#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
curl --fail --silent --show-error -o openapi.yaml https://app.stainless.com/api/spec/documented/openai/openapi.documented.yml

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace tryAGI.OpenAI \
  --clientClassName OpenAiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --ignore-openapi-errors

autosdk generate asyncapi.json \
  --namespace tryAGI.OpenAI.Realtime \
  --websocket-class-name OpenAiRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated \
  --base-url wss://api.openai.com
