#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AudioApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"audio", @"Audio endpoint commands.");
                         command.Subcommands.Add(AudioCreateSpeechCommandApiCommand.Create());
                         command.Subcommands.Add(AudioCreateTranscriptionCommandApiCommand.Create());
                         command.Subcommands.Add(AudioCreateTranscriptionAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(AudioCreateTranslationCommandApiCommand.Create());
                         command.Subcommands.Add(AudioCreateVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(AudioCreateVoiceConsentCommandApiCommand.Create());
                         command.Subcommands.Add(AudioDeleteVoiceConsentCommandApiCommand.Create());
                         command.Subcommands.Add(AudioListVoiceConsentsCommandApiCommand.Create());
                         command.Subcommands.Add(AudioRetrieveVoiceConsentCommandApiCommand.Create());
                         command.Subcommands.Add(AudioUpdateVoiceConsentCommandApiCommand.Create());
        return command;
    }
}