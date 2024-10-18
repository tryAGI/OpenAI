using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy. Only applicable if `file_ids` is non-empty.
    /// </summary>
    public readonly partial struct CreateVectorStoreRequestChunkingStrategy : global::System.IEquatable<CreateVectorStoreRequestChunkingStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.CreateVectorStoreRequestChunkingStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AutoChunkingStrategyRequestParam? AutoParam { get; init; }
#else
        public global::OpenAI.AutoChunkingStrategyRequestParam? AutoParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoParam))]
#endif
        public bool IsAutoParam => AutoParam != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVectorStoreRequestChunkingStrategy(global::OpenAI.AutoChunkingStrategyRequestParam value) => new CreateVectorStoreRequestChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AutoChunkingStrategyRequestParam?(CreateVectorStoreRequestChunkingStrategy @this) => @this.AutoParam;

        /// <summary>
        /// 
        /// </summary>
        public CreateVectorStoreRequestChunkingStrategy(global::OpenAI.AutoChunkingStrategyRequestParam? value)
        {
            AutoParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.StaticChunkingStrategyRequestParam? StaticParam { get; init; }
#else
        public global::OpenAI.StaticChunkingStrategyRequestParam? StaticParam { get; }
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
        public static implicit operator CreateVectorStoreRequestChunkingStrategy(global::OpenAI.StaticChunkingStrategyRequestParam value) => new CreateVectorStoreRequestChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.StaticChunkingStrategyRequestParam?(CreateVectorStoreRequestChunkingStrategy @this) => @this.StaticParam;

        /// <summary>
        /// 
        /// </summary>
        public CreateVectorStoreRequestChunkingStrategy(global::OpenAI.StaticChunkingStrategyRequestParam? value)
        {
            StaticParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateVectorStoreRequestChunkingStrategy(
            global::OpenAI.CreateVectorStoreRequestChunkingStrategyDiscriminatorType? type,
            global::OpenAI.AutoChunkingStrategyRequestParam? autoParam,
            global::OpenAI.StaticChunkingStrategyRequestParam? staticParam
            )
        {
            Type = type;

            AutoParam = autoParam;
            StaticParam = staticParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StaticParam as object ??
            AutoParam as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAutoParam && !IsStaticParam || !IsAutoParam && IsStaticParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.AutoChunkingStrategyRequestParam?, TResult>? autoParam = null,
            global::System.Func<global::OpenAI.StaticChunkingStrategyRequestParam?, TResult>? staticParam = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoParam && autoParam != null)
            {
                return autoParam(AutoParam!);
            }
            else if (IsStaticParam && staticParam != null)
            {
                return staticParam(StaticParam!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.AutoChunkingStrategyRequestParam?>? autoParam = null,
            global::System.Action<global::OpenAI.StaticChunkingStrategyRequestParam?>? staticParam = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoParam)
            {
                autoParam?.Invoke(AutoParam!);
            }
            else if (IsStaticParam)
            {
                staticParam?.Invoke(StaticParam!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoParam,
                typeof(global::OpenAI.AutoChunkingStrategyRequestParam),
                StaticParam,
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
        public bool Equals(CreateVectorStoreRequestChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AutoChunkingStrategyRequestParam?>.Default.Equals(AutoParam, other.AutoParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.StaticChunkingStrategyRequestParam?>.Default.Equals(StaticParam, other.StaticParam) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateVectorStoreRequestChunkingStrategy obj1, CreateVectorStoreRequestChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateVectorStoreRequestChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateVectorStoreRequestChunkingStrategy obj1, CreateVectorStoreRequestChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateVectorStoreRequestChunkingStrategy o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::OpenAI.CreateVectorStoreRequestChunkingStrategy? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.CreateVectorStoreRequestChunkingStrategy),
                jsonSerializerContext) as global::OpenAI.CreateVectorStoreRequestChunkingStrategy?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.CreateVectorStoreRequestChunkingStrategy? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.CreateVectorStoreRequestChunkingStrategy>(
                json,
                jsonSerializerOptions);
        }

    }
}
