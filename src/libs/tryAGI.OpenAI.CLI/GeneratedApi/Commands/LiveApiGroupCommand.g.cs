#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class LiveApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"live", @"Live endpoint commands.");
                         command.Subcommands.Add(LiveAcceptLiveSessionCommandApiCommand.Create());
                         command.Subcommands.Add(LiveCreateLiveCommandApiCommand.Create());
                         command.Subcommands.Add(LiveDownloadLiveRecordingCommandApiCommand.Create());
                         command.Subcommands.Add(LiveForkLiveSessionCommandApiCommand.Create());
                         command.Subcommands.Add(LiveHangupLiveSessionCommandApiCommand.Create());
                         command.Subcommands.Add(LiveReferLiveSessionCommandApiCommand.Create());
                         command.Subcommands.Add(LiveRejectLiveSessionCommandApiCommand.Create());
        return command;
    }
}