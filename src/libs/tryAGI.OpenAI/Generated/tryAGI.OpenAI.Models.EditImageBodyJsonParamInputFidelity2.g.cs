
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageBodyJsonParamInputFidelity2
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
    public static class EditImageBodyJsonParamInputFidelity2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageBodyJsonParamInputFidelity2 value)
        {
            return value switch
            {
                EditImageBodyJsonParamInputFidelity2.High => "high",
                EditImageBodyJsonParamInputFidelity2.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageBodyJsonParamInputFidelity2? ToEnum(string value)
        {
            return value switch
            {
                "high" => EditImageBodyJsonParamInputFidelity2.High,
                "low" => EditImageBodyJsonParamInputFidelity2.Low,
                _ => null,
            };
        }
    }
}