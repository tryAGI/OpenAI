#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class UploadsCancelUploadCommandApiCommand
{
    private static Argument<string> UploadId { get; } = new(
        name: @"upload-id")
    {
        Description = @"The ID of the Upload.
",
    };

    public static Command Create()
    {
        var command = new Command(@"cancel-upload", @"Cancels the Upload. No Parts may be added after an Upload is cancelled.

Returns the Upload object with status `cancelled`.
");
                        command.Arguments.Add(UploadId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var uploadId = parseResult.GetRequiredValue(UploadId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Uploads.CancelUploadAsync(
                                    uploadId: uploadId,
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