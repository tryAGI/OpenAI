#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnnotationsItem : global::System.IEquatable<AnnotationsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentTextObjectTextAnnotationDiscriminatorType? Type { get; }

        /// <summary>
        /// A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the "file_search" tool to search files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? FileCitation { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? FileCitation { get; }
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
        public static implicit operator AnnotationsItem(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject value) => new AnnotationsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject?(AnnotationsItem @this) => @this.FileCitation;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? value)
        {
            FileCitation = value;
        }

        /// <summary>
        /// A URL for the file that's generated when the assistant used the `code_interpreter` tool to generate a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? FilePath { get; init; }
#else
        public global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? FilePath { get; }
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
        public static implicit operator AnnotationsItem(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject value) => new AnnotationsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject?(AnnotationsItem @this) => @this.FilePath;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem(global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? value)
        {
            FilePath = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem(
            global::tryAGI.OpenAI.MessageContentTextObjectTextAnnotationDiscriminatorType? type,
            global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject? fileCitation,
            global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject? filePath
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
            global::System.Func<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject?, TResult>? fileCitation = null,
            global::System.Func<global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject?, TResult>? filePath = null,
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
            global::System.Action<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject?>? fileCitation = null,
            global::System.Action<global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject?>? filePath = null,
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
                typeof(global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject),
                FilePath,
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
        public bool Equals(AnnotationsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentTextAnnotationsFileCitationObject?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MessageContentTextAnnotationsFilePathObject?>.Default.Equals(FilePath, other.FilePath) 
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
    }
}
