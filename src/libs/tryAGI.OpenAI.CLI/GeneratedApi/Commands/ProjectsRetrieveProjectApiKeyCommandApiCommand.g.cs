#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectsRetrieveProjectApiKeyCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project.",
    };

    private static Argument<string> ApiKeyId { get; } = new(
        name: @"api-key-id")
    {
        Description = @"The ID of the API key.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-project-api-key", @"Retrieves an API key in the project.");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(ApiKeyId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var apiKeyId = parseResult.GetRequiredValue(ApiKeyId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Projects.RetrieveProjectApiKeyAsync(
                                    projectId: projectId,
                                    apiKeyId: apiKeyId,
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