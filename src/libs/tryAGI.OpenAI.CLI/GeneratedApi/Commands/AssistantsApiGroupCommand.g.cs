#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AssistantsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"assistants", @"Assistants endpoint commands.");
                         command.Subcommands.Add(AssistantsCancelRunCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsCreateMessageCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsCreateRunCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsCreateThreadCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsCreateThreadAndRunCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsDeleteMessageCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsDeleteThreadCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsGetMessageCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsGetRunCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsGetRunStepCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsGetThreadCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsListMessagesCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsListRunStepsCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsListRunsCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsModifyMessageCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsModifyRunCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsModifyThreadCommandApiCommand.Create());
                         command.Subcommands.Add(AssistantsSubmitToolOuputsToRunCommandApiCommand.Create());
        return command;
    }
}