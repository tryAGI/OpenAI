```csharp
using var api = new OpenAiClient(apiKey);

IAsyncEnumerable<CreateChatCompletionStreamResponse> enumerable = api.Chat.CreateChatCompletionAsStreamAsync(
    messages: ["Say 'this is a test.'"],
    model: ModelIdsSharedEnum.Gpt4o);

Console.WriteLine("[ASSISTANT]:");
await foreach (CreateChatCompletionStreamResponse chatUpdate in enumerable)
{
    Console.Write(chatUpdate.Choices[0].Delta.Content);
}
```