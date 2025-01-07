#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultItem : global::System.IEquatable<ResultItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject? Object { get; }

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
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageCompletionsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageCompletionsResult?(ResultItem @this) => @this.OrganizationUsageCompletionsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageCompletionsResult? value)
        {
            OrganizationUsageCompletionsResult = value;
        }

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
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageEmbeddingsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageEmbeddingsResult?(ResultItem @this) => @this.OrganizationUsageEmbeddingsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageEmbeddingsResult? value)
        {
            OrganizationUsageEmbeddingsResult = value;
        }

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
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageModerationsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageModerationsResult?(ResultItem @this) => @this.OrganizationUsageModerationsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageModerationsResult? value)
        {
            OrganizationUsageModerationsResult = value;
        }

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
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageImagesResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageImagesResult?(ResultItem @this) => @this.OrganizationUsageImagesResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageImagesResult? value)
        {
            OrganizationUsageImagesResult = value;
        }

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
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageAudioSpeechesResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageAudioSpeechesResult?(ResultItem @this) => @this.OrganizationUsageAudioSpeechesResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageAudioSpeechesResult? value)
        {
            OrganizationUsageAudioSpeechesResult = value;
        }

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
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?(ResultItem @this) => @this.OrganizationUsageAudioTranscriptionsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? value)
        {
            OrganizationUsageAudioTranscriptionsResult = value;
        }

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
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageVectorStoresResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageVectorStoresResult?(ResultItem @this) => @this.OrganizationUsageVectorStoresResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageVectorStoresResult? value)
        {
            OrganizationUsageVectorStoresResult = value;
        }

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
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?(ResultItem @this) => @this.OrganizationUsageCodeInterpreterSessionsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? value)
        {
            OrganizationUsageCodeInterpreterSessionsResult = value;
        }

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
        public static implicit operator ResultItem(global::tryAGI.OpenAI.CostsResult value) => new ResultItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CostsResult?(ResultItem @this) => @this.OrganizationCostsResult;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.CostsResult? value)
        {
            OrganizationCostsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(
            global::tryAGI.OpenAI.UsageTimeBucketResultItemDiscriminatorObject? @object,
            global::tryAGI.OpenAI.UsageCompletionsResult? organizationUsageCompletionsResult,
            global::tryAGI.OpenAI.UsageEmbeddingsResult? organizationUsageEmbeddingsResult,
            global::tryAGI.OpenAI.UsageModerationsResult? organizationUsageModerationsResult,
            global::tryAGI.OpenAI.UsageImagesResult? organizationUsageImagesResult,
            global::tryAGI.OpenAI.UsageAudioSpeechesResult? organizationUsageAudioSpeechesResult,
            global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? organizationUsageAudioTranscriptionsResult,
            global::tryAGI.OpenAI.UsageVectorStoresResult? organizationUsageVectorStoresResult,
            global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? organizationUsageCodeInterpreterSessionsResult,
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
            OrganizationCostsResult = organizationCostsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object1 =>
            OrganizationCostsResult as object ??
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
        public bool Validate()
        {
            return IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && IsOrganizationUsageCodeInterpreterSessionsResult && !IsOrganizationCostsResult || !IsOrganizationUsageCompletionsResult && !IsOrganizationUsageEmbeddingsResult && !IsOrganizationUsageModerationsResult && !IsOrganizationUsageImagesResult && !IsOrganizationUsageAudioSpeechesResult && !IsOrganizationUsageAudioTranscriptionsResult && !IsOrganizationUsageVectorStoresResult && !IsOrganizationUsageCodeInterpreterSessionsResult && IsOrganizationCostsResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.UsageCompletionsResult?, TResult>? organizationUsageCompletionsResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageEmbeddingsResult?, TResult>? organizationUsageEmbeddingsResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageModerationsResult?, TResult>? organizationUsageModerationsResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageImagesResult?, TResult>? organizationUsageImagesResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageAudioSpeechesResult?, TResult>? organizationUsageAudioSpeechesResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?, TResult>? organizationUsageAudioTranscriptionsResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageVectorStoresResult?, TResult>? organizationUsageVectorStoresResult = null,
            global::System.Func<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?, TResult>? organizationUsageCodeInterpreterSessionsResult = null,
            global::System.Func<global::tryAGI.OpenAI.CostsResult?, TResult>? organizationCostsResult = null,
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
            global::System.Action<global::tryAGI.OpenAI.UsageCompletionsResult?>? organizationUsageCompletionsResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageEmbeddingsResult?>? organizationUsageEmbeddingsResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageModerationsResult?>? organizationUsageModerationsResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageImagesResult?>? organizationUsageImagesResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageAudioSpeechesResult?>? organizationUsageAudioSpeechesResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?>? organizationUsageAudioTranscriptionsResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageVectorStoresResult?>? organizationUsageVectorStoresResult = null,
            global::System.Action<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?>? organizationUsageCodeInterpreterSessionsResult = null,
            global::System.Action<global::tryAGI.OpenAI.CostsResult?>? organizationCostsResult = null,
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
        public bool Equals(ResultItem other)
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CostsResult?>.Default.Equals(OrganizationCostsResult, other.OrganizationCostsResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultItem obj1, ResultItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultItem obj1, ResultItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultItem o && Equals(o);
        }
    }
}
