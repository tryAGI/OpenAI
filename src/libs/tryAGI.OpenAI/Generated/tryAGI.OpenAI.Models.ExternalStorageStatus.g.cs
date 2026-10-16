
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ExternalStorageStatus
    {
        /// <summary>
        ///
        /// </summary>
        Degraded,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Unhealthy,
        /// <summary>
        ///
        /// </summary>
        Validated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalStorageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalStorageStatus value)
        {
            return value switch
            {
                ExternalStorageStatus.Degraded => "degraded",
                ExternalStorageStatus.Pending => "pending",
                ExternalStorageStatus.Unhealthy => "unhealthy",
                ExternalStorageStatus.Validated => "validated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalStorageStatus? ToEnum(string value)
        {
            return value switch
            {
                "degraded" => ExternalStorageStatus.Degraded,
                "pending" => ExternalStorageStatus.Pending,
                "unhealthy" => ExternalStorageStatus.Unhealthy,
                "validated" => ExternalStorageStatus.Validated,
                _ => null,
            };
        }
    }
}