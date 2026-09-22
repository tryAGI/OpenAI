#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class TestWebhookEndpointCommandApiCommand
{
    private static Argument<string> WebhookEndpointId { get; } = new(
        name: @"webhook-endpoint-id")
    {
        Description = @"The ID of the webhook endpoint to test.",
    };

    private static Option<global::tryAGI.OpenAI.ProjectEventTypeEnum> EventType { get; } = new(
        name: @"--event-type")
    {
        Description = @"The event type to send as a sample delivery.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.WebhookEndpointTestResultResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.WebhookEndpointTestResultResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"test-webhook-endpoint", @"Test Webhook Endpoint
Sends a sample event to a webhook endpoint for the authenticated project.");
                        command.Arguments.Add(WebhookEndpointId);
                        command.Options.Add(EventType);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var webhookEndpointId = parseResult.GetRequiredValue(WebhookEndpointId);
                        var eventType = parseResult.GetRequiredValue(EventType);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TestWebhookEndpointAsync(
                                    webhookEndpointId: webhookEndpointId,
                                    eventType: eventType,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}