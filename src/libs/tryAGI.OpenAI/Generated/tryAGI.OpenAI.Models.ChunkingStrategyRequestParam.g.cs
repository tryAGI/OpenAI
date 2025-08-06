#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy. Only applicable if `file_ids` is non-empty.
    /// </summary>
    public readonly partial struct ChunkingStrategyRequestParam : global::System.IEquatable<ChunkingStrategyRequestParam>
    {
        /// <summary>
        /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam? Auto { get; init; }
#else
        public global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam? Auto { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Auto))]
#endif
        public bool IsAuto => Auto != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategyRequestParam(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam value) => new ChunkingStrategyRequestParam((global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam?(ChunkingStrategyRequestParam @this) => @this.Auto;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam? value)
        {
            Auto = value;
        }

        /// <summary>
        /// Customize your own chunking strategy by setting chunk size and chunk overlap.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam? Static { get; init; }
#else
        public global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam? Static { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Static))]
#endif
        public bool IsStatic => Static != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategyRequestParam(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam value) => new ChunkingStrategyRequestParam((global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam?(ChunkingStrategyRequestParam @this) => @this.Static;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam? value)
        {
            Static = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(
            global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam? auto,
            global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam? @static
            )
        {
            Auto = auto;
            Static = @static;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Static as object ??
            Auto as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Auto?.ToString() ??
            Static?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAuto || IsStatic;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam?, TResult>? auto = null,
            global::System.Func<global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam?, TResult>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto && auto != null)
            {
                return auto(Auto!);
            }
            else if (IsStatic && @static != null)
            {
                return @static(Static!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam?>? auto = null,
            global::System.Action<global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam?>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto)
            {
                auto?.Invoke(Auto!);
            }
            else if (IsStatic)
            {
                @static?.Invoke(Static!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Auto,
                typeof(global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam),
                Static,
                typeof(global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam),
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
        public bool Equals(ChunkingStrategyRequestParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutoChunkingStrategyRequestParam?>.Default.Equals(Auto, other.Auto) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.StaticChunkingStrategyRequestParam?>.Default.Equals(Static, other.Static) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChunkingStrategyRequestParam obj1, ChunkingStrategyRequestParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChunkingStrategyRequestParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChunkingStrategyRequestParam obj1, ChunkingStrategyRequestParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChunkingStrategyRequestParam o && Equals(o);
        }
    }
}
