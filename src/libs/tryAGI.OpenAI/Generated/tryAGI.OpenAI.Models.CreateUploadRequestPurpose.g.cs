
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The intended purpose of the uploaded file.<br/>
    /// See the [documentation on File<br/>
    /// purposes](https://developers.openai.com/api/reference/resources/files/methods/create#%28resource%29%20files%20%3E%20%28method%29%20create%20%3E%20%28params%29%200%20%3E%20%28param%29%20purpose%20%3E%20%28schema%29).
    /// </summary>
    public enum CreateUploadRequestPurpose
    {
        /// <summary>
        ///
        /// </summary>
        Assistants,
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        FineTune,
        /// <summary>
        ///
        /// </summary>
        Vision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateUploadRequestPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUploadRequestPurpose value)
        {
            return value switch
            {
                CreateUploadRequestPurpose.Assistants => "assistants",
                CreateUploadRequestPurpose.Batch => "batch",
                CreateUploadRequestPurpose.FineTune => "fine-tune",
                CreateUploadRequestPurpose.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUploadRequestPurpose? ToEnum(string value)
        {
            return value switch
            {
                "assistants" => CreateUploadRequestPurpose.Assistants,
                "batch" => CreateUploadRequestPurpose.Batch,
                "fine-tune" => CreateUploadRequestPurpose.FineTune,
                "vision" => CreateUploadRequestPurpose.Vision,
                _ => null,
            };
        }
    }
}