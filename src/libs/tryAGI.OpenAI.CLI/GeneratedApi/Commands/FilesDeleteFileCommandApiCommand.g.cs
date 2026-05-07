#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class FilesDeleteFileCommandApiCommand
{
    private static Argument<string> FileId { get; } = new(
        name: @"file-id")
    {
        Description = @"The ID of the file to use for this request.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-file", @"Delete a file and remove it from all vector stores.");
                        command.Arguments.Add(FileId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var fileId = parseResult.GetRequiredValue(FileId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Files.DeleteFileAsync(
                                    fileId: fileId,
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