#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaCreateResponse : global::System.IEquatable<BetaCreateResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCreateModelResponseProperties? ModelProperties { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCreateModelResponseProperties? ModelProperties { get; }
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
        public bool TryPickModelProperties(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCreateModelResponseProperties? value)
        {
            value = ModelProperties;
            return IsModelProperties;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateModelResponseProperties PickModelProperties() => IsModelProperties
            ? ModelProperties!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelProperties' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseProperties? Properties { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseProperties? Properties { get; }
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
        public bool TryPickProperties(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseProperties? value)
        {
            value = Properties;
            return IsProperties;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseProperties PickProperties() => IsProperties
            ? Properties!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Properties' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3? BetaCreateResponseVariant3 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3? BetaCreateResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaCreateResponseVariant3))]
#endif
        public bool IsBetaCreateResponseVariant3 => BetaCreateResponseVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBetaCreateResponseVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCreateResponseVariant3? value)
        {
            value = BetaCreateResponseVariant3;
            return IsBetaCreateResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3 PickBetaCreateResponseVariant3() => IsBetaCreateResponseVariant3
            ? BetaCreateResponseVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaCreateResponseVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaCreateResponse(global::tryAGI.OpenAI.BetaCreateModelResponseProperties value) => new BetaCreateResponse((global::tryAGI.OpenAI.BetaCreateModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCreateModelResponseProperties?(BetaCreateResponse @this) => @this.ModelProperties;

        /// <summary>
        /// 
        /// </summary>
        public BetaCreateResponse(global::tryAGI.OpenAI.BetaCreateModelResponseProperties? value)
        {
            ModelProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaCreateResponse FromModelProperties(global::tryAGI.OpenAI.BetaCreateModelResponseProperties? value) => new BetaCreateResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaCreateResponse(global::tryAGI.OpenAI.BetaResponseProperties value) => new BetaCreateResponse((global::tryAGI.OpenAI.BetaResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseProperties?(BetaCreateResponse @this) => @this.Properties;

        /// <summary>
        /// 
        /// </summary>
        public BetaCreateResponse(global::tryAGI.OpenAI.BetaResponseProperties? value)
        {
            Properties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaCreateResponse FromProperties(global::tryAGI.OpenAI.BetaResponseProperties? value) => new BetaCreateResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaCreateResponse(global::tryAGI.OpenAI.BetaCreateResponseVariant3 value) => new BetaCreateResponse((global::tryAGI.OpenAI.BetaCreateResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCreateResponseVariant3?(BetaCreateResponse @this) => @this.BetaCreateResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public BetaCreateResponse(global::tryAGI.OpenAI.BetaCreateResponseVariant3? value)
        {
            BetaCreateResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaCreateResponse FromBetaCreateResponseVariant3(global::tryAGI.OpenAI.BetaCreateResponseVariant3? value) => new BetaCreateResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaCreateResponse(
            global::tryAGI.OpenAI.BetaCreateModelResponseProperties? modelProperties,
            global::tryAGI.OpenAI.BetaResponseProperties? properties,
            global::tryAGI.OpenAI.BetaCreateResponseVariant3? betaCreateResponseVariant3
            )
        {
            ModelProperties = modelProperties;
            Properties = properties;
            BetaCreateResponseVariant3 = betaCreateResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BetaCreateResponseVariant3 as object ??
            Properties as object ??
            ModelProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelProperties?.ToString() ??
            Properties?.ToString() ??
            BetaCreateResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelProperties && IsProperties && IsBetaCreateResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaCreateModelResponseProperties?, TResult>? modelProperties = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseProperties, TResult>? properties = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCreateResponseVariant3, TResult>? betaCreateResponseVariant3 = null,
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
            else if (IsBetaCreateResponseVariant3 && betaCreateResponseVariant3 != null)
            {
                return betaCreateResponseVariant3(BetaCreateResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaCreateModelResponseProperties?>? modelProperties = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseProperties>? properties = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCreateResponseVariant3>? betaCreateResponseVariant3 = null,
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
            else if (IsBetaCreateResponseVariant3)
            {
                betaCreateResponseVariant3?.Invoke(BetaCreateResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaCreateModelResponseProperties?>? modelProperties = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseProperties>? properties = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCreateResponseVariant3>? betaCreateResponseVariant3 = null,
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
            else if (IsBetaCreateResponseVariant3)
            {
                betaCreateResponseVariant3?.Invoke(BetaCreateResponseVariant3!);
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
                typeof(global::tryAGI.OpenAI.BetaCreateModelResponseProperties),
                Properties,
                typeof(global::tryAGI.OpenAI.BetaResponseProperties),
                BetaCreateResponseVariant3,
                typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3),
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
        public bool Equals(BetaCreateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCreateModelResponseProperties?>.Default.Equals(ModelProperties, other.ModelProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseProperties?>.Default.Equals(Properties, other.Properties) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCreateResponseVariant3?>.Default.Equals(BetaCreateResponseVariant3, other.BetaCreateResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaCreateResponse obj1, BetaCreateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaCreateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaCreateResponse obj1, BetaCreateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaCreateResponse o && Equals(o);
        }
    }
}
