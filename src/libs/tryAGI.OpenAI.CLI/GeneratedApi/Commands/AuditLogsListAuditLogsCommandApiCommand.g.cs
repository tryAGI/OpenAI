#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AuditLogsListAuditLogsCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.ListAuditLogsEffectiveAt?> EffectiveAt { get; } = new(
        name: @"--effective-at")
    {
        Description = @"Return only events whose `effective_at` (Unix seconds) is in this range.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ProjectIds { get; } = new(
        name: @"--project-ids")
    {
        Description = @"Return only events for these projects.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AuditLogEventType>?> EventTypes { get; } = new(
        name: @"--event-types")
    {
        Description = @"Return only events with a `type` in one of these values. For example, `project.created`. For all options, see the documentation for the [audit log object](/docs/api-reference/audit-logs/object).",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ActorIds { get; } = new(
        name: @"--actor-ids")
    {
        Description = @"Return only events performed by these actors. Can be a user ID, a service account ID, or an api key tracking ID.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ActorEmails { get; } = new(
        name: @"--actor-emails")
    {
        Description = @"Return only events performed by users with these emails.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ResourceIds { get; } = new(
        name: @"--resource-ids")
    {
        Description = @"Return only events performed on these targets. For example, a project ID updated.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"A limit on the number of objects to be returned. Limit can range between 1 and 100, and the default is 20.
",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"A cursor for use in pagination. `after` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, ending with obj_foo, your subsequent call can include after=obj_foo in order to fetch the next page of the list.
",
    };

    private static Option<string?> Before { get; } = new(
        name: @"--before")
    {
        Description = @"A cursor for use in pagination. `before` is an object ID that defines your place in the list. For instance, if you make a list request and receive 100 objects, starting with obj_foo, your subsequent call can include before=obj_foo in order to fetch the previous page of the list.
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ListAuditLogsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ListAuditLogsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-audit-logs", @"List user actions and configuration changes within this organization.");
                        command.Options.Add(EffectiveAt);
                        command.Options.Add(ProjectIds);
                        command.Options.Add(EventTypes);
                        command.Options.Add(ActorIds);
                        command.Options.Add(ActorEmails);
                        command.Options.Add(ResourceIds);
                        command.Options.Add(Limit);
                        command.Options.Add(After);
                        command.Options.Add(Before);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var effectiveAt = parseResult.GetValue(EffectiveAt);
                        var projectIds = parseResult.GetValue(ProjectIds);
                        var eventTypes = parseResult.GetValue(EventTypes);
                        var actorIds = parseResult.GetValue(ActorIds);
                        var actorEmails = parseResult.GetValue(ActorEmails);
                        var resourceIds = parseResult.GetValue(ResourceIds);
                        var limit = parseResult.GetValue(Limit);
                        var after = parseResult.GetValue(After);
                        var before = parseResult.GetValue(Before);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AuditLogs.ListAuditLogsAsync(
                                    effectiveAt: effectiveAt,
                                    projectIds: projectIds,
                                    eventTypes: eventTypes,
                                    actorIds: actorIds,
                                    actorEmails: actorEmails,
                                    resourceIds: resourceIds,
                                    limit: limit,
                                    after: after,
                                    before: before,
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
        return command;
    }
}