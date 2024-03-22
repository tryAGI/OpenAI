namespace H.Generators;

internal static class SourceGenerationHelper
{
    /// <summary>
    /// https://swagger.io/docs/specification/data-models/data-types/
    /// </summary>
    /// <param name="parameter"></param>
    /// <param name="depth"></param>
    /// <returns></returns>
    public static string GenerateOpenApiSchema(ParameterData parameter, int depth = 0)
    {
        var indent = new string(' ', depth * 4);
        if (parameter.ArrayItem.Count != 0)
        {
            return $@"new
{indent}                    {{
{indent}                        type = ""{parameter.SchemaType}"",
{indent}                        description = ""{parameter.Description}"",
{indent}                        items = {GenerateOpenApiSchema(parameter.ArrayItem.First(), depth: depth + 1)},
{indent}                    }}";
        }
        if (parameter.Properties.Count != 0)
        {
            return $@"new
{indent}                    {{
{indent}                        type = ""{parameter.SchemaType}"",
{indent}                        description = ""{parameter.Description}"",
{indent}                        properties = new Dictionary<string, object>
{indent}                        {{
{indent}                            {string.Join(",\n                            " + indent, parameter.Properties.Select(x => $@"[""{x.Name}""] = " + GenerateOpenApiSchema(x, depth: depth + 2)))}
{indent}                        }},
{indent}                        required = new string[] {{ {string.Join(", ", parameter.Properties
                                    .Where(static x => x.IsRequired)
                                    .Select(static x => $"\"{x.Name}\""))} }},
{indent}                    }}";
        }
        
        if (parameter.EnumValues.Count != 0)
        {
            return $@"new
{indent}                    {{
{indent}                        type = ""{parameter.SchemaType}"",
{indent}                        description = ""{parameter.Description}"",
{indent}                        @enum = new string[] {{ {string.Join(", ", parameter.EnumValues.Select(static x => $"\"{x}\""))} }},
{indent}                    }}";
        }
        
        return $@"new
{indent}                    {{
{indent}                        type = ""{parameter.SchemaType}"",{(parameter.Format != null ? $@"
{indent}                        format = ""{parameter.Format}""," : "")}
{indent}                        description = ""{parameter.Description}"",
{indent}                    }}";
    }
}
