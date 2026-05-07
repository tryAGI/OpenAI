#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class SkillsGetSkillCommandApiCommand
{
    private static Argument<string> SkillId { get; } = new(
        name: @"skill-id")
    {
        Description = @"The identifier of the skill to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-skill", @"Get a skill by its ID.");
                        command.Arguments.Add(SkillId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var skillId = parseResult.GetRequiredValue(SkillId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Skills.GetSkillAsync(
                                    skillId: skillId,
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