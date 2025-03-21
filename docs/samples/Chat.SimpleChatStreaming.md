```csharp
using var api = GetAuthenticatedClient();

IAsyncEnumerable<CreateChatCompletionStreamResponse> enumerable = api.Chat.CreateChatCompletionAsStreamAsync(
    messages: ["Say 'this is a test.'"],
    model: ModelIdsEnum.Gpt4o);

Console.WriteLine("[ASSISTANT]:");
await foreach (CreateChatCompletionStreamResponse chatUpdate in enumerable)
{
    Console.Write(chatUpdate.Choices[0].Delta.Content);
}
```