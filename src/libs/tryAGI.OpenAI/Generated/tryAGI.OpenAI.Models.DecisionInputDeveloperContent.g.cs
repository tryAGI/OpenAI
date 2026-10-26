#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A text string or an ordered list of input text parts.
    /// </summary>
    public readonly partial struct DecisionInputDeveloperContent : global::System.IEquatable<DecisionInputDeveloperContent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DecisionInputDeveloperContentVariant1 { get; init; }
#else
        public string? DecisionInputDeveloperContentVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionInputDeveloperContentVariant1))]
#endif
        public bool IsDecisionInputDeveloperContentVariant1 => DecisionInputDeveloperContentVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionInputDeveloperContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DecisionInputDeveloperContentVariant1;
            return IsDecisionInputDeveloperContentVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickDecisionInputDeveloperContentVariant1() => DecisionInputDeveloperContentVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionInputDeveloperContentVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>? Parts { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>? Parts { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Parts))]
#endif
        public bool IsParts => Parts != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickParts(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>? value)
        {
            value = Parts;
            return IsParts;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText> PickParts() => Parts is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Parts' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputDeveloperContent(string value) => new DecisionInputDeveloperContent((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(DecisionInputDeveloperContent @this) => @this.DecisionInputDeveloperContentVariant1;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputDeveloperContent(string? value)
        {
            DecisionInputDeveloperContentVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputDeveloperContent FromDecisionInputDeveloperContentVariant1(string? value) => new DecisionInputDeveloperContent(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInputDeveloperContent(
            string? decisionInputDeveloperContentVariant1,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>? parts
            )
        {
            DecisionInputDeveloperContentVariant1 = decisionInputDeveloperContentVariant1;
            Parts = parts;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Parts as object ??
            DecisionInputDeveloperContentVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DecisionInputDeveloperContentVariant1?.ToString() ??
            Parts?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDecisionInputDeveloperContentVariant1 && !IsParts || !IsDecisionInputDeveloperContentVariant1 && IsParts;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? decisionInputDeveloperContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>, TResult>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputDeveloperContentVariant1 is { } __value0 && decisionInputDeveloperContentVariant1 != null)
            {
                return decisionInputDeveloperContentVariant1(__value0);
            }
            else if (Parts is { } __value1 && parts != null)
            {
                return parts(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? decisionInputDeveloperContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputDeveloperContentVariant1 is { } __value0)
            {
                decisionInputDeveloperContentVariant1?.Invoke(__value0);
            }
            else if (Parts is { } __value1)
            {
                parts?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? decisionInputDeveloperContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputDeveloperContentVariant1 is { } __value0)
            {
                decisionInputDeveloperContentVariant1?.Invoke(__value0);
            }
            else if (Parts is { } __value1)
            {
                parts?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DecisionInputDeveloperContentVariant1,
                typeof(string),
                Parts,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>),
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
        public bool Equals(DecisionInputDeveloperContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DecisionInputDeveloperContentVariant1, other.DecisionInputDeveloperContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputText>?>.Default.Equals(Parts, other.Parts)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInputDeveloperContent obj1, DecisionInputDeveloperContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInputDeveloperContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInputDeveloperContent obj1, DecisionInputDeveloperContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInputDeveloperContent o && Equals(o);
        }
    }
}
