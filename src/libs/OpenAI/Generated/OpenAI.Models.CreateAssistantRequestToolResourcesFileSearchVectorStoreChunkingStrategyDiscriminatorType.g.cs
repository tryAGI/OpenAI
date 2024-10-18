
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType
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
    public static class CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType value)
        {
            return value switch
            {
                CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto => "auto",
                CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto,
                "static" => CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}