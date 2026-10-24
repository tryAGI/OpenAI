#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentVariant2Item2 : global::System.IEquatable<ContentVariant2Item2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionOutputTextParam? OutputText { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionOutputTextParam? OutputText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputText))]
#endif
        public bool IsOutputText => OutputText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDecisionOutputTextParam? value)
        {
            value = OutputText;
            return IsOutputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionOutputTextParam PickOutputText() => OutputText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveDecisionRefusalParam? Refusal { get; init; }
#else
        public global::tryAGI.OpenAI.LiveDecisionRefusalParam? Refusal { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefusal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveDecisionRefusalParam? value)
        {
            value = Refusal;
            return IsRefusal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveDecisionRefusalParam PickRefusal() => Refusal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Refusal' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item2(global::tryAGI.OpenAI.LiveDecisionOutputTextParam value) => new ContentVariant2Item2((global::tryAGI.OpenAI.LiveDecisionOutputTextParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionOutputTextParam?(ContentVariant2Item2 @this) => @this.OutputText;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item2(global::tryAGI.OpenAI.LiveDecisionOutputTextParam? value)
        {
            OutputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item2 FromOutputText(global::tryAGI.OpenAI.LiveDecisionOutputTextParam? value) => new ContentVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentVariant2Item2(global::tryAGI.OpenAI.LiveDecisionRefusalParam value) => new ContentVariant2Item2((global::tryAGI.OpenAI.LiveDecisionRefusalParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDecisionRefusalParam?(ContentVariant2Item2 @this) => @this.Refusal;

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item2(global::tryAGI.OpenAI.LiveDecisionRefusalParam? value)
        {
            Refusal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentVariant2Item2 FromRefusal(global::tryAGI.OpenAI.LiveDecisionRefusalParam? value) => new ContentVariant2Item2(value);

        /// <summary>
        ///
        /// </summary>
        public ContentVariant2Item2(
            global::tryAGI.OpenAI.LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveDecisionOutputTextParam? outputText,
            global::tryAGI.OpenAI.LiveDecisionRefusalParam? refusal
            )
        {
            Type = type;

            OutputText = outputText;
            Refusal = refusal;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Refusal as object ??
            OutputText as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OutputText?.ToString() ??
            Refusal?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutputText && !IsRefusal || !IsOutputText && IsRefusal;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionOutputTextParam, TResult>? outputText = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDecisionRefusalParam, TResult>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputText is { } __value0 && outputText != null)
            {
                return outputText(__value0);
            }
            else if (Refusal is { } __value1 && refusal != null)
            {
                return refusal(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionOutputTextParam>? outputText = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDecisionRefusalParam>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputText is { } __value0)
            {
                outputText?.Invoke(__value0);
            }
            else if (Refusal is { } __value1)
            {
                refusal?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionOutputTextParam>? outputText = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDecisionRefusalParam>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputText is { } __value0)
            {
                outputText?.Invoke(__value0);
            }
            else if (Refusal is { } __value1)
            {
                refusal?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputText,
                typeof(global::tryAGI.OpenAI.LiveDecisionOutputTextParam),
                Refusal,
                typeof(global::tryAGI.OpenAI.LiveDecisionRefusalParam),
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
        public bool Equals(ContentVariant2Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionOutputTextParam?>.Default.Equals(OutputText, other.OutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDecisionRefusalParam?>.Default.Equals(Refusal, other.Refusal)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentVariant2Item2 obj1, ContentVariant2Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentVariant2Item2 obj1, ContentVariant2Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item2 o && Equals(o);
        }
    }
}
