#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class UpdateWebhookEndpointCommandApiCommand
{
    private static Argument<string> WebhookEndpointId { get; } = new(
        name: @"webhook-endpoint-id")
    {
        Description = @"The ID of the webhook endpoint to update.",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"A new human-readable name for the webhook endpoint.",
    };

    private static Option<string?> Url { get; } = new(
        name: @"--url")
    {
        Description = @"A new HTTPS URL that receives webhook deliveries.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum>?> EventTypes { get; } = new(
        name: @"--event-types")
    {
        Description = @"The complete set of event types that should trigger deliveries.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.WebhookEndpointBody value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.WebhookEndpointBody value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-webhook-endpoint", @"Update Webhook Endpoint
Updates a webhook endpoint for the authenticated project.");
                        command.Arguments.Add(WebhookEndpointId);
                        command.Options.Add(NameOption);
                        command.Options.Add(Url);
                        command.Options.Add(EventTypes);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.PublicUpdateEndpointBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var webhookEndpointId = parseResult.GetRequiredValue(WebhookEndpointId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var url = CliRuntime.WasSpecified(parseResult, Url) ? parseResult.GetValue(Url) : (__requestBase is { } __UrlBaseValue ? __UrlBaseValue.Url : default);
                        var eventTypes = CliRuntime.WasSpecified(parseResult, EventTypes) ? parseResult.GetValue(EventTypes) : (__requestBase is { } __EventTypesBaseValue ? __EventTypesBaseValue.EventTypes : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UpdateWebhookEndpointAsync(
                                    webhookEndpointId: webhookEndpointId,
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