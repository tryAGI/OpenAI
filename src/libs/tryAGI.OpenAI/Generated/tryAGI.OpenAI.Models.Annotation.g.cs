#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Annotation : global::System.IEquatable<Annotation>
    {
        /// <summary>
        /// A citation to a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FileCitation? FileCitation { get; init; }
#else
        public global::tryAGI.OpenAI.FileCitation? FileCitation { get; }
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
        public static implicit operator Annotation(global::tryAGI.OpenAI.FileCitation value) => new Annotation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileCitation?(Annotation @this) => @this.FileCitation;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::tryAGI.OpenAI.FileCitation? value)
        {
            FileCitation = value;
        }

        /// <summary>
        /// A citation for a web resource used to generate a model response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UrlCitation? UrlCitation { get; init; }
#else
        public global::tryAGI.OpenAI.UrlCitation? UrlCitation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UrlCitation))]
#endif
        public bool IsUrlCitation => UrlCitation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::tryAGI.OpenAI.UrlCitation value) => new Annotation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UrlCitation?(Annotation @this) => @this.UrlCitation;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::tryAGI.OpenAI.UrlCitation? value)
        {
            UrlCitation = value;
        }

        /// <summary>
        /// A path to a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FilePath? FilePath { get; init; }
#else
        public global::tryAGI.OpenAI.FilePath? FilePath { get; }
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
        public static implicit operator Annotation(global::tryAGI.OpenAI.FilePath value) => new Annotation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FilePath?(Annotation @this) => @this.FilePath;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::tryAGI.OpenAI.FilePath? value)
        {
            FilePath = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Annotation(
            global::tryAGI.OpenAI.FileCitation? fileCitation,
            global::tryAGI.OpenAI.UrlCitation? urlCitation,
            global::tryAGI.OpenAI.FilePath? filePath
            )
        {
            FileCitation = fileCitation;
            UrlCitation = urlCitation;
            FilePath = filePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FilePath as object ??
            UrlCitation as object ??
            FileCitation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileCitation && !IsUrlCitation && !IsFilePath || !IsFileCitation && IsUrlCitation && !IsFilePath || !IsFileCitation && !IsUrlCitation && IsFilePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FileCitation?, TResult>? fileCitation = null,
            global::System.Func<global::tryAGI.OpenAI.UrlCitation?, TResult>? urlCitation = null,
            global::System.Func<global::tryAGI.OpenAI.FilePath?, TResult>? filePath = null,
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
            else if (IsUrlCitation && urlCitation != null)
            {
                return urlCitation(UrlCitation!);
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
            global::System.Action<global::tryAGI.OpenAI.FileCitation?>? fileCitation = null,
            global::System.Action<global::tryAGI.OpenAI.UrlCitation?>? urlCitation = null,
            global::System.Action<global::tryAGI.OpenAI.FilePath?>? filePath = null,
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
            else if (IsUrlCitation)
            {
                urlCitation?.Invoke(UrlCitation!);
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
                typeof(global::tryAGI.OpenAI.FileCitation),
                UrlCitation,
                typeof(global::tryAGI.OpenAI.UrlCitation),
                FilePath,
                typeof(global::tryAGI.OpenAI.FilePath),
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
        public bool Equals(Annotation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileCitation?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UrlCitation?>.Default.Equals(UrlCitation, other.UrlCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FilePath?>.Default.Equals(FilePath, other.FilePath) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Annotation obj1, Annotation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Annotation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Annotation obj1, Annotation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Annotation o && Equals(o);
        }
    }
}
