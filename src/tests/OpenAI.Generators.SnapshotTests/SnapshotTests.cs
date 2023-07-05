namespace H.Generators.IntegrationTests;

[TestClass]
public class IpcGeneratorSnapshotTests : VerifyBase
{
    [TestMethod]
    public Task GeneratesCorrectly()
    {
        return this.CheckSourceAsync(
/* lang=csharp */ """
using tryAGI.OpenAI;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;
using System.Threading;
using System.Threading.Tasks;

namespace H.Ipc.Generator.IntegrationTests;

public enum Unit
{
    Celsius,
    Fahrenheit,
}

public class Weather
{
    public string Location { get; set; } = string.Empty;
    public double Temperature { get; set; }
    public Unit Unit { get; set; }
    public string Description { get; set; } = string.Empty;
}

[OpenAiFunctions]
public interface IWeatherFunctions
{
    [Description("Get the current weather in a given location")]
    public Weather GetCurrentWeather(
        [Description("The city and state, e.g. San Francisco, CA")] string location,
        Unit unit = Unit.Celsius);
    
    [Description("Get the current weather in a given location")]
    public Task<Weather> GetCurrentWeatherAsync(
        [Description("The city and state, e.g. San Francisco, CA")] string location,
        Unit unit = Unit.Celsius,
        CancellationToken cancellationToken = default);
}

public class WeatherService : IWeatherFunctions
{
    public Weather GetCurrentWeather(string location, Unit unit = Unit.Celsius)
    {
        return new Weather
        {
            Location = location,
            Temperature = 22.0,
            Unit = unit,
            Description = "Sunny",
        };
    }
    
    public Task<Weather> GetCurrentWeatherAsync(string location, Unit unit = Unit.Celsius, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(new Weather
        {
            Location = location,
            Temperature = 22.0,
            Unit = unit,
            Description = "Sunny",
        });
    }
}
""");
    }

    [TestMethod]
    public Task GeneratesUpdateCodeCorrectly()
    {
        return this.CheckSourceAsync(
/* lang=csharp */ """
using System;
using System.Collections.Generic;
using tryAGI.OpenAI;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace H.Ipc.Generator.IntegrationTests;

/// <summary>
/// 
/// </summary>
public enum ChangeType
{
    /// <summary>
    /// 
    /// </summary>
    CreateFile,
    
    /// <summary>
    /// 
    /// </summary>
    ReplaceFragment,
    
    /// <summary>
    /// 
    /// </summary>
    DeleteFragment,
    
    /// <summary>
    /// 
    /// </summary>
    RenameFile,
    
    /// <summary>
    /// 
    /// </summary>
    DeleteFile,
    
    /// <summary>
    /// 
    /// </summary>
    End,
}

public class Change
{
    /// <summary>
    /// 
    /// </summary>
    [Description("Describes the type of change to be made")]
    public ChangeType Type { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [Description("Specifies the path to a file")]
    public string Path { get; set; } = string.Empty;
    
    /// <summary>
    /// 
    /// </summary>
    [Description("Specifies the code to be removed. Used when deleting or replacing code.")]
    public string RemoveCode { get; set; } = string.Empty;
    
    /// <summary>
    /// 
    /// </summary>
    [Description("Specifies the code to add. Used when creating a file or replacing code.")]
    public string AddCode { get; set; } = string.Empty;
    
    /// <summary>
    /// 
    /// </summary>
    [Description("Specifies the new path for the file. Used when renaming a file.")]
    public string NewPath { get; set; } = string.Empty;
}

[OpenAiFunctions]
public interface IUpdateCodeFunctions
{
    [Description("Allows to change the project code")]
    public void UpdateCode(
        [Description("A series of code changes that must end with END change type")] IReadOnlyCollection<Change> changes);
}

public class UpdateCodeService : IUpdateCodeFunctions
{
    public void UpdateCode(IReadOnlyCollection<Change> changes)
    {
        foreach (var change in changes)
        {
            Console.WriteLine($"Type: {change.Type}, Path: {change.Path}");
            Console.WriteLine($"RemoveCode: {change.RemoveCode}");
            Console.WriteLine($"AddCode: {change.AddCode}");
            Console.WriteLine($"NewPath: {change.NewPath}");
        }
    }
}
""");
    }
}