#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ListtheexternalkeyconfigsregisteredontheuserSorganizationCommandApiCommand
{
    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.OrderEnum?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.ExternalKeyPurpose?> Purpose { get; } = new(
        name: @"--purpose")
    {
        Description = @"Filter by key purpose. When omitted, returns keys of all purposes.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ListExternalKeysResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ListExternalKeysResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"listtheexternalkeyconfigsregisteredontheuser-sorganization", @"List the external key configs registered on the user's organization
List the external key configs registered on the user's organization");
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);
                        command.Options.Add(Purpose);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                        var purpose = parseResult.GetValue(Purpose);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Listtheexternalkeyconfigsregisteredontheuser'sorganizationAsync(
                                    limit: limit,
                                    order: order,
                                    after: after,
                                    purpose: purpose,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Data",
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
        CustomizeCommand(ref command);
        return command;
    }
}