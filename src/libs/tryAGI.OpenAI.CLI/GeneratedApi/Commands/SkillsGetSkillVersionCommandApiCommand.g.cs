#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class SkillsGetSkillVersionCommandApiCommand
{
    private static Argument<string> SkillId { get; } = new(
        name: @"skill-id")
    {
        Description = @"The identifier of the skill.",
    };

    private static Argument<string> Version { get; } = new(
        name: @"version")
    {
        Description = @"The version number to retrieve.",
    };

    public static Command Create()
    {
        var command = new Command(@"get-skill-version", @"Get a specific skill version.");
                        command.Arguments.Add(SkillId);
                        command.Arguments.Add(Version);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var skillId = parseResult.GetRequiredValue(SkillId);
                        var version = parseResult.GetRequiredValue(Version);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Skills.GetSkillVersionAsync(
                                    skillId: skillId,
                                    version: version,
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