#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class UserOrganizationRoleAssignmentsAssignOrganizationRoleToUserCommandApiCommand
{
    private static Argument<string> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"The ID of the user that should receive the organization role.",
    };
    private static readonly PublicAssignOrganizationGroupRoleBodyOptionSet PublicAssignOrganizationGroupRoleBodyOptionSetOptions = PublicAssignOrganizationGroupRoleBodyOptionSet.Create();

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.UserRoleAssignment value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.UserRoleAssignment value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"assign-organization-role-to-user", @"Assigns an organization role to a user within the organization.");
                        command.Arguments.Add(UserId);                        command.Options.Add(PublicAssignOrganizationGroupRoleBodyOptionSetOptions.RoleId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var userId = parseResult.GetRequiredValue(UserId);                        var roleId = parseResult.GetRequiredValue(PublicAssignOrganizationGroupRoleBodyOptionSetOptions.RoleId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UserOrganizationRoleAssignments.AssignOrganizationRoleToUserAsync(
                                    userId: userId,
                                    roleId: roleId,
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