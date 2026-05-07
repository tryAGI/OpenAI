#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class RetrieveContainerCommandApiCommand
{
    private static Argument<string> ContainerId { get; } = new(
        name: @"container-id")
    {
        Description = @"",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-container", @"Retrieve Container
Retrieves a container.");
                        command.Arguments.Add(ContainerId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var containerId = parseResult.GetRequiredValue(ContainerId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.RetrieveContainerAsync(
                                    containerId: containerId,
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