#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class HostedToolsModifyProjectHostedToolPermissionsCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project.",
    };
    private static readonly HostedToolPermissionUpdateOptionSet FileSearchOptions = HostedToolPermissionUpdateOptionSet.Create(@"file-search");

    private static readonly HostedToolPermissionUpdateOptionSet WebSearchOptions = HostedToolPermissionUpdateOptionSet.Create(@"web-search");

    private static readonly HostedToolPermissionUpdateOptionSet ImageGenerationOptions = HostedToolPermissionUpdateOptionSet.Create(@"image-generation");

    private static readonly HostedToolPermissionUpdateOptionSet McpOptions = HostedToolPermissionUpdateOptionSet.Create(@"mcp");

    private static readonly HostedToolPermissionUpdateOptionSet CodeInterpreterOptions = HostedToolPermissionUpdateOptionSet.Create(@"code-interpreter");
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.ProjectHostedToolPermissions value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.ProjectHostedToolPermissions value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"modify-project-hosted-tool-permissions", @"Updates hosted tool permissions for a project.");
                        command.Arguments.Add(ProjectId);                        command.Options.Add(FileSearchOptions.Enabled);                        command.Options.Add(WebSearchOptions.Enabled);                        command.Options.Add(ImageGenerationOptions.Enabled);                        command.Options.Add(McpOptions.Enabled);                        command.Options.Add(CodeInterpreterOptions.Enabled);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.ProjectHostedToolPermissionsUpdateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);

                        var __fileSearchBase = __requestBase?.FileSearch;                        var fileSearchEnabled = parseResult.GetValue(FileSearchOptions.Enabled);
                        var __fileSearchSpecified = CliRuntime.WasSpecified(parseResult, FileSearchOptions.Enabled);
                        var fileSearch =
                            __fileSearchSpecified || __fileSearchBase is not null
                                ? new global::tryAGI.OpenAI.HostedToolPermissionUpdate
                                {
                                Enabled = fileSearchEnabled!,
                                }
                                : __fileSearchBase;

                        var __webSearchBase = __requestBase?.WebSearch;                        var webSearchEnabled = parseResult.GetValue(WebSearchOptions.Enabled);
                        var __webSearchSpecified = CliRuntime.WasSpecified(parseResult, WebSearchOptions.Enabled);
                        var webSearch =
                            __webSearchSpecified || __webSearchBase is not null
                                ? new global::tryAGI.OpenAI.HostedToolPermissionUpdate
                                {
                                Enabled = webSearchEnabled!,
                                }
                                : __webSearchBase;

                        var __imageGenerationBase = __requestBase?.ImageGeneration;                        var imageGenerationEnabled = parseResult.GetValue(ImageGenerationOptions.Enabled);
                        var __imageGenerationSpecified = CliRuntime.WasSpecified(parseResult, ImageGenerationOptions.Enabled);
                        var imageGeneration =
                            __imageGenerationSpecified || __imageGenerationBase is not null
                                ? new global::tryAGI.OpenAI.HostedToolPermissionUpdate
                                {
                                Enabled = imageGenerationEnabled!,
                                }
                                : __imageGenerationBase;

                        var __mcpBase = __requestBase?.Mcp;                        var mcpEnabled = parseResult.GetValue(McpOptions.Enabled);
                        var __mcpSpecified = CliRuntime.WasSpecified(parseResult, McpOptions.Enabled);
                        var mcp =
                            __mcpSpecified || __mcpBase is not null
                                ? new global::tryAGI.OpenAI.HostedToolPermissionUpdate
                                {
                                Enabled = mcpEnabled!,
                                }
                                : __mcpBase;

                        var __codeInterpreterBase = __requestBase?.CodeInterpreter;                        var codeInterpreterEnabled = parseResult.GetValue(CodeInterpreterOptions.Enabled);
                        var __codeInterpreterSpecified = CliRuntime.WasSpecified(parseResult, CodeInterpreterOptions.Enabled);
                        var codeInterpreter =
                            __codeInterpreterSpecified || __codeInterpreterBase is not null
                                ? new global::tryAGI.OpenAI.HostedToolPermissionUpdate
                                {
                                Enabled = codeInterpreterEnabled!,
                                }
                                : __codeInterpreterBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.HostedTools.ModifyProjectHostedToolPermissionsAsync(
                                    projectId: projectId,
                                    fileSearch: fileSearch,
                                    webSearch: webSearch,
                                    imageGeneration: imageGeneration,
                                    mcp: mcp,
                                    codeInterpreter: codeInterpreter,
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