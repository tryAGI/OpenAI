// namespace tryAGI.OpenAI.IntegrationTests.Examples;
//
// public partial class Examples
// {
//     [Test]
//     [Explicit]
//     public async Task SimpleChat()
//     {
//         using var api = GetAuthenticatedClient();
//         
//         CreateChatCompletionResponse response = await api.Chat.CreateChatCompletionAsync(
//             messages: ["Say 'this is a test.'"],
//             model: ModelIdsEnum.Gpt4o);
//
//         Console.WriteLine("[ASSISTANT]:");
//         Console.WriteLine($"{response.Choices[0].Message.Content}");
//     }
// }
