#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AgentsRetrieveAgentSessionArtifactContentCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"The ID of the session that owns the artifact.",
    };

    private static Argument<string> ArtifactId { get; } = new(
        name: @"artifact-id")
    {
        Description = @"The immutable session artifact ID.",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-agent-session-artifact-content", @"Retrieve agent session artifact content
Downloads immutable session artifact bytes after the execution environment expires. See [session artifacts](https://developers.openai.com/api/docs/guides/agents-api/environments/files#openai-hosted-artifacts).");
                        command.Arguments.Add(SessionId);
                        command.Arguments.Add(ArtifactId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var artifactId = parseResult.GetRequiredValue(ArtifactId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.RetrieveAgentSessionArtifactContentAsync(
                                    sessionId: sessionId,
                                    artifactId: artifactId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}