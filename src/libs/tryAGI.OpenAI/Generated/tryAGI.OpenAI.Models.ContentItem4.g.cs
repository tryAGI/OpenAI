#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentItem4 : global::System.IEquatable<ContentItem4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Assistant text supplied as conversation history when starting a Live session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParam? Text { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParam? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveInitialTextContentPartParam? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialTextContentPartParam PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Assistant output text supplied as conversation history when starting a Live session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? OutputText { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? OutputText { get; }
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
            out global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? value)
        {
            value = OutputText;
            return IsOutputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam PickOutputText() => IsOutputText
            ? OutputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputText' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::tryAGI.OpenAI.LiveInitialTextContentPartParam value) => new ContentItem4((global::tryAGI.OpenAI.LiveInitialTextContentPartParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInitialTextContentPartParam?(ContentItem4 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::tryAGI.OpenAI.LiveInitialTextContentPartParam? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromText(global::tryAGI.OpenAI.LiveInitialTextContentPartParam? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem4(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam value) => new ContentItem4((global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam?(ContentItem4 @this) => @this.OutputText;

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? value)
        {
            OutputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem4 FromOutputText(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? value) => new ContentItem4(value);

        /// <summary>
        ///
        /// </summary>
        public ContentItem4(
            global::tryAGI.OpenAI.LiveInitialAssistantMessageItemParamContentItemDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveInitialTextContentPartParam? text,
            global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam? outputText
            )
        {
            Type = type;

            Text = text;
            OutputText = outputText;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputText as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            OutputText?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsOutputText || !IsText && IsOutputText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveInitialTextContentPartParam, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam, TResult>? outputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsOutputText && outputText != null)
            {
                return outputText(OutputText!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveInitialTextContentPartParam>? text = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam>? outputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveInitialTextContentPartParam>? text = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam>? outputText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::tryAGI.OpenAI.LiveInitialTextContentPartParam),
                OutputText,
                typeof(global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam),
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
        public bool Equals(ContentItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInitialTextContentPartParam?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInitialOutputTextContentPartParam?>.Default.Equals(OutputText, other.OutputText)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentItem4 obj1, ContentItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentItem4 obj1, ContentItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem4 o && Equals(o);
        }
    }
}
