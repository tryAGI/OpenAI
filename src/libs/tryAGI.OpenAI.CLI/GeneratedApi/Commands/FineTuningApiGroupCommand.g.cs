#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class FineTuningApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"fine-tuning", @"Fine-tuning endpoint commands.");
                         command.Subcommands.Add(FineTuningCancelFineTuningCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningCreateCheckpointPermissionsCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningCreateFineTuningJobCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningDeleteCheckpointPermissionCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningListCheckpointPermissionsCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningListFineTuningCheckpointsCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningListFineTuningEventsCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningListFineTuningJobsCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningPauseFineTuningCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningResumeFineTuningCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningRetrieveFineTuningJobCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningRunGraderCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningValidateGraderCommandApiCommand.Create());
        return command;
    }
}