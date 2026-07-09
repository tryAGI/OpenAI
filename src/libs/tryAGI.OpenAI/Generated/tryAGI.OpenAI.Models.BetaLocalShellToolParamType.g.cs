
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the local shell tool. Always `local_shell`.<br/>
    /// Default Value: local_shell
    /// </summary>
    public enum BetaLocalShellToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        LocalShell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLocalShellToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLocalShellToolParamType value)
        {
            return value switch
            {
                BetaLocalShellToolParamType.LocalShell => "local_shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLocalShellToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "local_shell" => BetaLocalShellToolParamType.LocalShell,
                _ => null,
            };
        }
    }
}