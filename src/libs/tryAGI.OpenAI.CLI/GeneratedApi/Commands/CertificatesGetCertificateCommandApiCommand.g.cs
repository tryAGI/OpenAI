#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class CertificatesGetCertificateCommandApiCommand
{
    private static Argument<string> CertificateId { get; } = new(
        name: @"certificate-id")
    {
        Description = @"Unique ID of the certificate to retrieve.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetCertificateIncludeItem>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"A list of additional fields to include in the response. Currently the only supported value is `content` to fetch the PEM content of the certificate.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.Certificate value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.Certificate value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-certificate", @"Get a certificate that has been uploaded to the organization.

You can get a certificate regardless of whether it is active or not.
");
                        command.Arguments.Add(CertificateId);
                        command.Options.Add(Include);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var certificateId = parseResult.GetRequiredValue(CertificateId);
                        var include = parseResult.GetValue(Include);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Certificates.GetCertificateAsync(
                                    certificateId: certificateId,
                                    include: include,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}