using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var jsonOrYaml = await File.ReadAllTextAsync(path);

jsonOrYaml = jsonOrYaml.Replace("minimum: -9223372036854776000", "");

if (OpenApi31Support.IsOpenApi31(jsonOrYaml))
{
    jsonOrYaml = OpenApi31Support.ConvertToOpenApi30(jsonOrYaml);
}

var realtimeText = await File.ReadAllTextAsync(path.Replace(".yaml", ".realtime.yaml"));

var openApiDocument = new OpenApiStringReader().Read(jsonOrYaml, out var diagnostics);
var realtimeOpenApiDocument = new OpenApiStringReader().Read(realtimeText, out var realtimeDiagnostics);
foreach (var schema in realtimeOpenApiDocument.Components.Schemas)
{
    openApiDocument.Components.Schemas[schema.Key] = schema.Value;
}

openApiDocument.Components.Schemas["ParallelToolCalls"]!.Default = null;
openApiDocument.Components.Schemas["ParallelToolCalls"]!.Nullable = true;

openApiDocument.Components.Schemas["CreateEmbeddingRequest"]!.Properties["dimensions"].Nullable = true;

openApiDocument.Components.Schemas["CreateChatCompletionResponse"]!.Properties["choices"].Items.Required.Remove("logprobs");

openApiDocument.Components.Schemas["ChatCompletionResponseMessage"]!.Required.Remove("content");
openApiDocument.Components.Schemas["ChatCompletionResponseMessage"]!.Required.Remove("refusal");

openApiDocument.Components.Schemas["MessageObject"]!.Required.Remove("status");
openApiDocument.Components.Schemas["MessageObject"]!.Required.Remove("incomplete_details");
openApiDocument.Components.Schemas["MessageObject"]!.Required.Remove("completed_at");
openApiDocument.Components.Schemas["MessageObject"]!.Required.Remove("incomplete_at");

openApiDocument.Components.Schemas["RunStepObject"]!.Required.Remove("expired_at");
openApiDocument.Components.Schemas["RunStepObject"]!.Required.Remove("metadata");

openApiDocument.Paths["/files/{file_id}/content"]!.Operations[OperationType.Get].Responses["200"]!.Content.Remove("application/json");
openApiDocument.Paths["/files/{file_id}/content"]!.Operations[OperationType.Get].Responses["200"]!.Content.Add(
    "application/octet-stream",
    new OpenApiMediaType
    {
        Schema = new OpenApiSchema
        {
            Type = "string",
            Format = "binary",
        }
    });
//
// openApiDocument.Components.Schemas["CreateChatCompletionRequest"]!.Properties["model"].AnyOf[1].Enum =
//     openApiDocument.Components.Schemas["CreateChatCompletionRequest"]!.Properties["model"].AnyOf[1].Enum
//         .DistinctBy(x => (x as OpenApiString)?.Value)
//         .ToList();
// openApiDocument.Components.Schemas["CreateAssistantRequest"]!.Properties["model"].AnyOf[1].Enum =
//     openApiDocument.Components.Schemas["CreateAssistantRequest"]!.Properties["model"].AnyOf[1].Enum
//         .DistinctBy(x => (x as OpenApiString)?.Value)
//         .ToList();
// openApiDocument.Components.Schemas["CreateRunRequest"]!.Properties["model"].AnyOf[1].Enum =
//     openApiDocument.Components.Schemas["CreateRunRequest"]!.Properties["model"].AnyOf[1].Enum
//         .DistinctBy(x => (x as OpenApiString)?.Value)
//         .ToList();
// openApiDocument.Components.Schemas["CreateThreadAndRunRequest"]!.Properties["model"].AnyOf[1].Enum =
//     openApiDocument.Components.Schemas["CreateThreadAndRunRequest"]!.Properties["model"].AnyOf[1].Enum
//         .DistinctBy(x => (x as OpenApiString)?.Value)
//         .ToList();
    
jsonOrYaml = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(jsonOrYaml, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    //Environment.Exit(1);
}

await File.WriteAllTextAsync(path, jsonOrYaml);