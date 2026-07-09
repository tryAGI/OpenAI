#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaOutputMessageContent : global::System.IEquatable<BetaOutputMessageContent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType? Type { get; }

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
        /// 
        /// </summary>
        public static implicit operator BetaOutputMessageContent(global::tryAGI.OpenAI.BetaOutputTextContent value) => new BetaOutputMessageContent((global::tryAGI.OpenAI.BetaOutputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaOutputTextContent?(BetaOutputMessageContent @this) => @this.OutputText;

        /// <summary>
        /// 
        /// </summary>
        public BetaOutputMessageContent(global::tryAGI.OpenAI.BetaOutputTextContent? value)
        {
            OutputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaOutputMessageContent FromOutputText(global::tryAGI.OpenAI.BetaOutputTextContent? value) => new BetaOutputMessageContent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaOutputMessageContent(global::tryAGI.OpenAI.BetaRefusalContent value) => new BetaOutputMessageContent((global::tryAGI.OpenAI.BetaRefusalContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaRefusalContent?(BetaOutputMessageContent @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public BetaOutputMessageContent(global::tryAGI.OpenAI.BetaRefusalContent? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaOutputMessageContent FromRefusal(global::tryAGI.OpenAI.BetaRefusalContent? value) => new BetaOutputMessageContent(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaOutputMessageContent(
            global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaOutputTextContent? outputText,
            global::tryAGI.OpenAI.BetaRefusalContent? refusal
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
            global::System.Func<global::tryAGI.OpenAI.BetaOutputTextContent, TResult>? outputText = null,
            global::System.Func<global::tryAGI.OpenAI.BetaRefusalContent, TResult>? refusal = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaOutputTextContent>? outputText = null,

            global::System.Action<global::tryAGI.OpenAI.BetaRefusalContent>? refusal = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaOutputTextContent>? outputText = null,
            global::System.Action<global::tryAGI.OpenAI.BetaRefusalContent>? refusal = null,
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
        public bool Equals(BetaOutputMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaOutputTextContent?>.Default.Equals(OutputText, other.OutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaRefusalContent?>.Default.Equals(Refusal, other.Refusal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaOutputMessageContent obj1, BetaOutputMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaOutputMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaOutputMessageContent obj1, BetaOutputMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaOutputMessageContent o && Equals(o);
        }
    }
}
