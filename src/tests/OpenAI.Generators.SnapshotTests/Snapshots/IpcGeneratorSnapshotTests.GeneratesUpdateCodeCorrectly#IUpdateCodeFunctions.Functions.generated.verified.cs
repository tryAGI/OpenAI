//HintName: IUpdateCodeFunctions.Functions.generated.cs

using System.Collections.Generic;

#nullable enable

namespace H.Ipc.Generator.IntegrationTests
{
    public static class UpdateCodeFunctionsExtensions
    {
        public class UpdateCodeArgs
        {
            public global::System.Collections.Generic.IReadOnlyCollection<global::H.Ipc.Generator.IntegrationTests.Change>? Changes { get; set; }
        }

        public static (string Name, string Description, object Obj) UpdateCodeAsParametersObject(this IUpdateCodeFunctions functions)
        {
            return ("UpdateCode", "Allows to change the project code", new
            {
                type = "object",
                properties = new Dictionary<string, object>
                {
                    ["changes"] = new
                    {
                        type = "array",
                        description = "A series of code changes that must end with END change type",
                        items = new
                        {
                            type = "object",
                            description = "",
                            properties = new Dictionary<string, object>
                            {
                                ["Type"] = new
                                {
                                    type = "string",
                                    description = "Describes the type of change to be made",
                                    @enum = new string[] { "createfile", "replacefragment", "deletefragment", "renamefile", "deletefile", "end" },
                                },
                                ["Path"] = new
                                {
                                    type = "string",
                                    description = "Specifies the path to a file",
                                },
                                ["RemoveCode"] = new
                                {
                                    type = "string",
                                    description = "Specifies the code to be removed. Used when deleting or replacing code.",
                                },
                                ["AddCode"] = new
                                {
                                    type = "string",
                                    description = "Specifies the code to add. Used when creating a file or replacing code.",
                                },
                                ["NewPath"] = new
                                {
                                    type = "string",
                                    description = "Specifies the new path for the file. Used when renaming a file.",
                                }
                            },
                            required = new string[] { "Type", "Path", "RemoveCode", "AddCode", "NewPath" },
                        },
                    }
                },
                required = new string[] { "changes" },
            });
        }

        public static (string Name, string Description, Dictionary<string, object> Dictionary) UpdateCodeAsDictionary(this IUpdateCodeFunctions functions)
        {
            return ("UpdateCode", "Allows to change the project code", new Dictionary<string, object>
            {
                ["type"] = "object",
                ["properties"] = new Dictionary<string, object>
                {
                    ["changes"] = new
                    {
                        type = "array",
                        description = "A series of code changes that must end with END change type",
                        items = new
                        {
                            type = "object",
                            description = "",
                            properties = new Dictionary<string, object>
                            {
                                ["Type"] = new
                                {
                                    type = "string",
                                    description = "Describes the type of change to be made",
                                    @enum = new string[] { "createfile", "replacefragment", "deletefragment", "renamefile", "deletefile", "end" },
                                },
                                ["Path"] = new
                                {
                                    type = "string",
                                    description = "Specifies the path to a file",
                                },
                                ["RemoveCode"] = new
                                {
                                    type = "string",
                                    description = "Specifies the code to be removed. Used when deleting or replacing code.",
                                },
                                ["AddCode"] = new
                                {
                                    type = "string",
                                    description = "Specifies the code to add. Used when creating a file or replacing code.",
                                },
                                ["NewPath"] = new
                                {
                                    type = "string",
                                    description = "Specifies the new path for the file. Used when renaming a file.",
                                }
                            },
                            required = new string[] { "Type", "Path", "RemoveCode", "AddCode", "NewPath" },
                        },
                    }
                },
                ["required"] = new string[] { "changes" },
            });
        }

        public static global::System.Collections.Generic.ICollection<global::tryAGI.OpenAI.ChatCompletionFunctions> AsFunctions(this IUpdateCodeFunctions functions)
        {
            var function0 = functions.UpdateCodeAsDictionary();

            return new global::System.Collections.Generic.List<global::tryAGI.OpenAI.ChatCompletionFunctions>
            {
                new global::tryAGI.OpenAI.ChatCompletionFunctions()
                {
                    Name = function0.Name,
                    Description = function0.Description,
                    Parameters = new global::tryAGI.OpenAI.ChatCompletionFunctionParameters
                    {
                        AdditionalProperties = function0.Dictionary,
                    },
                },
            };
        }

        public static object UpdateCodeAsFunctionObject(this IUpdateCodeFunctions functions)
        {
            var (name, description, parameters) = functions.UpdateCodeAsParametersObject();

            return new
            {
                name = name,
                description = description,
                parameters = parameters,
            };
        }

        public static (string Name, string Description, global::System.Text.Json.Nodes.JsonNode Node) UpdateCodeAsParametersJsonNode(this IUpdateCodeFunctions functions)
        {
            var (name, description, parameters) = functions.UpdateCodeAsParametersObject();
            var node =
                global::System.Text.Json.JsonSerializer.SerializeToNode(parameters) ??
                throw new global::System.InvalidOperationException("Could not serialize parameters.");

            return (name, description, node);
        }

        public static UpdateCodeFunctionsExtensions.UpdateCodeArgs AsUpdateCodeArgs(
            this IUpdateCodeFunctions functions,
            string json)
        {
            return
                global::System.Text.Json.JsonSerializer.Deserialize<UpdateCodeFunctionsExtensions.UpdateCodeArgs>(json, new global::System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                }) ??
                throw new global::System.InvalidOperationException("Could not deserialize JSON.");
        }

 

        public static void CallUpdateCode(this IUpdateCodeFunctions functions, string json)
        {
            var args = functions.AsUpdateCodeArgs(json);
            functions.UpdateCode(args.Changes);
        }

 
    }
}