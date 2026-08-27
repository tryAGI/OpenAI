
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the local shell action. Always `exec`.<br/>
    /// Default Value: exec
    /// </summary>
    public enum BetaLocalShellExecActionType
    {
        /// <summary>
        ///
        /// </summary>
        Exec,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLocalShellExecActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLocalShellExecActionType value)
        {
            return value switch
            {
                BetaLocalShellExecActionType.Exec => "exec",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLocalShellExecActionType? ToEnum(string value)
        {
            return value switch
            {
                "exec" => BetaLocalShellExecActionType.Exec,
                _ => null,
            };
        }
    }
}