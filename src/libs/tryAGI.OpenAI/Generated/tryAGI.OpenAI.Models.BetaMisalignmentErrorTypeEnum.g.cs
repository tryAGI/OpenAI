
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaMisalignmentErrorTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        PotentiallyUnintendedDataAccess,
        /// <summary>
        ///
        /// </summary>
        PotentiallyUnintendedDataTransfer,
        /// <summary>
        ///
        /// </summary>
        PotentiallyUnintendedDestructiveActivity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMisalignmentErrorTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMisalignmentErrorTypeEnum value)
        {
            return value switch
            {
                BetaMisalignmentErrorTypeEnum.Other => "other",
                BetaMisalignmentErrorTypeEnum.PotentiallyUnintendedDataAccess => "potentially_unintended_data_access",
                BetaMisalignmentErrorTypeEnum.PotentiallyUnintendedDataTransfer => "potentially_unintended_data_transfer",
                BetaMisalignmentErrorTypeEnum.PotentiallyUnintendedDestructiveActivity => "potentially_unintended_destructive_activity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMisalignmentErrorTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "other" => BetaMisalignmentErrorTypeEnum.Other,
                "potentially_unintended_data_access" => BetaMisalignmentErrorTypeEnum.PotentiallyUnintendedDataAccess,
                "potentially_unintended_data_transfer" => BetaMisalignmentErrorTypeEnum.PotentiallyUnintendedDataTransfer,
                "potentially_unintended_destructive_activity" => BetaMisalignmentErrorTypeEnum.PotentiallyUnintendedDestructiveActivity,
                _ => null,
            };
        }
    }
}