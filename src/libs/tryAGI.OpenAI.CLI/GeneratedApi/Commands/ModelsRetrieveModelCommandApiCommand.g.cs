#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ModelsRetrieveModelCommandApiCommand
{
    private static Argument<string> Model { get; } = new(
        name: @"model")
    {
        Description = @"The ID of the model to use for this request",
    };

    public static Command Create()
    {
        var command = new Command(@"retrieve-model", @"Retrieves a model instance, providing basic information about the model such as the owner and permissioning.");
                        command.Arguments.Add(Model);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var model = parseResult.GetRequiredValue(Model);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Models.RetrieveModelAsync(
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