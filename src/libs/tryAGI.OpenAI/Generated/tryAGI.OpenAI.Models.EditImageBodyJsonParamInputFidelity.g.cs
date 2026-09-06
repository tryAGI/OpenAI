
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum EditImageBodyJsonParamInputFidelity
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageBodyJsonParamInputFidelityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamInputFidelity value)
        {
            return value switch
            {
                EditImageBodyJsonParamInputFidelity.High => "high",
                EditImageBodyJsonParamInputFidelity.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamInputFidelity? ToEnum(string value)
        {
            return value switch
            {
                "high" => EditImageBodyJsonParamInputFidelity.High,
                "low" => EditImageBodyJsonParamInputFidelity.Low,
                _ => null,
            };
        }
    }
}