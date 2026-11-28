#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record AccessProgramsParam2OptionSet(
    Option<global::tryAGI.OpenAI.CyberAccessProgramParam?> Cyber)
{
    public static AccessProgramsParam2OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AccessProgramsParam2OptionSet(
                        Cyber: new Option<global::tryAGI.OpenAI.CyberAccessProgramParam?>($"--{normalizedPrefix}cyber")
                {
                    Description = @"Selects a cyber access program compatible with the model. Daybreak requires access to the selected tier. Omit to use the model default.",
                }
        );
    }
}