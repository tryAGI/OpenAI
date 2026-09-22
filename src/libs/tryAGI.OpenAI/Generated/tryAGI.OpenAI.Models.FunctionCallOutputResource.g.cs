#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The text or model-input content supplied as a function result.
    /// </summary>
    public readonly partial struct FunctionCallOutputResource : global::System.IEquatable<FunctionCallOutputResource>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? FunctionCallOutputResourceVariant1 { get; init; }
#else
        public string? FunctionCallOutputResourceVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputResourceVariant1))]
#endif
        public bool IsFunctionCallOutputResourceVariant1 => FunctionCallOutputResourceVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutputResourceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = FunctionCallOutputResourceVariant1;
            return IsFunctionCallOutputResourceVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickFunctionCallOutputResourceVariant1() => IsFunctionCallOutputResourceVariant1
            ? FunctionCallOutputResourceVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutputResourceVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>? FunctionCallOutputResourceVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>? FunctionCallOutputResourceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputResourceVariant2))]
#endif
        public bool IsFunctionCallOutputResourceVariant2 => FunctionCallOutputResourceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutputResourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>? value)
        {
            value = FunctionCallOutputResourceVariant2;
            return IsFunctionCallOutputResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource> PickFunctionCallOutputResourceVariant2() => IsFunctionCallOutputResourceVariant2
            ? FunctionCallOutputResourceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutputResourceVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FunctionCallOutputResource(string value) => new FunctionCallOutputResource((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(FunctionCallOutputResource @this) => @this.FunctionCallOutputResourceVariant1;

        /// <summary>
        ///
        /// </summary>
        public FunctionCallOutputResource(string? value)
        {
            FunctionCallOutputResourceVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FunctionCallOutputResource FromFunctionCallOutputResourceVariant1(string? value) => new FunctionCallOutputResource(value);

        /// <summary>
        ///
        /// </summary>
        public FunctionCallOutputResource(
            string? functionCallOutputResourceVariant1,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>? functionCallOutputResourceVariant2
            )
        {
            FunctionCallOutputResourceVariant1 = functionCallOutputResourceVariant1;
            FunctionCallOutputResourceVariant2 = functionCallOutputResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FunctionCallOutputResourceVariant2 as object ??
            FunctionCallOutputResourceVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            FunctionCallOutputResourceVariant1?.ToString() ??
            FunctionCallOutputResourceVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunctionCallOutputResourceVariant1 && !IsFunctionCallOutputResourceVariant2 || !IsFunctionCallOutputResourceVariant1 && IsFunctionCallOutputResourceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? functionCallOutputResourceVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>, TResult>? functionCallOutputResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutputResourceVariant1 && functionCallOutputResourceVariant1 != null)
            {
                return functionCallOutputResourceVariant1(FunctionCallOutputResourceVariant1!);
            }
            else if (IsFunctionCallOutputResourceVariant2 && functionCallOutputResourceVariant2 != null)
            {
                return functionCallOutputResourceVariant2(FunctionCallOutputResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? functionCallOutputResourceVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>>? functionCallOutputResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutputResourceVariant1)
            {
                functionCallOutputResourceVariant1?.Invoke(FunctionCallOutputResourceVariant1!);
            }
            else if (IsFunctionCallOutputResourceVariant2)
            {
                functionCallOutputResourceVariant2?.Invoke(FunctionCallOutputResourceVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? functionCallOutputResourceVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>>? functionCallOutputResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutputResourceVariant1)
            {
                functionCallOutputResourceVariant1?.Invoke(FunctionCallOutputResourceVariant1!);
            }
            else if (IsFunctionCallOutputResourceVariant2)
            {
                functionCallOutputResourceVariant2?.Invoke(FunctionCallOutputResourceVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FunctionCallOutputResourceVariant1,
                typeof(string),
                FunctionCallOutputResourceVariant2,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>),
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
        public bool Equals(FunctionCallOutputResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(FunctionCallOutputResourceVariant1, other.FunctionCallOutputResourceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>?>.Default.Equals(FunctionCallOutputResourceVariant2, other.FunctionCallOutputResourceVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FunctionCallOutputResource obj1, FunctionCallOutputResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionCallOutputResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FunctionCallOutputResource obj1, FunctionCallOutputResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionCallOutputResource o && Equals(o);
        }
    }
}
