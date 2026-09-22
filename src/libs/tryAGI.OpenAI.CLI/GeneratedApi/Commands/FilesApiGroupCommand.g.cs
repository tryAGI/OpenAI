#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class FilesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"files", @"Files endpoint commands.");
                         command.Subcommands.Add(FilesCreateFileCommandApiCommand.Create());
                         command.Subcommands.Add(FilesDeleteFileCommandApiCommand.Create());
                         command.Subcommands.Add(FilesDownloadFileCommandApiCommand.Create());
                         command.Subcommands.Add(FilesListFilesCommandApiCommand.Create());
                         command.Subcommands.Add(FilesRetrieveFileCommandApiCommand.Create());
        return command;
    }
}