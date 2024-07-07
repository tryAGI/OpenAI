//HintName: IWeatherFunctions.Tools.generated.cs

#nullable enable

namespace H.Ipc.Generator.IntegrationTests
{
    public static partial class WeatherFunctionsExtensions
    {
        public static global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool> AsTools(this IWeatherFunctions functions)
        {
            return new global::System.Collections.Generic.List<global::OpenAI.ChatCompletionTool>
            {
                new global::OpenAI.ChatCompletionTool
                {
                    Function = new global::OpenAI.FunctionObject
                    {
                        Name = "GetCurrentWeather",
                        Description = "Get the current weather in a given location",
                        Parameters = new global::OpenAI.FunctionParameters
                    {
                        Type = "object",
                        Description = "Get the current weather in a given location",
                        Properties = new global::System.Collections.Generic.Dictionary<string, global::OpenAI.OpenApiSchema>
                        {
                            ["location"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "string",
                                Description = "The city and state, e.g. San Francisco, CA",
                            },
                            ["unit"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "string",
                                Description = "",
                                Enum = new string[] { "celsius", "fahrenheit" },
                            }
                        },
                        Required = new string[] { "location" },
                    },
                    },
                    Type = global::OpenAI.ChatCompletionToolType.Function,
                },

                new global::OpenAI.ChatCompletionTool
                {
                    Function = new global::OpenAI.FunctionObject
                    {
                        Name = "GetCurrentWeatherAsync",
                        Description = "Get the current weather in a given location",
                        Parameters = new global::OpenAI.FunctionParameters
                    {
                        Type = "object",
                        Description = "Get the current weather in a given location",
                        Properties = new global::System.Collections.Generic.Dictionary<string, global::OpenAI.OpenApiSchema>
                        {
                            ["location"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "string",
                                Description = "The city and state, e.g. San Francisco, CA",
                            },
                            ["unit"] = new global::OpenAI.OpenApiSchema
                            {
                                Type = "string",
                                Description = "",
                                Enum = new string[] { "celsius", "fahrenheit" },
                            }
                        },
                        Required = new string[] { "location" },
                    },
                    },
                    Type = global::OpenAI.ChatCompletionToolType.Function,
                },
            };
        }
    }
}