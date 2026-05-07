#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class VideosApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"videos", @"Videos endpoint commands.");
                         command.Subcommands.Add(VideosCreateVideoCommandApiCommand.Create());
                         command.Subcommands.Add(VideosCreateVideoCharacterCommandApiCommand.Create());
                         command.Subcommands.Add(VideosCreateVideoEditCommandApiCommand.Create());
                         command.Subcommands.Add(VideosCreateVideoExtendCommandApiCommand.Create());
                         command.Subcommands.Add(VideosDeleteVideoCommandApiCommand.Create());
                         command.Subcommands.Add(VideosGetVideoCharacterCommandApiCommand.Create());
                         command.Subcommands.Add(VideosListVideosCommandApiCommand.Create());
                         command.Subcommands.Add(VideosRemixVideoCommandApiCommand.Create());
                         command.Subcommands.Add(VideosRetrieveVideoCommandApiCommand.Create());
                         command.Subcommands.Add(VideosRetrieveVideoContentCommandApiCommand.Create());
        return command;
    }
}