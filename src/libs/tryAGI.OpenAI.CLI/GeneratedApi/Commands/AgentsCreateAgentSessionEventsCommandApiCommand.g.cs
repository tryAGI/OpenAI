#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AgentsCreateAgentSessionEventsCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"The ID of the session.",
    };

    private static Option<string?> IdempotencyKey { get; } = new(
        name: @"--idempotency-key")
    {
        Description = @"An optional client-generated key that makes retries of submitted messages idempotent.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionInputParam>> Events { get; } = new(
        name: @"--events")
    {
        Description = @"The input events to submit to the session.",
        Required = true,
    };

    public static Command Create()
    {
        var command = new Command(@"create-agent-session-events", @"Create agent session input events
Submits message, cancellation, or tool-result events to a managed agent session. Cancellation can recover a still-open turn whose backend execution has ended by marking it cancelled and abandoning unpublished outputs. Saved results, published files, and existing terminal outcomes are preserved. HTTP 202 confirms acceptance, not durable completion. See [session events](https://developers.openai.com/api/docs/guides/agents-api/sessions/events).");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(IdempotencyKey);
                        command.Options.Add(Events);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var idempotencyKey = parseResult.GetValue(IdempotencyKey);
                        var events = parseResult.GetRequiredValue(Events);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Agents.CreateAgentSessionEventsAsync(
                                    sessionId: sessionId,
                                    idempotencyKey: idempotencyKey,
                                    events: events,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}