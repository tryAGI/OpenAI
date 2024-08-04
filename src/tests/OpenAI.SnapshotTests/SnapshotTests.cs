namespace OpenAI.SnapshotTests;

[TestClass]
public class IpcGeneratorSnapshotTests : VerifyBase
{
    [TestMethod]
    public Task GeneratesCorrectly()
    {
        return this.CheckSourceAsync(H.Resources.WeatherTools_cs.AsString());
    }
    
    [TestMethod]
    public Task VariousTypes()
    {
        return this.CheckSourceAsync(H.Resources.VariousTypesTools_cs.AsString());
    }
}