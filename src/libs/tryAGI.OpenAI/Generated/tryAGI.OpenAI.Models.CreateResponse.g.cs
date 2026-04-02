#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateResponse : global::System.IEquatable<CreateResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateModelResponseProperties? ModelProperties { get; init; }
#else
        public global::tryAGI.OpenAI.CreateModelResponseProperties? ModelProperties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelProperties))]
#endif
        public bool IsModelProperties => ModelProperties != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseProperties? Properties { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseProperties? Properties { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Properties))]
#endif
        public bool IsProperties => Properties != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateResponseVariant3? CreateResponseVariant3 { get; init; }
#else
        public global::tryAGI.OpenAI.CreateResponseVariant3? CreateResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateResponseVariant3))]
#endif
        public bool IsCreateResponseVariant3 => CreateResponseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateResponse(global::tryAGI.OpenAI.CreateModelResponseProperties value) => new CreateResponse((global::tryAGI.OpenAI.CreateModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateModelResponseProperties?(CreateResponse @this) => @this.ModelProperties;

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(global::tryAGI.OpenAI.CreateModelResponseProperties? value)
        {
            ModelProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateResponse(global::tryAGI.OpenAI.ResponseProperties value) => new CreateResponse((global::tryAGI.OpenAI.ResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseProperties?(CreateResponse @this) => @this.Properties;

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(global::tryAGI.OpenAI.ResponseProperties? value)
        {
            Properties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateResponse(global::tryAGI.OpenAI.CreateResponseVariant3 value) => new CreateResponse((global::tryAGI.OpenAI.CreateResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateResponseVariant3?(CreateResponse @this) => @this.CreateResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(global::tryAGI.OpenAI.CreateResponseVariant3? value)
        {
            CreateResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateResponse(
            global::tryAGI.OpenAI.CreateModelResponseProperties? modelProperties,
            global::tryAGI.OpenAI.ResponseProperties? properties,
            global::tryAGI.OpenAI.CreateResponseVariant3? createResponseVariant3
            )
        {
            ModelProperties = modelProperties;
            Properties = properties;
            CreateResponseVariant3 = createResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateResponseVariant3 as object ??
            Properties as object ??
            ModelProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelProperties?.ToString() ??
            Properties?.ToString() ??
            CreateResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelProperties && IsProperties && IsCreateResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CreateModelResponseProperties?, TResult>? modelProperties = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseProperties?, TResult>? properties = null,
            global::System.Func<global::tryAGI.OpenAI.CreateResponseVariant3?, TResult>? createResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelProperties && modelProperties != null)
            {
                return modelProperties(ModelProperties!);
            }
            else if (IsProperties && properties != null)
            {
                return properties(Properties!);
            }
            else if (IsCreateResponseVariant3 && createResponseVariant3 != null)
            {
                return createResponseVariant3(CreateResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CreateModelResponseProperties?>? modelProperties = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseProperties?>? properties = null,
            global::System.Action<global::tryAGI.OpenAI.CreateResponseVariant3?>? createResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelProperties)
            {
                modelProperties?.Invoke(ModelProperties!);
            }
            else if (IsProperties)
            {
                properties?.Invoke(Properties!);
            }
            else if (IsCreateResponseVariant3)
            {
                createResponseVariant3?.Invoke(CreateResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelProperties,
                typeof(global::tryAGI.OpenAI.CreateModelResponseProperties),
                Properties,
                typeof(global::tryAGI.OpenAI.ResponseProperties),
                CreateResponseVariant3,
                typeof(global::tryAGI.OpenAI.CreateResponseVariant3),
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
        public bool Equals(CreateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateModelResponseProperties?>.Default.Equals(ModelProperties, other.ModelProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseProperties?>.Default.Equals(Properties, other.Properties) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateResponseVariant3?>.Default.Equals(CreateResponseVariant3, other.CreateResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateResponse obj1, CreateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateResponse obj1, CreateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateResponse o && Equals(o);
        }
    }
}
