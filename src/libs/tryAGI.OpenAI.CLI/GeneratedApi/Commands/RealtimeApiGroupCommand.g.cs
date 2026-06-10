#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class RealtimeApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"realtime", @"Realtime endpoint commands.");
                         command.Subcommands.Add(RealtimeAcceptCallCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateCallCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateClientSecretCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateSessionCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateTranscriptionSessionCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeCreateTranslationClientSecretCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeHangUpCallCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeReferCallCommandApiCommand.Create());
                         command.Subcommands.Add(RealtimeRejectCallCommandApiCommand.Create());
        return command;
    }
}