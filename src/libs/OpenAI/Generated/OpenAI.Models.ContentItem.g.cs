using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentItem : global::System.IEquatable<ContentItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorType? Type { get; }

        /// <summary>
        /// References an image [File](/docs/api-reference/files) in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageDeltaContentImageFileObject? MessageDeltaImageFileObject { get; init; }
#else
        public global::OpenAI.MessageDeltaContentImageFileObject? MessageDeltaImageFileObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDeltaImageFileObject))]
#endif
        public bool IsMessageDeltaImageFileObject => MessageDeltaImageFileObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::OpenAI.MessageDeltaContentImageFileObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageDeltaContentImageFileObject?(ContentItem @this) => @this.MessageDeltaImageFileObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::OpenAI.MessageDeltaContentImageFileObject? value)
        {
            MessageDeltaImageFileObject = value;
        }

        /// <summary>
        /// The text content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageDeltaContentTextObject? MessageDeltaTextObject { get; init; }
#else
        public global::OpenAI.MessageDeltaContentTextObject? MessageDeltaTextObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDeltaTextObject))]
#endif
        public bool IsMessageDeltaTextObject => MessageDeltaTextObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::OpenAI.MessageDeltaContentTextObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageDeltaContentTextObject?(ContentItem @this) => @this.MessageDeltaTextObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::OpenAI.MessageDeltaContentTextObject? value)
        {
            MessageDeltaTextObject = value;
        }

        /// <summary>
        /// The refusal content that is part of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageDeltaContentRefusalObject? MessageDeltaRefusalObject { get; init; }
#else
        public global::OpenAI.MessageDeltaContentRefusalObject? MessageDeltaRefusalObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDeltaRefusalObject))]
#endif
        public bool IsMessageDeltaRefusalObject => MessageDeltaRefusalObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::OpenAI.MessageDeltaContentRefusalObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageDeltaContentRefusalObject?(ContentItem @this) => @this.MessageDeltaRefusalObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::OpenAI.MessageDeltaContentRefusalObject? value)
        {
            MessageDeltaRefusalObject = value;
        }

        /// <summary>
        /// References an image URL in the content of a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageDeltaContentImageUrlObject? MessageDeltaImageUrlObject { get; init; }
#else
        public global::OpenAI.MessageDeltaContentImageUrlObject? MessageDeltaImageUrlObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDeltaImageUrlObject))]
#endif
        public bool IsMessageDeltaImageUrlObject => MessageDeltaImageUrlObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::OpenAI.MessageDeltaContentImageUrlObject value) => new ContentItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageDeltaContentImageUrlObject?(ContentItem @this) => @this.MessageDeltaImageUrlObject;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::OpenAI.MessageDeltaContentImageUrlObject? value)
        {
            MessageDeltaImageUrlObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(
            global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorType? type,
            global::OpenAI.MessageDeltaContentImageFileObject? messageDeltaImageFileObject,
            global::OpenAI.MessageDeltaContentTextObject? messageDeltaTextObject,
            global::OpenAI.MessageDeltaContentRefusalObject? messageDeltaRefusalObject,
            global::OpenAI.MessageDeltaContentImageUrlObject? messageDeltaImageUrlObject
            )
        {
            Type = type;

            MessageDeltaImageFileObject = messageDeltaImageFileObject;
            MessageDeltaTextObject = messageDeltaTextObject;
            MessageDeltaRefusalObject = messageDeltaRefusalObject;
            MessageDeltaImageUrlObject = messageDeltaImageUrlObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageDeltaImageUrlObject as object ??
            MessageDeltaRefusalObject as object ??
            MessageDeltaTextObject as object ??
            MessageDeltaImageFileObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageDeltaImageFileObject && !IsMessageDeltaTextObject && !IsMessageDeltaRefusalObject && !IsMessageDeltaImageUrlObject || !IsMessageDeltaImageFileObject && IsMessageDeltaTextObject && !IsMessageDeltaRefusalObject && !IsMessageDeltaImageUrlObject || !IsMessageDeltaImageFileObject && !IsMessageDeltaTextObject && IsMessageDeltaRefusalObject && !IsMessageDeltaImageUrlObject || !IsMessageDeltaImageFileObject && !IsMessageDeltaTextObject && !IsMessageDeltaRefusalObject && IsMessageDeltaImageUrlObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.MessageDeltaContentImageFileObject?, TResult>? messageDeltaImageFileObject = null,
            global::System.Func<global::OpenAI.MessageDeltaContentTextObject?, TResult>? messageDeltaTextObject = null,
            global::System.Func<global::OpenAI.MessageDeltaContentRefusalObject?, TResult>? messageDeltaRefusalObject = null,
            global::System.Func<global::OpenAI.MessageDeltaContentImageUrlObject?, TResult>? messageDeltaImageUrlObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageDeltaImageFileObject && messageDeltaImageFileObject != null)
            {
                return messageDeltaImageFileObject(MessageDeltaImageFileObject!);
            }
            else if (IsMessageDeltaTextObject && messageDeltaTextObject != null)
            {
                return messageDeltaTextObject(MessageDeltaTextObject!);
            }
            else if (IsMessageDeltaRefusalObject && messageDeltaRefusalObject != null)
            {
                return messageDeltaRefusalObject(MessageDeltaRefusalObject!);
            }
            else if (IsMessageDeltaImageUrlObject && messageDeltaImageUrlObject != null)
            {
                return messageDeltaImageUrlObject(MessageDeltaImageUrlObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.MessageDeltaContentImageFileObject?>? messageDeltaImageFileObject = null,
            global::System.Action<global::OpenAI.MessageDeltaContentTextObject?>? messageDeltaTextObject = null,
            global::System.Action<global::OpenAI.MessageDeltaContentRefusalObject?>? messageDeltaRefusalObject = null,
            global::System.Action<global::OpenAI.MessageDeltaContentImageUrlObject?>? messageDeltaImageUrlObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageDeltaImageFileObject)
            {
                messageDeltaImageFileObject?.Invoke(MessageDeltaImageFileObject!);
            }
            else if (IsMessageDeltaTextObject)
            {
                messageDeltaTextObject?.Invoke(MessageDeltaTextObject!);
            }
            else if (IsMessageDeltaRefusalObject)
            {
                messageDeltaRefusalObject?.Invoke(MessageDeltaRefusalObject!);
            }
            else if (IsMessageDeltaImageUrlObject)
            {
                messageDeltaImageUrlObject?.Invoke(MessageDeltaImageUrlObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageDeltaImageFileObject,
                typeof(global::OpenAI.MessageDeltaContentImageFileObject),
                MessageDeltaTextObject,
                typeof(global::OpenAI.MessageDeltaContentTextObject),
                MessageDeltaRefusalObject,
                typeof(global::OpenAI.MessageDeltaContentRefusalObject),
                MessageDeltaImageUrlObject,
                typeof(global::OpenAI.MessageDeltaContentImageUrlObject),
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
        public bool Equals(ContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageDeltaContentImageFileObject?>.Default.Equals(MessageDeltaImageFileObject, other.MessageDeltaImageFileObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageDeltaContentTextObject?>.Default.Equals(MessageDeltaTextObject, other.MessageDeltaTextObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageDeltaContentRefusalObject?>.Default.Equals(MessageDeltaRefusalObject, other.MessageDeltaRefusalObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageDeltaContentImageUrlObject?>.Default.Equals(MessageDeltaImageUrlObject, other.MessageDeltaImageUrlObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentItem obj1, ContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentItem obj1, ContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem o && Equals(o);
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
        public static global::OpenAI.ContentItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.ContentItem),
                jsonSerializerContext) as global::OpenAI.ContentItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.ContentItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.ContentItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
