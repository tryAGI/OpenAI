
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The intended purpose of the uploaded file. One of: - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
    /// </summary>
    public enum FilePurpose
    {
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        Assistants,
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        Batch,
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        FineTune,
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        Vision,
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        UserData,
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        Evals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilePurpose value)
        {
            return value switch
            {
                FilePurpose.Assistants => "assistants",
                FilePurpose.Batch => "batch",
                FilePurpose.FineTune => "fine-tune",
                FilePurpose.Vision => "vision",
                FilePurpose.UserData => "user_data",
                FilePurpose.Evals => "evals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilePurpose? ToEnum(string value)
        {
            return value switch
            {
                "assistants" => FilePurpose.Assistants,
                "batch" => FilePurpose.Batch,
                "fine-tune" => FilePurpose.FineTune,
                "vision" => FilePurpose.Vision,
                "user_data" => FilePurpose.UserData,
                "evals" => FilePurpose.Evals,
                _ => null,
            };
        }
    }
}