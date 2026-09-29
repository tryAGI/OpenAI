#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ProjectsCreateProjectCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"The friendly name of the project, this name appears in reports.",
    };

    private static Option<global::tryAGI.OpenAI.PublicProjectResidency?> Residency { get; } = new(
        name: @"--residency")
    {
        Description = @"Create the project with the specified residency configuration. Your organization must have access to the requested residency configuration in order to use it. See [data residency controls](https://developers.openai.com/api/docs/guides/your-data#data-residency-controls) to review the functionality and limitations of setting this field.",
    };

    private static Option<string?> ExternalKeyId { get; } = new(
        name: @"--external-key-id")
    {
        Description = @"External key ID to associate with the project.",
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.Project value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.Project value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"create-project", @"Create project
Create a new project in the organization. Projects can be created and archived, but cannot be deleted.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(Residency);
                        command.Options.Add(ExternalKeyId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.ProjectCreateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var residency = CliRuntime.WasSpecified(parseResult, Residency) ? parseResult.GetValue(Residency) : (__requestBase is { } __ResidencyBaseValue ? __ResidencyBaseValue.Residency : default);
                        var externalKeyId = CliRuntime.WasSpecified(parseResult, ExternalKeyId) ? parseResult.GetValue(ExternalKeyId) : (__requestBase is { } __ExternalKeyIdBaseValue ? __ExternalKeyIdBaseValue.ExternalKeyId : default);          var wait = parseResult.GetValue(Wait);
          var pollInterval = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(PollInterval), PollInterval.Name) : default;
          var waitTimeout = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(WaitTimeout), WaitTimeout.Name) : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                if (wait)
                                {
                                var createResponse = await client.Projects.CreateProjectAsync(
                                    name: name,
                                    residency: residency,
                                    externalKeyId: externalKeyId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);
                                    var resourceId = global::System.Convert.ToString(
                                        createResponse.Id,
                                        global::System.Globalization.CultureInfo.InvariantCulture);
                                    if (string.IsNullOrWhiteSpace(resourceId))
                                    {
                                        throw new CliException("The create response did not contain a job id.");
                                    }

                                    var waitResponse = await CliRuntime.PollUntilTerminalAsync(
                                        fetchAsync: token => client.Projects.RetrieveProjectAsync(
                                            projectId: resourceId,
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

                                var response = await client.Projects.CreateProjectAsync(
                                    name: name,
                                    residency: residency,
                                    externalKeyId: externalKeyId,
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