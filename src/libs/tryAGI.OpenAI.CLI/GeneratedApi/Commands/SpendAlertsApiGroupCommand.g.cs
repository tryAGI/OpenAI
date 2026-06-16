#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class SpendAlertsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"spend-alerts", @"Spend alerts endpoint commands.");
                         command.Subcommands.Add(SpendAlertsCreateOrganizationSpendAlertCommandApiCommand.Create());
                         command.Subcommands.Add(SpendAlertsCreateProjectSpendAlertCommandApiCommand.Create());
                         command.Subcommands.Add(SpendAlertsDeleteOrganizationSpendAlertCommandApiCommand.Create());
                         command.Subcommands.Add(SpendAlertsDeleteProjectSpendAlertCommandApiCommand.Create());
                         command.Subcommands.Add(SpendAlertsListOrganizationSpendAlertsCommandApiCommand.Create());
                         command.Subcommands.Add(SpendAlertsListProjectSpendAlertsCommandApiCommand.Create());
                         command.Subcommands.Add(SpendAlertsRetrieveOrganizationSpendAlertCommandApiCommand.Create());
                         command.Subcommands.Add(SpendAlertsRetrieveProjectSpendAlertCommandApiCommand.Create());
                         command.Subcommands.Add(SpendAlertsUpdateOrganizationSpendAlertCommandApiCommand.Create());
                         command.Subcommands.Add(SpendAlertsUpdateProjectSpendAlertCommandApiCommand.Create());
        return command;
    }
}