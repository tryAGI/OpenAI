#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ChatApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"chat", @"Chat endpoint commands.");
                         command.Subcommands.Add(ChatCreateChatCompletionCommandApiCommand.Create());
                         command.Subcommands.Add(ChatCreateChatCompletionAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(ChatDeleteChatCompletionCommandApiCommand.Create());
                         command.Subcommands.Add(ChatGetChatCompletionCommandApiCommand.Create());
                         command.Subcommands.Add(ChatGetChatCompletionMessagesCommandApiCommand.Create());
                         command.Subcommands.Add(ChatListChatCompletionsCommandApiCommand.Create());
                         command.Subcommands.Add(ChatUpdateChatCompletionCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}