//HintName: IVariousTypesTools.Tools.generated.cs

#nullable enable

namespace OpenAI.IntegrationTests
{
    public static partial class VariousTypesToolsExtensions
    {
        public static global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool> AsTools(this IVariousTypesTools functions)
        {
            return new global::System.Collections.Generic.List<global::OpenAI.ChatCompletionTool>
            {
                new global::OpenAI.ChatCompletionTool
                {
                    Function = new global::OpenAI.FunctionObject
                    {
                        Name = "GetCurrentWeather",
                        Description = "Get the current weather in a given location",
                        Strict = false,
                        Parameters = new global::OpenAI.FunctionParameters
                    {
                        Type = "object",
                        Description = "Get the current weather in a given location",
                        Properties = new global::System.Collections.Generic.Dictionary<string, global::OpenAI.OpenApiSchema>
                        {
                            ["parameter1"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "integer",
                                Format = "int64",
                                Description = "",
                            },
                            ["parameter2"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "integer",
                                Format = "int32",
                                Description = "",
                            },
                            ["parameter3"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "number",
                                Format = "float",
                                Description = "",
                            },
                            ["parameter4"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "number",
                                Format = "double",
                                Description = "",
                            },
                            ["parameter5"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "boolean",
                                Description = "",
                            },
                            ["dateTime"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "string",
                                Format = "date-time",
                                Description = "",
                            },
                            ["date"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "string",
                                Format = "date",
                                Description = "",
                            }
                        },
                        Required = new string[] { "parameter1", "parameter2", "parameter3", "parameter4", "parameter5", "dateTime", "date" },
                    },
                    },
                    Type = global::OpenAI.ChatCompletionToolType.Function,
                },
            };
        }
    }
}