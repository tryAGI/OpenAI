#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://app.stainless.com/api/spec/documented/openai/openapi.documented.yml (+ AsyncAPI)

use_pinned_spec=false
for arg in "$@"; do
  case "$arg" in
    --pinned-spec)
      use_pinned_spec=true
      ;;
    *)
      echo "Unknown argument: $arg" >&2
      exit 1
      ;;
  esac
done
if [[ "${TRYAGI_PINNED_SPEC:-0}" == "1" ]]; then
  use_pinned_spec=true
fi

dotnet tool update --global autosdk.cli --prerelease 2>/dev/null || dotnet tool install --global autosdk.cli --prerelease
if [[ "$use_pinned_spec" == false ]]; then
  curl --fail --silent --show-error -L -o openapi.yaml https://app.stainless.com/api/spec/documented/openai/openapi.documented.yml
elif [[ ! -f openapi.yaml ]]; then
  echo "error: --pinned-spec requested but openapi.yaml does not exist." >&2
  exit 1
fi

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
  --generate-http-exception-hierarchy \
  --generate-retry-handler \
  --generate-pageable-helpers \
  --generate-multipart-upload-helpers \
  --ignore-openapi-errors

rm -rf ../tryAGI.OpenAI.CLI/GeneratedApi
autosdk cli-project openapi.yaml \
  --output ../tryAGI.OpenAI.CLI/GeneratedApi \
  --api-only \
  --sdk-project ../tryAGI.OpenAI/tryAGI.OpenAI.csproj \
  --targetFramework net10.0 \
  --namespace tryAGI.OpenAI \
  --clientClassName OpenAiClient \
  --package-id tryAGI.OpenAI.CLI \
  --root-namespace tryAGI.OpenAI.Cli.GeneratedApi \
  --tool-command-name tryagi-openai \
  --user-secrets-id tryAGI.OpenAI.CLI \
  --api-key-env-var OPENAI_API_KEY \
  --base-url-env-var OPENAI_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --ignore-openapi-errors

autosdk generate asyncapi.json \
  --namespace tryAGI.OpenAI.Realtime \
  --websocket-class-name OpenAiRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated \
  --base-url wss://api.openai.com

# Regenerate the Claude skill bundle (SKILL.md + commands.md + auth.md) from the spec.
autosdk skill openapi.yaml \
  --package-id tryAGI.OpenAI.CLI \
  --output ../../../.claude/skills/tryagi-openai \
  --homepage https://github.com/tryAGI/OpenAI \
  --api-key-env-var OPENAI_API_KEY
