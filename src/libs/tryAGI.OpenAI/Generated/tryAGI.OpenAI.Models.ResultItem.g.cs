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
        /// The aggregated completions usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageCompletionsResult? UsageCompletions { get; init; }
#else
        public global::tryAGI.OpenAI.UsageCompletionsResult? UsageCompletions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageCompletions))]
#endif
        public bool IsUsageCompletions => UsageCompletions != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageCompletionsResult value) => new ResultItem((global::tryAGI.OpenAI.UsageCompletionsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageCompletionsResult?(ResultItem @this) => @this.UsageCompletions;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageCompletionsResult? value)
        {
            UsageCompletions = value;
        }

        /// <summary>
        /// The aggregated embeddings usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageEmbeddingsResult? UsageEmbeddings { get; init; }
#else
        public global::tryAGI.OpenAI.UsageEmbeddingsResult? UsageEmbeddings { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageEmbeddings))]
#endif
        public bool IsUsageEmbeddings => UsageEmbeddings != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageEmbeddingsResult value) => new ResultItem((global::tryAGI.OpenAI.UsageEmbeddingsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageEmbeddingsResult?(ResultItem @this) => @this.UsageEmbeddings;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageEmbeddingsResult? value)
        {
            UsageEmbeddings = value;
        }

        /// <summary>
        /// The aggregated moderations usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageModerationsResult? UsageModerations { get; init; }
#else
        public global::tryAGI.OpenAI.UsageModerationsResult? UsageModerations { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageModerations))]
#endif
        public bool IsUsageModerations => UsageModerations != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageModerationsResult value) => new ResultItem((global::tryAGI.OpenAI.UsageModerationsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageModerationsResult?(ResultItem @this) => @this.UsageModerations;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageModerationsResult? value)
        {
            UsageModerations = value;
        }

        /// <summary>
        /// The aggregated images usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageImagesResult? UsageImages { get; init; }
#else
        public global::tryAGI.OpenAI.UsageImagesResult? UsageImages { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageImages))]
#endif
        public bool IsUsageImages => UsageImages != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageImagesResult value) => new ResultItem((global::tryAGI.OpenAI.UsageImagesResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageImagesResult?(ResultItem @this) => @this.UsageImages;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageImagesResult? value)
        {
            UsageImages = value;
        }

        /// <summary>
        /// The aggregated audio speeches usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageAudioSpeechesResult? UsageAudioSpeeches { get; init; }
#else
        public global::tryAGI.OpenAI.UsageAudioSpeechesResult? UsageAudioSpeeches { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageAudioSpeeches))]
#endif
        public bool IsUsageAudioSpeeches => UsageAudioSpeeches != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageAudioSpeechesResult value) => new ResultItem((global::tryAGI.OpenAI.UsageAudioSpeechesResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageAudioSpeechesResult?(ResultItem @this) => @this.UsageAudioSpeeches;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageAudioSpeechesResult? value)
        {
            UsageAudioSpeeches = value;
        }

        /// <summary>
        /// The aggregated audio transcriptions usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? UsageAudioTranscriptions { get; init; }
#else
        public global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? UsageAudioTranscriptions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageAudioTranscriptions))]
#endif
        public bool IsUsageAudioTranscriptions => UsageAudioTranscriptions != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult value) => new ResultItem((global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?(ResultItem @this) => @this.UsageAudioTranscriptions;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? value)
        {
            UsageAudioTranscriptions = value;
        }

        /// <summary>
        /// The aggregated vector stores usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageVectorStoresResult? UsageVectorStores { get; init; }
#else
        public global::tryAGI.OpenAI.UsageVectorStoresResult? UsageVectorStores { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageVectorStores))]
#endif
        public bool IsUsageVectorStores => UsageVectorStores != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageVectorStoresResult value) => new ResultItem((global::tryAGI.OpenAI.UsageVectorStoresResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageVectorStoresResult?(ResultItem @this) => @this.UsageVectorStores;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageVectorStoresResult? value)
        {
            UsageVectorStores = value;
        }

        /// <summary>
        /// The aggregated code interpreter sessions usage details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? UsageCodeInterpreterSessions { get; init; }
#else
        public global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? UsageCodeInterpreterSessions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsageCodeInterpreterSessions))]
#endif
        public bool IsUsageCodeInterpreterSessions => UsageCodeInterpreterSessions != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult value) => new ResultItem((global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?(ResultItem @this) => @this.UsageCodeInterpreterSessions;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? value)
        {
            UsageCodeInterpreterSessions = value;
        }

        /// <summary>
        /// The aggregated costs details of the specific time bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CostsResult? Costs { get; init; }
#else
        public global::tryAGI.OpenAI.CostsResult? Costs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Costs))]
#endif
        public bool IsCosts => Costs != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultItem(global::tryAGI.OpenAI.CostsResult value) => new ResultItem((global::tryAGI.OpenAI.CostsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CostsResult?(ResultItem @this) => @this.Costs;

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(global::tryAGI.OpenAI.CostsResult? value)
        {
            Costs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultItem(
            global::tryAGI.OpenAI.UsageCompletionsResult? usageCompletions,
            global::tryAGI.OpenAI.UsageEmbeddingsResult? usageEmbeddings,
            global::tryAGI.OpenAI.UsageModerationsResult? usageModerations,
            global::tryAGI.OpenAI.UsageImagesResult? usageImages,
            global::tryAGI.OpenAI.UsageAudioSpeechesResult? usageAudioSpeeches,
            global::tryAGI.OpenAI.UsageAudioTranscriptionsResult? usageAudioTranscriptions,
            global::tryAGI.OpenAI.UsageVectorStoresResult? usageVectorStores,
            global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult? usageCodeInterpreterSessions,
            global::tryAGI.OpenAI.CostsResult? costs
            )
        {
            UsageCompletions = usageCompletions;
            UsageEmbeddings = usageEmbeddings;
            UsageModerations = usageModerations;
            UsageImages = usageImages;
            UsageAudioSpeeches = usageAudioSpeeches;
            UsageAudioTranscriptions = usageAudioTranscriptions;
            UsageVectorStores = usageVectorStores;
            UsageCodeInterpreterSessions = usageCodeInterpreterSessions;
            Costs = costs;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Costs as object ??
            UsageCodeInterpreterSessions as object ??
            UsageVectorStores as object ??
            UsageAudioTranscriptions as object ??
            UsageAudioSpeeches as object ??
            UsageImages as object ??
            UsageModerations as object ??
            UsageEmbeddings as object ??
            UsageCompletions as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UsageCompletions?.ToString() ??
            UsageEmbeddings?.ToString() ??
            UsageModerations?.ToString() ??
            UsageImages?.ToString() ??
            UsageAudioSpeeches?.ToString() ??
            UsageAudioTranscriptions?.ToString() ??
            UsageVectorStores?.ToString() ??
            UsageCodeInterpreterSessions?.ToString() ??
            Costs?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUsageCompletions || IsUsageEmbeddings || IsUsageModerations || IsUsageImages || IsUsageAudioSpeeches || IsUsageAudioTranscriptions || IsUsageVectorStores || IsUsageCodeInterpreterSessions || IsCosts;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.UsageCompletionsResult?, TResult>? usageCompletions = null,
            global::System.Func<global::tryAGI.OpenAI.UsageEmbeddingsResult?, TResult>? usageEmbeddings = null,
            global::System.Func<global::tryAGI.OpenAI.UsageModerationsResult?, TResult>? usageModerations = null,
            global::System.Func<global::tryAGI.OpenAI.UsageImagesResult?, TResult>? usageImages = null,
            global::System.Func<global::tryAGI.OpenAI.UsageAudioSpeechesResult?, TResult>? usageAudioSpeeches = null,
            global::System.Func<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?, TResult>? usageAudioTranscriptions = null,
            global::System.Func<global::tryAGI.OpenAI.UsageVectorStoresResult?, TResult>? usageVectorStores = null,
            global::System.Func<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?, TResult>? usageCodeInterpreterSessions = null,
            global::System.Func<global::tryAGI.OpenAI.CostsResult?, TResult>? costs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsageCompletions && usageCompletions != null)
            {
                return usageCompletions(UsageCompletions!);
            }
            else if (IsUsageEmbeddings && usageEmbeddings != null)
            {
                return usageEmbeddings(UsageEmbeddings!);
            }
            else if (IsUsageModerations && usageModerations != null)
            {
                return usageModerations(UsageModerations!);
            }
            else if (IsUsageImages && usageImages != null)
            {
                return usageImages(UsageImages!);
            }
            else if (IsUsageAudioSpeeches && usageAudioSpeeches != null)
            {
                return usageAudioSpeeches(UsageAudioSpeeches!);
            }
            else if (IsUsageAudioTranscriptions && usageAudioTranscriptions != null)
            {
                return usageAudioTranscriptions(UsageAudioTranscriptions!);
            }
            else if (IsUsageVectorStores && usageVectorStores != null)
            {
                return usageVectorStores(UsageVectorStores!);
            }
            else if (IsUsageCodeInterpreterSessions && usageCodeInterpreterSessions != null)
            {
                return usageCodeInterpreterSessions(UsageCodeInterpreterSessions!);
            }
            else if (IsCosts && costs != null)
            {
                return costs(Costs!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.UsageCompletionsResult?>? usageCompletions = null,
            global::System.Action<global::tryAGI.OpenAI.UsageEmbeddingsResult?>? usageEmbeddings = null,
            global::System.Action<global::tryAGI.OpenAI.UsageModerationsResult?>? usageModerations = null,
            global::System.Action<global::tryAGI.OpenAI.UsageImagesResult?>? usageImages = null,
            global::System.Action<global::tryAGI.OpenAI.UsageAudioSpeechesResult?>? usageAudioSpeeches = null,
            global::System.Action<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?>? usageAudioTranscriptions = null,
            global::System.Action<global::tryAGI.OpenAI.UsageVectorStoresResult?>? usageVectorStores = null,
            global::System.Action<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?>? usageCodeInterpreterSessions = null,
            global::System.Action<global::tryAGI.OpenAI.CostsResult?>? costs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUsageCompletions)
            {
                usageCompletions?.Invoke(UsageCompletions!);
            }
            else if (IsUsageEmbeddings)
            {
                usageEmbeddings?.Invoke(UsageEmbeddings!);
            }
            else if (IsUsageModerations)
            {
                usageModerations?.Invoke(UsageModerations!);
            }
            else if (IsUsageImages)
            {
                usageImages?.Invoke(UsageImages!);
            }
            else if (IsUsageAudioSpeeches)
            {
                usageAudioSpeeches?.Invoke(UsageAudioSpeeches!);
            }
            else if (IsUsageAudioTranscriptions)
            {
                usageAudioTranscriptions?.Invoke(UsageAudioTranscriptions!);
            }
            else if (IsUsageVectorStores)
            {
                usageVectorStores?.Invoke(UsageVectorStores!);
            }
            else if (IsUsageCodeInterpreterSessions)
            {
                usageCodeInterpreterSessions?.Invoke(UsageCodeInterpreterSessions!);
            }
            else if (IsCosts)
            {
                costs?.Invoke(Costs!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UsageCompletions,
                typeof(global::tryAGI.OpenAI.UsageCompletionsResult),
                UsageEmbeddings,
                typeof(global::tryAGI.OpenAI.UsageEmbeddingsResult),
                UsageModerations,
                typeof(global::tryAGI.OpenAI.UsageModerationsResult),
                UsageImages,
                typeof(global::tryAGI.OpenAI.UsageImagesResult),
                UsageAudioSpeeches,
                typeof(global::tryAGI.OpenAI.UsageAudioSpeechesResult),
                UsageAudioTranscriptions,
                typeof(global::tryAGI.OpenAI.UsageAudioTranscriptionsResult),
                UsageVectorStores,
                typeof(global::tryAGI.OpenAI.UsageVectorStoresResult),
                UsageCodeInterpreterSessions,
                typeof(global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult),
                Costs,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageCompletionsResult?>.Default.Equals(UsageCompletions, other.UsageCompletions) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageEmbeddingsResult?>.Default.Equals(UsageEmbeddings, other.UsageEmbeddings) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageModerationsResult?>.Default.Equals(UsageModerations, other.UsageModerations) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageImagesResult?>.Default.Equals(UsageImages, other.UsageImages) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageAudioSpeechesResult?>.Default.Equals(UsageAudioSpeeches, other.UsageAudioSpeeches) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageAudioTranscriptionsResult?>.Default.Equals(UsageAudioTranscriptions, other.UsageAudioTranscriptions) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageVectorStoresResult?>.Default.Equals(UsageVectorStores, other.UsageVectorStores) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsResult?>.Default.Equals(UsageCodeInterpreterSessions, other.UsageCodeInterpreterSessions) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CostsResult?>.Default.Equals(Costs, other.Costs) 
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
