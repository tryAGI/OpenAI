// namespace tryAGI.OpenAI.IntegrationTests.Examples;
//
// public partial class Examples
// {
//     [Test]
//     [Explicit]
//     public async Task SimpleChatStreaming()
//     {
//         using var api = GetAuthenticatedClient();
//         
//         IAsyncEnumerable<CreateChatCompletionStreamResponse> enumerable = api.Chat.CreateChatCompletionAsStreamAsync(
//             messages: ["Say 'this is a test.'"],
//             model: ModelIdsSharedEnum.Gpt4o);
//
//         Console.WriteLine("[ASSISTANT]:");
//         await foreach (CreateChatCompletionStreamResponse chatUpdate in enumerable)
//         {
//             Console.Write(chatUpdate.Choices[0].Delta.Content);
//         }
//     }
// }
