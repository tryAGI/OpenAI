#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class RolesUpdateProjectRoleCommandApiCommand
{
    private static Argument<string> ProjectId { get; } = new(
        name: @"project-id")
    {
        Description = @"The ID of the project to update.",
    };

    private static Argument<string> RoleId { get; } = new(
        name: @"role-id")
    {
        Description = @"The ID of the role to update.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Permissions { get; } = new(
        name: @"--permissions")
    {
        Description = @"Updated set of permissions for the role.",
    };
    private static readonly PublicUpdateOrganizationRoleBodyOptionSet PublicUpdateOrganizationRoleBodyOptionSetOptions = PublicUpdateOrganizationRoleBodyOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.Role value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.Role value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-project-role", @"Updates an existing project role.");
                        command.Arguments.Add(ProjectId);
                        command.Arguments.Add(RoleId);
                        command.Options.Add(Permissions);                        command.Options.Add(PublicUpdateOrganizationRoleBodyOptionSetOptions.DescriptionOption);
                        command.Options.Add(PublicUpdateOrganizationRoleBodyOptionSetOptions.RoleName);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.PublicUpdateOrganizationRoleBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = parseResult.GetRequiredValue(ProjectId);
                        var roleId = parseResult.GetRequiredValue(RoleId);
                        var permissions = CliRuntime.WasSpecified(parseResult, Permissions) ? parseResult.GetValue(Permissions) : (__requestBase is { } __PermissionsBaseValue ? __PermissionsBaseValue.Permissions : default);                        var description = CliRuntime.WasSpecified(parseResult, PublicUpdateOrganizationRoleBodyOptionSetOptions.DescriptionOption) ? parseResult.GetValue(PublicUpdateOrganizationRoleBodyOptionSetOptions.DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var roleName = CliRuntime.WasSpecified(parseResult, PublicUpdateOrganizationRoleBodyOptionSetOptions.RoleName) ? parseResult.GetValue(PublicUpdateOrganizationRoleBodyOptionSetOptions.RoleName) : (__requestBase is { } __RoleNameBaseValue ? __RoleNameBaseValue.RoleName : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Roles.UpdateProjectRoleAsync(
                                    projectId: projectId,
                                    roleId: roleId,
                                    permissions: permissions,
                                    description: description,
                                    roleName: roleName,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"Permissions",
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