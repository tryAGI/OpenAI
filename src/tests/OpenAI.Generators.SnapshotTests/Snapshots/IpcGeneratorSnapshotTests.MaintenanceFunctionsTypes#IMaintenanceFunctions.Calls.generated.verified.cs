//HintName: IMaintenanceFunctions.Calls.generated.cs

using System.Collections.Generic;

#nullable enable

namespace H.Ipc.Generator.IntegrationTests
{
    public static partial class MaintenanceFunctionsExtensions
    {
        public class GetContractTasksAsyncArgs
        {
            public global::H.Ipc.Generator.IntegrationTests.ExtractTasksRequest? Tasks { get; set; }
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

        public static MaintenanceFunctionsExtensions.GetContractTasksAsyncArgs AsGetContractTasksAsyncArgs(
            this IMaintenanceFunctions functions,
            string json)
        {
            return
                global::System.Text.Json.JsonSerializer.Deserialize<MaintenanceFunctionsExtensions.GetContractTasksAsyncArgs>(json, new global::System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                    Converters = {{ new global::System.Text.Json.Serialization.JsonStringEnumConverter(global::System.Text.Json.JsonNamingPolicy.CamelCase) }}
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