
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Legacy style parameter for retired image models. Unsupported for GPT image models; describe the desired style in the prompt instead.<br/>
    /// Default Value: vivid<br/>
    /// Example: vivid
    /// </summary>
    public enum CreateImageRequestStyle
    {
        /// <summary>
        ///
        /// </summary>
        Natural,
        /// <summary>
        ///
        /// </summary>
        Vivid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestStyle value)
        {
            return value switch
            {
                CreateImageRequestStyle.Natural => "natural",
                CreateImageRequestStyle.Vivid => "vivid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestStyle? ToEnum(string value)
        {
            return value switch
            {
                "natural" => CreateImageRequestStyle.Natural,
                "vivid" => CreateImageRequestStyle.Vivid,
                _ => null,
            };
        }
    }
}