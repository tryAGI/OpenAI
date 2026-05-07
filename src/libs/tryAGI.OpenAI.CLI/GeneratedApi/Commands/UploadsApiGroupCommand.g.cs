#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UploadsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"uploads", @"Uploads endpoint commands.");
                         command.Subcommands.Add(UploadsAddUploadPartCommandApiCommand.Create());
                         command.Subcommands.Add(UploadsCancelUploadCommandApiCommand.Create());
                         command.Subcommands.Add(UploadsCompleteUploadCommandApiCommand.Create());
                         command.Subcommands.Add(UploadsCreateUploadCommandApiCommand.Create());
        return command;
    }
}