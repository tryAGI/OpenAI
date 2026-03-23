
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The intended purpose of the uploaded file. One of:<br/>
    /// - `assistants`: Used in the Assistants API<br/>
    /// - `batch`: Used in the Batch API<br/>
    /// - `fine-tune`: Used for fine-tuning<br/>
    /// - `vision`: Images used for vision fine-tuning<br/>
    /// - `user_data`: Flexible file type for any purpose<br/>
    /// - `evals`: Used for eval data sets
    /// </summary>
    public enum CreateFileRequestPurpose
    {
        /// <summary>
        /// Used in the Assistants API
        /// </summary>
        Assistants,
        /// <summary>
        /// Used in the Batch API
        /// </summary>
        Batch,
        /// <summary>
        /// Used for eval data sets
        /// </summary>
        Evals,
        /// <summary>
        /// Used for fine-tuning
        /// </summary>
        FineTune,
        /// <summary>
        /// Flexible file type for any purpose
        /// </summary>
        UserData,
        /// <summary>
        /// Images used for vision fine-tuning
        /// </summary>
        Vision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFileRequestPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFileRequestPurpose value)
        {
            return value switch
            {
                CreateFileRequestPurpose.Assistants => "assistants",
                CreateFileRequestPurpose.Batch => "batch",
                CreateFileRequestPurpose.Evals => "evals",
                CreateFileRequestPurpose.FineTune => "fine-tune",
                CreateFileRequestPurpose.UserData => "user_data",
                CreateFileRequestPurpose.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFileRequestPurpose? ToEnum(string value)
        {
            return value switch
            {
                "assistants" => CreateFileRequestPurpose.Assistants,
                "batch" => CreateFileRequestPurpose.Batch,
                "evals" => CreateFileRequestPurpose.Evals,
                "fine-tune" => CreateFileRequestPurpose.FineTune,
                "user_data" => CreateFileRequestPurpose.UserData,
                "vision" => CreateFileRequestPurpose.Vision,
                _ => null,
            };
        }
    }
}