﻿using System;
using tryAGI.OpenAI;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace H.Ipc.Generator.IntegrationTests;

[OpenAiFunctions]
public interface IVariousTypesFunctions
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

public class VariousTypesService : IVariousTypesFunctions
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