#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectsDeleteProjectServiceAccountCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project.",
    };

    private static Argument<string> ServiceAccountId { get; } = new(
        name: @"service-account-id")
    {
        Description = @"The ID of the service account.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-project-service-account", @"Deletes a service account from the project.

Returns confirmation of service account deletion, or an error if the project
is archived (archived projects have no service accounts).
");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(ServiceAccountId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var serviceAccountId = parseResult.GetRequiredValue(ServiceAccountId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Projects.DeleteProjectServiceAccountAsync(
                                    projectId: projectId,
                                    serviceAccountId: serviceAccountId,
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