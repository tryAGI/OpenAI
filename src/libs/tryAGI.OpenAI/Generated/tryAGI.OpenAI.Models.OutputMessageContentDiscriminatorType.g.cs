
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputMessageContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessageContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessageContentDiscriminatorType value)
        {
            return value switch
            {
                OutputMessageContentDiscriminatorType.OutputText => "output_text",
                OutputMessageContentDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessageContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => OutputMessageContentDiscriminatorType.OutputText,
                "refusal" => OutputMessageContentDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}