#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class FineTuningApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"fine-tuning", @"Fine-tuning endpoint commands.");
                         command.Subcommands.Add(FineTuningCancelFineTuningJobCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningCreateFineTuningCheckpointPermissionCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningCreateFineTuningJobCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningDeleteFineTuningCheckpointPermissionCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningListFineTuningCheckpointPermissionsCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningListFineTuningEventsCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningListFineTuningJobCheckpointsCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningListPaginatedFineTuningJobsCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningPauseFineTuningJobCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningResumeFineTuningJobCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningRetrieveFineTuningJobCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningRunGraderCommandApiCommand.Create());
                         command.Subcommands.Add(FineTuningValidateGraderCommandApiCommand.Create());
        return command;
    }
}