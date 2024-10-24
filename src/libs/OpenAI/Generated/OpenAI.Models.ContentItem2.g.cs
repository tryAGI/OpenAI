using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentItem2 : global::System.IEquatable<ContentItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.MessageObjectContentItemDiscriminatorType? Type { get; }

        /// <summary>
        /// References an image [File](/docs/api-reference/files) in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageContentImageFileObject? MessageImageFileObject { get; init; }
#else
        public global::OpenAI.MessageContentImageFileObject? MessageImageFileObject { get; }
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
        public static implicit operator ContentItem2(global::OpenAI.MessageContentImageFileObject value) => new ContentItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageContentImageFileObject?(ContentItem2 @this) => @this.MessageImageFileObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem2(global::OpenAI.MessageContentImageFileObject? value)
        {
            MessageImageFileObject = value;
        }

        /// <summary>
        /// References an image URL in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageContentImageUrlObject? MessageImageUrlObject { get; init; }
#else
        public global::OpenAI.MessageContentImageUrlObject? MessageImageUrlObject { get; }
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
        public static implicit operator ContentItem2(global::OpenAI.MessageContentImageUrlObject value) => new ContentItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageContentImageUrlObject?(ContentItem2 @this) => @this.MessageImageUrlObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem2(global::OpenAI.MessageContentImageUrlObject? value)
        {
            MessageImageUrlObject = value;
        }

        /// <summary>
        /// The text content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageContentTextObject? MessageTextObject { get; init; }
#else
        public global::OpenAI.MessageContentTextObject? MessageTextObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageTextObject))]
#endif
        public bool IsMessageTextObject => MessageTextObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem2(global::OpenAI.MessageContentTextObject value) => new ContentItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageContentTextObject?(ContentItem2 @this) => @this.MessageTextObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem2(global::OpenAI.MessageContentTextObject? value)
        {
            MessageTextObject = value;
        }

        /// <summary>
        /// The refusal content generated by the assistant.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageContentRefusalObject? MessageRefusalObject { get; init; }
#else
        public global::OpenAI.MessageContentRefusalObject? MessageRefusalObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageRefusalObject))]
#endif
        public bool IsMessageRefusalObject => MessageRefusalObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem2(global::OpenAI.MessageContentRefusalObject value) => new ContentItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageContentRefusalObject?(ContentItem2 @this) => @this.MessageRefusalObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem2(global::OpenAI.MessageContentRefusalObject? value)
        {
            MessageRefusalObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentItem2(
            global::OpenAI.MessageObjectContentItemDiscriminatorType? type,
            global::OpenAI.MessageContentImageFileObject? messageImageFileObject,
            global::OpenAI.MessageContentImageUrlObject? messageImageUrlObject,
            global::OpenAI.MessageContentTextObject? messageTextObject,
            global::OpenAI.MessageContentRefusalObject? messageRefusalObject
            )
        {
            Type = type;

            MessageImageFileObject = messageImageFileObject;
            MessageImageUrlObject = messageImageUrlObject;
            MessageTextObject = messageTextObject;
            MessageRefusalObject = messageRefusalObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageRefusalObject as object ??
            MessageTextObject as object ??
            MessageImageUrlObject as object ??
            MessageImageFileObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageImageFileObject && !IsMessageImageUrlObject && !IsMessageTextObject && !IsMessageRefusalObject || !IsMessageImageFileObject && IsMessageImageUrlObject && !IsMessageTextObject && !IsMessageRefusalObject || !IsMessageImageFileObject && !IsMessageImageUrlObject && IsMessageTextObject && !IsMessageRefusalObject || !IsMessageImageFileObject && !IsMessageImageUrlObject && !IsMessageTextObject && IsMessageRefusalObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.MessageContentImageFileObject?, TResult>? messageImageFileObject = null,
            global::System.Func<global::OpenAI.MessageContentImageUrlObject?, TResult>? messageImageUrlObject = null,
            global::System.Func<global::OpenAI.MessageContentTextObject?, TResult>? messageTextObject = null,
            global::System.Func<global::OpenAI.MessageContentRefusalObject?, TResult>? messageRefusalObject = null,
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
            else if (IsMessageTextObject && messageTextObject != null)
            {
                return messageTextObject(MessageTextObject!);
            }
            else if (IsMessageRefusalObject && messageRefusalObject != null)
            {
                return messageRefusalObject(MessageRefusalObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.MessageContentImageFileObject?>? messageImageFileObject = null,
            global::System.Action<global::OpenAI.MessageContentImageUrlObject?>? messageImageUrlObject = null,
            global::System.Action<global::OpenAI.MessageContentTextObject?>? messageTextObject = null,
            global::System.Action<global::OpenAI.MessageContentRefusalObject?>? messageRefusalObject = null,
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
            else if (IsMessageTextObject)
            {
                messageTextObject?.Invoke(MessageTextObject!);
            }
            else if (IsMessageRefusalObject)
            {
                messageRefusalObject?.Invoke(MessageRefusalObject!);
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
                typeof(global::OpenAI.MessageContentImageFileObject),
                MessageImageUrlObject,
                typeof(global::OpenAI.MessageContentImageUrlObject),
                MessageTextObject,
                typeof(global::OpenAI.MessageContentTextObject),
                MessageRefusalObject,
                typeof(global::OpenAI.MessageContentRefusalObject),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ContentItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageContentImageFileObject?>.Default.Equals(MessageImageFileObject, other.MessageImageFileObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageContentImageUrlObject?>.Default.Equals(MessageImageUrlObject, other.MessageImageUrlObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageContentTextObject?>.Default.Equals(MessageTextObject, other.MessageTextObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageContentRefusalObject?>.Default.Equals(MessageRefusalObject, other.MessageRefusalObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentItem2 obj1, ContentItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentItem2 obj1, ContentItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem2 o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::OpenAI.ContentItem2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.ContentItem2),
                jsonSerializerContext) as global::OpenAI.ContentItem2?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.ContentItem2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.ContentItem2>(
                json,
                jsonSerializerOptions);
        }

    }
}
