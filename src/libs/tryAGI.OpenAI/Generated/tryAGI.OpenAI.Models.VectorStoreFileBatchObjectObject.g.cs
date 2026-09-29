
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `vector_store.file_batch`.
    /// </summary>
    public enum VectorStoreFileBatchObjectObject
    {
        /// <summary>
        ///
        /// </summary>
        VectorStoreFileBatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileBatchObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileBatchObjectObject value)
        {
            return value switch
            {
                VectorStoreFileBatchObjectObject.VectorStoreFileBatch => "vector_store.file_batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileBatchObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "vector_store.file_batch" => VectorStoreFileBatchObjectObject.VectorStoreFileBatch,
                _ => null,
            };
        }
    }
}