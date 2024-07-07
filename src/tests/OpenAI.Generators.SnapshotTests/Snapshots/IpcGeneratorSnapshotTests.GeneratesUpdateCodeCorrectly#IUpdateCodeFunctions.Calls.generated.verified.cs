//HintName: IUpdateCodeFunctions.Calls.generated.cs

using System.Collections.Generic;

#nullable enable

namespace H.Ipc.Generator.IntegrationTests
{
    public static partial class UpdateCodeFunctionsExtensions
    {
        public class UpdateCodeArgs
        {
            public global::System.Collections.Generic.IReadOnlyCollection<global::H.Ipc.Generator.IntegrationTests.Change>? Changes { get; set; }
        }

        public static global::System.Collections.Generic.IReadOnlyDictionary<string, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>>> AsCalls(this IUpdateCodeFunctions service)
        {
            return new global::System.Collections.Generic.Dictionary<string, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>>>
            {
 
                ["UpdateCode"] = (json, _) =>
                {
                    service.CallUpdateCode(json);

                    return global::System.Threading.Tasks.Task.FromResult(string.Empty);
                },
 
 
            };
        }

        public static UpdateCodeFunctionsExtensions.UpdateCodeArgs AsUpdateCodeArgs(
            this IUpdateCodeFunctions functions,
            string json)
        {
            return
                global::System.Text.Json.JsonSerializer.Deserialize<UpdateCodeFunctionsExtensions.UpdateCodeArgs>(json, new global::System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                    Converters = {{ new global::System.Text.Json.Serialization.JsonStringEnumConverter(global::System.Text.Json.JsonNamingPolicy.CamelCase) }}
                }) ??
                throw new global::System.InvalidOperationException("Could not deserialize JSON.");
        }

 

        public static void CallUpdateCode(this IUpdateCodeFunctions functions, string json)
        {
            var args = functions.AsUpdateCodeArgs(json);
            functions.UpdateCode(args.Changes);
        }

 

 

        public static async global::System.Threading.Tasks.Task<string> CallAsync(
            this IUpdateCodeFunctions service,
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