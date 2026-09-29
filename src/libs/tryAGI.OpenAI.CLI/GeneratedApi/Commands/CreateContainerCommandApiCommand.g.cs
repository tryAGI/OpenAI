#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class CreateContainerCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Name of the container to create.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> FileIds { get; } = new(
        name: @"--file-ids")
    {
        Description = @"IDs of files to copy to the container.",
    };

    private static Option<global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter?> ExpiresAfter { get; } = new(
        name: @"--expires-after")
    {
        Description = @"Container expiration time in seconds relative to the 'anchor' time.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem>?> Skills { get; } = new(
        name: @"--skills")
    {
        Description = @"An optional list of skills referenced by id or inline data.",
    };

    private static Option<global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit?> MemoryLimit { get; } = new(
        name: @"--memory-limit")
    {
        Description = @"Optional memory limit for the container. Defaults to ""1g"".",
    };

    private static Option<global::tryAGI.OpenAI.NetworkPolicy?> NetworkPolicy { get; } = new(
        name: @"--network-policy")
    {
        Description = @"Network access policy for the container.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ContainerResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ContainerResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-container", @"Create container
Create Container");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(FileIds);
                        command.Options.Add(ExpiresAfter);
                        command.Options.Add(Skills);
                        command.Options.Add(MemoryLimit);
                        command.Options.Add(NetworkPolicy);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });
          command.Options.Add(Wait);
          command.Options.Add(PollInterval);
          command.Options.Add(WaitTimeout);
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateContainerBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var fileIds = CliRuntime.WasSpecified(parseResult, FileIds) ? parseResult.GetValue(FileIds) : (__requestBase is { } __FileIdsBaseValue ? __FileIdsBaseValue.FileIds : default);
                        var expiresAfter = CliRuntime.WasSpecified(parseResult, ExpiresAfter) ? parseResult.GetValue(ExpiresAfter) : (__requestBase is { } __ExpiresAfterBaseValue ? __ExpiresAfterBaseValue.ExpiresAfter : default);
                        var skills = CliRuntime.WasSpecified(parseResult, Skills) ? parseResult.GetValue(Skills) : (__requestBase is { } __SkillsBaseValue ? __SkillsBaseValue.Skills : default);
                        var memoryLimit = CliRuntime.WasSpecified(parseResult, MemoryLimit) ? parseResult.GetValue(MemoryLimit) : (__requestBase is { } __MemoryLimitBaseValue ? __MemoryLimitBaseValue.MemoryLimit : default);
                        var networkPolicy = CliRuntime.WasSpecified(parseResult, NetworkPolicy) ? parseResult.GetValue(NetworkPolicy) : (__requestBase is { } __NetworkPolicyBaseValue ? __NetworkPolicyBaseValue.NetworkPolicy : default);          var wait = parseResult.GetValue(Wait);
          var pollInterval = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(PollInterval), PollInterval.Name) : default;
          var waitTimeout = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(WaitTimeout), WaitTimeout.Name) : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                if (wait)
                                {
                                var createResponse = await client.CreateContainerAsync(
                                    name: name,
                                    fileIds: fileIds,
                                    expiresAfter: expiresAfter,
                                    skills: skills,
                                    memoryLimit: memoryLimit,
                                    networkPolicy: networkPolicy,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);
                                    var resourceId = global::System.Convert.ToString(
                                        createResponse.Id,
                                        global::System.Globalization.CultureInfo.InvariantCulture);
                                    if (string.IsNullOrWhiteSpace(resourceId))
                                    {
                                        throw new CliException("The create response did not contain a job id.");
                                    }

                                    var waitResponse = await CliRuntime.PollUntilTerminalAsync(
                                        fetchAsync: token => client.RetrieveContainerAsync(
                                            containerId: resourceId,
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

                                var response = await client.CreateContainerAsync(
                                    name: name,
                                    fileIds: fileIds,
                                    expiresAfter: expiresAfter,
                                    skills: skills,
                                    memoryLimit: memoryLimit,
                                    networkPolicy: networkPolicy,
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