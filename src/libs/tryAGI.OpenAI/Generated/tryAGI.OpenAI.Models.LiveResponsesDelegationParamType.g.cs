
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The delegation owner. Always `responses` for tasks handled by the Responses API.<br/>
    /// Default Value: responses
    /// </summary>
    public enum LiveResponsesDelegationParamType
    {
        /// <summary>
        ///
        /// </summary>
        Responses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveResponsesDelegationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponsesDelegationParamType value)
        {
            return value switch
            {
                LiveResponsesDelegationParamType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponsesDelegationParamType? ToEnum(string value)
        {
            return value switch
            {
                "responses" => LiveResponsesDelegationParamType.Responses,
                _ => null,
            };
        }
    }
}