using H.Generators;
using H.Generators.Extensions;
using OpenAI.Generators.Core;

namespace OpenAI.Generators;

internal static partial class Sources
{
    /// <summary>
    /// https://swagger.io/docs/specification/data-models/data-types/
    /// </summary>
    /// <param name="parameter"></param>
    /// <param name="depth"></param>
    /// <param name="schema"></param>
    /// <returns></returns>
    public static string GenerateOpenApiSchema(OpenApiSchema parameter, int depth = 0, bool schema = true)
    {
        var indent = new string(' ', depth * 4);
        var name = schema ? "global::OpenAI.OpenApiSchema" : "global::OpenAI.FunctionParameters";
        if (parameter.ArrayItem.Count != 0)
        {
            return $@"new {name}
{indent}                    {{
{indent}                        Type = ""{parameter.SchemaType}"",
{indent}                        Description = ""{parameter.Description}"",
{indent}                        Items = {GenerateOpenApiSchema(parameter.ArrayItem.First(), depth: depth + 1)},
{indent}                    }}";
        }
        if (parameter.Properties.Count != 0)
        {
            return $@"new {name}
{indent}                    {{
{indent}                        Type = ""{parameter.SchemaType}"",
{indent}                        Description = ""{parameter.Description}"",
{indent}                        Properties = new global::System.Collections.Generic.Dictionary<string, global::OpenAI.OpenApiSchema>
{indent}                        {{
{indent}                            {string.Join(",\n                            " + indent, parameter.Properties.Select(x => $@"[""{x.Name}""] = " + GenerateOpenApiSchema(x, depth: depth + 2)))}
{indent}                        }},
{indent}                        Required = new string[] {{ {string.Join(", ", parameter.Properties
                                    .Where(static x => x.IsRequired)
                                    .Select(static x => $"\"{x.Name}\""))} }},
{indent}                    }}";
        }
        
        if (parameter.EnumValues.Count != 0)
        {
            return $@"new {name}
{indent}                    {{
{indent}                        Type = ""{parameter.SchemaType}"",
{indent}                        Description = ""{parameter.Description}"",
{indent}                        Enum = new string[] {{ {string.Join(", ", parameter.EnumValues.Select(static x => $"\"{x}\""))} }},
{indent}                    }}";
        }
        
        return $@"new {name}
{indent}                    {{
{indent}                        Type = ""{parameter.SchemaType}"",{(parameter.Format != null ? $@"
{indent}                        Format = ""{parameter.Format}""," : "")}
{indent}                        Description = ""{parameter.Description}"",
{indent}                    }}";
    }

    public static string GenerateClientImplementation(InterfaceData @interface)
    {
        var extensionsClassName = @interface.Name.Substring(startIndex: 1) + "Extensions";
        
        return @$"
#nullable enable

namespace {@interface.Namespace}
{{
    public static partial class {extensionsClassName}
    {{
        public static global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool> AsTools(this {@interface.Name} functions)
        {{
            return new global::System.Collections.Generic.List<global::OpenAI.ChatCompletionTool>
            {{
{@interface.Methods.Select(method => $@"
                new global::OpenAI.ChatCompletionTool
                {{
                    Function = new global::OpenAI.FunctionObject
                    {{
                        Name = ""{method.Name}"",
                        Description = ""{method.Description}"",
                        Strict = {(method.IsStrict ? "true" : "false")},
                        Parameters = {GenerateOpenApiSchema(method.Parameters, schema: false)},
                    }},
                    Type = global::OpenAI.ChatCompletionToolType.Function,
                }},
").Inject()}
            }};
        }}
    }}
}}";
    }
}
