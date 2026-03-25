#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomToolCallOutputResource : global::System.IEquatable<CustomToolCallOutputResource>
    {
        /// <summary>
        /// The output of a custom tool call from your code, being sent back to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomToolCallOutput? CustomToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolCallOutput? CustomToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutput))]
#endif
        public bool IsCustomToolCallOutput => CustomToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? Value2 { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? Value2 { get; }
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
        public static implicit operator CustomToolCallOutputResource(global::tryAGI.OpenAI.CustomToolCallOutput value) => new CustomToolCallOutputResource((global::tryAGI.OpenAI.CustomToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolCallOutput?(CustomToolCallOutputResource @this) => @this.CustomToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public CustomToolCallOutputResource(global::tryAGI.OpenAI.CustomToolCallOutput? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomToolCallOutputResource(global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2 value) => new CustomToolCallOutputResource((global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2?(CustomToolCallOutputResource @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public CustomToolCallOutputResource(global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomToolCallOutputResource(
            global::tryAGI.OpenAI.CustomToolCallOutput? customToolCallOutput,
            global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? value2
            )
        {
            CustomToolCallOutput = customToolCallOutput;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            CustomToolCallOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomToolCallOutput?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomToolCallOutput && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CustomToolCallOutput?, TResult>? customToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolCallOutput && customToolCallOutput != null)
            {
                return customToolCallOutput(CustomToolCallOutput!);
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
            global::System.Action<global::tryAGI.OpenAI.CustomToolCallOutput?>? customToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolCallOutput)
            {
                customToolCallOutput?.Invoke(CustomToolCallOutput!);
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
                CustomToolCallOutput,
                typeof(global::tryAGI.OpenAI.CustomToolCallOutput),
                Value2,
                typeof(global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2),
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
        public bool Equals(CustomToolCallOutputResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCallOutput?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomToolCallOutputResource obj1, CustomToolCallOutputResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomToolCallOutputResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomToolCallOutputResource obj1, CustomToolCallOutputResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomToolCallOutputResource o && Equals(o);
        }
    }
}
