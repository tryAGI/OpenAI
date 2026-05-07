#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static class RolesUpdateOrganizationRoleCommandApiCommand
{
    private static Argument<string> RoleId { get; } = new(
        name: @"role-id")
    {
        Description = @"The ID of the role to update.",
    };
      private static Option<string?> RequestJson { get; } = new("--request-json")
      {
          Description = "Request body as JSON.",
      };

      private static Option<string?> RequestFile { get; } = new("--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
      };

    public static Command Create()
    {
        var command = new Command(@"update-organization-role", @"Updates an existing organization role.");
                        command.Arguments.Add(RoleId);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              if (hasRequestJson == hasRequestFile)
              {
                  result.AddError("Specify exactly one of --request-json or --request-file.");
              }
          });
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var roleId = parseResult.GetRequiredValue(RoleId);
                        var request = await CliRuntime.ReadRequestAsync<global::tryAGI.OpenAI.PublicUpdateOrganizationRoleBody>(
                            parseResult,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                var response = await client.Roles.UpdateOrganizationRoleAsync(
                                    roleId: roleId,
                                    request: request,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteJsonAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}