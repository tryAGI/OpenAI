
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageTimeBucketResultDiscriminatorObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationCostsResult,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageAudioSpeechesResult,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageAudioTranscriptionsResult,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageCodeInterpreterSessionsResult,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageCompletionsResult,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageEmbeddingsResult,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageFileSearchesResult,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageImagesResult,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageModerationsResult,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageVectorStoresResult,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageWebSearchesResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageTimeBucketResultDiscriminatorObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageTimeBucketResultDiscriminatorObject value)
        {
            return value switch
            {
                UsageTimeBucketResultDiscriminatorObject.OrganizationCostsResult => "organization.costs.result",
                UsageTimeBucketResultDiscriminatorObject.OrganizationUsageAudioSpeechesResult => "organization.usage.audio_speeches.result",
                UsageTimeBucketResultDiscriminatorObject.OrganizationUsageAudioTranscriptionsResult => "organization.usage.audio_transcriptions.result",
                UsageTimeBucketResultDiscriminatorObject.OrganizationUsageCodeInterpreterSessionsResult => "organization.usage.code_interpreter_sessions.result",
                UsageTimeBucketResultDiscriminatorObject.OrganizationUsageCompletionsResult => "organization.usage.completions.result",
                UsageTimeBucketResultDiscriminatorObject.OrganizationUsageEmbeddingsResult => "organization.usage.embeddings.result",
                UsageTimeBucketResultDiscriminatorObject.OrganizationUsageFileSearchesResult => "organization.usage.file_searches.result",
                UsageTimeBucketResultDiscriminatorObject.OrganizationUsageImagesResult => "organization.usage.images.result",
                UsageTimeBucketResultDiscriminatorObject.OrganizationUsageModerationsResult => "organization.usage.moderations.result",
                UsageTimeBucketResultDiscriminatorObject.OrganizationUsageVectorStoresResult => "organization.usage.vector_stores.result",
                UsageTimeBucketResultDiscriminatorObject.OrganizationUsageWebSearchesResult => "organization.usage.web_searches.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageTimeBucketResultDiscriminatorObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.costs.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationCostsResult,
                "organization.usage.audio_speeches.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationUsageAudioSpeechesResult,
                "organization.usage.audio_transcriptions.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationUsageAudioTranscriptionsResult,
                "organization.usage.code_interpreter_sessions.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationUsageCodeInterpreterSessionsResult,
                "organization.usage.completions.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationUsageCompletionsResult,
                "organization.usage.embeddings.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationUsageEmbeddingsResult,
                "organization.usage.file_searches.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationUsageFileSearchesResult,
                "organization.usage.images.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationUsageImagesResult,
                "organization.usage.moderations.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationUsageModerationsResult,
                "organization.usage.vector_stores.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationUsageVectorStoresResult,
                "organization.usage.web_searches.result" => UsageTimeBucketResultDiscriminatorObject.OrganizationUsageWebSearchesResult,
                _ => null,
            };
        }
    }
}