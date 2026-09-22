#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class CreateWebhookEndpointCommandApiCommand
{
    private static Option<string> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"A human-readable name for the webhook endpoint.",
        Required = true,
    };

    private static Option<string> Url { get; } = new(
        name: @"--url")
    {
        Description = @"The HTTPS URL that receives webhook deliveries.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum>> EventTypes { get; } = new(
        name: @"--event-types")
    {
        Description = @"The event types that trigger deliveries to this endpoint.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.WebhookEndpointWithSecretResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.WebhookEndpointWithSecretResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-webhook-endpoint", @"Create Webhook Endpoint
Creates a webhook endpoint for the authenticated project.");
                        command.Options.Add(NameOption);
                        command.Options.Add(Url);
                        command.Options.Add(EventTypes);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetRequiredValue(NameOption);
                        var url = parseResult.GetRequiredValue(Url);
                        var eventTypes = parseResult.GetRequiredValue(EventTypes);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateWebhookEndpointAsync(
                                    name: name,
                                    url: url,
                                    eventTypes: eventTypes,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"EventTypes",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}