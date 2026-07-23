
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpendLimitEnforcementStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Enforcing,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpendLimitEnforcementStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendLimitEnforcementStatusEnum value)
        {
            return value switch
            {
                SpendLimitEnforcementStatusEnum.Enforcing => "enforcing",
                SpendLimitEnforcementStatusEnum.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendLimitEnforcementStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "enforcing" => SpendLimitEnforcementStatusEnum.Enforcing,
                "inactive" => SpendLimitEnforcementStatusEnum.Inactive,
                _ => null,
            };
        }
    }
}