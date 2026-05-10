
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerScreenshot,
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
    public static class MessageContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentItemDiscriminatorType value)
        {
            return value switch
            {
                MessageContentItemDiscriminatorType.ComputerScreenshot => "computer_screenshot",
                MessageContentItemDiscriminatorType.InputFile => "input_file",
                MessageContentItemDiscriminatorType.InputImage => "input_image",
                MessageContentItemDiscriminatorType.InputText => "input_text",
                MessageContentItemDiscriminatorType.OutputText => "output_text",
                MessageContentItemDiscriminatorType.ReasoningText => "reasoning_text",
                MessageContentItemDiscriminatorType.Refusal => "refusal",
                MessageContentItemDiscriminatorType.SummaryText => "summary_text",
                MessageContentItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "computer_screenshot" => MessageContentItemDiscriminatorType.ComputerScreenshot,
                "input_file" => MessageContentItemDiscriminatorType.InputFile,
                "input_image" => MessageContentItemDiscriminatorType.InputImage,
                "input_text" => MessageContentItemDiscriminatorType.InputText,
                "output_text" => MessageContentItemDiscriminatorType.OutputText,
                "reasoning_text" => MessageContentItemDiscriminatorType.ReasoningText,
                "refusal" => MessageContentItemDiscriminatorType.Refusal,
                "summary_text" => MessageContentItemDiscriminatorType.SummaryText,
                "text" => MessageContentItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}