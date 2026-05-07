#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectGroupsRemoveProjectGroupCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project to update.",
    };

    private static Argument<string> GroupId { get; } = new(
        name: @"group-id")
    {
        Description = @"The ID of the group to remove from the project.",
    };

    public static Command Create()
    {
        var command = new Command(@"remove-project-group", @"Revokes a group's access to a project.");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(GroupId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var groupId = parseResult.GetRequiredValue(GroupId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.ProjectGroups.RemoveProjectGroupAsync(
                                    projectId: projectId,
                                    groupId: groupId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteJsonAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}