#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The text or images to evaluate for every question. Provide a text string or user messages containing text and images. Images can be base64 data URLs or publicly accessible HTTP(S) URLs; at most 128 images are allowed across all messages in one request. Files, audio, tools, and item references are not supported.
    /// </summary>
    public readonly partial struct DecisionInput : global::System.IEquatable<DecisionInput>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DecisionInputVariant1 { get; init; }
#else
        public string? DecisionInputVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionInputVariant1))]
#endif
        public bool IsDecisionInputVariant1 => DecisionInputVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionInputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DecisionInputVariant1;
            return IsDecisionInputVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickDecisionInputVariant1() => DecisionInputVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionInputVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>? DecisionInputVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>? DecisionInputVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionInputVariant2))]
#endif
        public bool IsDecisionInputVariant2 => DecisionInputVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionInputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>? value)
        {
            value = DecisionInputVariant2;
            return IsDecisionInputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item> PickDecisionInputVariant2() => DecisionInputVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionInputVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInput(string value) => new DecisionInput((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(DecisionInput @this) => @this.DecisionInputVariant1;

        /// <summary>
        ///
        /// </summary>
        public DecisionInput(string? value)
        {
            DecisionInputVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInput FromDecisionInputVariant1(string? value) => new DecisionInput(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInput(
            string? decisionInputVariant1,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>? decisionInputVariant2
            )
        {
            DecisionInputVariant1 = decisionInputVariant1;
            DecisionInputVariant2 = decisionInputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DecisionInputVariant2 as object ??
            DecisionInputVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DecisionInputVariant1?.ToString() ??
            DecisionInputVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDecisionInputVariant1 && !IsDecisionInputVariant2 || !IsDecisionInputVariant1 && IsDecisionInputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? decisionInputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>, TResult>? decisionInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputVariant1 is { } __value0 && decisionInputVariant1 != null)
            {
                return decisionInputVariant1(__value0);
            }
            else if (DecisionInputVariant2 is { } __value1 && decisionInputVariant2 != null)
            {
                return decisionInputVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? decisionInputVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>>? decisionInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputVariant1 is { } __value0)
            {
                decisionInputVariant1?.Invoke(__value0);
            }
            else if (DecisionInputVariant2 is { } __value1)
            {
                decisionInputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? decisionInputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>>? decisionInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (DecisionInputVariant1 is { } __value0)
            {
                decisionInputVariant1?.Invoke(__value0);
            }
            else if (DecisionInputVariant2 is { } __value1)
            {
                decisionInputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DecisionInputVariant1,
                typeof(string),
                DecisionInputVariant2,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>),
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
        public bool Equals(DecisionInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DecisionInputVariant1, other.DecisionInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionInputVariant2Item>?>.Default.Equals(DecisionInputVariant2, other.DecisionInputVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInput obj1, DecisionInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInput obj1, DecisionInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInput o && Equals(o);
        }
    }
}
