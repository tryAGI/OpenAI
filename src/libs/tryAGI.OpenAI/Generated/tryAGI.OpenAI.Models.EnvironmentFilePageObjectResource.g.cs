
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type for a page of files in an execution environment.<br/>
    /// Default Value: page
    /// </summary>
    public enum EnvironmentFilePageObjectResource
    {
        /// <summary>
        ///
        /// </summary>
        Page,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentFilePageObjectResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentFilePageObjectResource value)
        {
            return value switch
            {
                EnvironmentFilePageObjectResource.Page => "page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentFilePageObjectResource? ToEnum(string value)
        {
            return value switch
            {
                "page" => EnvironmentFilePageObjectResource.Page,
                _ => null,
            };
        }
    }
}