#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class ProjectsCreateProjectServiceAccountCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project.",
    };

    private static Option<string> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"The name of the service account being created.",
        Required = true,
    };

    private static Option<bool?> CreateServiceAccountOnly { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--create-service-account-only",
        description: @"");

    private static Option<int?> ExpiresInSeconds { get; } = new(
        name: @"--expires-in-seconds")
    {
        Description = @"Number of seconds until the initial API key expires. If omitted or null, the key does not expire unless the effective organization or project policy requires an expiration. When a policy sets a maximum lifetime, this value must be provided and must not exceed that limit. A non-null value cannot be used when `create_service_account_only` is true.",
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ProjectServiceAccountCreateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ProjectServiceAccountCreateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-project-service-account", @"Create project service account
Creates a new service account in the project. By default, this also returns an unredacted API key for the service account.");
                        command.Arguments.Add(ProjectId);
                        command.Options.Add(NameOption);
                        command.Options.Add(CreateServiceAccountOnly);
                        command.Options.Add(ExpiresInSeconds);
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

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.ProjectServiceAccountCreateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var createServiceAccountOnly = CliRuntime.WasSpecified(parseResult, CreateServiceAccountOnly) ? parseResult.GetValue(CreateServiceAccountOnly) : (__requestBase is { } __CreateServiceAccountOnlyBaseValue ? __CreateServiceAccountOnlyBaseValue.CreateServiceAccountOnly : default);
                        var expiresInSeconds = CliRuntime.WasSpecified(parseResult, ExpiresInSeconds) ? parseResult.GetValue(ExpiresInSeconds) : (__requestBase is { } __ExpiresInSecondsBaseValue ? __ExpiresInSecondsBaseValue.ExpiresInSeconds : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Projects.CreateProjectServiceAccountAsync(
                                    projectId: projectId,
                                    name: name,
                                    createServiceAccountOnly: createServiceAccountOnly,
                                    expiresInSeconds: expiresInSeconds,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}