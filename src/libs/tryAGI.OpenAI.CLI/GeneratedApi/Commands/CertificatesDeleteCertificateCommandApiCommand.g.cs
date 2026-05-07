#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class CertificatesDeleteCertificateCommandApiCommand
{
    private static Argument<string> CertificateId { get; } = new(
        name: @"certificate-id")
    {
        Description = @"Unique ID of the certificate to delete.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-certificate", @"Delete a certificate from the organization.

The certificate must be inactive for the organization and all projects.
");
                        command.Arguments.Add(CertificateId);

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var certificateId = parseResult.GetRequiredValue(CertificateId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Certificates.DeleteCertificateAsync(
                                    certificateId: certificateId,
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