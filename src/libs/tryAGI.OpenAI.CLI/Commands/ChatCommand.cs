using System.CommandLine;
using System.Text;

namespace tryAGI.OpenAI.Cli.Commands;

internal static class ChatCommand
{
    public static Command Create()
    {
        var cmd = new Command("chat", "Chat completions.");
        cmd.Subcommands.Add(CreateCompletionCommand());
        return cmd;
    }

    private static Command CreateCompletionCommand()
    {
        var promptArg = new Argument<string>("prompt")
        {
            Description = "User prompt. Pass `-` to read from stdin or a file path to read from disk.",
        };
        var modelOpt = new Option<string>("--model")
        {
            DefaultValueFactory = _ => "gpt-4o-mini",
            Description = "Model id (e.g. `gpt-4o-mini`, `gpt-4o`, `o1-mini`).",
        };
        var systemOpt = new Option<string?>("--system")
        {
            Description = "Optional system message prepended to the conversation.",
        };
        var maxTokensOpt = new Option<int?>("--max-tokens")
        {
            Description = "Maximum number of completion tokens to generate.",
        };

        var cmd = new Command("complete", "Send a single-turn chat completion request.");
        cmd.Arguments.Add(promptArg);
        cmd.Options.Add(modelOpt);
        cmd.Options.Add(systemOpt);
        cmd.Options.Add(maxTokensOpt);

        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

            var promptRaw = CliRuntime.GetRequiredArgument(parseResult, promptArg);
            var prompt = await CliRuntime.ReadInputOrFileAsync(promptRaw, cancellationToken).ConfigureAwait(false);
            var model = parseResult.GetValue(modelOpt) ?? "gpt-4o-mini";
            var systemMessage = parseResult.GetValue(systemOpt);
            var maxTokens = parseResult.GetValue(maxTokensOpt);

            var messages = new List<ChatCompletionRequestMessage>();
            if (!string.IsNullOrWhiteSpace(systemMessage))
            {
                messages.Add(new ChatCompletionRequestMessage(new ChatCompletionRequestSystemMessage
                {
                    Content = systemMessage,
                    Role = ChatCompletionRequestSystemMessageRole.System,
                }));
            }

            messages.Add(new ChatCompletionRequestMessage(new ChatCompletionRequestUserMessage
            {
                Content = prompt,
                Role = ChatCompletionRequestUserMessageRole.User,
            }));

            var request = new CreateChatCompletionRequest
            {
                CreateChatCompletionRequestVariant2 = new CreateChatCompletionRequestVariant2
                {
                    Model = model,
                    Messages = messages,
                    MaxCompletionTokens = maxTokens,
                },
            };

            var response = await client.Chat.CreateChatCompletionAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false);
            var text = ExtractText(response);

            await CliRuntime.WriteOutputAsync(parseResult, text, response, cancellationToken).ConfigureAwait(false);
        }));

        return cmd;
    }

    private static string ExtractText(CreateChatCompletionResponse response)
    {
        var sb = new StringBuilder();
        foreach (var choice in response.Choices ?? [])
        {
            var content = choice.Message?.Content;
            if (!string.IsNullOrEmpty(content))
            {
                sb.Append(content);
            }
        }

        return sb.ToString().TrimEnd();
    }
}
