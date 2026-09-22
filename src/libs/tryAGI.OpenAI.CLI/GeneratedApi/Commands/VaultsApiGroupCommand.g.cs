#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class VaultsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"vaults", @"Vaults endpoint commands.");
                         command.Subcommands.Add(VaultsCreateVaultCommandApiCommand.Create());
                         command.Subcommands.Add(VaultsCreateVaultCredentialCommandApiCommand.Create());
                         command.Subcommands.Add(VaultsDeleteVaultCommandApiCommand.Create());
                         command.Subcommands.Add(VaultsDeleteVaultCredentialCommandApiCommand.Create());
                         command.Subcommands.Add(VaultsListVaultCredentialsCommandApiCommand.Create());
                         command.Subcommands.Add(VaultsListVaultsCommandApiCommand.Create());
                         command.Subcommands.Add(VaultsRetrieveVaultCommandApiCommand.Create());
                         command.Subcommands.Add(VaultsRetrieveVaultCredentialCommandApiCommand.Create());
                         command.Subcommands.Add(VaultsRotateVaultCredentialCommandApiCommand.Create());
        return command;
    }
}