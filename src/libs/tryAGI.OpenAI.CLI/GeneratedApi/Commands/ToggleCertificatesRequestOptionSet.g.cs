#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record ToggleCertificatesRequestOptionSet(
    Option<global::System.Collections.Generic.IList<string>> CertificateIds)
{
    public static ToggleCertificatesRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ToggleCertificatesRequestOptionSet(
                        CertificateIds: new Option<global::System.Collections.Generic.IList<string>>($"--{normalizedPrefix}certificate-ids")
                {
                    Description = @"",
                    Required = true,
                }
        );
    }
}