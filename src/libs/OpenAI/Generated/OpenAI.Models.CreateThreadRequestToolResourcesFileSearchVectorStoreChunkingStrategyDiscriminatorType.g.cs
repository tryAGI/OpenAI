
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType value)
        {
            return value switch
            {
                CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto => "auto",
                CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto,
                "static" => CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}