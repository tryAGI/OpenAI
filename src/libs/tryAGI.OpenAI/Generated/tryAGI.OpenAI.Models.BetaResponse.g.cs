#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Example: {"id":"resp_67ccd3a9da748190baa7f1570fe91ac604becb25c45c1d41","object":"response","created_at":1741476777,"status":"completed","completed_at":1741476778,"error":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","incomplete_details":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","instructions":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","max_output_tokens":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","model":"gpt-4o-2024-08-06","output":[{"type":"message","id":"msg_67ccd3acc8d48190a77525dc6de64b4104becb25c45c1d41","status":"completed","role":"assistant","content":[{"type":"output_text","text":"The image depicts a scenic landscape with a wooden boardwalk or pathway leading through lush, green grass under a blue sky with some clouds. The setting suggests a peaceful natural area, possibly a park or nature reserve. There are trees and shrubs in the background.","annotations":[]}]}],"parallel_tool_calls":true,"previous_response_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","reasoning":{"effort":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","summary":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","context":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},"store":true,"temperature":1,"text":{"format":{"type":"text"}},"tool_choice":"auto","tools":[],"top_p":1,"truncation":"disabled","usage":{"input_tokens":328,"input_tokens_details":{"cached_tokens":0,"cache_write_tokens":0},"output_tokens":52,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":380},"user":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","metadata":{}}
    /// </summary>
    public readonly partial struct BetaResponse : global::System.IEquatable<BetaResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaModelResponseProperties? ModelProperties { get; init; }
#else
        public global::tryAGI.OpenAI.BetaModelResponseProperties? ModelProperties { get; }
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
            out global::tryAGI.OpenAI.BetaModelResponseProperties? value)
        {
            value = ModelProperties;
            return IsModelProperties;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaModelResponseProperties PickModelProperties() => IsModelProperties
            ? ModelProperties!
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
        public global::tryAGI.OpenAI.BetaResponseVariant3? BetaResponseVariant3 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseVariant3? BetaResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaResponseVariant3))]
#endif
        public bool IsBetaResponseVariant3 => BetaResponseVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBetaResponseVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseVariant3? value)
        {
            value = BetaResponseVariant3;
            return IsBetaResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseVariant3 PickBetaResponseVariant3() => IsBetaResponseVariant3
            ? BetaResponseVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaResponseVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaResponse(global::tryAGI.OpenAI.BetaModelResponseProperties value) => new BetaResponse((global::tryAGI.OpenAI.BetaModelResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaModelResponseProperties?(BetaResponse @this) => @this.ModelProperties;

        /// <summary>
        /// 
        /// </summary>
        public BetaResponse(global::tryAGI.OpenAI.BetaModelResponseProperties? value)
        {
            ModelProperties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaResponse FromModelProperties(global::tryAGI.OpenAI.BetaModelResponseProperties? value) => new BetaResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaResponse(global::tryAGI.OpenAI.BetaResponseProperties value) => new BetaResponse((global::tryAGI.OpenAI.BetaResponseProperties?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseProperties?(BetaResponse @this) => @this.Properties;

        /// <summary>
        /// 
        /// </summary>
        public BetaResponse(global::tryAGI.OpenAI.BetaResponseProperties? value)
        {
            Properties = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaResponse FromProperties(global::tryAGI.OpenAI.BetaResponseProperties? value) => new BetaResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaResponse(global::tryAGI.OpenAI.BetaResponseVariant3 value) => new BetaResponse((global::tryAGI.OpenAI.BetaResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseVariant3?(BetaResponse @this) => @this.BetaResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public BetaResponse(global::tryAGI.OpenAI.BetaResponseVariant3? value)
        {
            BetaResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaResponse FromBetaResponseVariant3(global::tryAGI.OpenAI.BetaResponseVariant3? value) => new BetaResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaResponse(
            global::tryAGI.OpenAI.BetaModelResponseProperties? modelProperties,
            global::tryAGI.OpenAI.BetaResponseProperties? properties,
            global::tryAGI.OpenAI.BetaResponseVariant3? betaResponseVariant3
            )
        {
            ModelProperties = modelProperties;
            Properties = properties;
            BetaResponseVariant3 = betaResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BetaResponseVariant3 as object ??
            Properties as object ??
            ModelProperties as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModelProperties?.ToString() ??
            Properties?.ToString() ??
            BetaResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModelProperties && IsProperties && IsBetaResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaModelResponseProperties, TResult>? modelProperties = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseProperties, TResult>? properties = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseVariant3, TResult>? betaResponseVariant3 = null,
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
            else if (IsBetaResponseVariant3 && betaResponseVariant3 != null)
            {
                return betaResponseVariant3(BetaResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaModelResponseProperties>? modelProperties = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseProperties>? properties = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseVariant3>? betaResponseVariant3 = null,
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
            else if (IsBetaResponseVariant3)
            {
                betaResponseVariant3?.Invoke(BetaResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaModelResponseProperties>? modelProperties = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseProperties>? properties = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseVariant3>? betaResponseVariant3 = null,
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
            else if (IsBetaResponseVariant3)
            {
                betaResponseVariant3?.Invoke(BetaResponseVariant3!);
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
                typeof(global::tryAGI.OpenAI.BetaModelResponseProperties),
                Properties,
                typeof(global::tryAGI.OpenAI.BetaResponseProperties),
                BetaResponseVariant3,
                typeof(global::tryAGI.OpenAI.BetaResponseVariant3),
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
        public bool Equals(BetaResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaModelResponseProperties?>.Default.Equals(ModelProperties, other.ModelProperties) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseProperties?>.Default.Equals(Properties, other.Properties) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseVariant3?>.Default.Equals(BetaResponseVariant3, other.BetaResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaResponse obj1, BetaResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaResponse obj1, BetaResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponse o && Equals(o);
        }
    }
}
