// using System.Diagnostics.CodeAnalysis;
//
// namespace tryAGI.OpenAI.IntegrationTests.Examples;
//
// public partial class Examples
// {
//     [Test]
//     [Explicit]
//     [Experimental("OPENAI_BETA_001")]
//     public async Task Assistants_FunctionCalling()
//     {
//         using var api = GetAuthenticatedClient();
//         
//         var service = new FunctionCallingService();
//         IList<ChatCompletionTool> tools = service.AsTools().AsOpenAiTools();
//         
//         AssistantObject assistant = await api.Assistants.CreateAssistantAsync(
//             model: AssistantSupportedModels.Gpt4o,
//             name: "Example: Function Calling",
//             instructions: "Don't make assumptions about what values to plug into functions."
//                           + " Ask for clarification if a user request is ambiguous.",
//             tools: tools.Select(x => new global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>(new AssistantToolsFunction
//             {
//                 Function = x.Function,
//             })).ToArray());
//
//         RunObject run = await api.Assistants.CreateThreadAndRunAsync(
//             assistantId: assistant.Id,
//             new CreateThreadRequest
//             {
//                 Messages = ["What's the weather like today?"],
//             });
//         
//         // Poll the run until it is no longer queued or in progress.
//         while (run.Status is RunObjectStatus.Queued or RunObjectStatus.InProgress or RunObjectStatus.RequiresAction)
//         {
//             await Task.Delay(TimeSpan.FromSeconds(1));
//             run = await api.Assistants.GetRunAsync(run.ThreadId, run.Id);
//
//             // If the run requires action, resolve them.
//             if (run.Status == RunObjectStatus.RequiresAction)
//             {
//                 List<SubmitToolOutputsRunRequestToolOutput> toolOutputs = [];
//
//                 foreach (RunToolCallObject toolCall in run.RequiredAction?.SubmitToolOutputs.ToolCalls ?? [])
//                 {
//                     var json = await service.CallAsync(
//                         functionName: toolCall.Function.Name,
//                         argumentsAsJson: toolCall.Function.Arguments);
//                     toolOutputs.Add(new SubmitToolOutputsRunRequestToolOutput
//                     {
//                         ToolCallId = toolCall.Id,
//                         Output = json,
//                     });
//                 }
//
//                 // Submit the tool outputs to the assistant, which returns the run to the queued state.
//                 run = await api.Assistants.SubmitToolOuputsToRunAsync(
//                     threadId: run.ThreadId,
//                     runId: run.Id,
//                     toolOutputs: toolOutputs);
//             }
//         }
//         
//         // With the run complete, list the messages and display their content
//         if (run.Status == RunObjectStatus.Completed)
//         {
//             ListMessagesResponse messages
//                 = await api.Assistants.ListMessagesAsync(run.ThreadId, order: ListMessagesOrder.Asc);
//
//             foreach (MessageObject message in messages.Data)
//             {
//                 Console.WriteLine($"[{message.Role.ToString().ToUpper()}]: ");
//                 foreach (global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageContentTextObject, global::tryAGI.OpenAI.MessageContentRefusalObject> contentItem in message.Content)
//                 {
//                     if (contentItem.ImageFile is {} imageFile)
//                     {
//                         Console.WriteLine($" <Image File ID> {imageFile.ImageFile.FileId}");
//                     }
//                     if (contentItem.ImageUrl is {} imageUrl)
//                     {
//                         Console.WriteLine($" <Image URL> {imageUrl.ImageUrl.Url}");
//                     }
//                     if (contentItem.Text is {} text)
//                     {
//                         Console.WriteLine($"{text.Text.Value}");
//                         
//                         // Include annotations, if any.
//                         if (text.Text.Annotations.Count > 0)
//                         {
//                             Console.WriteLine();
//                             foreach (AnnotationsItem annotation in text.Text.Annotations)
//                             {
//                                 if (annotation.FileCitation is {} fileCitation)
//                                 {
//                                     Console.WriteLine($"* File citation, file ID: {fileCitation.FileCitation.FileId}");
//                                     Console.WriteLine($"* Text to replace: {fileCitation.Text}");
//                                     Console.WriteLine($"* Message content index range: {fileCitation.StartIndex}-{fileCitation.EndIndex}");
//                                 }
//                                 if (annotation.FilePath is {} filePath)
//                                 {
//                                     Console.WriteLine($"* File output, new file ID: {filePath.FilePath.FileId}");
//                                     Console.WriteLine($"* Text to replace: {filePath.Text}");
//                                     Console.WriteLine($"* Message content index range: {filePath.StartIndex}-{filePath.EndIndex}");
//                                 }
//                             }
//                         }
//                     }
//                     if (contentItem.Refusal is {} refusal)
//                     {
//                         Console.WriteLine($"Refusal: {refusal.Refusal}");
//                     }
//                 }
//                 Console.WriteLine();
//             }
//         }
//         else
//         {
//             throw new NotImplementedException(run.Status.ToString());
//         }
//         
//         // Optionally, delete any persistent resources you no longer need.
//         _ = await api.Assistants.DeleteThreadAsync(run.ThreadId);
//         _ = await api.Assistants.DeleteAssistantAsync(assistant.Id);
//     }
// }
