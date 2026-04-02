#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// When the number of tokens in a conversation exceeds the model's input token limit, the conversation be truncated, meaning messages (starting from the oldest) will not be included in the model's context. A 32k context model with 4,096 max output tokens can only include 28,224 tokens in the context before truncation occurs.<br/>
    /// Clients can configure truncation behavior to truncate with a lower max token limit, which is an effective way to control token usage and cost.<br/>
    /// Truncation will reduce the number of cached tokens on the next turn (busting the cache), since messages are dropped from the beginning of the context. However, clients can also configure truncation to retain messages up to a fraction of the maximum context size, which will reduce the need for future truncations and thus improve the cache rate.<br/>
    /// Truncation can be disabled entirely, which means the server will never truncate but would instead return an error if the conversation exceeds the model's input token limit.
    /// </summary>
    public readonly partial struct RealtimeTruncation : global::System.IEquatable<RealtimeTruncation>
    {
        /// <summary>
        /// The truncation strategy to use for the session. `auto` is the default truncation strategy. `disabled` will disable truncation and emit errors when the conversation exceeds the input token limit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTruncationEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTruncationEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// Retain a fraction of the conversation tokens when the conversation exceeds the input token limit. This allows you to amortize truncations across multiple turns, which can help improve cached token usage.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTruncationEnum2? RetentionRatioTruncation { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTruncationEnum2? RetentionRatioTruncation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetentionRatioTruncation))]
#endif
        public bool IsRetentionRatioTruncation => RetentionRatioTruncation != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTruncation(global::tryAGI.OpenAI.RealtimeTruncationEnum value) => new RealtimeTruncation((global::tryAGI.OpenAI.RealtimeTruncationEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTruncationEnum?(RealtimeTruncation @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTruncation(global::tryAGI.OpenAI.RealtimeTruncationEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTruncation(global::tryAGI.OpenAI.RealtimeTruncationEnum2 value) => new RealtimeTruncation((global::tryAGI.OpenAI.RealtimeTruncationEnum2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTruncationEnum2?(RealtimeTruncation @this) => @this.RetentionRatioTruncation;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTruncation(global::tryAGI.OpenAI.RealtimeTruncationEnum2? value)
        {
            RetentionRatioTruncation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTruncation(
            global::tryAGI.OpenAI.RealtimeTruncationEnum? @enum,
            global::tryAGI.OpenAI.RealtimeTruncationEnum2? retentionRatioTruncation
            )
        {
            Enum = @enum;
            RetentionRatioTruncation = retentionRatioTruncation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RetentionRatioTruncation as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            RetentionRatioTruncation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsRetentionRatioTruncation || !IsEnum && IsRetentionRatioTruncation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeTruncationEnum?, TResult>? @enum = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTruncationEnum2?, TResult>? retentionRatioTruncation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsRetentionRatioTruncation && retentionRatioTruncation != null)
            {
                return retentionRatioTruncation(RetentionRatioTruncation!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeTruncationEnum?>? @enum = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTruncationEnum2?>? retentionRatioTruncation = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsRetentionRatioTruncation)
            {
                retentionRatioTruncation?.Invoke(RetentionRatioTruncation!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum),
                RetentionRatioTruncation,
                typeof(global::tryAGI.OpenAI.RealtimeTruncationEnum2),
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
        public bool Equals(RealtimeTruncation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTruncationEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTruncationEnum2?>.Default.Equals(RetentionRatioTruncation, other.RetentionRatioTruncation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeTruncation obj1, RealtimeTruncation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeTruncation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeTruncation obj1, RealtimeTruncation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeTruncation o && Equals(o);
        }
    }
}
