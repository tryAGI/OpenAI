#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ChatApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"chat", @"Chat endpoint commands.");
                         command.Subcommands.Add(ChatCreateChatCompletionCommandApiCommand.Create());
                         command.Subcommands.Add(ChatCreateChatCompletionAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(ChatDeleteChatCompletionCommandApiCommand.Create());
                         command.Subcommands.Add(ChatGetChatCompletionCommandApiCommand.Create());
                         command.Subcommands.Add(ChatGetChatMessagesCommandApiCommand.Create());
                         command.Subcommands.Add(ChatListChatCompletionsCommandApiCommand.Create());
                         command.Subcommands.Add(ChatUpdateChatCompletionCommandApiCommand.Create());
        return command;
    }
}