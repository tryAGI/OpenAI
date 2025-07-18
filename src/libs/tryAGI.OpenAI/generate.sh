dotnet tool install --global autosdk.cli --prerelease
curl -o openapi.yaml https://app.stainless.com/api/spec/documented/openai/openapi.documented.yml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
  echo "Failed, exiting..."
  exit 1
fi
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace tryAGI.OpenAI \
  --clientClassName OpenAiClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --ignore-openapi-errors