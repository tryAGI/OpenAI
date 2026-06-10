#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class DataRetentionApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"data-retention", @"Data retention endpoint commands.");
                         command.Subcommands.Add(DataRetentionRetrieveOrganizationDataRetentionCommandApiCommand.Create());
                         command.Subcommands.Add(DataRetentionRetrieveProjectDataRetentionCommandApiCommand.Create());
                         command.Subcommands.Add(DataRetentionUpdateOrganizationDataRetentionCommandApiCommand.Create());
                         command.Subcommands.Add(DataRetentionUpdateProjectDataRetentionCommandApiCommand.Create());
        return command;
    }
}