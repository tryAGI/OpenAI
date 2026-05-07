#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");
          command.Options.Add(CliOptions.ApiKey);
          command.Options.Add(CliOptions.BaseUrl);
          command.Options.Add(CliOptions.Output);
                         command.Subcommands.Add(AssistantsApiGroupCommand.Create());
                         command.Subcommands.Add(AudioApiGroupCommand.Create());
                         command.Subcommands.Add(AuditLogsApiGroupCommand.Create());
                         command.Subcommands.Add(BatchApiGroupCommand.Create());
                         command.Subcommands.Add(CertificatesApiGroupCommand.Create());
                         command.Subcommands.Add(ChatApiGroupCommand.Create());
                         command.Subcommands.Add(CompletionsApiGroupCommand.Create());
                         command.Subcommands.Add(ConversationsApiGroupCommand.Create());
                         command.Subcommands.Add(DefaultApiGroupCommand.Create());
                         command.Subcommands.Add(EmbeddingsApiGroupCommand.Create());
                         command.Subcommands.Add(EvalsApiGroupCommand.Create());
                         command.Subcommands.Add(FilesApiGroupCommand.Create());
                         command.Subcommands.Add(FineTuningApiGroupCommand.Create());
                         command.Subcommands.Add(GroupOrganizationRoleAssignmentsApiGroupCommand.Create());
                         command.Subcommands.Add(GroupUsersApiGroupCommand.Create());
                         command.Subcommands.Add(GroupsApiGroupCommand.Create());
                         command.Subcommands.Add(ImagesApiGroupCommand.Create());
                         command.Subcommands.Add(InvitesApiGroupCommand.Create());
                         command.Subcommands.Add(ModelsApiGroupCommand.Create());
                         command.Subcommands.Add(ModerationsApiGroupCommand.Create());
                         command.Subcommands.Add(ProjectGroupRoleAssignmentsApiGroupCommand.Create());
                         command.Subcommands.Add(ProjectGroupsApiGroupCommand.Create());
                         command.Subcommands.Add(ProjectUserRoleAssignmentsApiGroupCommand.Create());
                         command.Subcommands.Add(ProjectsApiGroupCommand.Create());
                         command.Subcommands.Add(RealtimeApiGroupCommand.Create());
                         command.Subcommands.Add(ResponsesApiGroupCommand.Create());
                         command.Subcommands.Add(RolesApiGroupCommand.Create());
                         command.Subcommands.Add(SkillsApiGroupCommand.Create());
                         command.Subcommands.Add(UploadsApiGroupCommand.Create());
                         command.Subcommands.Add(UsageApiGroupCommand.Create());
                         command.Subcommands.Add(UserOrganizationRoleAssignmentsApiGroupCommand.Create());
                         command.Subcommands.Add(UsersApiGroupCommand.Create());
                         command.Subcommands.Add(VectorStoresApiGroupCommand.Create());
                         command.Subcommands.Add(VideosApiGroupCommand.Create());
        return command;
    }
}