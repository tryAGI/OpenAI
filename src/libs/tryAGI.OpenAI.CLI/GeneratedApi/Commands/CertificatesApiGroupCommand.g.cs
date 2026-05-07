#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class CertificatesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"certificates", @"Certificates endpoint commands.");
                         command.Subcommands.Add(CertificatesActivateCertificatesForOrganizationCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesActivateCertificatesForProjectCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesDeactivateCertificatesForOrganizationCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesDeactivateCertificatesForProjectCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesDeleteCertificateCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesGetCertificateCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesListOrganizationCertificatesCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesListProjectCertificatesCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesModifyCertificateCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesUploadCertificateCommandApiCommand.Create());
        return command;
    }
}