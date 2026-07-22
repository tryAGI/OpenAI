
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains the verbosity of the model's response. Lower values will result in<br/>
    /// more concise responses, while higher values will result in more verbose responses.<br/>
    /// Currently supported values are `low`, `medium`, and `high`. The default is<br/>
    /// `medium`.<br/>
    /// Default Value: medium
    /// </summary>
    public enum BetaVerbosityEnum
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaVerbosityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaVerbosityEnum value)
        {
            return value switch
            {
                BetaVerbosityEnum.High => "high",
                BetaVerbosityEnum.Low => "low",
                BetaVerbosityEnum.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaVerbosityEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaVerbosityEnum.High,
                "low" => BetaVerbosityEnum.Low,
                "medium" => BetaVerbosityEnum.Medium,
                _ => null,
            };
        }
    }
}