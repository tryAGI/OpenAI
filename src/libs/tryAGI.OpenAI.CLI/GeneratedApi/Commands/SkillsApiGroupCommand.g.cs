#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class SkillsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"skills", @"Skills endpoint commands.");
                         command.Subcommands.Add(SkillsCreateSkillCommandApiCommand.Create());
                         command.Subcommands.Add(SkillsCreateSkillVersionCommandApiCommand.Create());
                         command.Subcommands.Add(SkillsDeleteSkillCommandApiCommand.Create());
                         command.Subcommands.Add(SkillsDeleteSkillVersionCommandApiCommand.Create());
                         command.Subcommands.Add(SkillsGetSkillCommandApiCommand.Create());
                         command.Subcommands.Add(SkillsGetSkillContentCommandApiCommand.Create());
                         command.Subcommands.Add(SkillsGetSkillVersionCommandApiCommand.Create());
                         command.Subcommands.Add(SkillsGetSkillVersionContentCommandApiCommand.Create());
                         command.Subcommands.Add(SkillsListSkillVersionsCommandApiCommand.Create());
                         command.Subcommands.Add(SkillsListSkillsCommandApiCommand.Create());
                         command.Subcommands.Add(SkillsUpdateSkillDefaultVersionCommandApiCommand.Create());
        return command;
    }
}