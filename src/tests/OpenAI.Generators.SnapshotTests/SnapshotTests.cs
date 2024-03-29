﻿namespace H.Generators.IntegrationTests;

[TestClass]
public class IpcGeneratorSnapshotTests : VerifyBase
{
    [TestMethod]
    public Task GeneratesCorrectly()
    {
        return this.CheckSourceAsync(Resources.WeatherFunctions_cs.AsString());
    }
    
    [TestMethod]
    public Task GeneratesUpdateCodeCorrectly()
    {
        return this.CheckSourceAsync(Resources.UpdateCodeFunctions_cs.AsString());
    }
    
    [TestMethod]
    public Task VariousTypes()
    {
        return this.CheckSourceAsync(Resources.VariousTypesFunctions_cs.AsString());
    }
    
    [TestMethod]
    public Task MaintenanceFunctionsTypes()
    {
        return this.CheckSourceAsync(Resources.MaintenanceFunctions_cs.AsString());
    }
}