#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ImagesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"images", @"Images endpoint commands.");
                         command.Subcommands.Add(ImagesCreateImageCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesCreateImageAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesCreateImageEditCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesCreateImageEditAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesCreateImageVariationCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}