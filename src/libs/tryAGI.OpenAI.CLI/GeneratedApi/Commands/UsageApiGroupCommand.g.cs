#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UsageApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"usage", @"Usage endpoint commands.");
                         command.Subcommands.Add(UsageAudioSpeechesCommandApiCommand.Create());
                         command.Subcommands.Add(UsageAudioTranscriptionsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageCodeInterpreterSessionsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageCompletionsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageCostsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageEmbeddingsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageFileSearchCallsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageImagesCommandApiCommand.Create());
                         command.Subcommands.Add(UsageModerationsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageVectorStoresCommandApiCommand.Create());
                         command.Subcommands.Add(UsageWebSearchCallsCommandApiCommand.Create());
        return command;
    }
}