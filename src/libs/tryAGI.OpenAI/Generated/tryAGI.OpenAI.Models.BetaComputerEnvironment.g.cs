
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaComputerEnvironment
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
    public static class BetaComputerEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerEnvironment value)
        {
            return value switch
            {
                BetaComputerEnvironment.Browser => "browser",
                BetaComputerEnvironment.Linux => "linux",
                BetaComputerEnvironment.Mac => "mac",
                BetaComputerEnvironment.Ubuntu => "ubuntu",
                BetaComputerEnvironment.Windows => "windows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "browser" => BetaComputerEnvironment.Browser,
                "linux" => BetaComputerEnvironment.Linux,
                "mac" => BetaComputerEnvironment.Mac,
                "ubuntu" => BetaComputerEnvironment.Ubuntu,
                "windows" => BetaComputerEnvironment.Windows,
                _ => null,
            };
        }
    }
}