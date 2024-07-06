//HintName: IWeatherFunctions.Functions.generated.cs

using System.Collections.Generic;

#nullable enable

namespace H.Ipc.Generator.IntegrationTests
{
    public static class WeatherFunctionsExtensions
    {
        public class GetCurrentWeatherArgs
        {
            public string Location { get; set; } = string.Empty;
            public global::H.Ipc.Generator.IntegrationTests.Unit Unit { get; set; }
        }

        public class GetCurrentWeatherAsyncArgs
        {
            public string Location { get; set; } = string.Empty;
            public global::H.Ipc.Generator.IntegrationTests.Unit Unit { get; set; }
        }

        public static (string Name, string Description, object Obj) GetCurrentWeatherAsParametersObject(this IWeatherFunctions functions)
        {
            return ("GetCurrentWeather", "Get the current weather in a given location", new
            {
                type = "object",
                properties = new Dictionary<string, object>
                {
                    ["location"] = new
                    {
                        type = "string",
                        description = "The city and state, e.g. San Francisco, CA",
                    },
                    ["unit"] = new
                    {
                        type = "string",
                        description = "",
                        @enum = new string[] { "celsius", "fahrenheit" },
                    }
                },
                required = new string[] { "location" },
            });
        }

        public static (string Name, string Description, object Obj) GetCurrentWeatherAsyncAsParametersObject(this IWeatherFunctions functions)
        {
            return ("GetCurrentWeatherAsync", "Get the current weather in a given location", new
            {
                type = "object",
                properties = new Dictionary<string, object>
                {
                    ["location"] = new
                    {
                        type = "string",
                        description = "The city and state, e.g. San Francisco, CA",
                    },
                    ["unit"] = new
                    {
                        type = "string",
                        description = "",
                        @enum = new string[] { "celsius", "fahrenheit" },
                    }
                },
                required = new string[] { "location" },
            });
        }

        public static (string Name, string Description, Dictionary<string, object> Dictionary) GetCurrentWeatherAsDictionary(this IWeatherFunctions functions)
        {
            return ("GetCurrentWeather", "Get the current weather in a given location", new Dictionary<string, object>
            {
                ["type"] = "object",
                ["properties"] = new Dictionary<string, object>
                {
                    ["location"] = new
                    {
                        type = "string",
                        description = "The city and state, e.g. San Francisco, CA",
                    },
                    ["unit"] = new
                    {
                        type = "string",
                        description = "",
                        @enum = new string[] { "celsius", "fahrenheit" },
                    }
                },
                ["required"] = new string[] { "location" },
            });
        }

        public static (string Name, string Description, Dictionary<string, object> Dictionary) GetCurrentWeatherAsyncAsDictionary(this IWeatherFunctions functions)
        {
            return ("GetCurrentWeatherAsync", "Get the current weather in a given location", new Dictionary<string, object>
            {
                ["type"] = "object",
                ["properties"] = new Dictionary<string, object>
                {
                    ["location"] = new
                    {
                        type = "string",
                        description = "The city and state, e.g. San Francisco, CA",
                    },
                    ["unit"] = new
                    {
                        type = "string",
                        description = "",
                        @enum = new string[] { "celsius", "fahrenheit" },
                    }
                },
                ["required"] = new string[] { "location" },
            });
        }

        public static global::System.Collections.Generic.IList<global::OpenAI.FunctionObject> AsFunctions(this IWeatherFunctions functions)
        {
            var (name0, description0, jsonNode0) = functions.GetCurrentWeatherAsParametersJsonNode();
            var (name1, description1, jsonNode1) = functions.GetCurrentWeatherAsyncAsParametersJsonNode();

            return new global::System.Collections.Generic.List<global::OpenAI.FunctionObject>
            {
                new global::OpenAI.FunctionObject
                {
                    Name = name0,
                    Description = description0,
                    Parameters = new global::OpenAI.FunctionParameters
                    {
                        //AdditionalProperties = jsonNode0,
                    },
                },

                new global::OpenAI.FunctionObject
                {
                    Name = name1,
                    Description = description1,
                    Parameters = new global::OpenAI.FunctionParameters
                    {
                        //AdditionalProperties = jsonNode1,
                    },
                },
            };
        }

        public static global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool> AsTools(this IWeatherFunctions functions)
        {
            var (name0, description0, jsonNode0) = functions.GetCurrentWeatherAsParametersJsonNode();
            var (name1, description1, jsonNode1) = functions.GetCurrentWeatherAsyncAsParametersJsonNode();

            return new global::System.Collections.Generic.List<global::OpenAI.ChatCompletionTool>
            {
                new global::OpenAI.ChatCompletionTool
                {
                    Function = new global::OpenAI.FunctionObject
                    {
                        Name = name0,
                        Description = description0,
                        Parameters = new global::OpenAI.FunctionParameters
                        {
                            //AdditionalProperties = jsonNode0,
                        },
                    },
                    Type = global::OpenAI.ChatCompletionToolType.Function,
                },

                new global::OpenAI.ChatCompletionTool
                {
                    Function = new global::OpenAI.FunctionObject
                    {
                        Name = name1,
                        Description = description1,
                        Parameters = new global::OpenAI.FunctionParameters
                        {
                            //AdditionalProperties = jsonNode1,
                        },
                    },
                    Type = global::OpenAI.ChatCompletionToolType.Function,
                },
            };
        }

        public static global::System.Collections.Generic.IReadOnlyDictionary<string, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>>> AsCalls(this IWeatherFunctions service)
        {
            return new global::System.Collections.Generic.Dictionary<string, global::System.Func<string, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string>>>
            {
                ["GetCurrentWeather"] = (json, _) =>
                {
                    return global::System.Threading.Tasks.Task.FromResult(service.CallGetCurrentWeather(json));
                },
 
                ["GetCurrentWeatherAsync"] = async (json, cancellationToken) =>
                {
                    return await service.CallGetCurrentWeatherAsync(json, cancellationToken);
                },
 
            };
        }

        public static object GetCurrentWeatherAsFunctionObject(this IWeatherFunctions functions)
        {
            var (name, description, parameters) = functions.GetCurrentWeatherAsParametersObject();

            return new
            {
                name = name,
                description = description,
                parameters = parameters,
            };
        }

        public static object GetCurrentWeatherAsyncAsFunctionObject(this IWeatherFunctions functions)
        {
            var (name, description, parameters) = functions.GetCurrentWeatherAsyncAsParametersObject();

            return new
            {
                name = name,
                description = description,
                parameters = parameters,
            };
        }

        public static (string Name, string Description, global::System.Text.Json.Nodes.JsonNode Node) GetCurrentWeatherAsParametersJsonNode(this IWeatherFunctions functions)
        {
            var (name, description, parameters) = functions.GetCurrentWeatherAsParametersObject();
            var node =
                global::System.Text.Json.JsonSerializer.SerializeToNode(parameters) ??
                throw new global::System.InvalidOperationException("Could not serialize parameters.");

            return (name, description, node);
        }

        public static (string Name, string Description, global::System.Text.Json.Nodes.JsonNode Node) GetCurrentWeatherAsyncAsParametersJsonNode(this IWeatherFunctions functions)
        {
            var (name, description, parameters) = functions.GetCurrentWeatherAsyncAsParametersObject();
            var node =
                global::System.Text.Json.JsonSerializer.SerializeToNode(parameters) ??
                throw new global::System.InvalidOperationException("Could not serialize parameters.");

            return (name, description, node);
        }

        public static WeatherFunctionsExtensions.GetCurrentWeatherArgs AsGetCurrentWeatherArgs(
            this IWeatherFunctions functions,
            string json)
        {
            return
                global::System.Text.Json.JsonSerializer.Deserialize<WeatherFunctionsExtensions.GetCurrentWeatherArgs>(json, new global::System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                    Converters = {{ new global::System.Text.Json.Serialization.JsonStringEnumConverter(global::System.Text.Json.JsonNamingPolicy.CamelCase) }}
                }) ??
                throw new global::System.InvalidOperationException("Could not deserialize JSON.");
        }

        public static WeatherFunctionsExtensions.GetCurrentWeatherAsyncArgs AsGetCurrentWeatherAsyncArgs(
            this IWeatherFunctions functions,
            string json)
        {
            return
                global::System.Text.Json.JsonSerializer.Deserialize<WeatherFunctionsExtensions.GetCurrentWeatherAsyncArgs>(json, new global::System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                    Converters = {{ new global::System.Text.Json.Serialization.JsonStringEnumConverter(global::System.Text.Json.JsonNamingPolicy.CamelCase) }}
                }) ??
                throw new global::System.InvalidOperationException("Could not deserialize JSON.");
        }

        public static string CallGetCurrentWeather(this IWeatherFunctions functions, string json)
        {
            var args = functions.AsGetCurrentWeatherArgs(json);
            var jsonResult = functions.GetCurrentWeather(args.Location, args.Unit);

            return global::System.Text.Json.JsonSerializer.Serialize(jsonResult, new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                Converters = { new global::System.Text.Json.Serialization.JsonStringEnumConverter(global::System.Text.Json.JsonNamingPolicy.CamelCase) },
            });
        }

 

        public static async global::System.Threading.Tasks.Task<string> CallGetCurrentWeatherAsync(
            this IWeatherFunctions functions,
            string json,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var args = functions.AsGetCurrentWeatherAsyncArgs(json);
            var jsonResult = await functions.GetCurrentWeatherAsync(args.Location, args.Unit, cancellationToken);

            return global::System.Text.Json.JsonSerializer.Serialize(jsonResult, new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNamingPolicy = global::System.Text.Json.JsonNamingPolicy.CamelCase,
                Converters = { new global::System.Text.Json.Serialization.JsonStringEnumConverter(global::System.Text.Json.JsonNamingPolicy.CamelCase) },
            });
        }

 

        public static async global::System.Threading.Tasks.Task<string> CallAsync(
            this IWeatherFunctions service,
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