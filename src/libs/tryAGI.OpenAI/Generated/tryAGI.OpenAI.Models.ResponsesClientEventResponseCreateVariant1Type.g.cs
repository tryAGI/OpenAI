
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the client event. Always `response.create`.
    /// </summary>
    public enum ResponsesClientEventResponseCreateVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesClientEventResponseCreateVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesClientEventResponseCreateVariant1Type value)
        {
            return value switch
            {
                ResponsesClientEventResponseCreateVariant1Type.ResponseCreate => "response.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesClientEventResponseCreateVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "response.create" => ResponsesClientEventResponseCreateVariant1Type.ResponseCreate,
                _ => null,
            };
        }
    }
}