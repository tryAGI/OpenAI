using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The strategy used to chunk the file.
    /// </summary>
    public readonly partial struct VectorStoreFileObjectChunkingStrategy : global::System.IEquatable<VectorStoreFileObjectChunkingStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.VectorStoreFileObjectChunkingStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.StaticChunkingStrategyResponseParam? StaticResponseParam { get; init; }
#else
        public global::OpenAI.StaticChunkingStrategyResponseParam? StaticResponseParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StaticResponseParam))]
#endif
        public bool IsStaticResponseParam => StaticResponseParam != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStoreFileObjectChunkingStrategy(global::OpenAI.StaticChunkingStrategyResponseParam value) => new VectorStoreFileObjectChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.StaticChunkingStrategyResponseParam?(VectorStoreFileObjectChunkingStrategy @this) => @this.StaticResponseParam;

        /// <summary>
        /// 
        /// </summary>
        public VectorStoreFileObjectChunkingStrategy(global::OpenAI.StaticChunkingStrategyResponseParam? value)
        {
            StaticResponseParam = value;
        }

        /// <summary>
        /// This is returned when the chunking strategy is unknown. Typically, this is because the file was indexed before the `chunking_strategy` concept was introduced in the API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.OtherChunkingStrategyResponseParam? OtherResponseParam { get; init; }
#else
        public global::OpenAI.OtherChunkingStrategyResponseParam? OtherResponseParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OtherResponseParam))]
#endif
        public bool IsOtherResponseParam => OtherResponseParam != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStoreFileObjectChunkingStrategy(global::OpenAI.OtherChunkingStrategyResponseParam value) => new VectorStoreFileObjectChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.OtherChunkingStrategyResponseParam?(VectorStoreFileObjectChunkingStrategy @this) => @this.OtherResponseParam;

        /// <summary>
        /// 
        /// </summary>
        public VectorStoreFileObjectChunkingStrategy(global::OpenAI.OtherChunkingStrategyResponseParam? value)
        {
            OtherResponseParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorStoreFileObjectChunkingStrategy(
            global::OpenAI.VectorStoreFileObjectChunkingStrategyDiscriminatorType? type,
            global::OpenAI.StaticChunkingStrategyResponseParam? staticResponseParam,
            global::OpenAI.OtherChunkingStrategyResponseParam? otherResponseParam
            )
        {
            Type = type;

            StaticResponseParam = staticResponseParam;
            OtherResponseParam = otherResponseParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OtherResponseParam as object ??
            StaticResponseParam as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStaticResponseParam && !IsOtherResponseParam || !IsStaticResponseParam && IsOtherResponseParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.StaticChunkingStrategyResponseParam?, TResult>? staticResponseParam = null,
            global::System.Func<global::OpenAI.OtherChunkingStrategyResponseParam?, TResult>? otherResponseParam = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStaticResponseParam && staticResponseParam != null)
            {
                return staticResponseParam(StaticResponseParam!);
            }
            else if (IsOtherResponseParam && otherResponseParam != null)
            {
                return otherResponseParam(OtherResponseParam!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.StaticChunkingStrategyResponseParam?>? staticResponseParam = null,
            global::System.Action<global::OpenAI.OtherChunkingStrategyResponseParam?>? otherResponseParam = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStaticResponseParam)
            {
                staticResponseParam?.Invoke(StaticResponseParam!);
            }
            else if (IsOtherResponseParam)
            {
                otherResponseParam?.Invoke(OtherResponseParam!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StaticResponseParam,
                typeof(global::OpenAI.StaticChunkingStrategyResponseParam),
                OtherResponseParam,
                typeof(global::OpenAI.OtherChunkingStrategyResponseParam),
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
        public bool Equals(VectorStoreFileObjectChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.StaticChunkingStrategyResponseParam?>.Default.Equals(StaticResponseParam, other.StaticResponseParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.OtherChunkingStrategyResponseParam?>.Default.Equals(OtherResponseParam, other.OtherResponseParam) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorStoreFileObjectChunkingStrategy obj1, VectorStoreFileObjectChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorStoreFileObjectChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorStoreFileObjectChunkingStrategy obj1, VectorStoreFileObjectChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorStoreFileObjectChunkingStrategy o && Equals(o);
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
        public static global::OpenAI.VectorStoreFileObjectChunkingStrategy? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.VectorStoreFileObjectChunkingStrategy),
                jsonSerializerContext) as global::OpenAI.VectorStoreFileObjectChunkingStrategy?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.VectorStoreFileObjectChunkingStrategy? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.VectorStoreFileObjectChunkingStrategy>(
                json,
                jsonSerializerOptions);
        }

    }
}
