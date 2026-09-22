#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class RealtimeApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"realtime", @"Realtime endpoint commands.");
                         command.Subcommands.Add(RealtimeAcceptRealtimeCallCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateRealtimeCallCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateRealtimeCallWithRawBodyCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateRealtimeClientSecretCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateRealtimeSessionCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateRealtimeTranscriptionSessionCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateRealtimeTranslationClientSecretCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeHangupRealtimeCallCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeReferRealtimeCallCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeRejectRealtimeCallCommandApiCommand.Create());
        return command;
    }
}