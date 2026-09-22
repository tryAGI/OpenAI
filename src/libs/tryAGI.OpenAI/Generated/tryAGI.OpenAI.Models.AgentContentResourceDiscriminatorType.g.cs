
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentContentResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        EncryptedContent,
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentContentResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentContentResourceDiscriminatorType value)
        {
            return value switch
            {
                AgentContentResourceDiscriminatorType.EncryptedContent => "encrypted_content",
                AgentContentResourceDiscriminatorType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentContentResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted_content" => AgentContentResourceDiscriminatorType.EncryptedContent,
                "output_text" => AgentContentResourceDiscriminatorType.OutputText,
                _ => null,
            };
        }
    }
}