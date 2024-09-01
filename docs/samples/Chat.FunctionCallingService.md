```csharp
public enum WeatherUnit
{
    Celsius,
    Fahrenheit,
}

[OpenAiTools(Strict = true)]
public interface IFunctionCallingService
{
    [Description("Get the user's current location")]
    public Task<string> GetCurrentLocation(
        CancellationToken cancellationToken = default);

    [Description("Get the current weather in a given location")]
    public Task<string> GetCurrentWeatherAsync(
        [Description("The city and state, e.g. Boston, MA")]
        string location,
        [Description("The temperature unit to use. Infer this from the specified location.")]
        WeatherUnit unit = WeatherUnit.Celsius,
        CancellationToken cancellationToken = default);
}

public class FunctionCallingService : IFunctionCallingService
{
    public Task<string> GetCurrentLocation(
        CancellationToken cancellationToken = default)
    {
        // Call the location API here.
        return Task.FromResult("San Francisco");
    }
    
    public Task<string> GetCurrentWeatherAsync(
        string location,
        WeatherUnit unit = WeatherUnit.Celsius,
        CancellationToken cancellationToken = default)
    {
        // Call the weather API here.
        return Task.FromResult($"31 {unit:G}");
    }
}
```