#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ConversationsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"conversations", @"Conversations endpoint commands.");
                         command.Subcommands.Add(ConversationsCreateConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsCreateConversationItemsCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsDeleteConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsDeleteConversationItemCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsGetConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsGetConversationItemCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsListConversationItemsCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsUpdateConversationCommandApiCommand.Create());
        return command;
    }
}