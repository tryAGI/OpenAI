#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class FilesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"files", @"Files endpoint commands.");
                         command.Subcommands.Add(FilesDeleteFileCommandApiCommand.Create());
                         command.Subcommands.Add(FilesListFilesCommandApiCommand.Create());
                         command.Subcommands.Add(FilesRetrieveFileCommandApiCommand.Create());
                         command.Subcommands.Add(FilesRetrieveFileContentCommandApiCommand.Create());
                         command.Subcommands.Add(FilesUploadFileCommandApiCommand.Create());
        return command;
    }
}