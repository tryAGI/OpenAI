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
        /// References an image [File](https://platform.openai.com/docs/api-reference/files) in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentImageFileObject? MessageImageFileObject { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentImageFileObject? MessageImageFileObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageImageFileObject))]
#endif
        public bool IsMessageImageFileObject => MessageImageFileObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::tryAGI.OpenAI.MessageContentImageFileObject value) => new ContentVariant2Item((global::tryAGI.OpenAI.MessageContentImageFileObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentImageFileObject?(ContentVariant2Item @this) => @this.MessageImageFileObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::tryAGI.OpenAI.MessageContentImageFileObject? value)
        {
            MessageImageFileObject = value;
        }

        /// <summary>
        /// References an image URL in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentImageUrlObject? MessageImageUrlObject { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentImageUrlObject? MessageImageUrlObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageImageUrlObject))]
#endif
        public bool IsMessageImageUrlObject => MessageImageUrlObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::tryAGI.OpenAI.MessageContentImageUrlObject value) => new ContentVariant2Item((global::tryAGI.OpenAI.MessageContentImageUrlObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentImageUrlObject?(ContentVariant2Item @this) => @this.MessageImageUrlObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::tryAGI.OpenAI.MessageContentImageUrlObject? value)
        {
            MessageImageUrlObject = value;
        }

        /// <summary>
        /// The text content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageRequestContentTextObject? MessageRequestTextObject { get; init; }
#else
        public global::tryAGI.OpenAI.MessageRequestContentTextObject? MessageRequestTextObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageRequestTextObject))]
#endif
        public bool IsMessageRequestTextObject => MessageRequestTextObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::tryAGI.OpenAI.MessageRequestContentTextObject value) => new ContentVariant2Item((global::tryAGI.OpenAI.MessageRequestContentTextObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageRequestContentTextObject?(ContentVariant2Item @this) => @this.MessageRequestTextObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::tryAGI.OpenAI.MessageRequestContentTextObject? value)
        {
            MessageRequestTextObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(
            global::tryAGI.OpenAI.MessageContentImageFileObject? messageImageFileObject,
            global::tryAGI.OpenAI.MessageContentImageUrlObject? messageImageUrlObject,
            global::tryAGI.OpenAI.MessageRequestContentTextObject? messageRequestTextObject
            )
        {
            MessageImageFileObject = messageImageFileObject;
            MessageImageUrlObject = messageImageUrlObject;
            MessageRequestTextObject = messageRequestTextObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageRequestTextObject as object ??
            MessageImageUrlObject as object ??
            MessageImageFileObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessageImageFileObject?.ToString() ??
            MessageImageUrlObject?.ToString() ??
            MessageRequestTextObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageImageFileObject || IsMessageImageUrlObject || IsMessageRequestTextObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.MessageContentImageFileObject?, TResult>? messageImageFileObject = null,
            global::System.Func<global::tryAGI.OpenAI.MessageContentImageUrlObject?, TResult>? messageImageUrlObject = null,
            global::System.Func<global::tryAGI.OpenAI.MessageRequestContentTextObject?, TResult>? messageRequestTextObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageImageFileObject && messageImageFileObject != null)
            {
                return messageImageFileObject(MessageImageFileObject!);
            }
            else if (IsMessageImageUrlObject && messageImageUrlObject != null)
            {
                return messageImageUrlObject(MessageImageUrlObject!);
            }
            else if (IsMessageRequestTextObject && messageRequestTextObject != null)
            {
                return messageRequestTextObject(MessageRequestTextObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.MessageContentImageFileObject?>? messageImageFileObject = null,
            global::System.Action<global::tryAGI.OpenAI.MessageContentImageUrlObject?>? messageImageUrlObject = null,
            global::System.Action<global::tryAGI.OpenAI.MessageRequestContentTextObject?>? messageRequestTextObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageImageFileObject)
            {
                messageImageFileObject?.Invoke(MessageImageFileObject!);
            }
            else if (IsMessageImageUrlObject)
            {
                messageImageUrlObject?.Invoke(MessageImageUrlObject!);
            }
            else if (IsMessageRequestTextObject)
            {
                messageRequestTextObject?.Invoke(MessageRequestTextObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageImageFileObject,
                typeof(global::tryAGI.OpenAI.MessageContentImageFileObject),
                MessageImageUrlObject,
                typeof(global::tryAGI.OpenAI.MessageContentImageUrlObject),
                MessageRequestTextObject,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentImageFileObject?>.Default.Equals(MessageImageFileObject, other.MessageImageFileObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentImageUrlObject?>.Default.Equals(MessageImageUrlObject, other.MessageImageUrlObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageRequestContentTextObject?>.Default.Equals(MessageRequestTextObject, other.MessageRequestTextObject) 
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
