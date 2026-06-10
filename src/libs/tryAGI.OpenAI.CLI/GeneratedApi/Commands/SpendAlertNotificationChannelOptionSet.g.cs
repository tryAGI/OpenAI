#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record SpendAlertNotificationChannelOptionSet(
    Option<global::tryAGI.OpenAI.SpendAlertNotificationChannelType> Type,
                     Option<global::System.Collections.Generic.IList<string>> Recipients,
                     Option<string?> SubjectPrefix)
{
    public static SpendAlertNotificationChannelOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SpendAlertNotificationChannelOptionSet(
                        Type: new Option<global::tryAGI.OpenAI.SpendAlertNotificationChannelType>($"--{normalizedPrefix}type")
                {
                    Description = @"The notification channel type. Currently only `email` is supported.",
                },
                Recipients: new Option<global::System.Collections.Generic.IList<string>>($"--{normalizedPrefix}recipients")
                {
                    Description = @"Email addresses that receive the spend alert notification.",
                    Required = true,
                },
                SubjectPrefix: new Option<string?>($"--{normalizedPrefix}subject-prefix")
                {
                    Description = @"Optional subject prefix for alert emails.",
                }
        );
    }
}