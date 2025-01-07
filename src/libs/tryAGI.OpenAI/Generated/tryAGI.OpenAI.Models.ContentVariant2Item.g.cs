#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant2Item : global::System.IEquatable<ContentVariant2Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.CreateMessageRequestContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// References an image [File](/docs/api-reference/files) in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentImageFileObject? ImageFile { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentImageFileObject? ImageFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageFile))]
#endif
        public bool IsImageFile => ImageFile != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::tryAGI.OpenAI.MessageContentImageFileObject value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentImageFileObject?(ContentVariant2Item @this) => @this.ImageFile;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::tryAGI.OpenAI.MessageContentImageFileObject? value)
        {
            ImageFile = value;
        }

        /// <summary>
        /// References an image URL in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentImageUrlObject? ImageUrl { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentImageUrlObject? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::tryAGI.OpenAI.MessageContentImageUrlObject value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentImageUrlObject?(ContentVariant2Item @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::tryAGI.OpenAI.MessageContentImageUrlObject? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// The text content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageRequestContentTextObject? Text { get; init; }
#else
        public global::tryAGI.OpenAI.MessageRequestContentTextObject? Text { get; }
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
        public static implicit operator ContentVariant2Item(global::tryAGI.OpenAI.MessageRequestContentTextObject value) => new ContentVariant2Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageRequestContentTextObject?(ContentVariant2Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::tryAGI.OpenAI.MessageRequestContentTextObject? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(
            global::tryAGI.OpenAI.CreateMessageRequestContentVariant2ItemDiscriminatorType? type,
            global::tryAGI.OpenAI.MessageContentImageFileObject? imageFile,
            global::tryAGI.OpenAI.MessageContentImageUrlObject? imageUrl,
            global::tryAGI.OpenAI.MessageRequestContentTextObject? text
            )
        {
            Type = type;

            ImageFile = imageFile;
            ImageUrl = imageUrl;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            ImageUrl as object ??
            ImageFile as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageFile && !IsImageUrl && !IsText || !IsImageFile && IsImageUrl && !IsText || !IsImageFile && !IsImageUrl && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.MessageContentImageFileObject?, TResult>? imageFile = null,
            global::System.Func<global::tryAGI.OpenAI.MessageContentImageUrlObject?, TResult>? imageUrl = null,
            global::System.Func<global::tryAGI.OpenAI.MessageRequestContentTextObject?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageFile && imageFile != null)
            {
                return imageFile(ImageFile!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.MessageContentImageFileObject?>? imageFile = null,
            global::System.Action<global::tryAGI.OpenAI.MessageContentImageUrlObject?>? imageUrl = null,
            global::System.Action<global::tryAGI.OpenAI.MessageRequestContentTextObject?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageFile)
            {
                imageFile?.Invoke(ImageFile!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageFile,
                typeof(global::tryAGI.OpenAI.MessageContentImageFileObject),
                ImageUrl,
                typeof(global::tryAGI.OpenAI.MessageContentImageUrlObject),
                Text,
                typeof(global::tryAGI.OpenAI.MessageRequestContentTextObject),
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
        public bool Equals(ContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentImageFileObject?>.Default.Equals(ImageFile, other.ImageFile) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentImageUrlObject?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageRequestContentTextObject?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item o && Equals(o);
        }
    }
}
