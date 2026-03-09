#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Annotation object describing a cited source.
    /// </summary>
    public readonly partial struct AnnotationsItem3 : global::System.IEquatable<AnnotationsItem3>
    {
        /// <summary>
        /// Annotation that references an uploaded file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FileAnnotation? File { get; init; }
#else
        public global::tryAGI.OpenAI.FileAnnotation? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// Annotation that references a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UrlAnnotation? Url { get; init; }
#else
        public global::tryAGI.OpenAI.UrlAnnotation? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem3(global::tryAGI.OpenAI.FileAnnotation value) => new AnnotationsItem3((global::tryAGI.OpenAI.FileAnnotation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileAnnotation?(AnnotationsItem3 @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem3(global::tryAGI.OpenAI.FileAnnotation? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem3(global::tryAGI.OpenAI.UrlAnnotation value) => new AnnotationsItem3((global::tryAGI.OpenAI.UrlAnnotation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UrlAnnotation?(AnnotationsItem3 @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem3(global::tryAGI.OpenAI.UrlAnnotation? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem3(
            global::tryAGI.OpenAI.FileAnnotation? file,
            global::tryAGI.OpenAI.UrlAnnotation? url
            )
        {
            File = file;
            Url = url;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Url as object ??
            File as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            File?.ToString() ??
            Url?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFile && !IsUrl || !IsFile && IsUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FileAnnotation?, TResult>? file = null,
            global::System.Func<global::tryAGI.OpenAI.UrlAnnotation?, TResult>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsUrl && url != null)
            {
                return url(Url!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.FileAnnotation?>? file = null,
            global::System.Action<global::tryAGI.OpenAI.UrlAnnotation?>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsUrl)
            {
                url?.Invoke(Url!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                File,
                typeof(global::tryAGI.OpenAI.FileAnnotation),
                Url,
                typeof(global::tryAGI.OpenAI.UrlAnnotation),
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
        public bool Equals(AnnotationsItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileAnnotation?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UrlAnnotation?>.Default.Equals(Url, other.Url) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnnotationsItem3 obj1, AnnotationsItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnnotationsItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnnotationsItem3 obj1, AnnotationsItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnnotationsItem3 o && Equals(o);
        }
    }
}
