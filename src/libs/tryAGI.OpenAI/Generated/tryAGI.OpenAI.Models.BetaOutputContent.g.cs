#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaOutputContent : global::System.IEquatable<BetaOutputContent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType? Type { get; }

        /// <summary>
        /// A text output from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaOutputTextContent? OutputText { get; init; }
#else
        public global::tryAGI.OpenAI.BetaOutputTextContent? OutputText { get; }
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
            out global::tryAGI.OpenAI.BetaOutputTextContent? value)
        {
            value = OutputText;
            return IsOutputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContent PickOutputText() => IsOutputText
            ? OutputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputText' but the value was {ToString()}.");

        /// <summary>
        /// A refusal from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaRefusalContent? Refusal { get; init; }
#else
        public global::tryAGI.OpenAI.BetaRefusalContent? Refusal { get; }
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
            out global::tryAGI.OpenAI.BetaRefusalContent? value)
        {
            value = Refusal;
            return IsRefusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaRefusalContent PickRefusal() => IsRefusal
            ? Refusal!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Refusal' but the value was {ToString()}.");

        /// <summary>
        /// Reasoning text from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaReasoningTextContent? ReasoningText { get; init; }
#else
        public global::tryAGI.OpenAI.BetaReasoningTextContent? ReasoningText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningText))]
#endif
        public bool IsReasoningText => ReasoningText != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaReasoningTextContent? value)
        {
            value = ReasoningText;
            return IsReasoningText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaReasoningTextContent PickReasoningText() => IsReasoningText
            ? ReasoningText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningText' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaOutputContent(global::tryAGI.OpenAI.BetaOutputTextContent value) => new BetaOutputContent((global::tryAGI.OpenAI.BetaOutputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaOutputTextContent?(BetaOutputContent @this) => @this.OutputText;

        /// <summary>
        /// 
        /// </summary>
        public BetaOutputContent(global::tryAGI.OpenAI.BetaOutputTextContent? value)
        {
            OutputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaOutputContent FromOutputText(global::tryAGI.OpenAI.BetaOutputTextContent? value) => new BetaOutputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaOutputContent(global::tryAGI.OpenAI.BetaRefusalContent value) => new BetaOutputContent((global::tryAGI.OpenAI.BetaRefusalContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaRefusalContent?(BetaOutputContent @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public BetaOutputContent(global::tryAGI.OpenAI.BetaRefusalContent? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaOutputContent FromRefusal(global::tryAGI.OpenAI.BetaRefusalContent? value) => new BetaOutputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaOutputContent(global::tryAGI.OpenAI.BetaReasoningTextContent value) => new BetaOutputContent((global::tryAGI.OpenAI.BetaReasoningTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaReasoningTextContent?(BetaOutputContent @this) => @this.ReasoningText;

        /// <summary>
        /// 
        /// </summary>
        public BetaOutputContent(global::tryAGI.OpenAI.BetaReasoningTextContent? value)
        {
            ReasoningText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaOutputContent FromReasoningText(global::tryAGI.OpenAI.BetaReasoningTextContent? value) => new BetaOutputContent(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaOutputContent(
            global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaOutputTextContent? outputText,
            global::tryAGI.OpenAI.BetaRefusalContent? refusal,
            global::tryAGI.OpenAI.BetaReasoningTextContent? reasoningText
            )
        {
            Type = type;

            OutputText = outputText;
            Refusal = refusal;
            ReasoningText = reasoningText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReasoningText as object ??
            Refusal as object ??
            OutputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputText?.ToString() ??
            Refusal?.ToString() ??
            ReasoningText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputText && !IsRefusal && !IsReasoningText || !IsOutputText && IsRefusal && !IsReasoningText || !IsOutputText && !IsRefusal && IsReasoningText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaOutputTextContent, TResult>? outputText = null,
            global::System.Func<global::tryAGI.OpenAI.BetaRefusalContent, TResult>? refusal = null,
            global::System.Func<global::tryAGI.OpenAI.BetaReasoningTextContent, TResult>? reasoningText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputText && outputText != null)
            {
                return outputText(OutputText!);
            }
            else if (IsRefusal && refusal != null)
            {
                return refusal(Refusal!);
            }
            else if (IsReasoningText && reasoningText != null)
            {
                return reasoningText(ReasoningText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaOutputTextContent>? outputText = null,

            global::System.Action<global::tryAGI.OpenAI.BetaRefusalContent>? refusal = null,

            global::System.Action<global::tryAGI.OpenAI.BetaReasoningTextContent>? reasoningText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
            }
            else if (IsReasoningText)
            {
                reasoningText?.Invoke(ReasoningText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaOutputTextContent>? outputText = null,
            global::System.Action<global::tryAGI.OpenAI.BetaRefusalContent>? refusal = null,
            global::System.Action<global::tryAGI.OpenAI.BetaReasoningTextContent>? reasoningText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
            }
            else if (IsReasoningText)
            {
                reasoningText?.Invoke(ReasoningText!);
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
                typeof(global::tryAGI.OpenAI.BetaOutputTextContent),
                Refusal,
                typeof(global::tryAGI.OpenAI.BetaRefusalContent),
                ReasoningText,
                typeof(global::tryAGI.OpenAI.BetaReasoningTextContent),
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
        public bool Equals(BetaOutputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaOutputTextContent?>.Default.Equals(OutputText, other.OutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaRefusalContent?>.Default.Equals(Refusal, other.Refusal) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaReasoningTextContent?>.Default.Equals(ReasoningText, other.ReasoningText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaOutputContent obj1, BetaOutputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaOutputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaOutputContent obj1, BetaOutputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaOutputContent o && Equals(o);
        }
    }
}
