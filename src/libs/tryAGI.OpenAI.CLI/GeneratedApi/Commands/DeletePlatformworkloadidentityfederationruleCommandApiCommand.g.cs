#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class DeletePlatformworkloadidentityfederationruleCommandApiCommand
{
    private static Argument<string> WorkloadIdentityProviderId { get; } = new(
        name: @"workload-identity-provider-id")
    {
        Description = @"",
    };

    private static Argument<string> WorkloadIdentityFederationRuleId { get; } = new(
        name: @"workload-identity-federation-rule-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.PlatformFederationRuleDeletedResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.PlatformFederationRuleDeletedResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-platformworkloadidentityfederationrule", @"Delete Platform workload identity federation rule
Delete a federation rule to a project service account.");
                        command.Arguments.Add(WorkloadIdentityProviderId);
                        command.Arguments.Add(WorkloadIdentityFederationRuleId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var workloadIdentityProviderId = parseResult.GetRequiredValue(WorkloadIdentityProviderId);
                        var workloadIdentityFederationRuleId = parseResult.GetRequiredValue(WorkloadIdentityFederationRuleId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DeletePlatformworkloadidentityfederationruleAsync(
                                    workloadIdentityProviderId: workloadIdentityProviderId,
                                    workloadIdentityFederationRuleId: workloadIdentityFederationRuleId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}