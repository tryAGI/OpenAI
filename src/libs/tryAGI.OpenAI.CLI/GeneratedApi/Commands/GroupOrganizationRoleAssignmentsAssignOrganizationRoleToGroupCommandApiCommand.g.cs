#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class GroupOrganizationRoleAssignmentsAssignOrganizationRoleToGroupCommandApiCommand
{
    private static Argument<string> GroupId { get; } = new(
        name: @"group-id")
    {
        Description = @"The ID of the group that should receive the organization role.",
    };
    private static readonly PublicAssignOrganizationGroupRoleBodyOptionSet PublicAssignOrganizationGroupRoleBodyOptionSetOptions = PublicAssignOrganizationGroupRoleBodyOptionSet.Create();

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.GroupRoleAssignment value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.GroupRoleAssignment value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"assign-organization-role-to-group", @"Assigns an organization role to a group within the organization.");
                        command.Arguments.Add(GroupId);                        command.Options.Add(PublicAssignOrganizationGroupRoleBodyOptionSetOptions.RoleId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var groupId = parseResult.GetRequiredValue(GroupId);                        var roleId = parseResult.GetRequiredValue(PublicAssignOrganizationGroupRoleBodyOptionSetOptions.RoleId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GroupOrganizationRoleAssignments.AssignOrganizationRoleToGroupAsync(
                                    groupId: groupId,
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