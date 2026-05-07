#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AuditLogsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"audit-logs", @"Audit Logs endpoint commands.");
                         command.Subcommands.Add(AuditLogsListAuditLogsCommandApiCommand.Create());
        return command;
    }
}