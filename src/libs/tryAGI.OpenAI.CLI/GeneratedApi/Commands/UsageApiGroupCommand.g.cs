#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class UsageApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"usage", @"Usage endpoint commands.");
                         command.Subcommands.Add(UsageUsageAudioSpeechesCommandApiCommand.Create());
                         command.Subcommands.Add(UsageUsageAudioTranscriptionsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageUsageCodeInterpreterSessionsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageUsageCompletionsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageUsageCostsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageUsageEmbeddingsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageUsageFileSearchCallsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageUsageImagesCommandApiCommand.Create());
                         command.Subcommands.Add(UsageUsageModerationsCommandApiCommand.Create());
                         command.Subcommands.Add(UsageUsageVectorStoresCommandApiCommand.Create());
                         command.Subcommands.Add(UsageUsageWebSearchCallsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}