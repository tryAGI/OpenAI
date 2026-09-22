
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicProjectResidency
    {
        /// <summary>
        ///
        /// </summary>
        AeStorage,
        /// <summary>
        ///
        /// </summary>
        AeStorageProcessing,
        /// <summary>
        ///
        /// </summary>
        AuStorage,
        /// <summary>
        ///
        /// </summary>
        CaStorage,
        /// <summary>
        ///
        /// </summary>
        EuStorageProcessing,
        /// <summary>
        ///
        /// </summary>
        GbStorage,
        /// <summary>
        ///
        /// </summary>
        Global,
        /// <summary>
        ///
        /// </summary>
        InStorage,
        /// <summary>
        ///
        /// </summary>
        JpStorage,
        /// <summary>
        ///
        /// </summary>
        KrStorage,
        /// <summary>
        ///
        /// </summary>
        SgStorage,
        /// <summary>
        ///
        /// </summary>
        UsStorageProcessing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicProjectResidencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicProjectResidency value)
        {
            return value switch
            {
                PublicProjectResidency.AeStorage => "AE_STORAGE",
                PublicProjectResidency.AeStorageProcessing => "AE_STORAGE_PROCESSING",
                PublicProjectResidency.AuStorage => "AU_STORAGE",
                PublicProjectResidency.CaStorage => "CA_STORAGE",
                PublicProjectResidency.EuStorageProcessing => "EU_STORAGE_PROCESSING",
                PublicProjectResidency.GbStorage => "GB_STORAGE",
                PublicProjectResidency.Global => "GLOBAL",
                PublicProjectResidency.InStorage => "IN_STORAGE",
                PublicProjectResidency.JpStorage => "JP_STORAGE",
                PublicProjectResidency.KrStorage => "KR_STORAGE",
                PublicProjectResidency.SgStorage => "SG_STORAGE",
                PublicProjectResidency.UsStorageProcessing => "US_STORAGE_PROCESSING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicProjectResidency? ToEnum(string value)
        {
            return value switch
            {
                "AE_STORAGE" => PublicProjectResidency.AeStorage,
                "AE_STORAGE_PROCESSING" => PublicProjectResidency.AeStorageProcessing,
                "AU_STORAGE" => PublicProjectResidency.AuStorage,
                "CA_STORAGE" => PublicProjectResidency.CaStorage,
                "EU_STORAGE_PROCESSING" => PublicProjectResidency.EuStorageProcessing,
                "GB_STORAGE" => PublicProjectResidency.GbStorage,
                "GLOBAL" => PublicProjectResidency.Global,
                "IN_STORAGE" => PublicProjectResidency.InStorage,
                "JP_STORAGE" => PublicProjectResidency.JpStorage,
                "KR_STORAGE" => PublicProjectResidency.KrStorage,
                "SG_STORAGE" => PublicProjectResidency.SgStorage,
                "US_STORAGE_PROCESSING" => PublicProjectResidency.UsStorageProcessing,
                _ => null,
            };
        }
    }
}