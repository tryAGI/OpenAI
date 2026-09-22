#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A function result represented as text or supported model-input content.
    /// </summary>
    public readonly partial struct FunctionCallOutputParam : global::System.IEquatable<FunctionCallOutputParam>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? FunctionCallOutputParamVariant1 { get; init; }
#else
        public string? FunctionCallOutputParamVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputParamVariant1))]
#endif
        public bool IsFunctionCallOutputParamVariant1 => FunctionCallOutputParamVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutputParamVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = FunctionCallOutputParamVariant1;
            return IsFunctionCallOutputParamVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickFunctionCallOutputParamVariant1() => IsFunctionCallOutputParamVariant1
            ? FunctionCallOutputParamVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutputParamVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>? FunctionCallOutputParamVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>? FunctionCallOutputParamVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputParamVariant2))]
#endif
        public bool IsFunctionCallOutputParamVariant2 => FunctionCallOutputParamVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutputParamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>? value)
        {
            value = FunctionCallOutputParamVariant2;
            return IsFunctionCallOutputParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam> PickFunctionCallOutputParamVariant2() => IsFunctionCallOutputParamVariant2
            ? FunctionCallOutputParamVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutputParamVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FunctionCallOutputParam(string value) => new FunctionCallOutputParam((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(FunctionCallOutputParam @this) => @this.FunctionCallOutputParamVariant1;

        /// <summary>
        ///
        /// </summary>
        public FunctionCallOutputParam(string? value)
        {
            FunctionCallOutputParamVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FunctionCallOutputParam FromFunctionCallOutputParamVariant1(string? value) => new FunctionCallOutputParam(value);

        /// <summary>
        ///
        /// </summary>
        public FunctionCallOutputParam(
            string? functionCallOutputParamVariant1,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>? functionCallOutputParamVariant2
            )
        {
            FunctionCallOutputParamVariant1 = functionCallOutputParamVariant1;
            FunctionCallOutputParamVariant2 = functionCallOutputParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FunctionCallOutputParamVariant2 as object ??
            FunctionCallOutputParamVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            FunctionCallOutputParamVariant1?.ToString() ??
            FunctionCallOutputParamVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunctionCallOutputParamVariant1 && !IsFunctionCallOutputParamVariant2 || !IsFunctionCallOutputParamVariant1 && IsFunctionCallOutputParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? functionCallOutputParamVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>, TResult>? functionCallOutputParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutputParamVariant1 && functionCallOutputParamVariant1 != null)
            {
                return functionCallOutputParamVariant1(FunctionCallOutputParamVariant1!);
            }
            else if (IsFunctionCallOutputParamVariant2 && functionCallOutputParamVariant2 != null)
            {
                return functionCallOutputParamVariant2(FunctionCallOutputParamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? functionCallOutputParamVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>>? functionCallOutputParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutputParamVariant1)
            {
                functionCallOutputParamVariant1?.Invoke(FunctionCallOutputParamVariant1!);
            }
            else if (IsFunctionCallOutputParamVariant2)
            {
                functionCallOutputParamVariant2?.Invoke(FunctionCallOutputParamVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? functionCallOutputParamVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>>? functionCallOutputParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutputParamVariant1)
            {
                functionCallOutputParamVariant1?.Invoke(FunctionCallOutputParamVariant1!);
            }
            else if (IsFunctionCallOutputParamVariant2)
            {
                functionCallOutputParamVariant2?.Invoke(FunctionCallOutputParamVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FunctionCallOutputParamVariant1,
                typeof(string),
                FunctionCallOutputParamVariant2,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>),
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
        public bool Equals(FunctionCallOutputParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(FunctionCallOutputParamVariant1, other.FunctionCallOutputParamVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>?>.Default.Equals(FunctionCallOutputParamVariant2, other.FunctionCallOutputParamVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FunctionCallOutputParam obj1, FunctionCallOutputParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionCallOutputParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FunctionCallOutputParam obj1, FunctionCallOutputParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionCallOutputParam o && Equals(o);
        }
    }
}
