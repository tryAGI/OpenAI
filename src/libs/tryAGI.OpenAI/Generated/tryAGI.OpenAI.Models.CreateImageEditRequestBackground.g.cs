
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Set the background of the generated image(s). This parameter is only supported for<br/>
    /// the GPT image models. Must be one of `transparent`, `opaque`, or `auto` (default<br/>
    /// value). When `auto` is used, the model will automatically determine the best<br/>
    /// background for the image.<br/>
    /// `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their `2026-09-08`<br/>
    /// snapshots, support `opaque` and `transparent` backgrounds. Transparent backgrounds<br/>
    /// are available for supported GPT Image models. For `gpt-image-2` and<br/>
    /// `gpt-image-2-2026-04-21`, this support is in preview. When using `transparent`,<br/>
    /// set the output format to `png` or `webp`.<br/>
    /// Default Value: auto<br/>
    /// Example: transparent
    /// </summary>
    public enum CreateImageEditRequestBackground
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Opaque,
        /// <summary>
        ///
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestBackground value)
        {
            return value switch
            {
                CreateImageEditRequestBackground.Auto => "auto",
                CreateImageEditRequestBackground.Opaque => "opaque",
                CreateImageEditRequestBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageEditRequestBackground.Auto,
                "opaque" => CreateImageEditRequestBackground.Opaque,
                "transparent" => CreateImageEditRequestBackground.Transparent,
                _ => null,
            };
        }
    }
}