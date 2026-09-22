
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CostsResultQuantityUnit
    {
        /// <summary>
        ///
        /// </summary>
        x1000Tokens,
        /// <summary>
        ///
        /// </summary>
        Characters,
        /// <summary>
        ///
        /// </summary>
        DurationHours,
        /// <summary>
        ///
        /// </summary>
        DurationMinutes,
        /// <summary>
        ///
        /// </summary>
        DurationSeconds,
        /// <summary>
        ///
        /// </summary>
        GibibyteHours,
        /// <summary>
        ///
        /// </summary>
        Images,
        /// <summary>
        ///
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CostsResultQuantityUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CostsResultQuantityUnit value)
        {
            return value switch
            {
                CostsResultQuantityUnit.x1000Tokens => "1000_tokens",
                CostsResultQuantityUnit.Characters => "characters",
                CostsResultQuantityUnit.DurationHours => "duration_hours",
                CostsResultQuantityUnit.DurationMinutes => "duration_minutes",
                CostsResultQuantityUnit.DurationSeconds => "duration_seconds",
                CostsResultQuantityUnit.GibibyteHours => "gibibyte_hours",
                CostsResultQuantityUnit.Images => "images",
                CostsResultQuantityUnit.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CostsResultQuantityUnit? ToEnum(string value)
        {
            return value switch
            {
                "1000_tokens" => CostsResultQuantityUnit.x1000Tokens,
                "characters" => CostsResultQuantityUnit.Characters,
                "duration_hours" => CostsResultQuantityUnit.DurationHours,
                "duration_minutes" => CostsResultQuantityUnit.DurationMinutes,
                "duration_seconds" => CostsResultQuantityUnit.DurationSeconds,
                "gibibyte_hours" => CostsResultQuantityUnit.GibibyteHours,
                "images" => CostsResultQuantityUnit.Images,
                "tokens" => CostsResultQuantityUnit.Tokens,
                _ => null,
            };
        }
    }
}