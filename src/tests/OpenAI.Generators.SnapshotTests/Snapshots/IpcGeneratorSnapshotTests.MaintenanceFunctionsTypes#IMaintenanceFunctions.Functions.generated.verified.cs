//HintName: IMaintenanceFunctions.Functions.generated.cs

using System.Collections.Generic;

#nullable enable

namespace H.Ipc.Generator.IntegrationTests
{
    public static class MaintenanceFunctionsExtensions
    {
        public class GetContractTasksAsyncArgs
        {
            public global::H.Ipc.Generator.IntegrationTests.ExtractTasksRequest? Tasks { get; set; }
        }

        public static (string Name, string Description, object Obj) GetContractTasksAsyncAsParametersObject(this IMaintenanceFunctions functions)
        {
            return ("GetContractTasksAsync", "Get the tasks to extract from a contract", new
            {
                type = "object",
                properties = new Dictionary<string, object>
                {
                    ["tasks"] = new
                    {
                        type = "object",
                        description = "The tasks extracted from the contract",
                        properties = new Dictionary<string, object>
                        {
                            ["Tasks"] = new
                            {
                                type = "array",
                                description = "",
                                items = new
                                {
                                    type = "string",
                                    description = "",
                                },
                            }
                        },
                        required = new string[] { "Tasks" },
                    }
                },
                required = new string[] { "tasks" },
            });
        }

        public static (string Name, string Description, Dictionary<string, object> Dictionary) GetContractTasksAsyncAsDictionary(this IMaintenanceFunctions functions)
        {
            return ("GetContractTasksAsync", "Get the tasks to extract from a contract", new Dictionary<string, object>
            {
                ["type"] = "object",
                ["properties"] = new Dictionary<string, object>
                {
                    ["tasks"] = new
                    {
                        type = "object",
                        description = "The tasks extracted from the contract",
                        properties = new Dictionary<string, object>
                        {
                            ["Tasks"] = new
                            {
                                type = "array",
                                description = "",
                                items = new
                                {
                                    type = "string",
                                    description = "",
                                },
                            }
                        },
                        required = new string[] { "Tasks" },
                    }
                },
                ["required"] = new string[] { "tasks" },
            });
        }

        public static global::System.Collections.Generic.ICollection<global::OpenAI.Function> AsFunctions(this IMaintenanceFunctions functions)
        {
            var (name0, description0, jsonNode0) = functions.GetContractTasksAsyncAsParametersJsonNode();

            return new global::System.Collections.Generic.List<global::OpenAI.Function>
            {
                new global::OpenAI.Function(
                    name: name0,
                    description: description0,
                    parameters: jsonNode0),
            };
        }

        public static global::System.Collections.Generic.IReadOnlyDictionary<string, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>>> AsCalls(this IMaintenanceFunctions service)
        {
            return new global::System.Collections.Generic.Dictionary<string, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>>>
            {
 
 
                ["GetContractTasksAsync"] = async (json, cancellationToken) =>
                {
                    return await service.CallGetContractTasksAsync(json, cancellationToken);
                },
 
            };
        }

        public static object GetContractTasksAsyncAsFunctionObject(this IMaintenanceFunctions functions)
        {
            var (name, description, parameters) = functions.GetContractTasksAsyncAsParametersObject();

            return new
            {
                name = name,
                description = description,
                parameters = parameters,
            };
        }

        public static (string Name, string Description, global::System.Text.Json.Nodes.JsonNode Node) GetContractTasksAsyncAsParametersJsonNode(this IMaintenanceFunctions functions)
        {
            var (name, description, parameters) = functions.GetContractTasksAsyncAsParametersObject();
            var node =
                global::System.Text.Json.JsonSerializer.SerializeToNode(parameters) ??
                throw new global::System.InvalidOperationException("Could not serialize parameters.");

            return (name, description, node);
        }

        public static MaintenanceFunctionsExtensions.GetContractTasksAsyncArgs AsGetContractTasksAsyncArgs(
            this IMaintenanceFunctions functions,
            string json)
        {
            return
                global::System.Text.Json.JsonSerializer.Deserialize<MaintenanceFunctionsExtensions.GetContractTasksAsyncArgs>(json, new global::System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                }) ??
                throw new global::System.InvalidOperationException("Could not deserialize JSON.");
        }

 

 

        public static async global::System.Threading.Tasks.Task<string> CallGetContractTasksAsync(
            this IMaintenanceFunctions functions,
            string json,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var args = functions.AsGetContractTasksAsyncArgs(json);
            var jsonResult = await functions.GetContractTasksAsync(args.Tasks, cancellationToken);

            return global::System.Text.Json.JsonSerializer.Serialize(jsonResult, new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                Converters = { new global::System.Text.Json.Serialization.JsonStringEnumConverter(global::System.Text.Json.JsonNamingPolicy.CamelCase) },
            });
        }

 

        public static async global::System.Threading.Tasks.Task<string> CallAsync(
            this IMaintenanceFunctions service,
            string functionName,
            string argumentsAsJson,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var calls = service.AsCalls();
            var func = calls[functionName];

            return await func(argumentsAsJson, cancellationToken);
        }
    }
}