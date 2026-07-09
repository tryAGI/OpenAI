
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAgentMessageItemParamContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        EncryptedContent,
        /// <summary>
        /// 
        /// </summary>
        InputImage,
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAgentMessageItemParamContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAgentMessageItemParamContentItemDiscriminatorType value)
        {
            return value switch
            {
                BetaAgentMessageItemParamContentItemDiscriminatorType.EncryptedContent => "encrypted_content",
                BetaAgentMessageItemParamContentItemDiscriminatorType.InputImage => "input_image",
                BetaAgentMessageItemParamContentItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAgentMessageItemParamContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted_content" => BetaAgentMessageItemParamContentItemDiscriminatorType.EncryptedContent,
                "input_image" => BetaAgentMessageItemParamContentItemDiscriminatorType.InputImage,
                "input_text" => BetaAgentMessageItemParamContentItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}