#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class DeleteAContainerCommandApiCommand
{
    private static Argument<string> ContainerId { get; } = new(
        name: @"container-id")
    {
        Description = @"The ID of the container to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-acontainer", @"Delete Container
Delete a container.");
                        command.Arguments.Add(ContainerId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var containerId = parseResult.GetRequiredValue(ContainerId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.DeleteAContainerAsync(
                                    containerId: containerId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}