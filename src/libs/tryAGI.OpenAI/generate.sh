#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://app.stainless.com/api/spec/documented/openai/openapi.documented.yml (+ AsyncAPI)

dotnet tool install --global autosdk.cli --prerelease
curl --fail --silent --show-error -L -o openapi.yaml https://app.stainless.com/api/spec/documented/openai/openapi.documented.yml

# build-asyncapi.py requires PyYAML; install it on first run (CI or fresh clones).
python3 -c "import yaml" 2>/dev/null || python3 -m pip install --quiet --user --break-system-packages pyyaml
python3 build-asyncapi.py

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
