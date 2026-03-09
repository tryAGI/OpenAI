
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the local shell tool. Always `local_shell`.<br/>
    /// Default Value: local_shell
    /// </summary>
    public enum LocalShellToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        LocalShell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalShellToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellToolParamType value)
        {
            return value switch
            {
                LocalShellToolParamType.LocalShell => "local_shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "local_shell" => LocalShellToolParamType.LocalShell,
                _ => null,
            };
        }
    }
}