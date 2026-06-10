
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The role that provided the additional tools. Only `developer` is supported.<br/>
    /// Default Value: developer
    /// </summary>
    public enum AdditionalToolsItemParamRole
    {
        /// <summary>
        /// 
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdditionalToolsItemParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdditionalToolsItemParamRole value)
        {
            return value switch
            {
                AdditionalToolsItemParamRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdditionalToolsItemParamRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => AdditionalToolsItemParamRole.Developer,
                _ => null,
            };
        }
    }
}