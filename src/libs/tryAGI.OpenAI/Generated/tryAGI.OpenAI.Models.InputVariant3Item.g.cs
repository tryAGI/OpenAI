#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputVariant3Item : global::System.IEquatable<InputVariant3Item>
    {
        /// <summary>
        /// An object describing an image to classify.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ModerationImageURLInput? ModerationImageURL { get; init; }
#else
        public global::tryAGI.OpenAI.ModerationImageURLInput? ModerationImageURL { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModerationImageURL))]
#endif
        public bool IsModerationImageURL => ModerationImageURL != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant3Item(global::tryAGI.OpenAI.ModerationImageURLInput value) => new InputVariant3Item((global::tryAGI.OpenAI.ModerationImageURLInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModerationImageURLInput?(InputVariant3Item @this) => @this.ModerationImageURL;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant3Item(global::tryAGI.OpenAI.ModerationImageURLInput? value)
        {
            ModerationImageURL = value;
        }

        /// <summary>
        /// An object describing text to classify.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ModerationTextInput? ModerationText { get; init; }
#else
        public global::tryAGI.OpenAI.ModerationTextInput? ModerationText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModerationText))]
#endif
        public bool IsModerationText => ModerationText != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant3Item(global::tryAGI.OpenAI.ModerationTextInput value) => new InputVariant3Item((global::tryAGI.OpenAI.ModerationTextInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ModerationTextInput?(InputVariant3Item @this) => @this.ModerationText;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant3Item(global::tryAGI.OpenAI.ModerationTextInput? value)
        {
            ModerationText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputVariant3Item(
            global::tryAGI.OpenAI.ModerationImageURLInput? moderationImageURL,
            global::tryAGI.OpenAI.ModerationTextInput? moderationText
            )
        {
            ModerationImageURL = moderationImageURL;
            ModerationText = moderationText;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ModerationText as object ??
            ModerationImageURL as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModerationImageURL?.ToString() ??
            ModerationText?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModerationImageURL || IsModerationText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ModerationImageURLInput?, TResult>? moderationImageURL = null,
            global::System.Func<global::tryAGI.OpenAI.ModerationTextInput?, TResult>? moderationText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationImageURL && moderationImageURL != null)
            {
                return moderationImageURL(ModerationImageURL!);
            }
            else if (IsModerationText && moderationText != null)
            {
                return moderationText(ModerationText!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ModerationImageURLInput?>? moderationImageURL = null,
            global::System.Action<global::tryAGI.OpenAI.ModerationTextInput?>? moderationText = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationImageURL)
            {
                moderationImageURL?.Invoke(ModerationImageURL!);
            }
            else if (IsModerationText)
            {
                moderationText?.Invoke(ModerationText!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModerationImageURL,
                typeof(global::tryAGI.OpenAI.ModerationImageURLInput),
                ModerationText,
                typeof(global::tryAGI.OpenAI.ModerationTextInput),
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
        public bool Equals(InputVariant3Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModerationImageURLInput?>.Default.Equals(ModerationImageURL, other.ModerationImageURL) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ModerationTextInput?>.Default.Equals(ModerationText, other.ModerationText) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputVariant3Item obj1, InputVariant3Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputVariant3Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputVariant3Item obj1, InputVariant3Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputVariant3Item o && Equals(o);
        }
    }
}
