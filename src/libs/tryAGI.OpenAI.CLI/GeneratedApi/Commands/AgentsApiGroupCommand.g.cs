#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class AgentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"agents", @"Agents endpoint commands.");
                         command.Subcommands.Add(AgentsCreateAgentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsCreateAgentEnvironmentFileCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsCreateAgentEnvironmentTemplateCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsCreateAgentSessionCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsCreateAgentSessionAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsCreateAgentSessionEventsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsDeleteAgentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsDeleteAgentEnvironmentTemplateCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsDeleteAgentSessionCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsDeleteAgentSessionArtifactCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentEnvironmentFilesCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentEnvironmentTemplatesCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentSessionArtifactsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentSessionEventsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentSessionItemsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentSessionSubagentItemsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentSessionSubagentTurnItemsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentSessionSubagentTurnsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentSessionSubagentsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentSessionTurnsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentSessionsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListAgentsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRetrieveAgentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRetrieveAgentEnvironmentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRetrieveAgentEnvironmentTemplateCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRetrieveAgentSessionCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRetrieveAgentSessionArtifactCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRetrieveAgentSessionArtifactContentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRetrieveAgentSessionSubagentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRetrieveAgentSessionSubagentTurnCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRetrieveAgentSessionTurnCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsUpdateAgentCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsUpdateAgentEnvironmentTemplateCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsUpdateAgentSessionCommandApiCommand.Create());
        return command;
    }
}