#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ConversationsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"conversations", @"Conversations endpoint commands.");
                         command.Subcommands.Add(ConversationsCreateAConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsCreateItemsCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsDeleteAConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsDeleteAnItemCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsListItemsCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsRetrieveAConversationCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsRetrieveAnItemCommandApiCommand.Create());
                         command.Subcommands.Add(ConversationsUpdateAConversationCommandApiCommand.Create());
        return command;
    }
}