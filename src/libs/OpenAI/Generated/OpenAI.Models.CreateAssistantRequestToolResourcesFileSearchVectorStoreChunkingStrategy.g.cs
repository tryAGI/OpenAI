using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
    /// </summary>
    public readonly partial struct CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy : global::System.IEquatable<CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? Value1 { get; init; }
#else
        public global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? Value1 { get; }
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
        public static implicit operator CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1 value) => new CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?(CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? Value2 { get; init; }
#else
        public global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? Value2 { get; }
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
        public static implicit operator CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2 value) => new CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?(CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(
            global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? type,
            global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? value1,
            global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? value2
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
            global::System.Func<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?, TResult>? value1 = null,
            global::System.Func<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?, TResult>? value2 = null,
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
            global::System.Action<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?>? value1 = null,
            global::System.Action<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?>? value2 = null,
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
                typeof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1),
                Value2,
                typeof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2),
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
        public bool Equals(CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj1, CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj1, CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy o && Equals(o);
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
        public static global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy),
                jsonSerializerContext) as global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy>(
                json,
                jsonSerializerOptions);
        }

    }
}
