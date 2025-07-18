
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneDPOHyperparametersNEpochs
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneDPOHyperparametersNEpochsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneDPOHyperparametersNEpochs value)
        {
            return value switch
            {
                FineTuneDPOHyperparametersNEpochs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneDPOHyperparametersNEpochs? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneDPOHyperparametersNEpochs.Auto,
                _ => null,
            };
        }
    }
}