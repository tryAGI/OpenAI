#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Example: gpt-5.4
    /// </summary>
    public readonly partial struct ModelIdsShared : global::System.IEquatable<ModelIdsShared>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ModelIdsSharedVariant1 { get; init; }
#else
        public string? ModelIdsSharedVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelIdsSharedVariant1))]
#endif
        public bool IsModelIdsSharedVariant1 => ModelIdsSharedVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ModelIdsSharedEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.ModelIdsSharedEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIdsShared(string value) => new ModelIdsShared((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ModelIdsShared @this) => @this.ModelIdsSharedVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsShared(string? value)
        {
            ModelIdsSharedVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIdsShared(global::tryAGI.OpenAI.ModelIdsSharedEnum value) => new ModelIdsShared((global::tryAGI.OpenAI.ModelIdsSharedEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModelIdsSharedEnum?(ModelIdsShared @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsShared(global::tryAGI.OpenAI.ModelIdsSharedEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsShared(
            string? modelIdsSharedVariant1,
            global::tryAGI.OpenAI.ModelIdsSharedEnum? @enum
            )
        {
            ModelIdsSharedVariant1 = modelIdsSharedVariant1;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            ModelIdsSharedVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelIdsSharedVariant1?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelIdsSharedVariant1 || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? modelIdsSharedVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.ModelIdsSharedEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelIdsSharedVariant1 && modelIdsSharedVariant1 != null)
            {
                return modelIdsSharedVariant1(ModelIdsSharedVariant1!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? modelIdsSharedVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.ModelIdsSharedEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelIdsSharedVariant1)
            {
                modelIdsSharedVariant1?.Invoke(ModelIdsSharedVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelIdsSharedVariant1,
                typeof(string),
                Enum,
                typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum),
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
        public bool Equals(ModelIdsShared other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ModelIdsSharedVariant1, other.ModelIdsSharedVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModelIdsSharedEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelIdsShared obj1, ModelIdsShared obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelIdsShared>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelIdsShared obj1, ModelIdsShared obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelIdsShared o && Equals(o);
        }
    }
}
