// ReSharper disable RedundantUsingDirective
using System;
using CSharpToJsonSchema;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace OpenAI.IntegrationTests;

[GenerateJsonSchema]
public interface IVariousTypesTools
{
    [Description("Get the current weather in a given location")]
    public bool GetCurrentWeather(
        long parameter1,
        int parameter2,
        double parameter3,
        float parameter4,
        bool parameter5,
        DateTime dateTime,
        DateOnly date);
}

public class VariousTypesService : IVariousTypesTools
{
    public bool GetCurrentWeather(
        long parameter1,
        int parameter2,
        double parameter3,
        float parameter4,
        bool parameter5,
        DateTime dateTime,
        DateOnly date)
    {
        return true;
    }
}