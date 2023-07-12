//HintName: IVariousTypesFunctions.Functions.generated.cs

using System.Collections.Generic;

#nullable enable

namespace H.Ipc.Generator.IntegrationTests
{
    public static class VariousTypesFunctionsExtensions
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

        public static (string Name, string Description, object Obj) GetCurrentWeatherAsParametersObject(this IVariousTypesFunctions functions)
        {
            return ("GetCurrentWeather", "Get the current weather in a given location", new
            {
                type = "object",
                properties = new Dictionary<string, object>
                {
                    ["parameter1"] = new
                    {
                        type = "integer",
                        format = "int64",
                        description = "",
                    },
                    ["parameter2"] = new
                    {
                        type = "integer",
                        format = "int32",
                        description = "",
                    },
                    ["parameter3"] = new
                    {
                        type = "number",
                        format = "float",
                        description = "",
                    },
                    ["parameter4"] = new
                    {
                        type = "number",
                        format = "double",
                        description = "",
                    },
                    ["parameter5"] = new
                    {
                        type = "boolean",
                        description = "",
                    },
                    ["dateTime"] = new
                    {
                        type = "string",
                        format = "date-time",
                        description = "",
                    },
                    ["date"] = new
                    {
                        type = "string",
                        format = "date",
                        description = "",
                    }
                },
                required = new string[] { "parameter1", "parameter2", "parameter3", "parameter4", "parameter5", "dateTime", "date" },
            });
        }

        public static (string Name, string Description, Dictionary<string, object> Dictionary) GetCurrentWeatherAsDictionary(this IVariousTypesFunctions functions)
        {
            return ("GetCurrentWeather", "Get the current weather in a given location", new Dictionary<string, object>
            {
                ["type"] = "object",
                ["properties"] = new Dictionary<string, object>
                {
                    ["parameter1"] = new
                    {
                        type = "integer",
                        format = "int64",
                        description = "",
                    },
                    ["parameter2"] = new
                    {
                        type = "integer",
                        format = "int32",
                        description = "",
                    },
                    ["parameter3"] = new
                    {
                        type = "number",
                        format = "float",
                        description = "",
                    },
                    ["parameter4"] = new
                    {
                        type = "number",
                        format = "double",
                        description = "",
                    },
                    ["parameter5"] = new
                    {
                        type = "boolean",
                        description = "",
                    },
                    ["dateTime"] = new
                    {
                        type = "string",
                        format = "date-time",
                        description = "",
                    },
                    ["date"] = new
                    {
                        type = "string",
                        format = "date",
                        description = "",
                    }
                },
                ["required"] = new string[] { "parameter1", "parameter2", "parameter3", "parameter4", "parameter5", "dateTime", "date" },
            });
        }

        public static global::System.Collections.Generic.ICollection<global::tryAGI.OpenAI.ChatCompletionFunctions> AsFunctions(this IVariousTypesFunctions functions)
        {
            var function0 = functions.GetCurrentWeatherAsDictionary();

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

        public static global::System.Collections.Generic.IReadOnlyDictionary<string, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>>> AsCalls(this IVariousTypesFunctions service)
        {
            return new global::System.Collections.Generic.Dictionary<string, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>>>
            {
                ["GetCurrentWeather"] = (json, _) =>
                {
                    return global::System.Threading.Tasks.Task.FromResult(service.CallGetCurrentWeather(json));
                },
 
 
 
            };
        }

        public static object GetCurrentWeatherAsFunctionObject(this IVariousTypesFunctions functions)
        {
            var (name, description, parameters) = functions.GetCurrentWeatherAsParametersObject();

            return new
            {
                name = name,
                description = description,
                parameters = parameters,
            };
        }

        public static (string Name, string Description, global::System.Text.Json.Nodes.JsonNode Node) GetCurrentWeatherAsParametersJsonNode(this IVariousTypesFunctions functions)
        {
            var (name, description, parameters) = functions.GetCurrentWeatherAsParametersObject();
            var node =
                global::System.Text.Json.JsonSerializer.SerializeToNode(parameters) ??
                throw new global::System.InvalidOperationException("Could not serialize parameters.");

            return (name, description, node);
        }

        public static VariousTypesFunctionsExtensions.GetCurrentWeatherArgs AsGetCurrentWeatherArgs(
            this IVariousTypesFunctions functions,
            string json)
        {
            return
                global::System.Text.Json.JsonSerializer.Deserialize<VariousTypesFunctionsExtensions.GetCurrentWeatherArgs>(json, new global::System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                }) ??
                throw new global::System.InvalidOperationException("Could not deserialize JSON.");
        }

        public static string CallGetCurrentWeather(this IVariousTypesFunctions functions, string json)
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
            this IVariousTypesFunctions service,
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