#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Token usage statistics for the request.
    /// </summary>
    public readonly partial struct CreateTranscriptionResponseJsonUsage : global::System.IEquatable<CreateTranscriptionResponseJsonUsage>
    {
        /// <summary>
        /// Usage statistics for models billed by token usage.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TranscriptTextUsageTokens? TranscriptTextTokens { get; init; }
#else
        public global::tryAGI.OpenAI.TranscriptTextUsageTokens? TranscriptTextTokens { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptTextTokens))]
#endif
        public bool IsTranscriptTextTokens => TranscriptTextTokens != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTranscriptionResponseJsonUsage(global::tryAGI.OpenAI.TranscriptTextUsageTokens value) => new CreateTranscriptionResponseJsonUsage((global::tryAGI.OpenAI.TranscriptTextUsageTokens?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TranscriptTextUsageTokens?(CreateTranscriptionResponseJsonUsage @this) => @this.TranscriptTextTokens;

        /// <summary>
        /// 
        /// </summary>
        public CreateTranscriptionResponseJsonUsage(global::tryAGI.OpenAI.TranscriptTextUsageTokens? value)
        {
            TranscriptTextTokens = value;
        }

        /// <summary>
        /// Usage statistics for models billed by audio input duration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TranscriptTextUsageDuration? TranscriptTextDuration { get; init; }
#else
        public global::tryAGI.OpenAI.TranscriptTextUsageDuration? TranscriptTextDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptTextDuration))]
#endif
        public bool IsTranscriptTextDuration => TranscriptTextDuration != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTranscriptionResponseJsonUsage(global::tryAGI.OpenAI.TranscriptTextUsageDuration value) => new CreateTranscriptionResponseJsonUsage((global::tryAGI.OpenAI.TranscriptTextUsageDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TranscriptTextUsageDuration?(CreateTranscriptionResponseJsonUsage @this) => @this.TranscriptTextDuration;

        /// <summary>
        /// 
        /// </summary>
        public CreateTranscriptionResponseJsonUsage(global::tryAGI.OpenAI.TranscriptTextUsageDuration? value)
        {
            TranscriptTextDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateTranscriptionResponseJsonUsage(
            global::tryAGI.OpenAI.TranscriptTextUsageTokens? transcriptTextTokens,
            global::tryAGI.OpenAI.TranscriptTextUsageDuration? transcriptTextDuration
            )
        {
            TranscriptTextTokens = transcriptTextTokens;
            TranscriptTextDuration = transcriptTextDuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TranscriptTextDuration as object ??
            TranscriptTextTokens as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranscriptTextTokens?.ToString() ??
            TranscriptTextDuration?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranscriptTextTokens || IsTranscriptTextDuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.TranscriptTextUsageTokens?, TResult>? transcriptTextTokens = null,
            global::System.Func<global::tryAGI.OpenAI.TranscriptTextUsageDuration?, TResult>? transcriptTextDuration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptTextTokens && transcriptTextTokens != null)
            {
                return transcriptTextTokens(TranscriptTextTokens!);
            }
            else if (IsTranscriptTextDuration && transcriptTextDuration != null)
            {
                return transcriptTextDuration(TranscriptTextDuration!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.TranscriptTextUsageTokens?>? transcriptTextTokens = null,
            global::System.Action<global::tryAGI.OpenAI.TranscriptTextUsageDuration?>? transcriptTextDuration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptTextTokens)
            {
                transcriptTextTokens?.Invoke(TranscriptTextTokens!);
            }
            else if (IsTranscriptTextDuration)
            {
                transcriptTextDuration?.Invoke(TranscriptTextDuration!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranscriptTextTokens,
                typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokens),
                TranscriptTextDuration,
                typeof(global::tryAGI.OpenAI.TranscriptTextUsageDuration),
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
        public bool Equals(CreateTranscriptionResponseJsonUsage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TranscriptTextUsageTokens?>.Default.Equals(TranscriptTextTokens, other.TranscriptTextTokens) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TranscriptTextUsageDuration?>.Default.Equals(TranscriptTextDuration, other.TranscriptTextDuration) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateTranscriptionResponseJsonUsage obj1, CreateTranscriptionResponseJsonUsage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTranscriptionResponseJsonUsage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateTranscriptionResponseJsonUsage obj1, CreateTranscriptionResponseJsonUsage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTranscriptionResponseJsonUsage o && Equals(o);
        }
    }
}
