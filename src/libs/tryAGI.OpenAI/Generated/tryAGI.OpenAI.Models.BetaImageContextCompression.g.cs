
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaImageContextCompression
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageContextCompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageContextCompression value)
        {
            return value switch
            {
                BetaImageContextCompression.Auto => "auto",
                BetaImageContextCompression.Disabled => "disabled",
                BetaImageContextCompression.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageContextCompression? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaImageContextCompression.Auto,
                "disabled" => BetaImageContextCompression.Disabled,
                "enabled" => BetaImageContextCompression.Enabled,
                _ => null,
            };
        }
    }
}