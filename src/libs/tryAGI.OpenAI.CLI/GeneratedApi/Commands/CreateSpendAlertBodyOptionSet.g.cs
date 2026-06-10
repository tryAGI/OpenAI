#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record CreateSpendAlertBodyOptionSet(
    Option<int> ThresholdAmount,
                     Option<global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency> Currency,
                     Option<global::tryAGI.OpenAI.CreateSpendAlertBodyInterval> Interval)
{
    public static CreateSpendAlertBodyOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateSpendAlertBodyOptionSet(
                        ThresholdAmount: new Option<int>($"--{normalizedPrefix}threshold-amount")
                {
                    Description = @"The alert threshold amount, in cents.",
                    Required = true,
                },
                Currency: new Option<global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency>($"--{normalizedPrefix}currency")
                {
                    Description = @"The currency for the threshold amount.",
                },
                Interval: new Option<global::tryAGI.OpenAI.CreateSpendAlertBodyInterval>($"--{normalizedPrefix}interval")
                {
                    Description = @"The time interval for evaluating spend against the threshold.",
                }
        );
    }
}