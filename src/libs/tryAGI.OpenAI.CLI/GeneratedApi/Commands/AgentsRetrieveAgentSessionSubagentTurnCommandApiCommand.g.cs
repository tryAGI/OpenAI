#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AgentsRetrieveAgentSessionSubagentTurnCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"The ID of the session.",
    };

    private static Argument<string> SubagentId { get; } = new(
        name: @"subagent-id")
    {
        Description = @"The ID of the subagent in this session.",
    };

    private static Argument<string> TurnId { get; } = new(
        name: @"turn-id")
    {
        Description = @"The ID of a turn belonging to this subagent.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.TurnResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.TurnResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"retrieve-agent-session-subagent-turn", @"Retrieve a subagent turn
Retrieves a turn belonging to this subagent. See [subagent workflows](https://developers.openai.com/api/docs/guides/agents-api/multi-agent).");
                        command.Arguments.Add(SessionId);
                        command.Arguments.Add(SubagentId);
                        command.Arguments.Add(TurnId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var subagentId = parseResult.GetRequiredValue(SubagentId);
                        var turnId = parseResult.GetRequiredValue(TurnId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.RetrieveAgentSessionSubagentTurnAsync(
                                    sessionId: sessionId,
                                    subagentId: subagentId,
                                    turnId: turnId,
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