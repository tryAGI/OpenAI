
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The object type, which is always `organization.invite.deleted`
    /// </summary>
    public enum InviteDeleteResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationInviteDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InviteDeleteResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteDeleteResponseObject value)
        {
            return value switch
            {
                InviteDeleteResponseObject.OrganizationInviteDeleted => "organization.invite.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteDeleteResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.invite.deleted" => InviteDeleteResponseObject.OrganizationInviteDeleted,
                _ => null,
            };
        }
    }
}