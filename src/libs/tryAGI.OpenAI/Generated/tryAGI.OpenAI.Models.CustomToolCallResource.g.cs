#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomToolCallResource : global::System.IEquatable<CustomToolCallResource>
    {
        /// <summary>
        /// A call to a custom tool created by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomToolCall? CustomToolCall { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolCall? CustomToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCall))]
#endif
        public bool IsCustomToolCall => CustomToolCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomToolCallResourceVariant2? CustomToolCallResourceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolCallResourceVariant2? CustomToolCallResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallResourceVariant2))]
#endif
        public bool IsCustomToolCallResourceVariant2 => CustomToolCallResourceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomToolCallResource(global::tryAGI.OpenAI.CustomToolCall value) => new CustomToolCallResource((global::tryAGI.OpenAI.CustomToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolCall?(CustomToolCallResource @this) => @this.CustomToolCall;

        /// <summary>
        /// 
        /// </summary>
        public CustomToolCallResource(global::tryAGI.OpenAI.CustomToolCall? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomToolCallResource(global::tryAGI.OpenAI.CustomToolCallResourceVariant2 value) => new CustomToolCallResource((global::tryAGI.OpenAI.CustomToolCallResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolCallResourceVariant2?(CustomToolCallResource @this) => @this.CustomToolCallResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CustomToolCallResource(global::tryAGI.OpenAI.CustomToolCallResourceVariant2? value)
        {
            CustomToolCallResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomToolCallResource(
            global::tryAGI.OpenAI.CustomToolCall? customToolCall,
            global::tryAGI.OpenAI.CustomToolCallResourceVariant2? customToolCallResourceVariant2
            )
        {
            CustomToolCall = customToolCall;
            CustomToolCallResourceVariant2 = customToolCallResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomToolCallResourceVariant2 as object ??
            CustomToolCall as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomToolCall?.ToString() ??
            CustomToolCallResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomToolCall && IsCustomToolCallResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CustomToolCall?, TResult>? customToolCall = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCallResourceVariant2?, TResult>? customToolCallResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolCall && customToolCall != null)
            {
                return customToolCall(CustomToolCall!);
            }
            else if (IsCustomToolCallResourceVariant2 && customToolCallResourceVariant2 != null)
            {
                return customToolCallResourceVariant2(CustomToolCallResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CustomToolCall?>? customToolCall = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCallResourceVariant2?>? customToolCallResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolCall)
            {
                customToolCall?.Invoke(CustomToolCall!);
            }
            else if (IsCustomToolCallResourceVariant2)
            {
                customToolCallResourceVariant2?.Invoke(CustomToolCallResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomToolCall,
                typeof(global::tryAGI.OpenAI.CustomToolCall),
                CustomToolCallResourceVariant2,
                typeof(global::tryAGI.OpenAI.CustomToolCallResourceVariant2),
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
        public bool Equals(CustomToolCallResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCall?>.Default.Equals(CustomToolCall, other.CustomToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCallResourceVariant2?>.Default.Equals(CustomToolCallResourceVariant2, other.CustomToolCallResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomToolCallResource obj1, CustomToolCallResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomToolCallResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomToolCallResource obj1, CustomToolCallResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomToolCallResource o && Equals(o);
        }
    }
}
