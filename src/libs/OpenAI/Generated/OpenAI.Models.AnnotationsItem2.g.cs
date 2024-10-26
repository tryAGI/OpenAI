using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnnotationsItem2 : global::System.IEquatable<AnnotationsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType? Type { get; }

        /// <summary>
        /// A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the "file_search" tool to search files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? FileCitation { get; init; }
#else
        public global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? FileCitation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileCitation))]
#endif
        public bool IsFileCitation => FileCitation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem2(global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject value) => new AnnotationsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject?(AnnotationsItem2 @this) => @this.FileCitation;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem2(global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? value)
        {
            FileCitation = value;
        }

        /// <summary>
        /// A URL for the file that's generated when the assistant used the `code_interpreter` tool to generate a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? FilePath { get; init; }
#else
        public global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? FilePath { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilePath))]
#endif
        public bool IsFilePath => FilePath != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem2(global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject value) => new AnnotationsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject?(AnnotationsItem2 @this) => @this.FilePath;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem2(global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? value)
        {
            FilePath = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem2(
            global::OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType? type,
            global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? fileCitation,
            global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? filePath
            )
        {
            Type = type;

            FileCitation = fileCitation;
            FilePath = filePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FilePath as object ??
            FileCitation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileCitation && !IsFilePath || !IsFileCitation && IsFilePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject?, TResult>? fileCitation = null,
            global::System.Func<global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject?, TResult>? filePath = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitation && fileCitation != null)
            {
                return fileCitation(FileCitation!);
            }
            else if (IsFilePath && filePath != null)
            {
                return filePath(FilePath!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject?>? fileCitation = null,
            global::System.Action<global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject?>? filePath = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitation)
            {
                fileCitation?.Invoke(FileCitation!);
            }
            else if (IsFilePath)
            {
                filePath?.Invoke(FilePath!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileCitation,
                typeof(global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject),
                FilePath,
                typeof(global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject),
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
        public bool Equals(AnnotationsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject?>.Default.Equals(FilePath, other.FilePath) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnnotationsItem2 obj1, AnnotationsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnnotationsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnnotationsItem2 obj1, AnnotationsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnnotationsItem2 o && Equals(o);
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
        public static global::OpenAI.AnnotationsItem2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.AnnotationsItem2),
                jsonSerializerContext) as global::OpenAI.AnnotationsItem2?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.AnnotationsItem2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.AnnotationsItem2>(
                json,
                jsonSerializerOptions);
        }

    }
}
