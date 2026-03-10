using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var realtimeText = await File.ReadAllTextAsync(path.Replace(".yaml", ".realtime.yaml"));

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);
var realtimeOpenApiDocument = realtimeText.GetOpenApiDocument(Settings.Default);
foreach (var schema in realtimeOpenApiDocument.Components!.Schemas!)
{
    openApiDocument.Components!.Schemas![schema.Key] = schema.Value;
}

// Make embedding dimensions nullable (spec omits this but the field is optional)
if (openApiDocument.Components!.Schemas!["CreateEmbeddingRequest"]!.Properties!["dimensions"] is OpenApiSchema dimensionsSchema)
{
    dimensionsSchema.Type |= JsonSchemaType.Null;
}

// Fix file download endpoint: spec says application/json but endpoint returns binary
var fileContentResponse = openApiDocument.Paths!["/files/{file_id}/content"]!.Operations[System.Net.Http.HttpMethod.Get]!.Responses!["200"]!.Content!;
fileContentResponse.Remove("application/json");
if (!fileContentResponse.ContainsKey("application/octet-stream"))
{
    fileContentResponse.Add(
        "application/octet-stream",
        new OpenApiMediaType
        {
            Schema = new OpenApiSchema
            {
                Type = JsonSchemaType.String,
                Format = "binary",
            }
        });
}

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
