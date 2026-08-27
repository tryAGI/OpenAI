
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.<br/>
    /// `none` means the model will not call any tool and instead generates a message.<br/>
    /// `auto` means the model can pick between generating a message or calling one or<br/>
    /// more tools.<br/>
    /// `required` means the model must call one or more tools.
    /// </summary>
    public enum BetaToolChoiceOptions
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolChoiceOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolChoiceOptions value)
        {
            return value switch
            {
                BetaToolChoiceOptions.Auto => "auto",
                BetaToolChoiceOptions.None => "none",
                BetaToolChoiceOptions.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolChoiceOptions? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaToolChoiceOptions.Auto,
                "none" => BetaToolChoiceOptions.None,
                "required" => BetaToolChoiceOptions.Required,
                _ => null,
            };
        }
    }
}