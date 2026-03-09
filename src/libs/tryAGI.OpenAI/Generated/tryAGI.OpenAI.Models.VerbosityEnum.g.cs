
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains the verbosity of the model's response. Lower values will result in<br/>
    /// more concise responses, while higher values will result in more verbose responses.<br/>
    /// Currently supported values are `low`, `medium`, and `high`.<br/>
    /// Default Value: medium
    /// </summary>
    public enum VerbosityEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VerbosityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VerbosityEnum value)
        {
            return value switch
            {
                VerbosityEnum.Low => "low",
                VerbosityEnum.Medium => "medium",
                VerbosityEnum.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VerbosityEnum? ToEnum(string value)
        {
            return value switch
            {
                "low" => VerbosityEnum.Low,
                "medium" => VerbosityEnum.Medium,
                "high" => VerbosityEnum.High,
                _ => null,
            };
        }
    }
}