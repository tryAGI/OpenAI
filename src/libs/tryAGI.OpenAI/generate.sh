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
