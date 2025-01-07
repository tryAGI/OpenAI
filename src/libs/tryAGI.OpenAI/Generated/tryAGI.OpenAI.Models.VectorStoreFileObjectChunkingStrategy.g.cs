#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The strategy used to chunk the file.
    /// </summary>
    public readonly partial struct VectorStoreFileObjectChunkingStrategy : global::System.IEquatable<VectorStoreFileObjectChunkingStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.VectorStoreFileObjectChunkingStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? Static { get; init; }
#else
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? Static { get; }
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
        public static implicit operator VectorStoreFileObjectChunkingStrategy(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam value) => new VectorStoreFileObjectChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam?(VectorStoreFileObjectChunkingStrategy @this) => @this.Static;

        /// <summary>
        /// 
        /// </summary>
        public VectorStoreFileObjectChunkingStrategy(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? value)
        {
            Static = value;
        }

        /// <summary>
        /// This is returned when the chunking strategy is unknown. Typically, this is because the file was indexed before the `chunking_strategy` concept was introduced in the API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? Other { get; init; }
#else
        public global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? Other { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Other))]
#endif
        public bool IsOther => Other != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStoreFileObjectChunkingStrategy(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam value) => new VectorStoreFileObjectChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam?(VectorStoreFileObjectChunkingStrategy @this) => @this.Other;

        /// <summary>
        /// 
        /// </summary>
        public VectorStoreFileObjectChunkingStrategy(global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? value)
        {
            Other = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorStoreFileObjectChunkingStrategy(
            global::tryAGI.OpenAI.VectorStoreFileObjectChunkingStrategyDiscriminatorType? type,
            global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam? @static,
            global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam? other
            )
        {
            Type = type;

            Static = @static;
            Other = other;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Other as object ??
            Static as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStatic && !IsOther || !IsStatic && IsOther;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam?, TResult>? @static = null,
            global::System.Func<global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam?, TResult>? other = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStatic && @static != null)
            {
                return @static(Static!);
            }
            else if (IsOther && other != null)
            {
                return other(Other!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam?>? @static = null,
            global::System.Action<global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam?>? other = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStatic)
            {
                @static?.Invoke(Static!);
            }
            else if (IsOther)
            {
                other?.Invoke(Other!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Static,
                typeof(global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam),
                Other,
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
        public bool Equals(VectorStoreFileObjectChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.StaticChunkingStrategyResponseParam?>.Default.Equals(Static, other.Static) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OtherChunkingStrategyResponseParam?>.Default.Equals(Other, other.Other) 
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
    }
}
