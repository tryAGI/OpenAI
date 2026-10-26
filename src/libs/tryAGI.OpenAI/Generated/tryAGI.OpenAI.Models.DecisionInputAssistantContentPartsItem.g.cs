#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DecisionInputAssistantContentPartsItem : global::System.IEquatable<DecisionInputAssistantContentPartsItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputAssistantContentPartDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputOutputText? OutputText { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputOutputText? OutputText { get; }
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
            out global::tryAGI.OpenAI.DecisionInputOutputText? value)
        {
            value = OutputText;
            return IsOutputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputOutputText PickOutputText() => OutputText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.DecisionInputRefusal? Refusal { get; init; }
#else
        public global::tryAGI.OpenAI.DecisionInputRefusal? Refusal { get; }
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
            out global::tryAGI.OpenAI.DecisionInputRefusal? value)
        {
            value = Refusal;
            return IsRefusal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.DecisionInputRefusal PickRefusal() => Refusal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Refusal' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputAssistantContentPartsItem(global::tryAGI.OpenAI.DecisionInputOutputText value) => new DecisionInputAssistantContentPartsItem((global::tryAGI.OpenAI.DecisionInputOutputText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputOutputText?(DecisionInputAssistantContentPartsItem @this) => @this.OutputText;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputAssistantContentPartsItem(global::tryAGI.OpenAI.DecisionInputOutputText? value)
        {
            OutputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputAssistantContentPartsItem FromOutputText(global::tryAGI.OpenAI.DecisionInputOutputText? value) => new DecisionInputAssistantContentPartsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInputAssistantContentPartsItem(global::tryAGI.OpenAI.DecisionInputRefusal value) => new DecisionInputAssistantContentPartsItem((global::tryAGI.OpenAI.DecisionInputRefusal?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.DecisionInputRefusal?(DecisionInputAssistantContentPartsItem @this) => @this.Refusal;

        /// <summary>
        ///
        /// </summary>
        public DecisionInputAssistantContentPartsItem(global::tryAGI.OpenAI.DecisionInputRefusal? value)
        {
            Refusal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInputAssistantContentPartsItem FromRefusal(global::tryAGI.OpenAI.DecisionInputRefusal? value) => new DecisionInputAssistantContentPartsItem(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInputAssistantContentPartsItem(
            global::tryAGI.OpenAI.DecisionInputAssistantContentPartDiscriminatorType? type,
            global::tryAGI.OpenAI.DecisionInputOutputText? outputText,
            global::tryAGI.OpenAI.DecisionInputRefusal? refusal
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
            global::System.Func<global::tryAGI.OpenAI.DecisionInputOutputText, TResult>? outputText = null,
            global::System.Func<global::tryAGI.OpenAI.DecisionInputRefusal, TResult>? refusal = null,
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
            global::System.Action<global::tryAGI.OpenAI.DecisionInputOutputText>? outputText = null,

            global::System.Action<global::tryAGI.OpenAI.DecisionInputRefusal>? refusal = null,
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
            global::System.Action<global::tryAGI.OpenAI.DecisionInputOutputText>? outputText = null,
            global::System.Action<global::tryAGI.OpenAI.DecisionInputRefusal>? refusal = null,
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
                typeof(global::tryAGI.OpenAI.DecisionInputOutputText),
                Refusal,
                typeof(global::tryAGI.OpenAI.DecisionInputRefusal),
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
        public bool Equals(DecisionInputAssistantContentPartsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputOutputText?>.Default.Equals(OutputText, other.OutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.DecisionInputRefusal?>.Default.Equals(Refusal, other.Refusal)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInputAssistantContentPartsItem obj1, DecisionInputAssistantContentPartsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInputAssistantContentPartsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInputAssistantContentPartsItem obj1, DecisionInputAssistantContentPartsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInputAssistantContentPartsItem o && Equals(o);
        }
    }
}
