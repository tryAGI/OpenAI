
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the local shell action. Always `exec`.
    /// </summary>
    public enum LocalShellExecActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Exec,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalShellExecActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellExecActionType value)
        {
            return value switch
            {
                LocalShellExecActionType.Exec => "exec",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellExecActionType? ToEnum(string value)
        {
            return value switch
            {
                "exec" => LocalShellExecActionType.Exec,
                _ => null,
            };
        }
    }
}