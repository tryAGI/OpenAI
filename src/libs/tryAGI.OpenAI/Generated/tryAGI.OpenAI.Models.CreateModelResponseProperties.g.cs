#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateModelResponseProperties : global::System.IEquatable<CreateModelResponseProperties>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ModelResponseProperties? ModelResponseProperties { get; init; }
#else
        public global::tryAGI.OpenAI.ModelResponseProperties? ModelResponseProperties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelResponseProperties))]
#endif
        public bool IsModelResponseProperties => ModelResponseProperties != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2? CreateModelResponsePropertiesVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2? CreateModelResponsePropertiesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateModelResponsePropertiesVariant2))]
#endif
        public bool IsCreateModelResponsePropertiesVariant2 => CreateModelResponsePropertiesVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateModelResponseProperties(global::tryAGI.OpenAI.ModelResponseProperties value) => new CreateModelResponseProperties((global::tryAGI.OpenAI.ModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModelResponseProperties?(CreateModelResponseProperties @this) => @this.ModelResponseProperties;

        /// <summary>
        /// 
        /// </summary>
        public CreateModelResponseProperties(global::tryAGI.OpenAI.ModelResponseProperties? value)
        {
            ModelResponseProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateModelResponseProperties(global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2 value) => new CreateModelResponseProperties((global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2?(CreateModelResponseProperties @this) => @this.CreateModelResponsePropertiesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateModelResponseProperties(global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2? value)
        {
            CreateModelResponsePropertiesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateModelResponseProperties(
            global::tryAGI.OpenAI.ModelResponseProperties? modelResponseProperties,
            global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2? createModelResponsePropertiesVariant2
            )
        {
            ModelResponseProperties = modelResponseProperties;
            CreateModelResponsePropertiesVariant2 = createModelResponsePropertiesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateModelResponsePropertiesVariant2 as object ??
            ModelResponseProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelResponseProperties?.ToString() ??
            CreateModelResponsePropertiesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelResponseProperties && IsCreateModelResponsePropertiesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ModelResponseProperties?, TResult>? modelResponseProperties = null,
            global::System.Func<global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2?, TResult>? createModelResponsePropertiesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelResponseProperties && modelResponseProperties != null)
            {
                return modelResponseProperties(ModelResponseProperties!);
            }
            else if (IsCreateModelResponsePropertiesVariant2 && createModelResponsePropertiesVariant2 != null)
            {
                return createModelResponsePropertiesVariant2(CreateModelResponsePropertiesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ModelResponseProperties?>? modelResponseProperties = null,
            global::System.Action<global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2?>? createModelResponsePropertiesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelResponseProperties)
            {
                modelResponseProperties?.Invoke(ModelResponseProperties!);
            }
            else if (IsCreateModelResponsePropertiesVariant2)
            {
                createModelResponsePropertiesVariant2?.Invoke(CreateModelResponsePropertiesVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelResponseProperties,
                typeof(global::tryAGI.OpenAI.ModelResponseProperties),
                CreateModelResponsePropertiesVariant2,
                typeof(global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2),
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
        public bool Equals(CreateModelResponseProperties other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModelResponseProperties?>.Default.Equals(ModelResponseProperties, other.ModelResponseProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2?>.Default.Equals(CreateModelResponsePropertiesVariant2, other.CreateModelResponsePropertiesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateModelResponseProperties obj1, CreateModelResponseProperties obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateModelResponseProperties>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateModelResponseProperties obj1, CreateModelResponseProperties obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateModelResponseProperties o && Equals(o);
        }
    }
}
