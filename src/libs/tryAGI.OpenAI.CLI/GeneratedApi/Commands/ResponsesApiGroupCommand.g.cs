#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class ResponsesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"responses", @"Responses endpoint commands.");
                         command.Subcommands.Add(ResponsesCancelAResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesCancelAResponse2CommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesCreateAModelResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesCreateAModelResponse2CommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesCreateAModelResponse2AsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesCreateAModelResponseAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesDeleteAModelResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesDeleteAModelResponse2CommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesGetAModelResponseCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesGetAModelResponse2CommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesListInputItemsCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesListInputItems2CommandApiCommand.Create());
        return command;
    }
}