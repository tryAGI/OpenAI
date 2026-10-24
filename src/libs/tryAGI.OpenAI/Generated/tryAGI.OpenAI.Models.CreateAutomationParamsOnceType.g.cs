
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `once`.<br/>
    /// Default Value: once
    /// </summary>
    public enum CreateAutomationParamsOnceType
    {
        /// <summary>
        ///
        /// </summary>
        Once,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAutomationParamsOnceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAutomationParamsOnceType value)
        {
            return value switch
            {
                CreateAutomationParamsOnceType.Once => "once",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAutomationParamsOnceType? ToEnum(string value)
        {
            return value switch
            {
                "once" => CreateAutomationParamsOnceType.Once,
                _ => null,
            };
        }
    }
}