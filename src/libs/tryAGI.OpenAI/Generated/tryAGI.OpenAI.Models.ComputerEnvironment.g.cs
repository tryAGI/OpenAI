
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
        Browser,
        /// <summary>
        /// 
        /// </summary>
        Linux,
        /// <summary>
        /// 
        /// </summary>
        Mac,
        /// <summary>
        /// 
        /// </summary>
        Ubuntu,
        /// <summary>
        /// 
        /// </summary>
        Windows,
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
                ComputerEnvironment.Browser => "browser",
                ComputerEnvironment.Linux => "linux",
                ComputerEnvironment.Mac => "mac",
                ComputerEnvironment.Ubuntu => "ubuntu",
                ComputerEnvironment.Windows => "windows",
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
                "browser" => ComputerEnvironment.Browser,
                "linux" => ComputerEnvironment.Linux,
                "mac" => ComputerEnvironment.Mac,
                "ubuntu" => ComputerEnvironment.Ubuntu,
                "windows" => ComputerEnvironment.Windows,
                _ => null,
            };
        }
    }
}