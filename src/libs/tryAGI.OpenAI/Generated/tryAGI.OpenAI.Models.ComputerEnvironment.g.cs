
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComputerEnvironment
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
    public static class ComputerEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerEnvironment value)
        {
            return value switch
            {
                ComputerEnvironment.Windows => "windows",
                ComputerEnvironment.Mac => "mac",
                ComputerEnvironment.Linux => "linux",
                ComputerEnvironment.Ubuntu => "ubuntu",
                ComputerEnvironment.Browser => "browser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "windows" => ComputerEnvironment.Windows,
                "mac" => ComputerEnvironment.Mac,
                "linux" => ComputerEnvironment.Linux,
                "ubuntu" => ComputerEnvironment.Ubuntu,
                "browser" => ComputerEnvironment.Browser,
                _ => null,
            };
        }
    }
}