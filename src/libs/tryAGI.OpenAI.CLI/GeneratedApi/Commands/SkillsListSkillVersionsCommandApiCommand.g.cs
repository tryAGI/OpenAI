#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class SkillsListSkillVersionsCommandApiCommand
{
    private static Argument<string> SkillId { get; } = new(
        name: @"skill-id")
    {
        Description = @"The identifier of the skill.",
    };    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of versions to retrieve.",
    };

    private static Option<global::tryAGI.OpenAI.OrderEnum?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order of results by version number.",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"The skill version ID to start after.",
    };

    public static Command Create()
    {
        var command = new Command(@"list-skill-versions", @"List skill versions for a skill.");
                        command.Arguments.Add(SkillId);
                        command.Options.Add(Limit);
                        command.Options.Add(Order);
                        command.Options.Add(After);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var skillId = parseResult.GetRequiredValue(SkillId);
                        var limit = parseResult.GetValue(Limit);
                        var order = parseResult.GetValue(Order);
                        var after = parseResult.GetValue(After);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Skills.ListSkillVersionsAsync(
                                    skillId: skillId,
                                    limit: limit,
                                    order: order,
                                    after: after,
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