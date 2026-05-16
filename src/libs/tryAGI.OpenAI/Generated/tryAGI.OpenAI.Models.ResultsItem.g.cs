#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultsItem : global::System.IEquatable<ResultsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject? Object { get; }

        /// <summary>
        /// The aggregated completions usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageCompletionsResult? OrganizationUsageCompletionsResult { get; init; }
#else
        public global::tryAGI.OpenAI.UsageCompletionsResult? OrganizationUsageCompletionsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageCompletionsResult))]
#endif
        public bool IsOrganizationUsageCompletionsResult => OrganizationUsageCompletionsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationUsageCompletionsResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UsageCompletionsResult? value)
        {
            value = OrganizationUsageCompletionsResult;
            return IsOrganizationUsageCompletionsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageCompletionsResult PickOrganizationUsageCompletionsResult() => IsOrganizationUsageCompletionsResult
            ? OrganizationUsageCompletionsResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationUsageCompletionsResult' but the value was {ToString()}.");

        /// <summary>
        /// The aggregated embeddings usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageEmbeddingsResult? OrganizationUsageEmbeddingsResult { get; init; }
#else
        public global::tryAGI.OpenAI.UsageEmbeddingsResult? OrganizationUsageEmbeddingsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageEmbeddingsResult))]
#endif
        public bool IsOrganizationUsageEmbeddingsResult => OrganizationUsageEmbeddingsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationUsageEmbeddingsResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UsageEmbeddingsResult? value)
        {
            value = OrganizationUsageEmbeddingsResult;
            return IsOrganizationUsageEmbeddingsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageEmbeddingsResult PickOrganizationUsageEmbeddingsResult() => IsOrganizationUsageEmbeddingsResult
            ? OrganizationUsageEmbeddingsResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationUsageEmbeddingsResult' but the value was {ToString()}.");

        /// <summary>
        /// The aggregated moderations usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageModerationsResult? OrganizationUsageModerationsResult { get; init; }
#else
        public global::tryAGI.OpenAI.UsageModerationsResult? OrganizationUsageModerationsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageModerationsResult))]
#endif
        public bool IsOrganizationUsageModerationsResult => OrganizationUsageModerationsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationUsageModerationsResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UsageModerationsResult? value)
        {
            value = OrganizationUsageModerationsResult;
            return IsOrganizationUsageModerationsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageModerationsResult PickOrganizationUsageModerationsResult() => IsOrganizationUsageModerationsResult
            ? OrganizationUsageModerationsResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationUsageModerationsResult' but the value was {ToString()}.");

        /// <summary>
        /// The aggregated images usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageImagesResult? OrganizationUsageImagesResult { get; init; }
#else
        public global::tryAGI.OpenAI.UsageImagesResult? OrganizationUsageImagesResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageImagesResult))]
#endif
        public bool IsOrganizationUsageImagesResult => OrganizationUsageImagesResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationUsageImagesResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UsageImagesResult? value)
        {
            value = OrganizationUsageImagesResult;
            return IsOrganizationUsageImagesResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageImagesResult PickOrganizationUsageImagesResult() => IsOrganizationUsageImagesResult
            ? OrganizationUsageImagesResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationUsageImagesResult' but the value was {ToString()}.");

        /// <summary>
        /// The aggregated audio speeches usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageAudioSpeechesResult? OrganizationUsageAudioSpeechesResult { get; init; }
#else
        public global::tryAGI.OpenAI.UsageAudioSpeechesResult? OrganizationUsageAudioSpeechesResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageAudioSpeechesResult))]
#endif
        public bool IsOrganizationUsageAudioSpeechesResult => OrganizationUsageAudioSpeechesResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationUsageAudioSpeechesResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UsageAudioSpeechesResult? value)
        {
            value = OrganizationUsageAudioSpeechesResult;
            return IsOrganizationUsageAudioSpeechesResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioSpeechesResult PickOrganizationUsageAudioSpeechesResult() => IsOrganizationUsageAudioSpeechesResult
            ? OrganizationUsageAudioSpeechesResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationUsageAudioSpeechesResult' but the value was {ToString()}.");

        /// <summary>
        /// The aggregated audio transcriptions usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? OrganizationUsageAudioTranscriptionsResult { get; init; }
#else
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? OrganizationUsageAudioTranscriptionsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageAudioTranscriptionsResult))]
#endif
        public bool IsOrganizationUsageAudioTranscriptionsResult => OrganizationUsageAudioTranscriptionsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationUsageAudioTranscriptionsResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? value)
        {
            value = OrganizationUsageAudioTranscriptionsResult;
            return IsOrganizationUsageAudioTranscriptionsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResult PickOrganizationUsageAudioTranscriptionsResult() => IsOrganizationUsageAudioTranscriptionsResult
            ? OrganizationUsageAudioTranscriptionsResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationUsageAudioTranscriptionsResult' but the value was {ToString()}.");

        /// <summary>
        /// The aggregated vector stores usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageVectorStoresResult? OrganizationUsageVectorStoresResult { get; init; }
#else
        public global::tryAGI.OpenAI.UsageVectorStoresResult? OrganizationUsageVectorStoresResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageVectorStoresResult))]
#endif
        public bool IsOrganizationUsageVectorStoresResult => OrganizationUsageVectorStoresResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationUsageVectorStoresResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UsageVectorStoresResult? value)
        {
            value = OrganizationUsageVectorStoresResult;
            return IsOrganizationUsageVectorStoresResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageVectorStoresResult PickOrganizationUsageVectorStoresResult() => IsOrganizationUsageVectorStoresResult
            ? OrganizationUsageVectorStoresResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationUsageVectorStoresResult' but the value was {ToString()}.");

        /// <summary>
        /// The aggregated code interpreter sessions usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? OrganizationUsageCodeInterpreterSessionsResult { get; init; }
#else
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? OrganizationUsageCodeInterpreterSessionsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageCodeInterpreterSessionsResult))]
#endif
        public bool IsOrganizationUsageCodeInterpreterSessionsResult => OrganizationUsageCodeInterpreterSessionsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationUsageCodeInterpreterSessionsResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? value)
        {
            value = OrganizationUsageCodeInterpreterSessionsResult;
            return IsOrganizationUsageCodeInterpreterSessionsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult PickOrganizationUsageCodeInterpreterSessionsResult() => IsOrganizationUsageCodeInterpreterSessionsResult
            ? OrganizationUsageCodeInterpreterSessionsResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationUsageCodeInterpreterSessionsResult' but the value was {ToString()}.");

        /// <summary>
        /// The aggregated file search calls usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageFileSearchCallsResult? OrganizationUsageFileSearchesResult { get; init; }
#else
        public global::tryAGI.OpenAI.UsageFileSearchCallsResult? OrganizationUsageFileSearchesResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageFileSearchesResult))]
#endif
        public bool IsOrganizationUsageFileSearchesResult => OrganizationUsageFileSearchesResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationUsageFileSearchesResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UsageFileSearchCallsResult? value)
        {
            value = OrganizationUsageFileSearchesResult;
            return IsOrganizationUsageFileSearchesResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageFileSearchCallsResult PickOrganizationUsageFileSearchesResult() => IsOrganizationUsageFileSearchesResult
            ? OrganizationUsageFileSearchesResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationUsageFileSearchesResult' but the value was {ToString()}.");

        /// <summary>
        /// The aggregated web search calls usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageWebSearchCallsResult? OrganizationUsageWebSearchesResult { get; init; }
#else
        public global::tryAGI.OpenAI.UsageWebSearchCallsResult? OrganizationUsageWebSearchesResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationUsageWebSearchesResult))]
#endif
        public bool IsOrganizationUsageWebSearchesResult => OrganizationUsageWebSearchesResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationUsageWebSearchesResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.UsageWebSearchCallsResult? value)
        {
            value = OrganizationUsageWebSearchesResult;
            return IsOrganizationUsageWebSearchesResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageWebSearchCallsResult PickOrganizationUsageWebSearchesResult() => IsOrganizationUsageWebSearchesResult
            ? OrganizationUsageWebSearchesResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationUsageWebSearchesResult' but the value was {ToString()}.");

        /// <summary>
        /// The aggregated costs details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CostsResult? OrganizationCostsResult { get; init; }
#else
        public global::tryAGI.OpenAI.CostsResult? OrganizationCostsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationCostsResult))]
#endif
        public bool IsOrganizationCostsResult => OrganizationCostsResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrganizationCostsResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.CostsResult? value)
        {
            value = OrganizationCostsResult;
            return IsOrganizationCostsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.CostsResult PickOrganizationCostsResult() => IsOrganizationCostsResult
            ? OrganizationCostsResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrganizationCostsResult' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.UsageCompletionsResult value) => new ResultsItem((global::tryAGI.OpenAI.UsageCompletionsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageCompletionsResult?(ResultsItem @this) => @this.OrganizationUsageCompletionsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.UsageCompletionsResult? value)
        {
            OrganizationUsageCompletionsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationUsageCompletionsResult(global::tryAGI.OpenAI.UsageCompletionsResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.UsageEmbeddingsResult value) => new ResultsItem((global::tryAGI.OpenAI.UsageEmbeddingsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageEmbeddingsResult?(ResultsItem @this) => @this.OrganizationUsageEmbeddingsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.UsageEmbeddingsResult? value)
        {
            OrganizationUsageEmbeddingsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationUsageEmbeddingsResult(global::tryAGI.OpenAI.UsageEmbeddingsResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.UsageModerationsResult value) => new ResultsItem((global::tryAGI.OpenAI.UsageModerationsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageModerationsResult?(ResultsItem @this) => @this.OrganizationUsageModerationsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.UsageModerationsResult? value)
        {
            OrganizationUsageModerationsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationUsageModerationsResult(global::tryAGI.OpenAI.UsageModerationsResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.UsageImagesResult value) => new ResultsItem((global::tryAGI.OpenAI.UsageImagesResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageImagesResult?(ResultsItem @this) => @this.OrganizationUsageImagesResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.UsageImagesResult? value)
        {
            OrganizationUsageImagesResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationUsageImagesResult(global::tryAGI.OpenAI.UsageImagesResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.UsageAudioSpeechesResult value) => new ResultsItem((global::tryAGI.OpenAI.UsageAudioSpeechesResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageAudioSpeechesResult?(ResultsItem @this) => @this.OrganizationUsageAudioSpeechesResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.UsageAudioSpeechesResult? value)
        {
            OrganizationUsageAudioSpeechesResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationUsageAudioSpeechesResult(global::tryAGI.OpenAI.UsageAudioSpeechesResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult value) => new ResultsItem((global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?(ResultsItem @this) => @this.OrganizationUsageAudioTranscriptionsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? value)
        {
            OrganizationUsageAudioTranscriptionsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationUsageAudioTranscriptionsResult(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.UsageVectorStoresResult value) => new ResultsItem((global::tryAGI.OpenAI.UsageVectorStoresResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageVectorStoresResult?(ResultsItem @this) => @this.OrganizationUsageVectorStoresResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.UsageVectorStoresResult? value)
        {
            OrganizationUsageVectorStoresResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationUsageVectorStoresResult(global::tryAGI.OpenAI.UsageVectorStoresResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult value) => new ResultsItem((global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?(ResultsItem @this) => @this.OrganizationUsageCodeInterpreterSessionsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? value)
        {
            OrganizationUsageCodeInterpreterSessionsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationUsageCodeInterpreterSessionsResult(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.UsageFileSearchCallsResult value) => new ResultsItem((global::tryAGI.OpenAI.UsageFileSearchCallsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageFileSearchCallsResult?(ResultsItem @this) => @this.OrganizationUsageFileSearchesResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.UsageFileSearchCallsResult? value)
        {
            OrganizationUsageFileSearchesResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationUsageFileSearchesResult(global::tryAGI.OpenAI.UsageFileSearchCallsResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.UsageWebSearchCallsResult value) => new ResultsItem((global::tryAGI.OpenAI.UsageWebSearchCallsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageWebSearchCallsResult?(ResultsItem @this) => @this.OrganizationUsageWebSearchesResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.UsageWebSearchCallsResult? value)
        {
            OrganizationUsageWebSearchesResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationUsageWebSearchesResult(global::tryAGI.OpenAI.UsageWebSearchCallsResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultsItem(global::tryAGI.OpenAI.CostsResult value) => new ResultsItem((global::tryAGI.OpenAI.CostsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CostsResult?(ResultsItem @this) => @this.OrganizationCostsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(global::tryAGI.OpenAI.CostsResult? value)
        {
            OrganizationCostsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultsItem FromOrganizationCostsResult(global::tryAGI.OpenAI.CostsResult? value) => new ResultsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public ResultsItem(
            global::tryAGI.OpenAI.UsageTimeBucketResultDiscriminatorObject? @object,
            global::tryAGI.OpenAI.UsageCompletionsResult? organizationUsageCompletionsResult,
            global::tryAGI.OpenAI.UsageEmbeddingsResult? organizationUsageEmbeddingsResult,
            global::tryAGI.OpenAI.UsageModerationsResult? organizationUsageModerationsResult,
            global::tryAGI.OpenAI.UsageImagesResult? organizationUsageImagesResult,
            global::tryAGI.OpenAI.UsageAudioSpeechesResult? organizationUsageAudioSpeechesResult,
            global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? organizationUsageAudioTranscriptionsResult,
            global::tryAGI.OpenAI.UsageVectorStoresResult? organizationUsageVectorStoresResult,
            global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? organizationUsageCodeInterpreterSessionsResult,
            global::tryAGI.OpenAI.UsageFileSearchCallsResult? organizationUsageFileSearchesResult,
            global::tryAGI.OpenAI.UsageWebSearchCallsResult? organizationUsageWebSearchesResult,
            global::tryAGI.OpenAI.CostsResult? organizationCostsResult
            )
        {
            Object = @object;

            OrganizationUsageCompletionsResult = organizationUsageCompletionsResult;
            OrganizationUsageEmbeddingsResult = organizationUsageEmbeddingsResult;
            OrganizationUsageModerationsResult = organizationUsageModerationsResult;
            OrganizationUsageImagesResult = organizationUsageImagesResult;
            OrganizationUsageAudioSpeechesResult = organizationUsageAudioSpeechesResult;
            OrganizationUsageAudioTranscriptionsResult = organizationUsageAudioTranscriptionsResult;
            OrganizationUsageVectorStoresResult = organizationUsageVectorStoresResult;
            OrganizationUsageCodeInterpreterSessionsResult = organizationUsageCodeInterpreterSessionsResult;
            OrganizationUsageFileSearchesResult = organizationUsageFileSearchesResult;
            OrganizationUsageWebSearchesResult = organizationUsageWebSearchesResult;
            OrganizationCostsResult = organizationCostsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object1 =>
            OrganizationCostsResult as object ??
            OrganizationUsageWebSearchesResult as object ??
            OrganizationUsageFileSearchesResult as object ??
            OrganizationUsageCodeInterpreterSessionsResult as object ??
            OrganizationUsageVectorStoresResult as object ??
            OrganizationUsageAudioTranscriptionsResult as object ??
            OrganizationUsageAudioSpeechesResult as object ??
            OrganizationUsageImagesResult as object ??
            OrganizationUsageModerationsResult as object ??
            OrganizationUsageEmbeddingsResult as object ??
            OrganizationUsageCompletionsResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OrganizationUsageCompletionsResult?.ToString() ??
            OrganizationUsageEmbeddingsResult?.ToString() ??
            OrganizationUsageModerationsResult?.ToString() ??
            OrganizationUsageImagesResult?.ToString() ??
            OrganizationUsageAudioSpeechesResult?.ToString() ??
            OrganizationUsageAudioTranscriptionsResult?.ToString() ??
            OrganizationUsageVectorStoresResult?.ToString() ??
            OrganizationUsageCodeInterpreterSessionsResult?.ToString() ??
            OrganizationUsageFileSearchesResult?.ToString() ??
            OrganizationUsageWebSearchesResult?.ToString() ??
            OrganizationCostsResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationUsageFileSearchesResult && !IsOrganizationUsageWebSearchesResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationUsageFileSearchesResult && !IsOrganizationUsageWebSearchesResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationUsageFileSearchesResult && !IsOrganizationUsageWebSearchesResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationUsageFileSearchesResult && !IsOrganizationUsageWebSearchesResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationUsageFileSearchesResult && !IsOrganizationUsageWebSearchesResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationUsageFileSearchesResult && !IsOrganizationUsageWebSearchesResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationUsageFileSearchesResult && !IsOrganizationUsageWebSearchesResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationUsageFileSearchesResult && !IsOrganizationUsageWebSearchesResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && IsOrganizationUsageFileSearchesResult && !IsOrganizationUsageWebSearchesResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationUsageFileSearchesResult && IsOrganizationUsageWebSearchesResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationUsageFileSearchesResult && !IsOrganizationUsageWebSearchesResult && IsOrganizationCostsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.UsageCompletionsResult, TResult>? organizationUsageCompletionsResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageEmbeddingsResult, TResult>? organizationUsageEmbeddingsResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageModerationsResult, TResult>? organizationUsageModerationsResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageImagesResult, TResult>? organizationUsageImagesResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageAudioSpeechesResult, TResult>? organizationUsageAudioSpeechesResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult, TResult>? organizationUsageAudioTranscriptionsResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageVectorStoresResult, TResult>? organizationUsageVectorStoresResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult, TResult>? organizationUsageCodeInterpreterSessionsResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageFileSearchCallsResult, TResult>? organizationUsageFileSearchesResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageWebSearchCallsResult, TResult>? organizationUsageWebSearchesResult = null,
            global::System.Func<global::tryAGI.OpenAI.CostsResult, TResult>? organizationCostsResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganizationUsageCompletionsResult && organizationUsageCompletionsResult != null)
            {
                return organizationUsageCompletionsResult(OrganizationUsageCompletionsResult!);
            }
            else if (IsOrganizationUsageEmbeddingsResult && organizationUsageEmbeddingsResult != null)
            {
                return organizationUsageEmbeddingsResult(OrganizationUsageEmbeddingsResult!);
            }
            else if (IsOrganizationUsageModerationsResult && organizationUsageModerationsResult != null)
            {
                return organizationUsageModerationsResult(OrganizationUsageModerationsResult!);
            }
            else if (IsOrganizationUsageImagesResult && organizationUsageImagesResult != null)
            {
                return organizationUsageImagesResult(OrganizationUsageImagesResult!);
            }
            else if (IsOrganizationUsageAudioSpeechesResult && organizationUsageAudioSpeechesResult != null)
            {
                return organizationUsageAudioSpeechesResult(OrganizationUsageAudioSpeechesResult!);
            }
            else if (IsOrganizationUsageAudioTranscriptionsResult && organizationUsageAudioTranscriptionsResult != null)
            {
                return organizationUsageAudioTranscriptionsResult(OrganizationUsageAudioTranscriptionsResult!);
            }
            else if (IsOrganizationUsageVectorStoresResult && organizationUsageVectorStoresResult != null)
            {
                return organizationUsageVectorStoresResult(OrganizationUsageVectorStoresResult!);
            }
            else if (IsOrganizationUsageCodeInterpreterSessionsResult && organizationUsageCodeInterpreterSessionsResult != null)
            {
                return organizationUsageCodeInterpreterSessionsResult(OrganizationUsageCodeInterpreterSessionsResult!);
            }
            else if (IsOrganizationUsageFileSearchesResult && organizationUsageFileSearchesResult != null)
            {
                return organizationUsageFileSearchesResult(OrganizationUsageFileSearchesResult!);
            }
            else if (IsOrganizationUsageWebSearchesResult && organizationUsageWebSearchesResult != null)
            {
                return organizationUsageWebSearchesResult(OrganizationUsageWebSearchesResult!);
            }
            else if (IsOrganizationCostsResult && organizationCostsResult != null)
            {
                return organizationCostsResult(OrganizationCostsResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.UsageCompletionsResult>? organizationUsageCompletionsResult = null,

            global::System.Action<global::tryAGI.OpenAI.UsageEmbeddingsResult>? organizationUsageEmbeddingsResult = null,

            global::System.Action<global::tryAGI.OpenAI.UsageModerationsResult>? organizationUsageModerationsResult = null,

            global::System.Action<global::tryAGI.OpenAI.UsageImagesResult>? organizationUsageImagesResult = null,

            global::System.Action<global::tryAGI.OpenAI.UsageAudioSpeechesResult>? organizationUsageAudioSpeechesResult = null,

            global::System.Action<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult>? organizationUsageAudioTranscriptionsResult = null,

            global::System.Action<global::tryAGI.OpenAI.UsageVectorStoresResult>? organizationUsageVectorStoresResult = null,

            global::System.Action<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult>? organizationUsageCodeInterpreterSessionsResult = null,

            global::System.Action<global::tryAGI.OpenAI.UsageFileSearchCallsResult>? organizationUsageFileSearchesResult = null,

            global::System.Action<global::tryAGI.OpenAI.UsageWebSearchCallsResult>? organizationUsageWebSearchesResult = null,

            global::System.Action<global::tryAGI.OpenAI.CostsResult>? organizationCostsResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganizationUsageCompletionsResult)
            {
                organizationUsageCompletionsResult?.Invoke(OrganizationUsageCompletionsResult!);
            }
            else if (IsOrganizationUsageEmbeddingsResult)
            {
                organizationUsageEmbeddingsResult?.Invoke(OrganizationUsageEmbeddingsResult!);
            }
            else if (IsOrganizationUsageModerationsResult)
            {
                organizationUsageModerationsResult?.Invoke(OrganizationUsageModerationsResult!);
            }
            else if (IsOrganizationUsageImagesResult)
            {
                organizationUsageImagesResult?.Invoke(OrganizationUsageImagesResult!);
            }
            else if (IsOrganizationUsageAudioSpeechesResult)
            {
                organizationUsageAudioSpeechesResult?.Invoke(OrganizationUsageAudioSpeechesResult!);
            }
            else if (IsOrganizationUsageAudioTranscriptionsResult)
            {
                organizationUsageAudioTranscriptionsResult?.Invoke(OrganizationUsageAudioTranscriptionsResult!);
            }
            else if (IsOrganizationUsageVectorStoresResult)
            {
                organizationUsageVectorStoresResult?.Invoke(OrganizationUsageVectorStoresResult!);
            }
            else if (IsOrganizationUsageCodeInterpreterSessionsResult)
            {
                organizationUsageCodeInterpreterSessionsResult?.Invoke(OrganizationUsageCodeInterpreterSessionsResult!);
            }
            else if (IsOrganizationUsageFileSearchesResult)
            {
                organizationUsageFileSearchesResult?.Invoke(OrganizationUsageFileSearchesResult!);
            }
            else if (IsOrganizationUsageWebSearchesResult)
            {
                organizationUsageWebSearchesResult?.Invoke(OrganizationUsageWebSearchesResult!);
            }
            else if (IsOrganizationCostsResult)
            {
                organizationCostsResult?.Invoke(OrganizationCostsResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.UsageCompletionsResult>? organizationUsageCompletionsResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageEmbeddingsResult>? organizationUsageEmbeddingsResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageModerationsResult>? organizationUsageModerationsResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageImagesResult>? organizationUsageImagesResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageAudioSpeechesResult>? organizationUsageAudioSpeechesResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult>? organizationUsageAudioTranscriptionsResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageVectorStoresResult>? organizationUsageVectorStoresResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult>? organizationUsageCodeInterpreterSessionsResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageFileSearchCallsResult>? organizationUsageFileSearchesResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageWebSearchCallsResult>? organizationUsageWebSearchesResult = null,
            global::System.Action<global::tryAGI.OpenAI.CostsResult>? organizationCostsResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganizationUsageCompletionsResult)
            {
                organizationUsageCompletionsResult?.Invoke(OrganizationUsageCompletionsResult!);
            }
            else if (IsOrganizationUsageEmbeddingsResult)
            {
                organizationUsageEmbeddingsResult?.Invoke(OrganizationUsageEmbeddingsResult!);
            }
            else if (IsOrganizationUsageModerationsResult)
            {
                organizationUsageModerationsResult?.Invoke(OrganizationUsageModerationsResult!);
            }
            else if (IsOrganizationUsageImagesResult)
            {
                organizationUsageImagesResult?.Invoke(OrganizationUsageImagesResult!);
            }
            else if (IsOrganizationUsageAudioSpeechesResult)
            {
                organizationUsageAudioSpeechesResult?.Invoke(OrganizationUsageAudioSpeechesResult!);
            }
            else if (IsOrganizationUsageAudioTranscriptionsResult)
            {
                organizationUsageAudioTranscriptionsResult?.Invoke(OrganizationUsageAudioTranscriptionsResult!);
            }
            else if (IsOrganizationUsageVectorStoresResult)
            {
                organizationUsageVectorStoresResult?.Invoke(OrganizationUsageVectorStoresResult!);
            }
            else if (IsOrganizationUsageCodeInterpreterSessionsResult)
            {
                organizationUsageCodeInterpreterSessionsResult?.Invoke(OrganizationUsageCodeInterpreterSessionsResult!);
            }
            else if (IsOrganizationUsageFileSearchesResult)
            {
                organizationUsageFileSearchesResult?.Invoke(OrganizationUsageFileSearchesResult!);
            }
            else if (IsOrganizationUsageWebSearchesResult)
            {
                organizationUsageWebSearchesResult?.Invoke(OrganizationUsageWebSearchesResult!);
            }
            else if (IsOrganizationCostsResult)
            {
                organizationCostsResult?.Invoke(OrganizationCostsResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OrganizationUsageCompletionsResult,
                typeof(global::tryAGI.OpenAI.UsageCompletionsResult),
                OrganizationUsageEmbeddingsResult,
                typeof(global::tryAGI.OpenAI.UsageEmbeddingsResult),
                OrganizationUsageModerationsResult,
                typeof(global::tryAGI.OpenAI.UsageModerationsResult),
                OrganizationUsageImagesResult,
                typeof(global::tryAGI.OpenAI.UsageImagesResult),
                OrganizationUsageAudioSpeechesResult,
                typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResult),
                OrganizationUsageAudioTranscriptionsResult,
                typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult),
                OrganizationUsageVectorStoresResult,
                typeof(global::tryAGI.OpenAI.UsageVectorStoresResult),
                OrganizationUsageCodeInterpreterSessionsResult,
                typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult),
                OrganizationUsageFileSearchesResult,
                typeof(global::tryAGI.OpenAI.UsageFileSearchCallsResult),
                OrganizationUsageWebSearchesResult,
                typeof(global::tryAGI.OpenAI.UsageWebSearchCallsResult),
                OrganizationCostsResult,
                typeof(global::tryAGI.OpenAI.CostsResult),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResultsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageCompletionsResult?>.Default.Equals(OrganizationUsageCompletionsResult, other.OrganizationUsageCompletionsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageEmbeddingsResult?>.Default.Equals(OrganizationUsageEmbeddingsResult, other.OrganizationUsageEmbeddingsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageModerationsResult?>.Default.Equals(OrganizationUsageModerationsResult, other.OrganizationUsageModerationsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageImagesResult?>.Default.Equals(OrganizationUsageImagesResult, other.OrganizationUsageImagesResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageAudioSpeechesResult?>.Default.Equals(OrganizationUsageAudioSpeechesResult, other.OrganizationUsageAudioSpeechesResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?>.Default.Equals(OrganizationUsageAudioTranscriptionsResult, other.OrganizationUsageAudioTranscriptionsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageVectorStoresResult?>.Default.Equals(OrganizationUsageVectorStoresResult, other.OrganizationUsageVectorStoresResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?>.Default.Equals(OrganizationUsageCodeInterpreterSessionsResult, other.OrganizationUsageCodeInterpreterSessionsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageFileSearchCallsResult?>.Default.Equals(OrganizationUsageFileSearchesResult, other.OrganizationUsageFileSearchesResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageWebSearchCallsResult?>.Default.Equals(OrganizationUsageWebSearchesResult, other.OrganizationUsageWebSearchesResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CostsResult?>.Default.Equals(OrganizationCostsResult, other.OrganizationCostsResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultsItem obj1, ResultsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultsItem obj1, ResultsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultsItem o && Equals(o);
        }
    }
}
