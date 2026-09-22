#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ResponsesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"responses", @"Responses endpoint commands.");
                         command.Subcommands.Add(ResponsesBetaCancelResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesBetaCompactconversationCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesBetaCreateResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesBetaCreateResponseAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesBetaDeleteResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesBetaGetResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesBetaGetinputtokencountsCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesBetaListInputItemsCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesCancelResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesCompactconversationCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesCreateResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesCreateResponseAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesDeleteResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesGetResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesGetinputtokencountsCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesListInputItemsCommandApiCommand.Create());
        return command;
    }
}