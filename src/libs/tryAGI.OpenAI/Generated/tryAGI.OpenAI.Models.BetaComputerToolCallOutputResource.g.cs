#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaComputerToolCallOutputResource : global::System.IEquatable<BetaComputerToolCallOutputResource>
    {
        /// <summary>
        /// The output of a computer tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaComputerToolCallOutput? ComputerToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaComputerToolCallOutput? ComputerToolCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCallOutput))]
#endif
        public bool IsComputerToolCallOutput => ComputerToolCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerToolCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaComputerToolCallOutput? value)
        {
            value = ComputerToolCallOutput;
            return IsComputerToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutput PickComputerToolCallOutput() => IsComputerToolCallOutput
            ? ComputerToolCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerToolCallOutput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? BetaComputerToolCallOutputResourceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? BetaComputerToolCallOutputResourceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaComputerToolCallOutputResourceVariant2))]
#endif
        public bool IsBetaComputerToolCallOutputResourceVariant2 => BetaComputerToolCallOutputResourceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaComputerToolCallOutputResourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? value)
        {
            value = BetaComputerToolCallOutputResourceVariant2;
            return IsBetaComputerToolCallOutputResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2 PickBetaComputerToolCallOutputResourceVariant2() => IsBetaComputerToolCallOutputResourceVariant2
            ? BetaComputerToolCallOutputResourceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaComputerToolCallOutputResourceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerToolCallOutputResource(global::tryAGI.OpenAI.BetaComputerToolCallOutput value) => new BetaComputerToolCallOutputResource((global::tryAGI.OpenAI.BetaComputerToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaComputerToolCallOutput?(BetaComputerToolCallOutputResource @this) => @this.ComputerToolCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerToolCallOutputResource(global::tryAGI.OpenAI.BetaComputerToolCallOutput? value)
        {
            ComputerToolCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerToolCallOutputResource FromComputerToolCallOutput(global::tryAGI.OpenAI.BetaComputerToolCallOutput? value) => new BetaComputerToolCallOutputResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerToolCallOutputResource(global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2 value) => new BetaComputerToolCallOutputResource((global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2?(BetaComputerToolCallOutputResource @this) => @this.BetaComputerToolCallOutputResourceVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerToolCallOutputResource(global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? value)
        {
            BetaComputerToolCallOutputResourceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerToolCallOutputResource FromBetaComputerToolCallOutputResourceVariant2(global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? value) => new BetaComputerToolCallOutputResource(value);

        /// <summary>
        ///
        /// </summary>
        public BetaComputerToolCallOutputResource(
            global::tryAGI.OpenAI.BetaComputerToolCallOutput? computerToolCallOutput,
            global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2? betaComputerToolCallOutputResourceVariant2
            )
        {
            ComputerToolCallOutput = computerToolCallOutput;
            BetaComputerToolCallOutputResourceVariant2 = betaComputerToolCallOutputResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaComputerToolCallOutputResourceVariant2 as object ??
            ComputerToolCallOutput as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ComputerToolCallOutput?.ToString() ??
            BetaComputerToolCallOutputResourceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsComputerToolCallOutput && IsBetaComputerToolCallOutputResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaComputerToolCallOutput, TResult>? computerToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2, TResult>? betaComputerToolCallOutputResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComputerToolCallOutput && computerToolCallOutput != null)
            {
                return computerToolCallOutput(ComputerToolCallOutput!);
            }
            else if (IsBetaComputerToolCallOutputResourceVariant2 && betaComputerToolCallOutputResourceVariant2 != null)
            {
                return betaComputerToolCallOutputResourceVariant2(BetaComputerToolCallOutputResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaComputerToolCallOutput>? computerToolCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2>? betaComputerToolCallOutputResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComputerToolCallOutput)
            {
                computerToolCallOutput?.Invoke(ComputerToolCallOutput!);
            }
            else if (IsBetaComputerToolCallOutputResourceVariant2)
            {
                betaComputerToolCallOutputResourceVariant2?.Invoke(BetaComputerToolCallOutputResourceVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaComputerToolCallOutput>? computerToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2>? betaComputerToolCallOutputResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComputerToolCallOutput)
            {
                computerToolCallOutput?.Invoke(ComputerToolCallOutput!);
            }
            else if (IsBetaComputerToolCallOutputResourceVariant2)
            {
                betaComputerToolCallOutputResourceVariant2?.Invoke(BetaComputerToolCallOutputResourceVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ComputerToolCallOutput,
                typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutput),
                BetaComputerToolCallOutputResourceVariant2,
                typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2),
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
        public bool Equals(BetaComputerToolCallOutputResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaComputerToolCallOutput?>.Default.Equals(ComputerToolCallOutput, other.ComputerToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2?>.Default.Equals(BetaComputerToolCallOutputResourceVariant2, other.BetaComputerToolCallOutputResourceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaComputerToolCallOutputResource obj1, BetaComputerToolCallOutputResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaComputerToolCallOutputResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaComputerToolCallOutputResource obj1, BetaComputerToolCallOutputResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaComputerToolCallOutputResource o && Equals(o);
        }
    }
}
