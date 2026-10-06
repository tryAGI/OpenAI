#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text evidence or an ordered list of text and inline image parts.
    /// </summary>
    public readonly partial struct DecisionInputContent : global::System.IEquatable<DecisionInputContent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DecisionInputContentVariant1 { get; init; }
#else
        public string? DecisionInputContentVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionInputContentVariant1))]
#endif
        public bool IsDecisionInputContentVariant1 => DecisionInputContentVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionInputContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DecisionInputContentVariant1;
            return IsDecisionInputContentVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickDecisionInputContentVariant1() => DecisionInputContentVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionInputContentVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? Parts { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? Parts { get; }
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
            out global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? value)
        {
            value = Parts;
            return IsParts;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem> PickParts() => Parts is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Parts' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputContent(string value) => new DecisionInputContent((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(DecisionInputContent @this) => @this.DecisionInputContentVariant1;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputContent(string? value)
        {
            DecisionInputContentVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputContent FromDecisionInputContentVariant1(string? value) => new DecisionInputContent(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInputContent(
            string? decisionInputContentVariant1,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>? parts
            )
        {
            DecisionInputContentVariant1 = decisionInputContentVariant1;
            Parts = parts;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Parts as object ??
            DecisionInputContentVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DecisionInputContentVariant1?.ToString() ??
            Parts?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDecisionInputContentVariant1 && !IsParts || !IsDecisionInputContentVariant1 && IsParts;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? decisionInputContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>, TResult>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputContentVariant1 is { } __value0 && decisionInputContentVariant1 != null)
            {
                return decisionInputContentVariant1(__value0);
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
            global::System.Action<string>? decisionInputContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputContentVariant1 is { } __value0)
            {
                decisionInputContentVariant1?.Invoke(__value0);
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
            global::System.Action<string>? decisionInputContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputContentVariant1 is { } __value0)
            {
                decisionInputContentVariant1?.Invoke(__value0);
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
                DecisionInputContentVariant1,
                typeof(string),
                Parts,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>),
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
        public bool Equals(DecisionInputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DecisionInputContentVariant1, other.DecisionInputContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputContentPartsItem>?>.Default.Equals(Parts, other.Parts)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInputContent obj1, DecisionInputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInputContent obj1, DecisionInputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInputContent o && Equals(o);
        }
    }
}
