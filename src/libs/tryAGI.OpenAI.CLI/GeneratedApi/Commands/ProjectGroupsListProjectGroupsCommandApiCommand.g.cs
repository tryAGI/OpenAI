#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ProjectGroupsListProjectGroupsCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project to inspect.",
    };    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"A limit on the number of project groups to return. Defaults to 20.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"Cursor for pagination. Provide the ID of the last group from the previous response to fetch the next page.",
    };

    private static Option<global::tryAGI.OpenAI.ListProjectGroupsOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order for the returned groups.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-project-groups", @"Lists the groups that have access to a project.");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(Limit);
                        command.Options.Add(After);
                        command.Options.Add(Order);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var limit = parseResult.GetValue(Limit);
                        var after = parseResult.GetValue(After);
                        var order = parseResult.GetValue(Order);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.ProjectGroups.ListProjectGroupsAsync(
                                    projectId: projectId,
                                    limit: limit,
                                    after: after,
                                    order: order,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteJsonAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}