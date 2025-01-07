// ReSharper disable RedundantUsingDirective
using System.Threading;
using System.Threading.Tasks;
using CSharpToJsonSchema;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace tryAGI.OpenAI.IntegrationTests;

public enum Unit2
{
    Celsius,
    Fahrenheit,
}

public class Weather2
{
    public string Location { get; set; } = string.Empty;
    public double Temperature { get; set; }
    public Unit2 Unit { get; set; }
    public string Description { get; set; } = string.Empty;
}

[GenerateJsonSchema(Strict = true)]
public interface IWeatherStrictTools
{
    [Description("Get the current weather in a given location")]
    public Weather2 GetCurrentWeather(
        [Description("The city and state, e.g. San Francisco, CA")] string location,
        Unit2 unit);
    
    [Description("Get the current weather in a given location")]
    public Task<Weather2> GetCurrentWeatherAsync(
        [Description("The city and state, e.g. San Francisco, CA")] string location,
        Unit2 unit,
        CancellationToken cancellationToken = default);
}

public class WeatherStrictService : IWeatherStrictTools
{
    public Weather2 GetCurrentWeather(string location, Unit2 unit)
    {
        return new Weather2
        {
            Location = location,
            Temperature = 22.0,
            Unit = unit,
            Description = "Sunny",
        };
    }
    
    public Task<Weather2> GetCurrentWeatherAsync(string location, Unit2 unit, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(new Weather2
        {
            Location = location,
            Temperature = 22.0,
            Unit = unit,
            Description = "Sunny",
        });
    }
}