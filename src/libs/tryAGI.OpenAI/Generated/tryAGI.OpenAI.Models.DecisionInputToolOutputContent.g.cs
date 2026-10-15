#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text evidence or an ordered list of text and image parts.
    /// </summary>
    public readonly partial struct DecisionInputToolOutputContent : global::System.IEquatable<DecisionInputToolOutputContent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DecisionInputToolOutputContentVariant1 { get; init; }
#else
        public string? DecisionInputToolOutputContentVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionInputToolOutputContentVariant1))]
#endif
        public bool IsDecisionInputToolOutputContentVariant1 => DecisionInputToolOutputContentVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionInputToolOutputContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DecisionInputToolOutputContentVariant1;
            return IsDecisionInputToolOutputContentVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickDecisionInputToolOutputContentVariant1() => DecisionInputToolOutputContentVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionInputToolOutputContentVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>? Parts { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>? Parts { get; }
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
            out global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>? value)
        {
            value = Parts;
            return IsParts;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem> PickParts() => Parts is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Parts' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputToolOutputContent(string value) => new DecisionInputToolOutputContent((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(DecisionInputToolOutputContent @this) => @this.DecisionInputToolOutputContentVariant1;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputToolOutputContent(string? value)
        {
            DecisionInputToolOutputContentVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputToolOutputContent FromDecisionInputToolOutputContentVariant1(string? value) => new DecisionInputToolOutputContent(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInputToolOutputContent(
            string? decisionInputToolOutputContentVariant1,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>? parts
            )
        {
            DecisionInputToolOutputContentVariant1 = decisionInputToolOutputContentVariant1;
            Parts = parts;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Parts as object ??
            DecisionInputToolOutputContentVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DecisionInputToolOutputContentVariant1?.ToString() ??
            Parts?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDecisionInputToolOutputContentVariant1 && !IsParts || !IsDecisionInputToolOutputContentVariant1 && IsParts;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? decisionInputToolOutputContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>, TResult>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputToolOutputContentVariant1 is { } __value0 && decisionInputToolOutputContentVariant1 != null)
            {
                return decisionInputToolOutputContentVariant1(__value0);
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
            global::System.Action<string>? decisionInputToolOutputContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputToolOutputContentVariant1 is { } __value0)
            {
                decisionInputToolOutputContentVariant1?.Invoke(__value0);
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
            global::System.Action<string>? decisionInputToolOutputContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputToolOutputContentVariant1 is { } __value0)
            {
                decisionInputToolOutputContentVariant1?.Invoke(__value0);
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
                DecisionInputToolOutputContentVariant1,
                typeof(string),
                Parts,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>),
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
        public bool Equals(DecisionInputToolOutputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DecisionInputToolOutputContentVariant1, other.DecisionInputToolOutputContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputToolOutputContentPartsItem>?>.Default.Equals(Parts, other.Parts)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInputToolOutputContent obj1, DecisionInputToolOutputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInputToolOutputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInputToolOutputContent obj1, DecisionInputToolOutputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInputToolOutputContent o && Equals(o);
        }
    }
}
