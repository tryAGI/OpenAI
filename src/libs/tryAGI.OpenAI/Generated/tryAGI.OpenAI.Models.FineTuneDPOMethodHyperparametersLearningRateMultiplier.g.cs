
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneDPOMethodHyperparametersLearningRateMultiplier
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneDPOMethodHyperparametersLearningRateMultiplierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneDPOMethodHyperparametersLearningRateMultiplier value)
        {
            return value switch
            {
                FineTuneDPOMethodHyperparametersLearningRateMultiplier.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneDPOMethodHyperparametersLearningRateMultiplier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneDPOMethodHyperparametersLearningRateMultiplier.Auto,
                _ => null,
            };
        }
    }
}