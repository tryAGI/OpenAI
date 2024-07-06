using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text.Replace("description: *run_temperature_description", "description: empty");
text = text.Replace("description: &run_temperature_description ", "description: ");

text = text.Replace("description: *run_top_p_description", "description: empty");
text = text.Replace("description: &run_top_p_description ", "description: ");

_ = new OpenApiStringReader().Read(text, out var diagnostics);
// openApiDocument.Components.Schemas["CreateAssistantRequest"]!.Properties["temperature"]!.Description = string.Empty;

// text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
// openApiDocument = new OpenApiStringReader().Read(text, out diagnostics);

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