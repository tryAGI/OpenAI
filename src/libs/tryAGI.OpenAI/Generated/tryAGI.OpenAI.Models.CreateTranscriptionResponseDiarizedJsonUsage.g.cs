#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Token or duration usage statistics for the request.
    /// </summary>
    public readonly partial struct CreateTranscriptionResponseDiarizedJsonUsage : global::System.IEquatable<CreateTranscriptionResponseDiarizedJsonUsage>
    {
        /// <summary>
        /// Usage statistics for models billed by token usage.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TranscriptTextUsageTokens? Tokens { get; init; }
#else
        public global::tryAGI.OpenAI.TranscriptTextUsageTokens? Tokens { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tokens))]
#endif
        public bool IsTokens => Tokens != null;

        /// <summary>
        /// Usage statistics for models billed by audio input duration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TranscriptTextUsageDuration? Duration { get; init; }
#else
        public global::tryAGI.OpenAI.TranscriptTextUsageDuration? Duration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Duration))]
#endif
        public bool IsDuration => Duration != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTranscriptionResponseDiarizedJsonUsage(global::tryAGI.OpenAI.TranscriptTextUsageTokens value) => new CreateTranscriptionResponseDiarizedJsonUsage((global::tryAGI.OpenAI.TranscriptTextUsageTokens?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TranscriptTextUsageTokens?(CreateTranscriptionResponseDiarizedJsonUsage @this) => @this.Tokens;

        /// <summary>
        /// 
        /// </summary>
        public CreateTranscriptionResponseDiarizedJsonUsage(global::tryAGI.OpenAI.TranscriptTextUsageTokens? value)
        {
            Tokens = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTranscriptionResponseDiarizedJsonUsage(global::tryAGI.OpenAI.TranscriptTextUsageDuration value) => new CreateTranscriptionResponseDiarizedJsonUsage((global::tryAGI.OpenAI.TranscriptTextUsageDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TranscriptTextUsageDuration?(CreateTranscriptionResponseDiarizedJsonUsage @this) => @this.Duration;

        /// <summary>
        /// 
        /// </summary>
        public CreateTranscriptionResponseDiarizedJsonUsage(global::tryAGI.OpenAI.TranscriptTextUsageDuration? value)
        {
            Duration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateTranscriptionResponseDiarizedJsonUsage(
            global::tryAGI.OpenAI.TranscriptTextUsageTokens? tokens,
            global::tryAGI.OpenAI.TranscriptTextUsageDuration? duration
            )
        {
            Tokens = tokens;
            Duration = duration;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Duration as object ??
            Tokens as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Tokens?.ToString() ??
            Duration?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTokens && !IsDuration || !IsTokens && IsDuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.TranscriptTextUsageTokens?, TResult>? tokens = null,
            global::System.Func<global::tryAGI.OpenAI.TranscriptTextUsageDuration?, TResult>? duration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTokens && tokens != null)
            {
                return tokens(Tokens!);
            }
            else if (IsDuration && duration != null)
            {
                return duration(Duration!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.TranscriptTextUsageTokens?>? tokens = null,
            global::System.Action<global::tryAGI.OpenAI.TranscriptTextUsageDuration?>? duration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTokens)
            {
                tokens?.Invoke(Tokens!);
            }
            else if (IsDuration)
            {
                duration?.Invoke(Duration!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Tokens,
                typeof(global::tryAGI.OpenAI.TranscriptTextUsageTokens),
                Duration,
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
        public bool Equals(CreateTranscriptionResponseDiarizedJsonUsage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TranscriptTextUsageTokens?>.Default.Equals(Tokens, other.Tokens) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TranscriptTextUsageDuration?>.Default.Equals(Duration, other.Duration) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateTranscriptionResponseDiarizedJsonUsage obj1, CreateTranscriptionResponseDiarizedJsonUsage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTranscriptionResponseDiarizedJsonUsage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateTranscriptionResponseDiarizedJsonUsage obj1, CreateTranscriptionResponseDiarizedJsonUsage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTranscriptionResponseDiarizedJsonUsage o && Equals(o);
        }
    }
}
