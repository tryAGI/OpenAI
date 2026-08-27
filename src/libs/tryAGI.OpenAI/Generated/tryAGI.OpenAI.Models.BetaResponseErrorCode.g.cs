
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The error code for the response.
    /// </summary>
    public enum BetaResponseErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        BioPolicy,
        /// <summary>
        ///
        /// </summary>
        DataResidencyMismatch,
        /// <summary>
        ///
        /// </summary>
        EmptyImageFile,
        /// <summary>
        ///
        /// </summary>
        FailedToDownloadImage,
        /// <summary>
        ///
        /// </summary>
        ImageContentPolicyViolation,
        /// <summary>
        ///
        /// </summary>
        ImageFileNotFound,
        /// <summary>
        ///
        /// </summary>
        ImageFileTooLarge,
        /// <summary>
        ///
        /// </summary>
        ImageParseError,
        /// <summary>
        ///
        /// </summary>
        ImageTooLarge,
        /// <summary>
        ///
        /// </summary>
        ImageTooSmall,
        /// <summary>
        ///
        /// </summary>
        InvalidBase64Image,
        /// <summary>
        ///
        /// </summary>
        InvalidImage,
        /// <summary>
        ///
        /// </summary>
        InvalidImageFormat,
        /// <summary>
        ///
        /// </summary>
        InvalidImageMode,
        /// <summary>
        ///
        /// </summary>
        InvalidImageUrl,
        /// <summary>
        ///
        /// </summary>
        InvalidPrompt,
        /// <summary>
        ///
        /// </summary>
        RateLimitExceeded,
        /// <summary>
        ///
        /// </summary>
        ServerError,
        /// <summary>
        ///
        /// </summary>
        UnsupportedImageMediaType,
        /// <summary>
        ///
        /// </summary>
        VectorStoreTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseErrorCode value)
        {
            return value switch
            {
                BetaResponseErrorCode.BioPolicy => "bio_policy",
                BetaResponseErrorCode.DataResidencyMismatch => "data_residency_mismatch",
                BetaResponseErrorCode.EmptyImageFile => "empty_image_file",
                BetaResponseErrorCode.FailedToDownloadImage => "failed_to_download_image",
                BetaResponseErrorCode.ImageContentPolicyViolation => "image_content_policy_violation",
                BetaResponseErrorCode.ImageFileNotFound => "image_file_not_found",
                BetaResponseErrorCode.ImageFileTooLarge => "image_file_too_large",
                BetaResponseErrorCode.ImageParseError => "image_parse_error",
                BetaResponseErrorCode.ImageTooLarge => "image_too_large",
                BetaResponseErrorCode.ImageTooSmall => "image_too_small",
                BetaResponseErrorCode.InvalidBase64Image => "invalid_base64_image",
                BetaResponseErrorCode.InvalidImage => "invalid_image",
                BetaResponseErrorCode.InvalidImageFormat => "invalid_image_format",
                BetaResponseErrorCode.InvalidImageMode => "invalid_image_mode",
                BetaResponseErrorCode.InvalidImageUrl => "invalid_image_url",
                BetaResponseErrorCode.InvalidPrompt => "invalid_prompt",
                BetaResponseErrorCode.RateLimitExceeded => "rate_limit_exceeded",
                BetaResponseErrorCode.ServerError => "server_error",
                BetaResponseErrorCode.UnsupportedImageMediaType => "unsupported_image_media_type",
                BetaResponseErrorCode.VectorStoreTimeout => "vector_store_timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "bio_policy" => BetaResponseErrorCode.BioPolicy,
                "data_residency_mismatch" => BetaResponseErrorCode.DataResidencyMismatch,
                "empty_image_file" => BetaResponseErrorCode.EmptyImageFile,
                "failed_to_download_image" => BetaResponseErrorCode.FailedToDownloadImage,
                "image_content_policy_violation" => BetaResponseErrorCode.ImageContentPolicyViolation,
                "image_file_not_found" => BetaResponseErrorCode.ImageFileNotFound,
                "image_file_too_large" => BetaResponseErrorCode.ImageFileTooLarge,
                "image_parse_error" => BetaResponseErrorCode.ImageParseError,
                "image_too_large" => BetaResponseErrorCode.ImageTooLarge,
                "image_too_small" => BetaResponseErrorCode.ImageTooSmall,
                "invalid_base64_image" => BetaResponseErrorCode.InvalidBase64Image,
                "invalid_image" => BetaResponseErrorCode.InvalidImage,
                "invalid_image_format" => BetaResponseErrorCode.InvalidImageFormat,
                "invalid_image_mode" => BetaResponseErrorCode.InvalidImageMode,
                "invalid_image_url" => BetaResponseErrorCode.InvalidImageUrl,
                "invalid_prompt" => BetaResponseErrorCode.InvalidPrompt,
                "rate_limit_exceeded" => BetaResponseErrorCode.RateLimitExceeded,
                "server_error" => BetaResponseErrorCode.ServerError,
                "unsupported_image_media_type" => BetaResponseErrorCode.UnsupportedImageMediaType,
                "vector_store_timeout" => BetaResponseErrorCode.VectorStoreTimeout,
                _ => null,
            };
        }
    }
}