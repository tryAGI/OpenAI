#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class CertificatesGetCertificateCommandApiCommand
{
    private static Argument<string> CertificateId { get; } = new(
        name: @"certificate-id")
    {
        Description = @"Unique ID of the certificate to retrieve.",
    };    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetCertificateIncludeItem>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"A list of additional fields to include in the response. Currently the only supported value is `content` to fetch the PEM content of the certificate.",
    };

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

                                await CliRuntime.WriteJsonAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}