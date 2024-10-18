using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnnotationsItem : global::System.IEquatable<AnnotationsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.MessageContentTextObjectTextAnnotationDiscriminatorType? Type { get; }

        /// <summary>
        /// A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the "file_search" tool to search files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageContentTextAnnotationsFileCitationObject? MessageContentTextFileCitationObject { get; init; }
#else
        public global::OpenAI.MessageContentTextAnnotationsFileCitationObject? MessageContentTextFileCitationObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageContentTextFileCitationObject))]
#endif
        public bool IsMessageContentTextFileCitationObject => MessageContentTextFileCitationObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem(global::OpenAI.MessageContentTextAnnotationsFileCitationObject value) => new AnnotationsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageContentTextAnnotationsFileCitationObject?(AnnotationsItem @this) => @this.MessageContentTextFileCitationObject;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem(global::OpenAI.MessageContentTextAnnotationsFileCitationObject? value)
        {
            MessageContentTextFileCitationObject = value;
        }

        /// <summary>
        /// A URL for the file that's generated when the assistant used the `code_interpreter` tool to generate a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageContentTextAnnotationsFilePathObject? MessageContentTextFilePathObject { get; init; }
#else
        public global::OpenAI.MessageContentTextAnnotationsFilePathObject? MessageContentTextFilePathObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageContentTextFilePathObject))]
#endif
        public bool IsMessageContentTextFilePathObject => MessageContentTextFilePathObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem(global::OpenAI.MessageContentTextAnnotationsFilePathObject value) => new AnnotationsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageContentTextAnnotationsFilePathObject?(AnnotationsItem @this) => @this.MessageContentTextFilePathObject;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem(global::OpenAI.MessageContentTextAnnotationsFilePathObject? value)
        {
            MessageContentTextFilePathObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem(
            global::OpenAI.MessageContentTextObjectTextAnnotationDiscriminatorType? type,
            global::OpenAI.MessageContentTextAnnotationsFileCitationObject? messageContentTextFileCitationObject,
            global::OpenAI.MessageContentTextAnnotationsFilePathObject? messageContentTextFilePathObject
            )
        {
            Type = type;

            MessageContentTextFileCitationObject = messageContentTextFileCitationObject;
            MessageContentTextFilePathObject = messageContentTextFilePathObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageContentTextFilePathObject as object ??
            MessageContentTextFileCitationObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageContentTextFileCitationObject && !IsMessageContentTextFilePathObject || !IsMessageContentTextFileCitationObject && IsMessageContentTextFilePathObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.MessageContentTextAnnotationsFileCitationObject?, TResult>? messageContentTextFileCitationObject = null,
            global::System.Func<global::OpenAI.MessageContentTextAnnotationsFilePathObject?, TResult>? messageContentTextFilePathObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageContentTextFileCitationObject && messageContentTextFileCitationObject != null)
            {
                return messageContentTextFileCitationObject(MessageContentTextFileCitationObject!);
            }
            else if (IsMessageContentTextFilePathObject && messageContentTextFilePathObject != null)
            {
                return messageContentTextFilePathObject(MessageContentTextFilePathObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.MessageContentTextAnnotationsFileCitationObject?>? messageContentTextFileCitationObject = null,
            global::System.Action<global::OpenAI.MessageContentTextAnnotationsFilePathObject?>? messageContentTextFilePathObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageContentTextFileCitationObject)
            {
                messageContentTextFileCitationObject?.Invoke(MessageContentTextFileCitationObject!);
            }
            else if (IsMessageContentTextFilePathObject)
            {
                messageContentTextFilePathObject?.Invoke(MessageContentTextFilePathObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageContentTextFileCitationObject,
                typeof(global::OpenAI.MessageContentTextAnnotationsFileCitationObject),
                MessageContentTextFilePathObject,
                typeof(global::OpenAI.MessageContentTextAnnotationsFilePathObject),
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
        public bool Equals(AnnotationsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageContentTextAnnotationsFileCitationObject?>.Default.Equals(MessageContentTextFileCitationObject, other.MessageContentTextFileCitationObject) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageContentTextAnnotationsFilePathObject?>.Default.Equals(MessageContentTextFilePathObject, other.MessageContentTextFilePathObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnnotationsItem obj1, AnnotationsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnnotationsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnnotationsItem obj1, AnnotationsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnnotationsItem o && Equals(o);
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
        public static global::OpenAI.AnnotationsItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.AnnotationsItem),
                jsonSerializerContext) as global::OpenAI.AnnotationsItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.AnnotationsItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.AnnotationsItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
