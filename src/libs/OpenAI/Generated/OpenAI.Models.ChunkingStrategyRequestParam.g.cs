using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
    /// </summary>
    public readonly struct ChunkingStrategyRequestParam : global::System.IEquatable<ChunkingStrategyRequestParam>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AutoChunkingStrategyRequestParam? Auto { get; init; }
#else
        public global::OpenAI.AutoChunkingStrategyRequestParam? Auto { get; }
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
        public static implicit operator ChunkingStrategyRequestParam(global::OpenAI.AutoChunkingStrategyRequestParam value) => new ChunkingStrategyRequestParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AutoChunkingStrategyRequestParam?(ChunkingStrategyRequestParam @this) => @this.Auto;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(global::OpenAI.AutoChunkingStrategyRequestParam? value)
        {
            Auto = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.StaticChunkingStrategyRequestParam? Static { get; init; }
#else
        public global::OpenAI.StaticChunkingStrategyRequestParam? Static { get; }
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
        public static implicit operator ChunkingStrategyRequestParam(global::OpenAI.StaticChunkingStrategyRequestParam value) => new ChunkingStrategyRequestParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.StaticChunkingStrategyRequestParam?(ChunkingStrategyRequestParam @this) => @this.Static;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(global::OpenAI.StaticChunkingStrategyRequestParam? value)
        {
            Static = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategyRequestParam(
            global::OpenAI.AutoChunkingStrategyRequestParam? auto,
            global::OpenAI.StaticChunkingStrategyRequestParam? @static
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
        public bool Validate()
        {
            return IsAuto && !IsStatic || !IsAuto && IsStatic;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Auto,
                typeof(global::OpenAI.AutoChunkingStrategyRequestParam),
                Static,
                typeof(global::OpenAI.StaticChunkingStrategyRequestParam),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChunkingStrategyRequestParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AutoChunkingStrategyRequestParam?>.Default.Equals(Auto, other.Auto) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.StaticChunkingStrategyRequestParam?>.Default.Equals(Static, other.Static) 
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
