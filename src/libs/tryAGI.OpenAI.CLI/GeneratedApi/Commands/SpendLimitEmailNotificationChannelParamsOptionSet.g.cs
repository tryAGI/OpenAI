#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record SpendLimitEmailNotificationChannelParamsOptionSet(
    Option<global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParamsType> Type,
                     Option<global::System.Collections.Generic.IList<string>?> Recipients,
                     Option<string?> SubjectPrefix)
{
    public static SpendLimitEmailNotificationChannelParamsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SpendLimitEmailNotificationChannelParamsOptionSet(
                        Type: new Option<global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParamsType>($"--{normalizedPrefix}type")
                {
                    Description = @"",
                    DefaultValueFactory = _ => global::tryAGI.OpenAI.SpendLimitEmailNotificationChannelParamsType.Email,
                },
                Recipients: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}recipients")
                {
                    Description = @"Additional email recipients. Omit to keep them unchanged; send [] to clear them.",
                },
                SubjectPrefix: new Option<string?>($"--{normalizedPrefix}subject-prefix")
                {
                    Description = @"",
                }
        );
    }
}