//HintName: IMaintenanceFunctions.Tools.generated.cs

#nullable enable

namespace H.Ipc.Generator.IntegrationTests
{
    public static partial class MaintenanceFunctionsExtensions
    {
        public static global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool> AsTools(this IMaintenanceFunctions functions)
        {
            return new global::System.Collections.Generic.List<global::OpenAI.ChatCompletionTool>
            {
                new global::OpenAI.ChatCompletionTool
                {
                    Function = new global::OpenAI.FunctionObject
                    {
                        Name = "GetContractTasksAsync",
                        Description = "Get the tasks to extract from a contract",
                        Parameters = new global::OpenAI.FunctionParameters
                    {
                        Type = "object",
                        Description = "Get the tasks to extract from a contract",
                        Properties = new global::System.Collections.Generic.Dictionary<string, global::OpenAI.OpenApiSchema>
                        {
                            ["tasks"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "object",
                                Description = "The tasks extracted from the contract",
                                Properties = new global::System.Collections.Generic.Dictionary<string, global::OpenAI.OpenApiSchema>
                                {
                                    ["Tasks"] = new global::OpenAI.OpenApiSchema
                                    {
                                        Type = "array",
                                        Description = "",
                                        Items = new global::OpenAI.OpenApiSchema
                                        {
                                            Type = "string",
                                            Description = "",
                                        },
                                    }
                                },
                                Required = new string[] { "Tasks" },
                            }
                        },
                        Required = new string[] { "tasks" },
                    },
                    },
                    Type = global::OpenAI.ChatCompletionToolType.Function,
                },
            };
        }
    }
}