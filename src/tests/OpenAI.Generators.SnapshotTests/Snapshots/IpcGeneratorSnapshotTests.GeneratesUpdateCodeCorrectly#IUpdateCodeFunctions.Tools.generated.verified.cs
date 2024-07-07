//HintName: IUpdateCodeFunctions.Tools.generated.cs

#nullable enable

namespace H.Ipc.Generator.IntegrationTests
{
    public static partial class UpdateCodeFunctionsExtensions
    {
        public static global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool> AsTools(this IUpdateCodeFunctions functions)
        {
            return new global::System.Collections.Generic.List<global::OpenAI.ChatCompletionTool>
            {
                new global::OpenAI.ChatCompletionTool
                {
                    Function = new global::OpenAI.FunctionObject
                    {
                        Name = "UpdateCode",
                        Description = "Allows to change the project code",
                        Parameters = new global::OpenAI.FunctionParameters
                    {
                        Type = "object",
                        Description = "Allows to change the project code",
                        Properties = new global::System.Collections.Generic.Dictionary<string, global::OpenAI.OpenApiSchema>
                        {
                            ["changes"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "array",
                                Description = "A series of code changes that must end with END change type",
                                Items = new global::OpenAI.OpenApiSchema
                                {
                                    Type = "object",
                                    Description = "",
                                    Properties = new global::System.Collections.Generic.Dictionary<string, global::OpenAI.OpenApiSchema>
                                    {
                                        ["Type"] = new global::OpenAI.OpenApiSchema
                                        {
                                            Type = "string",
                                            Description = "Describes the type of change to be made",
                                            Enum = new string[] { "createfile", "replacefragment", "deletefragment", "renamefile", "deletefile", "end" },
                                        },
                                        ["Path"] = new global::OpenAI.OpenApiSchema
                                        {
                                            Type = "string",
                                            Description = "Specifies the path to a file",
                                        },
                                        ["RemoveCode"] = new global::OpenAI.OpenApiSchema
                                        {
                                            Type = "string",
                                            Description = "Specifies the code to be removed. Used when deleting or replacing code.",
                                        },
                                        ["AddCode"] = new global::OpenAI.OpenApiSchema
                                        {
                                            Type = "string",
                                            Description = "Specifies the code to add. Used when creating a file or replacing code.",
                                        },
                                        ["NewPath"] = new global::OpenAI.OpenApiSchema
                                        {
                                            Type = "string",
                                            Description = "Specifies the new path for the file. Used when renaming a file.",
                                        }
                                    },
                                    Required = new string[] { "Type", "Path", "RemoveCode", "AddCode", "NewPath" },
                                },
                            }
                        },
                        Required = new string[] { "changes" },
                    },
                    },
                    Type = global::OpenAI.ChatCompletionToolType.Function,
                },
            };
        }
    }
}