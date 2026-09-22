
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `response.item.create`.<br/>
    /// Default Value: response.item.create
    /// </summary>
    public enum LiveResponseItemCreateParamType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseItemCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveResponseItemCreateParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponseItemCreateParamType value)
        {
            return value switch
            {
                LiveResponseItemCreateParamType.ResponseItemCreate => "response.item.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponseItemCreateParamType? ToEnum(string value)
        {
            return value switch
            {
                "response.item.create" => LiveResponseItemCreateParamType.ResponseItemCreate,
                _ => null,
            };
        }
    }
}