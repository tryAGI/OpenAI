#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class SkillsGetSkillContentCommandApiCommand
{
    private static Argument<string> SkillId { get; } = new(
        name: @"skill-id")
    {
        Description = @"The identifier of the skill to download.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-skill-content", @"Download a skill zip bundle by its ID.");
                        command.Arguments.Add(SkillId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var skillId = parseResult.GetRequiredValue(SkillId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Skills.GetSkillContentAsync(
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