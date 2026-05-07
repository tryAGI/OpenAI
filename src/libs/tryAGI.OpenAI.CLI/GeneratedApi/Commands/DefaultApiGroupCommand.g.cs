#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(CancelChatSessionCommandApiCommand.Create());
                         command.Subcommands.Add(CompactAResponseCommandApiCommand.Create());
                         command.Subcommands.Add(CreateAdminApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(CreateChatKitSessionCommandApiCommand.Create());
                         command.Subcommands.Add(CreateContainerCommandApiCommand.Create());
                         command.Subcommands.Add(CreateContainerFileCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteAContainerCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteAContainerFileCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteAdminApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteChatKitThreadCommandApiCommand.Create());
                         command.Subcommands.Add(GetInputTokenCountsCommandApiCommand.Create());
                         command.Subcommands.Add(ListAllOrganizationAndProjectApiKeysCommandApiCommand.Create());
                         command.Subcommands.Add(ListChatKitThreadItemsCommandApiCommand.Create());
                         command.Subcommands.Add(ListChatKitThreadsCommandApiCommand.Create());
                         command.Subcommands.Add(ListContainerFilesCommandApiCommand.Create());
                         command.Subcommands.Add(ListContainersCommandApiCommand.Create());
                         command.Subcommands.Add(RetrieveAdminApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(RetrieveChatKitThreadCommandApiCommand.Create());
                         command.Subcommands.Add(RetrieveContainerCommandApiCommand.Create());
                         command.Subcommands.Add(RetrieveContainerFileCommandApiCommand.Create());
                         command.Subcommands.Add(RetrieveContainerFileContentCommandApiCommand.Create());
        return command;
    }
}