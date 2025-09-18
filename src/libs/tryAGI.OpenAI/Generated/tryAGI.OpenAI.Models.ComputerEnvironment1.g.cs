
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComputerEnvironment1
    {
        /// <summary>
        /// 
        /// </summary>
        Windows,
        /// <summary>
        /// 
        /// </summary>
        Mac,
        /// <summary>
        /// 
        /// </summary>
        Linux,
        /// <summary>
        /// 
        /// </summary>
        Ubuntu,
        /// <summary>
        /// 
        /// </summary>
        Browser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerEnvironment1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerEnvironment1 value)
        {
            return value switch
            {
                ComputerEnvironment1.Windows => "windows",
                ComputerEnvironment1.Mac => "mac",
                ComputerEnvironment1.Linux => "linux",
                ComputerEnvironment1.Ubuntu => "ubuntu",
                ComputerEnvironment1.Browser => "browser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerEnvironment1? ToEnum(string value)
        {
            return value switch
            {
                "windows" => ComputerEnvironment1.Windows,
                "mac" => ComputerEnvironment1.Mac,
                "linux" => ComputerEnvironment1.Linux,
                "ubuntu" => ComputerEnvironment1.Ubuntu,
                "browser" => ComputerEnvironment1.Browser,
                _ => null,
            };
        }
    }
}