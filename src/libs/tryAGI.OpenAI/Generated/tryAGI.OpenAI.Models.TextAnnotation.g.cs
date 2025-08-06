#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TextAnnotation : global::System.IEquatable<TextAnnotation>
    {
        /// <summary>
        /// A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the "file_search" tool to search files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? MessageContentAnnotationsFileCitationObject { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? MessageContentAnnotationsFileCitationObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageContentAnnotationsFileCitationObject))]
#endif
        public bool IsMessageContentAnnotationsFileCitationObject => MessageContentAnnotationsFileCitationObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextAnnotation(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject value) => new TextAnnotation((global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject?(TextAnnotation @this) => @this.MessageContentAnnotationsFileCitationObject;

        /// <summary>
        /// 
        /// </summary>
        public TextAnnotation(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? value)
        {
            MessageContentAnnotationsFileCitationObject = value;
        }

        /// <summary>
        /// A URL for the file that's generated when the assistant used the `code_interpreter` tool to generate a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? MessageContentAnnotationsFilePathObject { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? MessageContentAnnotationsFilePathObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageContentAnnotationsFilePathObject))]
#endif
        public bool IsMessageContentAnnotationsFilePathObject => MessageContentAnnotationsFilePathObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextAnnotation(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject value) => new TextAnnotation((global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject?(TextAnnotation @this) => @this.MessageContentAnnotationsFilePathObject;

        /// <summary>
        /// 
        /// </summary>
        public TextAnnotation(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? value)
        {
            MessageContentAnnotationsFilePathObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextAnnotation(
            global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? messageContentAnnotationsFileCitationObject,
            global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? messageContentAnnotationsFilePathObject
            )
        {
            MessageContentAnnotationsFileCitationObject = messageContentAnnotationsFileCitationObject;
            MessageContentAnnotationsFilePathObject = messageContentAnnotationsFilePathObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessageContentAnnotationsFilePathObject as object ??
            MessageContentAnnotationsFileCitationObject as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessageContentAnnotationsFileCitationObject?.ToString() ??
            MessageContentAnnotationsFilePathObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageContentAnnotationsFileCitationObject || IsMessageContentAnnotationsFilePathObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject?, TResult>? messageContentAnnotationsFileCitationObject = null,
            global::System.Func<global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject?, TResult>? messageContentAnnotationsFilePathObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageContentAnnotationsFileCitationObject && messageContentAnnotationsFileCitationObject != null)
            {
                return messageContentAnnotationsFileCitationObject(MessageContentAnnotationsFileCitationObject!);
            }
            else if (IsMessageContentAnnotationsFilePathObject && messageContentAnnotationsFilePathObject != null)
            {
                return messageContentAnnotationsFilePathObject(MessageContentAnnotationsFilePathObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject?>? messageContentAnnotationsFileCitationObject = null,
            global::System.Action<global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject?>? messageContentAnnotationsFilePathObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageContentAnnotationsFileCitationObject)
            {
                messageContentAnnotationsFileCitationObject?.Invoke(MessageContentAnnotationsFileCitationObject!);
            }
            else if (IsMessageContentAnnotationsFilePathObject)
            {
                messageContentAnnotationsFilePathObject?.Invoke(MessageContentAnnotationsFilePathObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageContentAnnotationsFileCitationObject,
                typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject),
                MessageContentAnnotationsFilePathObject,
                typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject),
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
        public bool Equals(TextAnnotation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject?>.Default.Equals(MessageContentAnnotationsFileCitationObject, other.MessageContentAnnotationsFileCitationObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject?>.Default.Equals(MessageContentAnnotationsFilePathObject, other.MessageContentAnnotationsFilePathObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextAnnotation obj1, TextAnnotation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextAnnotation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextAnnotation obj1, TextAnnotation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextAnnotation o && Equals(o);
        }
    }
}
