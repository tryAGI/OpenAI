#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaCustomToolCallOutputResource : global::System.IEquatable<BetaCustomToolCallOutputResource>
    {
        /// <summary>
        /// The output of a custom tool call from your code, being sent back to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput? CustomToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput? CustomToolCallOutput { get; }
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
        public bool TryPickCustomToolCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCustomToolCallOutput? value)
        {
            value = CustomToolCallOutput;
            return IsCustomToolCallOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutput PickCustomToolCallOutput() => IsCustomToolCallOutput
            ? CustomToolCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? BetaCustomToolCallOutputResourceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? BetaCustomToolCallOutputResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaCustomToolCallOutputResourceVariant2))]
#endif
        public bool IsBetaCustomToolCallOutputResourceVariant2 => BetaCustomToolCallOutputResourceVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBetaCustomToolCallOutputResourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? value)
        {
            value = BetaCustomToolCallOutputResourceVariant2;
            return IsBetaCustomToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2 PickBetaCustomToolCallOutputResourceVariant2() => IsBetaCustomToolCallOutputResourceVariant2
            ? BetaCustomToolCallOutputResourceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaCustomToolCallOutputResourceVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaCustomToolCallOutputResource(global::tryAGI.OpenAI.BetaCustomToolCallOutput value) => new BetaCustomToolCallOutputResource((global::tryAGI.OpenAI.BetaCustomToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomToolCallOutput?(BetaCustomToolCallOutputResource @this) => @this.CustomToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public BetaCustomToolCallOutputResource(global::tryAGI.OpenAI.BetaCustomToolCallOutput? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaCustomToolCallOutputResource FromCustomToolCallOutput(global::tryAGI.OpenAI.BetaCustomToolCallOutput? value) => new BetaCustomToolCallOutputResource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaCustomToolCallOutputResource(global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2 value) => new BetaCustomToolCallOutputResource((global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2?(BetaCustomToolCallOutputResource @this) => @this.BetaCustomToolCallOutputResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BetaCustomToolCallOutputResource(global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? value)
        {
            BetaCustomToolCallOutputResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaCustomToolCallOutputResource FromBetaCustomToolCallOutputResourceVariant2(global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? value) => new BetaCustomToolCallOutputResource(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaCustomToolCallOutputResource(
            global::tryAGI.OpenAI.BetaCustomToolCallOutput? customToolCallOutput,
            global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2? betaCustomToolCallOutputResourceVariant2
            )
        {
            CustomToolCallOutput = customToolCallOutput;
            BetaCustomToolCallOutputResourceVariant2 = betaCustomToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BetaCustomToolCallOutputResourceVariant2 as object ??
            CustomToolCallOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomToolCallOutput?.ToString() ??
            BetaCustomToolCallOutputResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomToolCallOutput && IsBetaCustomToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaCustomToolCallOutput, TResult>? customToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2, TResult>? betaCustomToolCallOutputResourceVariant2 = null,
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
            else if (IsBetaCustomToolCallOutputResourceVariant2 && betaCustomToolCallOutputResourceVariant2 != null)
            {
                return betaCustomToolCallOutputResourceVariant2(BetaCustomToolCallOutputResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCallOutput>? customToolCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2>? betaCustomToolCallOutputResourceVariant2 = null,
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
            else if (IsBetaCustomToolCallOutputResourceVariant2)
            {
                betaCustomToolCallOutputResourceVariant2?.Invoke(BetaCustomToolCallOutputResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCallOutput>? customToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2>? betaCustomToolCallOutputResourceVariant2 = null,
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
            else if (IsBetaCustomToolCallOutputResourceVariant2)
            {
                betaCustomToolCallOutputResourceVariant2?.Invoke(BetaCustomToolCallOutputResourceVariant2!);
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
                typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutput),
                BetaCustomToolCallOutputResourceVariant2,
                typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2),
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
        public bool Equals(BetaCustomToolCallOutputResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomToolCallOutput?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2?>.Default.Equals(BetaCustomToolCallOutputResourceVariant2, other.BetaCustomToolCallOutputResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaCustomToolCallOutputResource obj1, BetaCustomToolCallOutputResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaCustomToolCallOutputResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaCustomToolCallOutputResource obj1, BetaCustomToolCallOutputResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaCustomToolCallOutputResource o && Equals(o);
        }
    }
}
