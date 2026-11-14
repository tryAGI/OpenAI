
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInputRemovalReason
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
    public static class BetaInputRemovalReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputRemovalReason value)
        {
            return value switch
            {
                BetaInputRemovalReason.EndUserMismatch => "end_user_mismatch",
                BetaInputRemovalReason.ModelMismatch => "model_mismatch",
                BetaInputRemovalReason.OrganizationMismatch => "organization_mismatch",
                BetaInputRemovalReason.PrefixMismatch => "prefix_mismatch",
                BetaInputRemovalReason.TurnBoundary => "turn_boundary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputRemovalReason? ToEnum(string value)
        {
            return value switch
            {
                "end_user_mismatch" => BetaInputRemovalReason.EndUserMismatch,
                "model_mismatch" => BetaInputRemovalReason.ModelMismatch,
                "organization_mismatch" => BetaInputRemovalReason.OrganizationMismatch,
                "prefix_mismatch" => BetaInputRemovalReason.PrefixMismatch,
                "turn_boundary" => BetaInputRemovalReason.TurnBoundary,
                _ => null,
            };
        }
    }
}