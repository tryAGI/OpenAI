
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneSupervisedHyperparametersBatchSize
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneSupervisedHyperparametersBatchSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneSupervisedHyperparametersBatchSize value)
        {
            return value switch
            {
                FineTuneSupervisedHyperparametersBatchSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneSupervisedHyperparametersBatchSize? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneSupervisedHyperparametersBatchSize.Auto,
                _ => null,
            };
        }
    }
}