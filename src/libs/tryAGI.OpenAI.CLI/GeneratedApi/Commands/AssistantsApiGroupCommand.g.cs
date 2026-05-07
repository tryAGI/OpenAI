#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AssistantsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"assistants", @"Assistants endpoint commands.");
                         command.Subcommands.Add(AssistantsCancelARunCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsCreateMessageCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsCreateRunCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsCreateThreadCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsCreateThreadAndRunCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsDeleteMessageCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsDeleteThreadCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsListMessagesCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsListRunStepsCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsListRunsCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsModifyMessageCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsModifyRunCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsModifyThreadCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsRetrieveMessageCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsRetrieveRunCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsRetrieveRunStepCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsRetrieveThreadCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsSubmitToolOutputsToRunCommandApiCommand.Create());
        return command;
    }
}