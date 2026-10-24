#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A text string or an ordered list of output text and refusal parts.
    /// </summary>
    public readonly partial struct DecisionInputAssistantContent : global::System.IEquatable<DecisionInputAssistantContent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DecisionInputAssistantContentVariant1 { get; init; }
#else
        public string? DecisionInputAssistantContentVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionInputAssistantContentVariant1))]
#endif
        public bool IsDecisionInputAssistantContentVariant1 => DecisionInputAssistantContentVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionInputAssistantContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DecisionInputAssistantContentVariant1;
            return IsDecisionInputAssistantContentVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickDecisionInputAssistantContentVariant1() => DecisionInputAssistantContentVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionInputAssistantContentVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>? Parts { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>? Parts { get; }
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
            out global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>? value)
        {
            value = Parts;
            return IsParts;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem> PickParts() => Parts is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Parts' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputAssistantContent(string value) => new DecisionInputAssistantContent((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(DecisionInputAssistantContent @this) => @this.DecisionInputAssistantContentVariant1;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputAssistantContent(string? value)
        {
            DecisionInputAssistantContentVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputAssistantContent FromDecisionInputAssistantContentVariant1(string? value) => new DecisionInputAssistantContent(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInputAssistantContent(
            string? decisionInputAssistantContentVariant1,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>? parts
            )
        {
            DecisionInputAssistantContentVariant1 = decisionInputAssistantContentVariant1;
            Parts = parts;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Parts as object ??
            DecisionInputAssistantContentVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DecisionInputAssistantContentVariant1?.ToString() ??
            Parts?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDecisionInputAssistantContentVariant1 && !IsParts || !IsDecisionInputAssistantContentVariant1 && IsParts;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? decisionInputAssistantContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>, TResult>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputAssistantContentVariant1 is { } __value0 && decisionInputAssistantContentVariant1 != null)
            {
                return decisionInputAssistantContentVariant1(__value0);
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
            global::System.Action<string>? decisionInputAssistantContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputAssistantContentVariant1 is { } __value0)
            {
                decisionInputAssistantContentVariant1?.Invoke(__value0);
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
            global::System.Action<string>? decisionInputAssistantContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>>? parts = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputAssistantContentVariant1 is { } __value0)
            {
                decisionInputAssistantContentVariant1?.Invoke(__value0);
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
                DecisionInputAssistantContentVariant1,
                typeof(string),
                Parts,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>),
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
        public bool Equals(DecisionInputAssistantContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DecisionInputAssistantContentVariant1, other.DecisionInputAssistantContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputAssistantContentPartsItem>?>.Default.Equals(Parts, other.Parts)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInputAssistantContent obj1, DecisionInputAssistantContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInputAssistantContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInputAssistantContent obj1, DecisionInputAssistantContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInputAssistantContent o && Equals(o);
        }
    }
}
