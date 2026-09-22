
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum MisalignmentErrorTypeEnum
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
    public static class MisalignmentErrorTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MisalignmentErrorTypeEnum value)
        {
            return value switch
            {
                MisalignmentErrorTypeEnum.Other => "other",
                MisalignmentErrorTypeEnum.PotentiallyUnintendedDataAccess => "potentially_unintended_data_access",
                MisalignmentErrorTypeEnum.PotentiallyUnintendedDataTransfer => "potentially_unintended_data_transfer",
                MisalignmentErrorTypeEnum.PotentiallyUnintendedDestructiveActivity => "potentially_unintended_destructive_activity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MisalignmentErrorTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "other" => MisalignmentErrorTypeEnum.Other,
                "potentially_unintended_data_access" => MisalignmentErrorTypeEnum.PotentiallyUnintendedDataAccess,
                "potentially_unintended_data_transfer" => MisalignmentErrorTypeEnum.PotentiallyUnintendedDataTransfer,
                "potentially_unintended_destructive_activity" => MisalignmentErrorTypeEnum.PotentiallyUnintendedDestructiveActivity,
                _ => null,
            };
        }
    }
}