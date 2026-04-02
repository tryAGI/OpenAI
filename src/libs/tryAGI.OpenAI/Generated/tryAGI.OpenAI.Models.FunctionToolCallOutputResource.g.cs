#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionToolCallOutputResource : global::System.IEquatable<FunctionToolCallOutputResource>
    {
        /// <summary>
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionToolCallOutput? FunctionToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolCallOutput? FunctionToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCallOutput))]
#endif
        public bool IsFunctionToolCallOutput => FunctionToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2? FunctionToolCallOutputResourceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2? FunctionToolCallOutputResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolCallOutputResourceVariant2))]
#endif
        public bool IsFunctionToolCallOutputResourceVariant2 => FunctionToolCallOutputResourceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionToolCallOutputResource(global::tryAGI.OpenAI.FunctionToolCallOutput value) => new FunctionToolCallOutputResource((global::tryAGI.OpenAI.FunctionToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCallOutput?(FunctionToolCallOutputResource @this) => @this.FunctionToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public FunctionToolCallOutputResource(global::tryAGI.OpenAI.FunctionToolCallOutput? value)
        {
            FunctionToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionToolCallOutputResource(global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2 value) => new FunctionToolCallOutputResource((global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2?(FunctionToolCallOutputResource @this) => @this.FunctionToolCallOutputResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FunctionToolCallOutputResource(global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2? value)
        {
            FunctionToolCallOutputResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionToolCallOutputResource(
            global::tryAGI.OpenAI.FunctionToolCallOutput? functionToolCallOutput,
            global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2? functionToolCallOutputResourceVariant2
            )
        {
            FunctionToolCallOutput = functionToolCallOutput;
            FunctionToolCallOutputResourceVariant2 = functionToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionToolCallOutputResourceVariant2 as object ??
            FunctionToolCallOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FunctionToolCallOutput?.ToString() ??
            FunctionToolCallOutputResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunctionToolCallOutput && IsFunctionToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCallOutput?, TResult>? functionToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2?, TResult>? functionToolCallOutputResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionToolCallOutput && functionToolCallOutput != null)
            {
                return functionToolCallOutput(FunctionToolCallOutput!);
            }
            else if (IsFunctionToolCallOutputResourceVariant2 && functionToolCallOutputResourceVariant2 != null)
            {
                return functionToolCallOutputResourceVariant2(FunctionToolCallOutputResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCallOutput?>? functionToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2?>? functionToolCallOutputResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionToolCallOutput)
            {
                functionToolCallOutput?.Invoke(FunctionToolCallOutput!);
            }
            else if (IsFunctionToolCallOutputResourceVariant2)
            {
                functionToolCallOutputResourceVariant2?.Invoke(FunctionToolCallOutputResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FunctionToolCallOutput,
                typeof(global::tryAGI.OpenAI.FunctionToolCallOutput),
                FunctionToolCallOutputResourceVariant2,
                typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2),
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
        public bool Equals(FunctionToolCallOutputResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCallOutput?>.Default.Equals(FunctionToolCallOutput, other.FunctionToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2?>.Default.Equals(FunctionToolCallOutputResourceVariant2, other.FunctionToolCallOutputResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionToolCallOutputResource obj1, FunctionToolCallOutputResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionToolCallOutputResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionToolCallOutputResource obj1, FunctionToolCallOutputResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionToolCallOutputResource o && Equals(o);
        }
    }
}
