#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class HostedToolsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"hosted-tools", @"Hosted tools endpoint commands.");
                         command.Subcommands.Add(HostedToolsRetrieveProjectHostedToolPermissionsCommandApiCommand.Create());
                         command.Subcommands.Add(HostedToolsUpdateProjectHostedToolPermissionsCommandApiCommand.Create());
        return command;
    }
}