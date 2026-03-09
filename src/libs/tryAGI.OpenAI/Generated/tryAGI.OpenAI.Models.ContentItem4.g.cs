#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Content blocks that comprise a user message.
    /// </summary>
    public readonly partial struct ContentItem4 : global::System.IEquatable<ContentItem4>
    {
        /// <summary>
        /// Text block that a user contributed to the thread.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UserMessageInputText? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.UserMessageInputText? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        /// Quoted snippet that the user referenced in their message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UserMessageQuotedText? QuotedText { get; init; }
#else
        public global::tryAGI.OpenAI.UserMessageQuotedText? QuotedText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QuotedText))]
#endif
        public bool IsQuotedText => QuotedText != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem4(global::tryAGI.OpenAI.UserMessageInputText value) => new ContentItem4((global::tryAGI.OpenAI.UserMessageInputText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UserMessageInputText?(ContentItem4 @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem4(global::tryAGI.OpenAI.UserMessageInputText? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem4(global::tryAGI.OpenAI.UserMessageQuotedText value) => new ContentItem4((global::tryAGI.OpenAI.UserMessageQuotedText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UserMessageQuotedText?(ContentItem4 @this) => @this.QuotedText;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem4(global::tryAGI.OpenAI.UserMessageQuotedText? value)
        {
            QuotedText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentItem4(
            global::tryAGI.OpenAI.UserMessageInputText? inputText,
            global::tryAGI.OpenAI.UserMessageQuotedText? quotedText
            )
        {
            InputText = inputText;
            QuotedText = quotedText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            QuotedText as object ??
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            QuotedText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsQuotedText || !IsInputText && IsQuotedText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.UserMessageInputText?, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.UserMessageQuotedText?, TResult>? quotedText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsQuotedText && quotedText != null)
            {
                return quotedText(QuotedText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.UserMessageInputText?>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.UserMessageQuotedText?>? quotedText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsQuotedText)
            {
                quotedText?.Invoke(QuotedText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::tryAGI.OpenAI.UserMessageInputText),
                QuotedText,
                typeof(global::tryAGI.OpenAI.UserMessageQuotedText),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UserMessageInputText?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UserMessageQuotedText?>.Default.Equals(QuotedText, other.QuotedText) 
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
