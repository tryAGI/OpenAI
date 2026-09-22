#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(AdminApiKeysCreateCommandApiCommand.Create());
                         command.Subcommands.Add(AdminApiKeysDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(AdminApiKeysGetCommandApiCommand.Create());
                         command.Subcommands.Add(AdminApiKeysListCommandApiCommand.Create());
                         command.Subcommands.Add(CancelChatSessionMethodCommandApiCommand.Create());
                         command.Subcommands.Add(CreateChatSessionMethodCommandApiCommand.Create());
                         command.Subcommands.Add(CreateContainerCommandApiCommand.Create());
                         command.Subcommands.Add(CreateContainerFileCommandApiCommand.Create());
                         command.Subcommands.Add(CreateWebhookEndpointCommandApiCommand.Create());
                         command.Subcommands.Add(CreateanAPIkeyforaserviceaccountCommandApiCommand.Create());
                         command.Subcommands.Add(CreateanexternalstorageconfigurationCommandApiCommand.Create());
                         command.Subcommands.Add(CreatecontentprovenancecheckCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteContainerCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteContainerFileCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteThreadMethodCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteWebhookEndpointCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteanexternalstorageconfigurationCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteorganizationspendlimitCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteprojectspendlimitCommandApiCommand.Create());
                         command.Subcommands.Add(GetThreadMethodCommandApiCommand.Create());
                         command.Subcommands.Add(GetanexternalstorageconfigurationCommandApiCommand.Create());
                         command.Subcommands.Add(GetorganizationspendlimitCommandApiCommand.Create());
                         command.Subcommands.Add(GetprojectsafetyalertCommandApiCommand.Create());
                         command.Subcommands.Add(GetprojectspendlimitCommandApiCommand.Create());
                         command.Subcommands.Add(GetsafetycaseCommandApiCommand.Create());
                         command.Subcommands.Add(ListContainerFilesCommandApiCommand.Create());
                         command.Subcommands.Add(ListContainersCommandApiCommand.Create());
                         command.Subcommands.Add(ListThreadItemsMethodCommandApiCommand.Create());
                         command.Subcommands.Add(ListThreadsMethodCommandApiCommand.Create());
                         command.Subcommands.Add(ListWebhookEndpointsCommandApiCommand.Create());
                         command.Subcommands.Add(ListWebhookEventTypesCommandApiCommand.Create());
                         command.Subcommands.Add(ListexternalstorageconfigurationsCommandApiCommand.Create());
                         command.Subcommands.Add(RetrieveContainerCommandApiCommand.Create());
                         command.Subcommands.Add(RetrieveContainerFileCommandApiCommand.Create());
                         command.Subcommands.Add(RetrieveContainerFileContentCommandApiCommand.Create());
                         command.Subcommands.Add(RetrieveWebhookEndpointCommandApiCommand.Create());
                         command.Subcommands.Add(RotateWebhookEndpointSigningSecretCommandApiCommand.Create());
                         command.Subcommands.Add(TestWebhookEndpointCommandApiCommand.Create());
                         command.Subcommands.Add(UpdateWebhookEndpointCommandApiCommand.Create());
                         command.Subcommands.Add(UpdateorganizationspendlimitCommandApiCommand.Create());
                         command.Subcommands.Add(UpdateprojectspendlimitCommandApiCommand.Create());
                         command.Subcommands.Add(ValidateanexternalstorageconfigurationCommandApiCommand.Create());
        return command;
    }
}