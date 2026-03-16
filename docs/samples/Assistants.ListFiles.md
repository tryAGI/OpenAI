```csharp
using var api = new OpenAiClient(apiKey);

int count = 0;

ListFilesResponse files = await api.Files.ListFilesAsync(purpose: OpenAIFilePurpose.Assistants.ToValueString());
foreach (OpenAIFile file in files.Data)
{
    Console.WriteLine($"[{count,3}] {file.Id} {file.CreatedAt:s} {file.Filename}");

    count++;

    //_ = await api.Files.DeleteFileAsync(file.Id);
}
```