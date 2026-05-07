#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class InvitesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"invites", @"Invites endpoint commands.");
                         command.Subcommands.Add(InvitesCreateInviteCommandApiCommand.Create());
                         command.Subcommands.Add(InvitesDeleteInviteCommandApiCommand.Create());
                         command.Subcommands.Add(InvitesListInvitesCommandApiCommand.Create());
                         command.Subcommands.Add(InvitesRetrieveInviteCommandApiCommand.Create());
        return command;
    }
}