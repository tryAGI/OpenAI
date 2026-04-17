using System.CommandLine;
using tryAGI.OpenAI.Cli.Commands;

namespace tryAGI.OpenAI.Cli;

internal static class CliRoot
{
    public static RootCommand CreateRootCommand()
    {
        var root = new RootCommand(
            "tryAGI.OpenAI.CLI — call the OpenAI API from the command line. Run via `dnx tryAGI.OpenAI.CLI <command>`.");

        root.Options.Add(CliOptions.ApiKey);
        root.Options.Add(CliOptions.BaseUrl);
        root.Options.Add(CliOptions.Json);
        root.Options.Add(CliOptions.Output);

        root.Subcommands.Add(AuthCommand.Create());
        root.Subcommands.Add(ChatCommand.Create());
        root.Subcommands.Add(ImagesCommand.Create());
        root.Subcommands.Add(EmbeddingsCommand.Create());
        root.Subcommands.Add(AudioCommand.Create());
        root.Subcommands.Add(ModelsCommand.Create());
        root.Subcommands.Add(SkillCommand.Create());

        return root;
    }
}
