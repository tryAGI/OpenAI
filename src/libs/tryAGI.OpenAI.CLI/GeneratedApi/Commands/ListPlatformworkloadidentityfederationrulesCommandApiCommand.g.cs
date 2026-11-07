#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ListPlatformworkloadidentityfederationrulesCommandApiCommand
{
    private static Argument<string> WorkloadIdentityProviderId { get; } = new(
        name: @"workload-identity-provider-id")
    {
        Description = @"",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant1?, global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant2?>?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"",
    };

    private static Option<string?> ServiceAccountId { get; } = new(
        name: @"--service-account-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.PlatformFederationRuleListResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.PlatformFederationRuleListResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"list-platformworkloadidentityfederationrules", @"List Platform workload identity federation rules
List the provider's federation rules to project service accounts.");
                        command.Arguments.Add(WorkloadIdentityProviderId);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);
                        command.Options.Add(ServiceAccountId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var workloadIdentityProviderId = parseResult.GetRequiredValue(WorkloadIdentityProviderId);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                        var serviceAccountId = parseResult.GetValue(ServiceAccountId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ListPlatformworkloadidentityfederationrulesAsync(
                                    workloadIdentityProviderId: workloadIdentityProviderId,
                                    limit: limit,
                                    order: order,
                                    after: after,
                                    serviceAccountId: serviceAccountId,
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