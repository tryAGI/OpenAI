
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType.Image => "image",
                CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType.Image,
                "logs" => CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType.Logs,
                _ => null,
            };
        }
    }
}