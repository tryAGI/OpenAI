#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AuditLogsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"audit-logs", @"Audit Logs endpoint commands.");
                         command.Subcommands.Add(AuditLogsListAuditLogsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}