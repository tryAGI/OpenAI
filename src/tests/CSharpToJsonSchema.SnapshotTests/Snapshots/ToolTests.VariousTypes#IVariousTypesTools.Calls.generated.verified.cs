﻿//HintName: IVariousTypesTools.Calls.generated.cs
#nullable enable

namespace OpenAI.IntegrationTests
{
    public static partial class VariousTypesToolsExtensions
    {
        public class GetCurrentWeatherArgs
        {
            public long Parameter1 { get; set; }
            public int Parameter2 { get; set; }
            public double Parameter3 { get; set; }
            public float Parameter4 { get; set; }
            public bool Parameter5 { get; set; }
            public global::System.DateTime DateTime { get; set; }
            public global::System.DateOnly Date { get; set; }
        }

        public static global::System.Collections.Generic.IReadOnlyDictionary<string, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>>> AsCalls(this IVariousTypesTools service)
        {
            return new global::System.Collections.Generic.Dictionary<string, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>>>
            {
                ["GetCurrentWeather"] = (json, _) =>
                {
                    return global::System.Threading.Tasks.Task.FromResult(service.CallGetCurrentWeather(json));
                },
 
 
 
            };
        }

        public static VariousTypesToolsExtensions.GetCurrentWeatherArgs AsGetCurrentWeatherArgs(
            this IVariousTypesTools functions,
            string json)
        {
            return
                global::System.Text.Json.JsonSerializer.Deserialize<VariousTypesToolsExtensions.GetCurrentWeatherArgs>(json, new global::System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                    Converters = {{ new global::System.Text.Json.Serialization.JsonStringEnumConverter(global::System.Text.Json.JsonNamingPolicy.CamelCase) }}
                }) ??
                throw new global::System.InvalidOperationException("Could not deserialize JSON.");
        }

        public static string CallGetCurrentWeather(this IVariousTypesTools functions, string json)
        {
            var args = functions.AsGetCurrentWeatherArgs(json);
            var jsonResult = functions.GetCurrentWeather(args.Parameter1, args.Parameter2, args.Parameter3, args.Parameter4, args.Parameter5, args.DateTime, args.Date);

            return global::System.Text.Json.JsonSerializer.Serialize(jsonResult, new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                Converters = { new global::System.Text.Json.Serialization.JsonStringEnumConverter(global::System.Text.Json.JsonNamingPolicy.CamelCase) },
            });
        }

 

 

 

        public static async global::System.Threading.Tasks.Task<string> CallAsync(
            this IVariousTypesTools service,
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