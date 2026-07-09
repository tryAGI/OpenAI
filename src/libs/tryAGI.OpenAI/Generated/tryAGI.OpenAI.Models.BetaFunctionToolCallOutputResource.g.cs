#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaFunctionToolCallOutputResource : global::System.IEquatable<BetaFunctionToolCallOutputResource>
    {
        /// <summary>
        /// The output of a function tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput? FunctionToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput? FunctionToolCallOutput { get; }
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
        public bool TryPickFunctionToolCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFunctionToolCallOutput? value)
        {
            value = FunctionToolCallOutput;
            return IsFunctionToolCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutput PickFunctionToolCallOutput() => IsFunctionToolCallOutput
            ? FunctionToolCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionToolCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? BetaFunctionToolCallOutputResourceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? BetaFunctionToolCallOutputResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaFunctionToolCallOutputResourceVariant2))]
#endif
        public bool IsBetaFunctionToolCallOutputResourceVariant2 => BetaFunctionToolCallOutputResourceVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBetaFunctionToolCallOutputResourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? value)
        {
            value = BetaFunctionToolCallOutputResourceVariant2;
            return IsBetaFunctionToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2 PickBetaFunctionToolCallOutputResourceVariant2() => IsBetaFunctionToolCallOutputResourceVariant2
            ? BetaFunctionToolCallOutputResourceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaFunctionToolCallOutputResourceVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaFunctionToolCallOutputResource(global::tryAGI.OpenAI.BetaFunctionToolCallOutput value) => new BetaFunctionToolCallOutputResource((global::tryAGI.OpenAI.BetaFunctionToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionToolCallOutput?(BetaFunctionToolCallOutputResource @this) => @this.FunctionToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public BetaFunctionToolCallOutputResource(global::tryAGI.OpenAI.BetaFunctionToolCallOutput? value)
        {
            FunctionToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaFunctionToolCallOutputResource FromFunctionToolCallOutput(global::tryAGI.OpenAI.BetaFunctionToolCallOutput? value) => new BetaFunctionToolCallOutputResource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaFunctionToolCallOutputResource(global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2 value) => new BetaFunctionToolCallOutputResource((global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2?(BetaFunctionToolCallOutputResource @this) => @this.BetaFunctionToolCallOutputResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BetaFunctionToolCallOutputResource(global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? value)
        {
            BetaFunctionToolCallOutputResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaFunctionToolCallOutputResource FromBetaFunctionToolCallOutputResourceVariant2(global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? value) => new BetaFunctionToolCallOutputResource(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaFunctionToolCallOutputResource(
            global::tryAGI.OpenAI.BetaFunctionToolCallOutput? functionToolCallOutput,
            global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2? betaFunctionToolCallOutputResourceVariant2
            )
        {
            FunctionToolCallOutput = functionToolCallOutput;
            BetaFunctionToolCallOutputResourceVariant2 = betaFunctionToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BetaFunctionToolCallOutputResourceVariant2 as object ??
            FunctionToolCallOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FunctionToolCallOutput?.ToString() ??
            BetaFunctionToolCallOutputResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunctionToolCallOutput && IsBetaFunctionToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionToolCallOutput, TResult>? functionToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2, TResult>? betaFunctionToolCallOutputResourceVariant2 = null,
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
            else if (IsBetaFunctionToolCallOutputResourceVariant2 && betaFunctionToolCallOutputResourceVariant2 != null)
            {
                return betaFunctionToolCallOutputResourceVariant2(BetaFunctionToolCallOutputResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCallOutput>? functionToolCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2>? betaFunctionToolCallOutputResourceVariant2 = null,
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
            else if (IsBetaFunctionToolCallOutputResourceVariant2)
            {
                betaFunctionToolCallOutputResourceVariant2?.Invoke(BetaFunctionToolCallOutputResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCallOutput>? functionToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2>? betaFunctionToolCallOutputResourceVariant2 = null,
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
            else if (IsBetaFunctionToolCallOutputResourceVariant2)
            {
                betaFunctionToolCallOutputResourceVariant2?.Invoke(BetaFunctionToolCallOutputResourceVariant2!);
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
                typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutput),
                BetaFunctionToolCallOutputResourceVariant2,
                typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2),
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
        public bool Equals(BetaFunctionToolCallOutputResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionToolCallOutput?>.Default.Equals(FunctionToolCallOutput, other.FunctionToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2?>.Default.Equals(BetaFunctionToolCallOutputResourceVariant2, other.BetaFunctionToolCallOutputResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaFunctionToolCallOutputResource obj1, BetaFunctionToolCallOutputResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaFunctionToolCallOutputResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaFunctionToolCallOutputResource obj1, BetaFunctionToolCallOutputResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaFunctionToolCallOutputResource o && Equals(o);
        }
    }
}
