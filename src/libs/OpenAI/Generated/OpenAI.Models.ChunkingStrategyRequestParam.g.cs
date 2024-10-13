using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
    /// </summary>
    public readonly partial struct ChunkingStrategyRequestParam : global::System.IEquatable<ChunkingStrategyRequestParam>
    {
        /// <summary>
        /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
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
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.AutoChunkingStrategyRequestParam?, TResult>? auto = null,
            global::System.Func<global::OpenAI.StaticChunkingStrategyRequestParam?, TResult>? @static = null,
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
            global::System.Action<global::OpenAI.AutoChunkingStrategyRequestParam?>? auto = null,
            global::System.Action<global::OpenAI.StaticChunkingStrategyRequestParam?>? @static = null,
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


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::OpenAI.ChunkingStrategyRequestParam? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.ChunkingStrategyRequestParam),
                jsonSerializerContext) as global::OpenAI.ChunkingStrategyRequestParam?;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.ChunkingStrategyRequestParam? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.ChunkingStrategyRequestParam>(
                json,
                jsonSerializerOptions);
        }

    }
}
