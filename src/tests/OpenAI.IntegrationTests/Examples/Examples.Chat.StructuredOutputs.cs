namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task StructuredOutputs()
    {
        using var api = GetAuthenticatedClient();
        
        MathReasoning? mathReasoning = await api.Chat.CreateChatCompletionAsAsync<MathReasoning>(
            messages: ["How can I solve 8x + 7 = -23?"],
            model: CreateChatCompletionRequestModel.Gpt4o20240806,
            strict: true);

        Console.WriteLine($"Final answer: {mathReasoning?.FinalAnswer}");
        Console.WriteLine("Reasoning steps:");

        foreach (MathReasoningStep step in mathReasoning?.Steps ?? [])
        {
            Console.WriteLine($"  - Explanation: {step.Explanation}");
            Console.WriteLine($"    Output: {step.Output}");
        }
    }
}
