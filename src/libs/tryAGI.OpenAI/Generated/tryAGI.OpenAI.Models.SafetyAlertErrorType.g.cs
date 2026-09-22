
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SafetyAlertErrorType
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
    public static class SafetyAlertErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetyAlertErrorType value)
        {
            return value switch
            {
                SafetyAlertErrorType.Other => "other",
                SafetyAlertErrorType.PotentiallyUnintendedDataAccess => "potentially_unintended_data_access",
                SafetyAlertErrorType.PotentiallyUnintendedDataTransfer => "potentially_unintended_data_transfer",
                SafetyAlertErrorType.PotentiallyUnintendedDestructiveActivity => "potentially_unintended_destructive_activity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetyAlertErrorType? ToEnum(string value)
        {
            return value switch
            {
                "other" => SafetyAlertErrorType.Other,
                "potentially_unintended_data_access" => SafetyAlertErrorType.PotentiallyUnintendedDataAccess,
                "potentially_unintended_data_transfer" => SafetyAlertErrorType.PotentiallyUnintendedDataTransfer,
                "potentially_unintended_destructive_activity" => SafetyAlertErrorType.PotentiallyUnintendedDestructiveActivity,
                _ => null,
            };
        }
    }
}