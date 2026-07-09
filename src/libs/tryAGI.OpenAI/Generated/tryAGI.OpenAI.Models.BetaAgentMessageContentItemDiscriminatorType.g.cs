
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAgentMessageContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerScreenshot,
        /// <summary>
        /// 
        /// </summary>
        EncryptedContent,
        /// <summary>
        /// 
        /// </summary>
        InputFile,
        /// <summary>
        /// 
        /// </summary>
        InputImage,
        /// <summary>
        /// 
        /// </summary>
        InputText,
        /// <summary>
        /// 
        /// </summary>
        OutputText,
        /// <summary>
        /// 
        /// </summary>
        ReasoningText,
        /// <summary>
        /// 
        /// </summary>
        Refusal,
        /// <summary>
        /// 
        /// </summary>
        SummaryText,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAgentMessageContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAgentMessageContentItemDiscriminatorType value)
        {
            return value switch
            {
                BetaAgentMessageContentItemDiscriminatorType.ComputerScreenshot => "computer_screenshot",
                BetaAgentMessageContentItemDiscriminatorType.EncryptedContent => "encrypted_content",
                BetaAgentMessageContentItemDiscriminatorType.InputFile => "input_file",
                BetaAgentMessageContentItemDiscriminatorType.InputImage => "input_image",
                BetaAgentMessageContentItemDiscriminatorType.InputText => "input_text",
                BetaAgentMessageContentItemDiscriminatorType.OutputText => "output_text",
                BetaAgentMessageContentItemDiscriminatorType.ReasoningText => "reasoning_text",
                BetaAgentMessageContentItemDiscriminatorType.Refusal => "refusal",
                BetaAgentMessageContentItemDiscriminatorType.SummaryText => "summary_text",
                BetaAgentMessageContentItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAgentMessageContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "computer_screenshot" => BetaAgentMessageContentItemDiscriminatorType.ComputerScreenshot,
                "encrypted_content" => BetaAgentMessageContentItemDiscriminatorType.EncryptedContent,
                "input_file" => BetaAgentMessageContentItemDiscriminatorType.InputFile,
                "input_image" => BetaAgentMessageContentItemDiscriminatorType.InputImage,
                "input_text" => BetaAgentMessageContentItemDiscriminatorType.InputText,
                "output_text" => BetaAgentMessageContentItemDiscriminatorType.OutputText,
                "reasoning_text" => BetaAgentMessageContentItemDiscriminatorType.ReasoningText,
                "refusal" => BetaAgentMessageContentItemDiscriminatorType.Refusal,
                "summary_text" => BetaAgentMessageContentItemDiscriminatorType.SummaryText,
                "text" => BetaAgentMessageContentItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}