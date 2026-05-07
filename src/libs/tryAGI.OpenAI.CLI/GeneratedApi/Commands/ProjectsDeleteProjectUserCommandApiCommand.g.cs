#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectsDeleteProjectUserCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project.",
    };

    private static Argument<string> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"The ID of the user.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-project-user", @"Deletes a user from the project.

Returns confirmation of project user deletion, or an error if the project is
archived (archived projects have no users).
");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(UserId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var userId = parseResult.GetRequiredValue(UserId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Projects.DeleteProjectUserAsync(
                                    projectId: projectId,
                                    userId: userId,
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