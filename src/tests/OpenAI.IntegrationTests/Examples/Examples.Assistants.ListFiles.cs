namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task ListFiles()
    {
        using var api = GetAuthenticatedClient();
        
        int count = 0;
        
        ListFilesResponse files = await api.Files.ListFilesAsync(purpose: CreateFileRequestPurpose.Assistants.ToValueString());
        foreach (OpenAIFile file in files.Data)
        {
            Console.WriteLine($"[{count,3}] {file.Id} {file.CreatedAt:s} {file.Filename}");
            
            count++;
            
            //_ = await api.Files.DeleteFileAsync(file.Id);
        }
    }
}
