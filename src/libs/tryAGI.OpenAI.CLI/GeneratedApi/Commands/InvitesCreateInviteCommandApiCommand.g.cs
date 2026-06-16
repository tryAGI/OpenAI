#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class InvitesCreateInviteCommandApiCommand
{
    private static Option<string> Email { get; } = new(
        name: @"--email")
    {
        Description = @"Send an email to this address",
        Required = true,
    };

    private static Option<global::tryAGI.OpenAI.InviteRequestRole> Role { get; } = new(
        name: @"--role")
    {
        Description = @"`owner` or `reader`",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteRequestProject>?> Projects { get; } = new(
        name: @"--projects")
    {
        Description = @"An array of projects to which membership is granted at the same time the org invite is accepted. If omitted, the user will be invited to the default project for compatibility with legacy behavior. If empty list is passed, the user will not be invited to any projects, including the default one.",
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.Invite value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.Invite value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-invite", @"Create an invite for a user to the organization. The invite must be accepted by the user before they have access to the organization.");
                        command.Options.Add(Email);
                        command.Options.Add(Role);
                        command.Options.Add(Projects);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.InviteRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var email = parseResult.GetRequiredValue(Email);
                        var role = parseResult.GetRequiredValue(Role);
                        var projects = CliRuntime.WasSpecified(parseResult, Projects) ? parseResult.GetValue(Projects) : (__requestBase is { } __ProjectsBaseValue ? __ProjectsBaseValue.Projects : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Invites.CreateInviteAsync(
                                    email: email,
                                    role: role,
                                    projects: projects,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Projects",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}