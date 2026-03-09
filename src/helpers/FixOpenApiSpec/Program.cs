using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

yamlOrJson = yamlOrJson.Replace("minimum: -9223372036854776000", "");

var realtimeText = await File.ReadAllTextAsync(path.Replace(".yaml", ".realtime.yaml"));

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);
var realtimeOpenApiDocument = realtimeText.GetOpenApiDocument(Settings.Default);
foreach (var schema in realtimeOpenApiDocument.Components!.Schemas!)
{
    openApiDocument.Components!.Schemas![schema.Key] = schema.Value;
}

((OpenApiSchema)openApiDocument.Components!.Schemas!["ParallelToolCalls"]!).Default = null;
((OpenApiSchema)openApiDocument.Components.Schemas["ParallelToolCalls"]!).Type |= JsonSchemaType.Null;

((OpenApiSchema)openApiDocument.Components.Schemas["CreateEmbeddingRequest"]!.Properties!["dimensions"]!).Type |= JsonSchemaType.Null;

((OpenApiSchema)openApiDocument.Components.Schemas["CreateChatCompletionResponse"]!.Properties!["choices"]!).Items!.Required!.Remove("logprobs");

((OpenApiSchema)openApiDocument.Components.Schemas["ChatCompletionResponseMessage"]!).Required!.Remove("content");
((OpenApiSchema)openApiDocument.Components.Schemas["ChatCompletionResponseMessage"]!).Required!.Remove("refusal");

((OpenApiSchema)openApiDocument.Components.Schemas["MessageObject"]!).Required!.Remove("status");
((OpenApiSchema)openApiDocument.Components.Schemas["MessageObject"]!).Required!.Remove("incomplete_details");
((OpenApiSchema)openApiDocument.Components.Schemas["MessageObject"]!).Required!.Remove("completed_at");
((OpenApiSchema)openApiDocument.Components.Schemas["MessageObject"]!).Required!.Remove("incomplete_at");

((OpenApiSchema)openApiDocument.Components.Schemas["RunStepObject"]!).Required!.Remove("expired_at");
((OpenApiSchema)openApiDocument.Components.Schemas["RunStepObject"]!).Required!.Remove("metadata");

openApiDocument.Paths!["/files/{file_id}/content"]!.Operations[System.Net.Http.HttpMethod.Get]!.Responses!["200"]!.Content!.Remove("application/json");
openApiDocument.Paths["/files/{file_id}/content"]!.Operations[System.Net.Http.HttpMethod.Get]!.Responses!["200"]!.Content!.Add(
    "application/octet-stream",
    new OpenApiMediaType
    {
        Schema = new OpenApiSchema
        {
            Type = JsonSchemaType.String,
            Format = "binary",
        }
    });

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
