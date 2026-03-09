#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputContent : global::System.IEquatable<OutputContent>
    {
        /// <summary>
        /// A text output from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OutputTextContent? OutputText { get; init; }
#else
        public global::tryAGI.OpenAI.OutputTextContent? OutputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputText))]
#endif
        public bool IsOutputText => OutputText != null;

        /// <summary>
        /// A refusal from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RefusalContent? Refusal { get; init; }
#else
        public global::tryAGI.OpenAI.RefusalContent? Refusal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        /// Reasoning text from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ReasoningTextContent? ReasoningText { get; init; }
#else
        public global::tryAGI.OpenAI.ReasoningTextContent? ReasoningText { get; }
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
        public static implicit operator OutputContent(global::tryAGI.OpenAI.OutputTextContent value) => new OutputContent((global::tryAGI.OpenAI.OutputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputTextContent?(OutputContent @this) => @this.OutputText;

        /// <summary>
        /// 
        /// </summary>
        public OutputContent(global::tryAGI.OpenAI.OutputTextContent? value)
        {
            OutputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContent(global::tryAGI.OpenAI.RefusalContent value) => new OutputContent((global::tryAGI.OpenAI.RefusalContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RefusalContent?(OutputContent @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public OutputContent(global::tryAGI.OpenAI.RefusalContent? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContent(global::tryAGI.OpenAI.ReasoningTextContent value) => new OutputContent((global::tryAGI.OpenAI.ReasoningTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ReasoningTextContent?(OutputContent @this) => @this.ReasoningText;

        /// <summary>
        /// 
        /// </summary>
        public OutputContent(global::tryAGI.OpenAI.ReasoningTextContent? value)
        {
            ReasoningText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputContent(
            global::tryAGI.OpenAI.OutputTextContent? outputText,
            global::tryAGI.OpenAI.RefusalContent? refusal,
            global::tryAGI.OpenAI.ReasoningTextContent? reasoningText
            )
        {
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
            global::System.Func<global::tryAGI.OpenAI.OutputTextContent?, TResult>? outputText = null,
            global::System.Func<global::tryAGI.OpenAI.RefusalContent?, TResult>? refusal = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningTextContent?, TResult>? reasoningText = null,
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
            global::System.Action<global::tryAGI.OpenAI.OutputTextContent?>? outputText = null,
            global::System.Action<global::tryAGI.OpenAI.RefusalContent?>? refusal = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningTextContent?>? reasoningText = null,
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
                typeof(global::tryAGI.OpenAI.OutputTextContent),
                Refusal,
                typeof(global::tryAGI.OpenAI.RefusalContent),
                ReasoningText,
                typeof(global::tryAGI.OpenAI.ReasoningTextContent),
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
        public bool Equals(OutputContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputTextContent?>.Default.Equals(OutputText, other.OutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RefusalContent?>.Default.Equals(Refusal, other.Refusal) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningTextContent?>.Default.Equals(ReasoningText, other.ReasoningText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputContent obj1, OutputContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputContent obj1, OutputContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputContent o && Equals(o);
        }
    }
}
