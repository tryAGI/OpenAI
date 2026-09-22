
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `response.create`.<br/>
    /// Default Value: response.create
    /// </summary>
    public enum LiveResponseCreateParamType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveResponseCreateParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponseCreateParamType value)
        {
            return value switch
            {
                LiveResponseCreateParamType.ResponseCreate => "response.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponseCreateParamType? ToEnum(string value)
        {
            return value switch
            {
                "response.create" => LiveResponseCreateParamType.ResponseCreate,
                _ => null,
            };
        }
    }
}