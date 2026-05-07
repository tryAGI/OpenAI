#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectsRetrieveProjectCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-project", @"Retrieves a project.");
                        command.Arguments.Add(ProjectId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Projects.RetrieveProjectAsync(
                                    projectId: projectId,
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