using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
    /// </summary>
    public readonly partial struct CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy : global::System.IEquatable<CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? Value1 { get; init; }
#else
        public global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1 value) => new CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?(CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? Value2 { get; init; }
#else
        public global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2 value) => new CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?(CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(
            global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? type,
            global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? value1,
            global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? value2
            )
        {
            Type = type;

            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?, TResult>? value1 = null,
            global::System.Func<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?>? value1 = null,
            global::System.Action<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1),
                Value2,
                typeof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2),
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
        public bool Equals(CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj1, CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj1, CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy o && Equals(o);
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
        public static global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy),
                jsonSerializerContext) as global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy>(
                json,
                jsonSerializerOptions);
        }

    }
}
