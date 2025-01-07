#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnnotationsItem2 : global::System.IEquatable<AnnotationsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType? Type { get; }

        /// <summary>
        /// A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the "file_search" tool to search files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? FileCitation { get; init; }
#else
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? FileCitation { get; }
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
        public static implicit operator AnnotationsItem2(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject value) => new AnnotationsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject?(AnnotationsItem2 @this) => @this.FileCitation;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem2(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? value)
        {
            FileCitation = value;
        }

        /// <summary>
        /// A URL for the file that's generated when the assistant used the `code_interpreter` tool to generate a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? FilePath { get; init; }
#else
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? FilePath { get; }
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
        public static implicit operator AnnotationsItem2(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject value) => new AnnotationsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject?(AnnotationsItem2 @this) => @this.FilePath;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem2(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? value)
        {
            FilePath = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem2(
            global::tryAGI.OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType? type,
            global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? fileCitation,
            global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? filePath
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
            global::System.Func<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject?, TResult>? fileCitation = null,
            global::System.Func<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject?, TResult>? filePath = null,
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
            global::System.Action<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject?>? fileCitation = null,
            global::System.Action<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject?>? filePath = null,
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
                typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject),
                FilePath,
                typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject),
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
        public bool Equals(AnnotationsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject?>.Default.Equals(FilePath, other.FilePath) 
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
    }
}
