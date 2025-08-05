#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The strategy used to chunk the file.
    /// </summary>
    public readonly partial struct ChunkingStrategyResponse : global::System.IEquatable<ChunkingStrategyResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? StaticParam { get; init; }
#else
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? StaticParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StaticParam))]
#endif
        public bool IsStaticParam => StaticParam != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategyResponse(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam value) => new ChunkingStrategyResponse((global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam?(ChunkingStrategyResponse @this) => @this.StaticParam;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyResponse(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? value)
        {
            StaticParam = value;
        }

        /// <summary>
        /// This is returned when the chunking strategy is unknown. Typically, this is because the file was indexed before the `chunking_strategy` concept was introduced in the API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? OtherParam { get; init; }
#else
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? OtherParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OtherParam))]
#endif
        public bool IsOtherParam => OtherParam != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategyResponse(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam value) => new ChunkingStrategyResponse((global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam?(ChunkingStrategyResponse @this) => @this.OtherParam;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyResponse(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? value)
        {
            OtherParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyResponse(
            global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? staticParam,
            global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? otherParam
            )
        {
            StaticParam = staticParam;
            OtherParam = otherParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OtherParam as object ??
            StaticParam as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StaticParam?.ToString() ??
            OtherParam?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStaticParam || IsOtherParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam?, TResult>? staticParam = null,
            global::System.Func<global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam?, TResult>? otherParam = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStaticParam && staticParam != null)
            {
                return staticParam(StaticParam!);
            }
            else if (IsOtherParam && otherParam != null)
            {
                return otherParam(OtherParam!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam?>? staticParam = null,
            global::System.Action<global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam?>? otherParam = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStaticParam)
            {
                staticParam?.Invoke(StaticParam!);
            }
            else if (IsOtherParam)
            {
                otherParam?.Invoke(OtherParam!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StaticParam,
                typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam),
                OtherParam,
                typeof(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam),
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
        public bool Equals(ChunkingStrategyResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam?>.Default.Equals(StaticParam, other.StaticParam) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam?>.Default.Equals(OtherParam, other.OtherParam) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChunkingStrategyResponse obj1, ChunkingStrategyResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChunkingStrategyResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChunkingStrategyResponse obj1, ChunkingStrategyResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChunkingStrategyResponse o && Equals(o);
        }
    }
}
