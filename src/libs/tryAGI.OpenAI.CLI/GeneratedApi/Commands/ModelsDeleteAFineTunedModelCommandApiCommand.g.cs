#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ModelsDeleteAFineTunedModelCommandApiCommand
{
    private static Argument<string> Model { get; } = new(
        name: @"model")
    {
        Description = @"The model to delete",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-afine-tuned-model", @"Delete a fine-tuned model. You must have the Owner role in your organization to delete a model.");
                        command.Arguments.Add(Model);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var model = parseResult.GetRequiredValue(Model);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Models.DeleteAFineTunedModelAsync(
                                    model: model,
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