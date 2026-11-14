
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum InputRemovalReason
    {
        /// <summary>
        ///
        /// </summary>
        EndUserMismatch,
        /// <summary>
        ///
        /// </summary>
        ModelMismatch,
        /// <summary>
        ///
        /// </summary>
        OrganizationMismatch,
        /// <summary>
        ///
        /// </summary>
        PrefixMismatch,
        /// <summary>
        ///
        /// </summary>
        TurnBoundary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputRemovalReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputRemovalReason value)
        {
            return value switch
            {
                InputRemovalReason.EndUserMismatch => "end_user_mismatch",
                InputRemovalReason.ModelMismatch => "model_mismatch",
                InputRemovalReason.OrganizationMismatch => "organization_mismatch",
                InputRemovalReason.PrefixMismatch => "prefix_mismatch",
                InputRemovalReason.TurnBoundary => "turn_boundary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputRemovalReason? ToEnum(string value)
        {
            return value switch
            {
                "end_user_mismatch" => InputRemovalReason.EndUserMismatch,
                "model_mismatch" => InputRemovalReason.ModelMismatch,
                "organization_mismatch" => InputRemovalReason.OrganizationMismatch,
                "prefix_mismatch" => InputRemovalReason.PrefixMismatch,
                "turn_boundary" => InputRemovalReason.TurnBoundary,
                _ => null,
            };
        }
    }
}