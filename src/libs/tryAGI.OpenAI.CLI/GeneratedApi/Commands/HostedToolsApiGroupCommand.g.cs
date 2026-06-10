#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class HostedToolsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"hosted-tools", @"Hosted tools endpoint commands.");
                         command.Subcommands.Add(HostedToolsModifyProjectHostedToolPermissionsCommandApiCommand.Create());
                         command.Subcommands.Add(HostedToolsRetrieveProjectHostedToolPermissionsCommandApiCommand.Create());
        return command;
    }
}