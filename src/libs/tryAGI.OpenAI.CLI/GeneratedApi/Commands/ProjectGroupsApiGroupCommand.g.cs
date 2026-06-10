#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectGroupsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"project-groups", @"Project groups endpoint commands.");
                         command.Subcommands.Add(ProjectGroupsAddProjectGroupCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupsListProjectGroupsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupsRemoveProjectGroupCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupsRetrieveProjectGroupCommandApiCommand.Create());
        return command;
    }
}