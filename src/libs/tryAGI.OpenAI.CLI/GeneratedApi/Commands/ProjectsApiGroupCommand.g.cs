#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"projects", @"Projects endpoint commands.");
                         command.Subcommands.Add(ProjectsArchiveProjectCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsCreateProjectCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsCreateProjectServiceAccountCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsCreateProjectUserCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsDeleteProjectApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsDeleteProjectServiceAccountCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsDeleteProjectUserCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsListProjectApiKeysCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsListProjectRateLimitsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsListProjectServiceAccountsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsListProjectUsersCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsListProjectsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsModifyProjectCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsModifyProjectRateLimitCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsModifyProjectUserCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsRetrieveProjectCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsRetrieveProjectApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsRetrieveProjectServiceAccountCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsRetrieveProjectUserCommandApiCommand.Create());
        return command;
    }
}