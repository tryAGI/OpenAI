dotnet tool install --global openapigenerator.cli --prerelease
rm -rf Generated
mkdir Generated
curl -O https://raw.githubusercontent.com/openai/openai-openapi/master/openapi.yaml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
  echo "Failed, exiting..."
  exit 1
fi
oag generate openapi.yaml --namespace OpenAI -c OpenAiApi -o Generated -t net8.0