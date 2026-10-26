#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AgentsListAgentAutomationsCommandApiCommand
{
    private static Option<long?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"The maximum number of resources to return, between 1 and 100. Defaults to 20.",
    };

    private static Option<global::tryAGI.OpenAI.ListOrderParam?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"The order in which resources are returned. Defaults to `desc`.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Return resources after this resource ID in the selected order.",
    };

    private static Option<string?> SessionId { get; } = new(
        name: @"--session-id")
    {
        Description = @"Matches existing-session targets, including agent-created automations.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ListAgentAutomationsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ListAgentAutomationsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"list-agent-automations", @"List automations
Lists project-owned automations, optionally filtered by target session.");
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);
                        command.Options.Add(SessionId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                        var sessionId = parseResult.GetValue(SessionId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.ListAgentAutomationsAsync(
                                    limit: limit,
                                    order: order,
                                    after: after,
                                    sessionId: sessionId,
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