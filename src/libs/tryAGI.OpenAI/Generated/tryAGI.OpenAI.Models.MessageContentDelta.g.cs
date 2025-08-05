#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageContentDelta : global::System.IEquatable<MessageContentDelta>
    {
        /// <summary>
        /// References an image [File](https://platform.openai.com/docs/api-reference/files) in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObject? ImageFileObject { get; init; }
#else
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObject? ImageFileObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageFileObject))]
#endif
        public bool IsImageFileObject => ImageFileObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageContentDelta(global::tryAGI.OpenAI.MessageDeltaContentImageFileObject value) => new MessageContentDelta((global::tryAGI.OpenAI.MessageDeltaContentImageFileObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageDeltaContentImageFileObject?(MessageContentDelta @this) => @this.ImageFileObject;

        /// <summary>
        /// 
        /// </summary>
        public MessageContentDelta(global::tryAGI.OpenAI.MessageDeltaContentImageFileObject? value)
        {
            ImageFileObject = value;
        }

        /// <summary>
        /// The text content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageDeltaContentTextObject? TextObject { get; init; }
#else
        public global::tryAGI.OpenAI.MessageDeltaContentTextObject? TextObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextObject))]
#endif
        public bool IsTextObject => TextObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageContentDelta(global::tryAGI.OpenAI.MessageDeltaContentTextObject value) => new MessageContentDelta((global::tryAGI.OpenAI.MessageDeltaContentTextObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageDeltaContentTextObject?(MessageContentDelta @this) => @this.TextObject;

        /// <summary>
        /// 
        /// </summary>
        public MessageContentDelta(global::tryAGI.OpenAI.MessageDeltaContentTextObject? value)
        {
            TextObject = value;
        }

        /// <summary>
        /// The refusal content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObject? RefusalObject { get; init; }
#else
        public global::tryAGI.OpenAI.MessageDeltaContentRefusalObject? RefusalObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalObject))]
#endif
        public bool IsRefusalObject => RefusalObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageContentDelta(global::tryAGI.OpenAI.MessageDeltaContentRefusalObject value) => new MessageContentDelta((global::tryAGI.OpenAI.MessageDeltaContentRefusalObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageDeltaContentRefusalObject?(MessageContentDelta @this) => @this.RefusalObject;

        /// <summary>
        /// 
        /// </summary>
        public MessageContentDelta(global::tryAGI.OpenAI.MessageDeltaContentRefusalObject? value)
        {
            RefusalObject = value;
        }

        /// <summary>
        /// References an image URL in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject? ImageUrlObject { get; init; }
#else
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject? ImageUrlObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrlObject))]
#endif
        public bool IsImageUrlObject => ImageUrlObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageContentDelta(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject value) => new MessageContentDelta((global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject?(MessageContentDelta @this) => @this.ImageUrlObject;

        /// <summary>
        /// 
        /// </summary>
        public MessageContentDelta(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject? value)
        {
            ImageUrlObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageContentDelta(
            global::tryAGI.OpenAI.MessageDeltaContentImageFileObject? imageFileObject,
            global::tryAGI.OpenAI.MessageDeltaContentTextObject? textObject,
            global::tryAGI.OpenAI.MessageDeltaContentRefusalObject? refusalObject,
            global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject? imageUrlObject
            )
        {
            ImageFileObject = imageFileObject;
            TextObject = textObject;
            RefusalObject = refusalObject;
            ImageUrlObject = imageUrlObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageUrlObject as object ??
            RefusalObject as object ??
            TextObject as object ??
            ImageFileObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImageFileObject?.ToString() ??
            TextObject?.ToString() ??
            RefusalObject?.ToString() ??
            ImageUrlObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageFileObject || IsTextObject || IsRefusalObject || IsImageUrlObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject?, TResult>? imageFileObject = null,
            global::System.Func<global::tryAGI.OpenAI.MessageDeltaContentTextObject?, TResult>? textObject = null,
            global::System.Func<global::tryAGI.OpenAI.MessageDeltaContentRefusalObject?, TResult>? refusalObject = null,
            global::System.Func<global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject?, TResult>? imageUrlObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageFileObject && imageFileObject != null)
            {
                return imageFileObject(ImageFileObject!);
            }
            else if (IsTextObject && textObject != null)
            {
                return textObject(TextObject!);
            }
            else if (IsRefusalObject && refusalObject != null)
            {
                return refusalObject(RefusalObject!);
            }
            else if (IsImageUrlObject && imageUrlObject != null)
            {
                return imageUrlObject(ImageUrlObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject?>? imageFileObject = null,
            global::System.Action<global::tryAGI.OpenAI.MessageDeltaContentTextObject?>? textObject = null,
            global::System.Action<global::tryAGI.OpenAI.MessageDeltaContentRefusalObject?>? refusalObject = null,
            global::System.Action<global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject?>? imageUrlObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageFileObject)
            {
                imageFileObject?.Invoke(ImageFileObject!);
            }
            else if (IsTextObject)
            {
                textObject?.Invoke(TextObject!);
            }
            else if (IsRefusalObject)
            {
                refusalObject?.Invoke(RefusalObject!);
            }
            else if (IsImageUrlObject)
            {
                imageUrlObject?.Invoke(ImageUrlObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageFileObject,
                typeof(global::tryAGI.OpenAI.MessageDeltaContentImageFileObject),
                TextObject,
                typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObject),
                RefusalObject,
                typeof(global::tryAGI.OpenAI.MessageDeltaContentRefusalObject),
                ImageUrlObject,
                typeof(global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject),
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
        public bool Equals(MessageContentDelta other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageDeltaContentImageFileObject?>.Default.Equals(ImageFileObject, other.ImageFileObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageDeltaContentTextObject?>.Default.Equals(TextObject, other.TextObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageDeltaContentRefusalObject?>.Default.Equals(RefusalObject, other.RefusalObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageDeltaContentImageUrlObject?>.Default.Equals(ImageUrlObject, other.ImageUrlObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageContentDelta obj1, MessageContentDelta obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageContentDelta>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageContentDelta obj1, MessageContentDelta obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageContentDelta o && Equals(o);
        }
    }
}
