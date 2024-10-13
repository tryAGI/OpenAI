//HintName: IWeatherStrictTools.Tools.generated.cs

#nullable enable

namespace OpenAI.IntegrationTests
{
    public static partial class WeatherStrictToolsExtensions
    {
        public static global::System.Collections.Generic.IList<global::CSharpToJsonSchema.Tool> AsTools(this IWeatherStrictTools functions)
        {
            return new global::System.Collections.Generic.List<global::CSharpToJsonSchema.Tool>
            {
                new global::CSharpToJsonSchema.Tool
                {
                    Name = "GetCurrentWeather",
                    Description = "Get the current weather in a given location",
                    Strict = true,
                    Parameters = new global::CSharpToJsonSchema.OpenApiSchema
                    {
                        Type = "object",
                        Description = "Get the current weather in a given location",
                        Properties = new global::System.Collections.Generic.Dictionary<string, global::CSharpToJsonSchema.OpenApiSchema>
                        {
                            ["location"] = new global::CSharpToJsonSchema.OpenApiSchema
                            {
                                Type = "string",
                                Description = "The city and state, e.g. San Francisco, CA",
                            },
                            ["unit"] = new global::CSharpToJsonSchema.OpenApiSchema
                            {
                                Type = "string",
                                Description = "",
                                Enum = new string[] { "celsius", "fahrenheit" },
                            }
                        },
                        Required = new string[] { "location", "unit" },
                    },
                },

                new global::CSharpToJsonSchema.Tool
                {
                    Name = "GetCurrentWeatherAsync",
                    Description = "Get the current weather in a given location",
                    Strict = true,
                    Parameters = new global::CSharpToJsonSchema.OpenApiSchema
                    {
                        Type = "object",
                        Description = "Get the current weather in a given location",
                        Properties = new global::System.Collections.Generic.Dictionary<string, global::CSharpToJsonSchema.OpenApiSchema>
                        {
                            ["location"] = new global::CSharpToJsonSchema.OpenApiSchema
                            {
                                Type = "string",
                                Description = "The city and state, e.g. San Francisco, CA",
                            },
                            ["unit"] = new global::CSharpToJsonSchema.OpenApiSchema
                            {
                                Type = "string",
                                Description = "",
                                Enum = new string[] { "celsius", "fahrenheit" },
                            }
                        },
                        Required = new string[] { "location", "unit" },
                    },
                },
            };
        }
    }
}