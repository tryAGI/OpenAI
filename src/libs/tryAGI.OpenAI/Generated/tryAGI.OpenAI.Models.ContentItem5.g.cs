#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A plaintext, image, or encrypted agent message content part.
    /// </summary>
    public readonly partial struct ContentItem5 : global::System.IEquatable<ContentItem5>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputTextContentParam? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputTextContentParam? InputText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaInputTextContentParam? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputTextContentParam PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

        /// <summary>
        /// An image input to the model. Learn about [image inputs](/docs/guides/vision)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? InputImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

        /// <summary>
        /// Opaque encrypted content that Responses API decrypts inside trusted model execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaEncryptedContentParam? EncryptedContent { get; init; }
#else
        public global::tryAGI.OpenAI.BetaEncryptedContentParam? EncryptedContent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EncryptedContent))]
#endif
        public bool IsEncryptedContent => EncryptedContent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEncryptedContent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaEncryptedContentParam? value)
        {
            value = EncryptedContent;
            return IsEncryptedContent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaEncryptedContentParam PickEncryptedContent() => IsEncryptedContent
            ? EncryptedContent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EncryptedContent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem5(global::tryAGI.OpenAI.BetaInputTextContentParam value) => new ContentItem5((global::tryAGI.OpenAI.BetaInputTextContentParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputTextContentParam?(ContentItem5 @this) => @this.InputText;

        /// <summary>
        ///
        /// </summary>
        public ContentItem5(global::tryAGI.OpenAI.BetaInputTextContentParam? value)
        {
            InputText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem5 FromInputText(global::tryAGI.OpenAI.BetaInputTextContentParam? value) => new ContentItem5(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem5(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam value) => new ContentItem5((global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam?(ContentItem5 @this) => @this.InputImage;

        /// <summary>
        ///
        /// </summary>
        public ContentItem5(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? value)
        {
            InputImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem5 FromInputImage(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? value) => new ContentItem5(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem5(global::tryAGI.OpenAI.BetaEncryptedContentParam value) => new ContentItem5((global::tryAGI.OpenAI.BetaEncryptedContentParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaEncryptedContentParam?(ContentItem5 @this) => @this.EncryptedContent;

        /// <summary>
        ///
        /// </summary>
        public ContentItem5(global::tryAGI.OpenAI.BetaEncryptedContentParam? value)
        {
            EncryptedContent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem5 FromEncryptedContent(global::tryAGI.OpenAI.BetaEncryptedContentParam? value) => new ContentItem5(value);

        /// <summary>
        ///
        /// </summary>
        public ContentItem5(
            global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaInputTextContentParam? inputText,
            global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam? inputImage,
            global::tryAGI.OpenAI.BetaEncryptedContentParam? encryptedContent
            )
        {
            Type = type;

            InputText = inputText;
            InputImage = inputImage;
            EncryptedContent = encryptedContent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EncryptedContent as object ??
            InputImage as object ??
            InputText as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            InputImage?.ToString() ??
            EncryptedContent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputText && !IsInputImage && !IsEncryptedContent || !IsInputText && IsInputImage && !IsEncryptedContent || !IsInputText && !IsInputImage && IsEncryptedContent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaInputTextContentParam, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.BetaEncryptedContentParam, TResult>? encryptedContent = null,
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
            else if (IsInputImage && inputImage != null)
            {
                return inputImage(InputImage!);
            }
            else if (IsEncryptedContent && encryptedContent != null)
            {
                return encryptedContent(EncryptedContent!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaInputTextContentParam>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam>? inputImage = null,

            global::System.Action<global::tryAGI.OpenAI.BetaEncryptedContentParam>? encryptedContent = null,
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
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsEncryptedContent)
            {
                encryptedContent?.Invoke(EncryptedContent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaInputTextContentParam>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.BetaEncryptedContentParam>? encryptedContent = null,
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
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsEncryptedContent)
            {
                encryptedContent?.Invoke(EncryptedContent!);
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
                typeof(global::tryAGI.OpenAI.BetaInputTextContentParam),
                InputImage,
                typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam),
                EncryptedContent,
                typeof(global::tryAGI.OpenAI.BetaEncryptedContentParam),
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
        public bool Equals(ContentItem5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputTextContentParam?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaEncryptedContentParam?>.Default.Equals(EncryptedContent, other.EncryptedContent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentItem5 obj1, ContentItem5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentItem5 obj1, ContentItem5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem5 o && Equals(o);
        }
    }
}
