
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuningJobHyperparametersBatchSizeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuningJobHyperparametersBatchSizeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningJobHyperparametersBatchSizeVariant1 value)
        {
            return value switch
            {
                FineTuningJobHyperparametersBatchSizeVariant1.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningJobHyperparametersBatchSizeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuningJobHyperparametersBatchSizeVariant1.Auto,
                _ => null,
            };
        }
    }
}