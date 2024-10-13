namespace OpenAI.SnapshotTests;

[TestClass]
public class ToolTests : VerifyBase
{
    [TestMethod]
    public Task Weather()
    {
        return this.CheckSourceAsync(H.Resources.WeatherTools_cs.AsString());
    }
    
    [TestMethod]
    public Task WeatherStrict()
    {
        return this.CheckSourceAsync(H.Resources.WeatherStrictTools_cs.AsString());
    }
    
    [TestMethod]
    public Task VariousTypes()
    {
        return this.CheckSourceAsync(H.Resources.VariousTypesTools_cs.AsString());
    }
}