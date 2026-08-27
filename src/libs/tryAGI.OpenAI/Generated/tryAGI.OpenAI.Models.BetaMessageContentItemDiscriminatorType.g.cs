
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaMessageContentItemDiscriminatorType
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
    public static class BetaMessageContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageContentItemDiscriminatorType value)
        {
            return value switch
            {
                BetaMessageContentItemDiscriminatorType.ComputerScreenshot => "computer_screenshot",
                BetaMessageContentItemDiscriminatorType.EncryptedContent => "encrypted_content",
                BetaMessageContentItemDiscriminatorType.InputFile => "input_file",
                BetaMessageContentItemDiscriminatorType.InputImage => "input_image",
                BetaMessageContentItemDiscriminatorType.InputText => "input_text",
                BetaMessageContentItemDiscriminatorType.OutputText => "output_text",
                BetaMessageContentItemDiscriminatorType.ReasoningText => "reasoning_text",
                BetaMessageContentItemDiscriminatorType.Refusal => "refusal",
                BetaMessageContentItemDiscriminatorType.SummaryText => "summary_text",
                BetaMessageContentItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "computer_screenshot" => BetaMessageContentItemDiscriminatorType.ComputerScreenshot,
                "encrypted_content" => BetaMessageContentItemDiscriminatorType.EncryptedContent,
                "input_file" => BetaMessageContentItemDiscriminatorType.InputFile,
                "input_image" => BetaMessageContentItemDiscriminatorType.InputImage,
                "input_text" => BetaMessageContentItemDiscriminatorType.InputText,
                "output_text" => BetaMessageContentItemDiscriminatorType.OutputText,
                "reasoning_text" => BetaMessageContentItemDiscriminatorType.ReasoningText,
                "refusal" => BetaMessageContentItemDiscriminatorType.Refusal,
                "summary_text" => BetaMessageContentItemDiscriminatorType.SummaryText,
                "text" => BetaMessageContentItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}