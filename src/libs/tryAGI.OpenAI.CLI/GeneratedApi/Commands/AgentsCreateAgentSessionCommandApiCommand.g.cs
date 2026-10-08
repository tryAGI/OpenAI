#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AgentsCreateAgentSessionCommandApiCommand
{
    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters. Omission or null defaults to an empty map.",
    };

    private static Option<global::tryAGI.OpenAI.EnvironmentParam> Environment { get; } = new(
        name: @"--environment")
    {
        Description = @"An inline execution environment or a reference to an environment template.",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.CreateSessionInputParam?> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Initial input to submit when the session is created. A string is shorthand for a single user message. Required when `environment.type` is `none`, or when `stream` is `true` for an environment that is not `self_hosted`; optional for self-hosted and non-streaming execution environments.",
    };
    private static readonly CreateAgentSessionParamsOptionSet CreateAgentSessionParamsOptionSetOptions = CreateAgentSessionParamsOptionSet.Create();

    private static readonly SessionSpendControlParamOptionSet SpendControlOptions = SessionSpendControlParamOptionSet.Create(@"spend-control");

    private static readonly SessionAgentConfigParamOptionSet AgentOptions = SessionAgentConfigParamOptionSet.Create(@"agent");
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };
      private static Option<bool> Wait { get; } = new("--wait")
      {
          Description = "Poll the generated wait helper until the resource reaches a terminal state.",
      };

      private static Option<string> PollInterval { get; } = new("--poll-interval")
      {
          Description = "Polling interval, for example 250ms, 2s, 30m, or 01:00:00.",
          DefaultValueFactory = _ => "2s",
      };

      private static Option<string> WaitTimeout { get; } = new("--wait-timeout")
      {
          Description = "Maximum time to wait before timing out, for example 30m or 00:30:00.",
          DefaultValueFactory = _ => "30m",
      };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.SessionResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.SessionResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-agent-session", @"Create an agent session
Creates a managed agent session, optionally submits initial input, and returns the session or streams its events when stream is true. See [running sessions](https://developers.openai.com/api/docs/guides/agents-api/sessions).");
                        command.Options.Add(Metadata);
                        command.Options.Add(Environment);
                        command.Options.Add(InputOption);                        command.Options.Add(CreateAgentSessionParamsOptionSetOptions.AgentId);
                        command.Options.Add(CreateAgentSessionParamsOptionSetOptions.VaultIds);                        command.Options.Add(SpendControlOptions.Limit);                        command.Options.Add(AgentOptions.Model);
                        command.Options.Add(AgentOptions.Instructions);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });
          command.Options.Add(Wait);
          command.Options.Add(PollInterval);
          command.Options.Add(WaitTimeout);
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateAgentSessionParams>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var environment = parseResult.GetRequiredValue(Environment);
                        var input = CliRuntime.WasSpecified(parseResult, InputOption) ? parseResult.GetValue(InputOption) : (__requestBase is { } __InputBaseValue ? __InputBaseValue.Input : default);                        var agentId = CliRuntime.WasSpecified(parseResult, CreateAgentSessionParamsOptionSetOptions.AgentId) ? parseResult.GetValue(CreateAgentSessionParamsOptionSetOptions.AgentId) : (__requestBase is { } __AgentIdBaseValue ? __AgentIdBaseValue.AgentId : default);
                        var vaultIds = CliRuntime.WasSpecified(parseResult, CreateAgentSessionParamsOptionSetOptions.VaultIds) ? parseResult.GetValue(CreateAgentSessionParamsOptionSetOptions.VaultIds) : (__requestBase is { } __VaultIdsBaseValue ? __VaultIdsBaseValue.VaultIds : default);

                        var __SpendControlBase = __requestBase is { } __SpendControlBaseValue ? __SpendControlBaseValue.SpendControl : default;                        var spendControlLimit = CliRuntime.WasSpecified(parseResult, SpendControlOptions.Limit) ? parseResult.GetValue(SpendControlOptions.Limit) : (__SpendControlBase is { } __SpendControllimitBaseValue ? __SpendControllimitBaseValue.Limit : default);
                        var __SpendControlSpecified = CliRuntime.WasSpecified(parseResult, SpendControlOptions.Limit);
                        var spendControl =
                            __SpendControlSpecified || __SpendControlBase is not null
                                ? new global::tryAGI.OpenAI.SessionSpendControlParam
                                {
	                                Limit = spendControlLimit,

                                }
                                : __SpendControlBase;

                        var __AgentBase = __requestBase is { } __AgentBaseValue ? __AgentBaseValue.Agent : default;                        var agentModel = CliRuntime.WasSpecified(parseResult, AgentOptions.Model) ? parseResult.GetValue(AgentOptions.Model) : (__AgentBase is { } __AgentmodelBaseValue ? __AgentmodelBaseValue.Model : default);
                        var agentInstructions = CliRuntime.WasSpecified(parseResult, AgentOptions.Instructions) ? parseResult.GetValue(AgentOptions.Instructions) : (__AgentBase is { } __AgentinstructionsBaseValue ? __AgentinstructionsBaseValue.Instructions : default);
                        var __AgentSpecified = CliRuntime.WasSpecified(parseResult, AgentOptions.Model) || CliRuntime.WasSpecified(parseResult, AgentOptions.Instructions);
                        var agent =
                            __AgentSpecified || __AgentBase is not null
                                ? new global::tryAGI.OpenAI.SessionAgentConfigParam
                                {
	                                Model = agentModel,
                                Instructions = agentInstructions,

                                }
                                : __AgentBase;          var wait = parseResult.GetValue(Wait);
          var pollInterval = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(PollInterval), PollInterval.Name) : default;
          var waitTimeout = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(WaitTimeout), WaitTimeout.Name) : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                if (wait)
                                {
                                var createResponse = await client.Agents.CreateAgentSessionAsync(
                                    metadata: metadata,
                                    environment: environment,
                                    input: input,
                                    agentId: agentId,
                                    vaultIds: vaultIds,
                                    spendControl: spendControl,
                                    agent: agent,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);
                                    var resourceId = global::System.Convert.ToString(
                                        createResponse.Id,
                                        global::System.Globalization.CultureInfo.InvariantCulture);
                                    if (string.IsNullOrWhiteSpace(resourceId))
                                    {
                                        throw new CliException("The create response did not contain a job id.");
                                    }

                                    var waitResponse = await CliRuntime.PollUntilTerminalAsync(
                                        fetchAsync: token => client.Agents.RetrieveAgentSessionAsync(
                                            sessionId: resourceId,
                                            cancellationToken: token),
                                        pollInterval: pollInterval,
                                        waitTimeout: waitTimeout,
                                        context: global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    await CliRuntime.WriteResponseAsync(
                                        parseResult,
                                        waitResponse,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    return;
                                }

                                var response = await client.Agents.CreateAgentSessionAsync(
                                    metadata: metadata,
                                    environment: environment,
                                    input: input,
                                    agentId: agentId,
                                    vaultIds: vaultIds,
                                    spendControl: spendControl,
                                    agent: agent,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}