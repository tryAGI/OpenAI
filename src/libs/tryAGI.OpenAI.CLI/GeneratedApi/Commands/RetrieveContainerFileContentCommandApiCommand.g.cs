#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class RetrieveContainerFileContentCommandApiCommand
{
    private static Argument<string> ContainerId { get; } = new(
        name: @"container-id")
    {
        Description = @"",
    };

    private static Argument<string> FileId { get; } = new(
        name: @"file-id")
    {
        Description = @"",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-container-file-content", @"Retrieve Container File Content
Retrieves a container file content.");
                        command.Arguments.Add(ContainerId);
                        command.Arguments.Add(FileId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var containerId = parseResult.GetRequiredValue(ContainerId);
                        var fileId = parseResult.GetRequiredValue(FileId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.RetrieveContainerFileContentAsync(
                                    containerId: containerId,
                                    fileId: fileId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}