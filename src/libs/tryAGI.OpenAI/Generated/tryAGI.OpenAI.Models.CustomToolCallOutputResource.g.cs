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
        public global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? CustomToolCallOutputResourceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? CustomToolCallOutputResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutputResourceVariant2))]
#endif
        public bool IsCustomToolCallOutputResourceVariant2 => CustomToolCallOutputResourceVariant2 != null;
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
        public static implicit operator global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2?(CustomToolCallOutputResource @this) => @this.CustomToolCallOutputResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CustomToolCallOutputResource(global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? value)
        {
            CustomToolCallOutputResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomToolCallOutputResource(
            global::tryAGI.OpenAI.CustomToolCallOutput? customToolCallOutput,
            global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2? customToolCallOutputResourceVariant2
            )
        {
            CustomToolCallOutput = customToolCallOutput;
            CustomToolCallOutputResourceVariant2 = customToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomToolCallOutputResourceVariant2 as object ??
            CustomToolCallOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomToolCallOutput?.ToString() ??
            CustomToolCallOutputResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomToolCallOutput && IsCustomToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CustomToolCallOutput?, TResult>? customToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2?, TResult>? customToolCallOutputResourceVariant2 = null,
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
            else if (IsCustomToolCallOutputResourceVariant2 && customToolCallOutputResourceVariant2 != null)
            {
                return customToolCallOutputResourceVariant2(CustomToolCallOutputResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CustomToolCallOutput?>? customToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2?>? customToolCallOutputResourceVariant2 = null,
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
            else if (IsCustomToolCallOutputResourceVariant2)
            {
                customToolCallOutputResourceVariant2?.Invoke(CustomToolCallOutputResourceVariant2!);
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
                CustomToolCallOutputResourceVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2?>.Default.Equals(CustomToolCallOutputResourceVariant2, other.CustomToolCallOutputResourceVariant2) 
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
