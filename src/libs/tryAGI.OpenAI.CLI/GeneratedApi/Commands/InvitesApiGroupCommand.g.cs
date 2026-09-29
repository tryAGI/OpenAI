#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class InvitesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"invites", @"Invites endpoint commands.");
                         command.Subcommands.Add(InvitesDeleteInviteCommandApiCommand.Create());
                         command.Subcommands.Add(InvitesInviteUserCommandApiCommand.Create());
                         command.Subcommands.Add(InvitesListInvitesCommandApiCommand.Create());
                         command.Subcommands.Add(InvitesRetrieveInviteCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}