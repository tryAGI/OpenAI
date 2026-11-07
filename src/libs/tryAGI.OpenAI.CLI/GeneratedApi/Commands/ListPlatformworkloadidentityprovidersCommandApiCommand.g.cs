#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ListPlatformworkloadidentityprovidersCommandApiCommand
{
    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant1?, global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant2?>?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.PlatformProviderListResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.PlatformProviderListResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"list-platformworkloadidentityproviders", @"List Platform workload identity providers
List OIDC providers in the authenticated Admin API key's organization.");
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ListPlatformworkloadidentityprovidersAsync(
                                    limit: limit,
                                    order: order,
                                    after: after,
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