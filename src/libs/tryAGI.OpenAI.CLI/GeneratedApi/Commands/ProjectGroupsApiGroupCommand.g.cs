#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ProjectGroupsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"project-groups", @"Project groups endpoint commands.");
                         command.Subcommands.Add(ProjectGroupsAddProjectGroupCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupsListProjectGroupsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupsRemoveProjectGroupCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectGroupsRetrieveProjectGroupCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}