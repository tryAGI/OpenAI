using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);
var extendedText = await File.ReadAllTextAsync(path.Replace(".yaml", ".extended.yaml"));

text = text.Replace("description: *run_temperature_description", "description: empty");
text = text.Replace("description: &run_temperature_description ", "description: ");

text = text.Replace("description: *run_top_p_description", "description: empty");
text = text.Replace("description: &run_top_p_description ", "description: ");

text = text.Replace("example: *moderation_example", "example: empty");
text = text.Replace("response: &moderation_example |", "response: |");

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);
var extendedOpenApiDocument = new OpenApiStringReader().Read(extendedText, out var extendedDiagnostics);
foreach (var schema in extendedOpenApiDocument.Components.Schemas)
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

openApiDocument.Components.Schemas["CreateChatCompletionRequest"]!.Properties["model"].AnyOf[1].Enum =
    openApiDocument.Components.Schemas["CreateChatCompletionRequest"]!.Properties["model"].AnyOf[1].Enum
        .DistinctBy(x => (x as OpenApiString)?.Value)
        .ToList();
openApiDocument.Components.Schemas["CreateAssistantRequest"]!.Properties["model"].AnyOf[1].Enum =
    openApiDocument.Components.Schemas["CreateAssistantRequest"]!.Properties["model"].AnyOf[1].Enum
        .DistinctBy(x => (x as OpenApiString)?.Value)
        .ToList();
openApiDocument.Components.Schemas["CreateRunRequest"]!.Properties["model"].AnyOf[1].Enum =
    openApiDocument.Components.Schemas["CreateRunRequest"]!.Properties["model"].AnyOf[1].Enum
        .DistinctBy(x => (x as OpenApiString)?.Value)
        .ToList();
openApiDocument.Components.Schemas["CreateThreadAndRunRequest"]!.Properties["model"].AnyOf[1].Enum =
    openApiDocument.Components.Schemas["CreateThreadAndRunRequest"]!.Properties["model"].AnyOf[1].Enum
        .DistinctBy(x => (x as OpenApiString)?.Value)
        .ToList();
    
text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);