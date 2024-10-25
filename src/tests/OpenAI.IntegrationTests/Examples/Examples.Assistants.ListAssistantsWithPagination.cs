using System.Diagnostics.CodeAnalysis;

namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    [Experimental("OPENAI_BETA_001")]
    public async Task ListAssistantsWithPagination()
    {
        using var api = GetAuthenticatedClient();
        
        int count = 0;

        ListAssistantsResponse response = await api.Assistants.ListAssistantsAsync();
        foreach (AssistantObject assistant in response.Data)
        {
            Console.WriteLine($"[{count,3}] {assistant.Id} {assistant.CreatedAt:s} {assistant.Name}");

            count++;
            
            //_ = await api.Assistants.DeleteAssistantAsync(assistant.Id);
        }
    }
}
