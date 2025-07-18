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
        public global::tryAGI.OpenAI.FileCitationBody? FileCitationBody { get; init; }
#else
        public global::tryAGI.OpenAI.FileCitationBody? FileCitationBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileCitationBody))]
#endif
        public bool IsFileCitationBody => FileCitationBody != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::tryAGI.OpenAI.FileCitationBody value) => new Annotation((global::tryAGI.OpenAI.FileCitationBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileCitationBody?(Annotation @this) => @this.FileCitationBody;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::tryAGI.OpenAI.FileCitationBody? value)
        {
            FileCitationBody = value;
        }

        /// <summary>
        /// A citation for a web resource used to generate a model response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UrlCitationBody? UrlCitationBody { get; init; }
#else
        public global::tryAGI.OpenAI.UrlCitationBody? UrlCitationBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UrlCitationBody))]
#endif
        public bool IsUrlCitationBody => UrlCitationBody != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::tryAGI.OpenAI.UrlCitationBody value) => new Annotation((global::tryAGI.OpenAI.UrlCitationBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UrlCitationBody?(Annotation @this) => @this.UrlCitationBody;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::tryAGI.OpenAI.UrlCitationBody? value)
        {
            UrlCitationBody = value;
        }

        /// <summary>
        /// A citation for a container file used to generate a model response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ContainerFileCitationBody? ContainerFileCitationBody { get; init; }
#else
        public global::tryAGI.OpenAI.ContainerFileCitationBody? ContainerFileCitationBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerFileCitationBody))]
#endif
        public bool IsContainerFileCitationBody => ContainerFileCitationBody != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation(global::tryAGI.OpenAI.ContainerFileCitationBody value) => new Annotation((global::tryAGI.OpenAI.ContainerFileCitationBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ContainerFileCitationBody?(Annotation @this) => @this.ContainerFileCitationBody;

        /// <summary>
        /// 
        /// </summary>
        public Annotation(global::tryAGI.OpenAI.ContainerFileCitationBody? value)
        {
            ContainerFileCitationBody = value;
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
        public static implicit operator Annotation(global::tryAGI.OpenAI.FilePath value) => new Annotation((global::tryAGI.OpenAI.FilePath?)value);

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
            global::tryAGI.OpenAI.FileCitationBody? fileCitationBody,
            global::tryAGI.OpenAI.UrlCitationBody? urlCitationBody,
            global::tryAGI.OpenAI.ContainerFileCitationBody? containerFileCitationBody,
            global::tryAGI.OpenAI.FilePath? filePath
            )
        {
            FileCitationBody = fileCitationBody;
            UrlCitationBody = urlCitationBody;
            ContainerFileCitationBody = containerFileCitationBody;
            FilePath = filePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FilePath as object ??
            ContainerFileCitationBody as object ??
            UrlCitationBody as object ??
            FileCitationBody as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileCitationBody?.ToString() ??
            UrlCitationBody?.ToString() ??
            ContainerFileCitationBody?.ToString() ??
            FilePath?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileCitationBody && !IsUrlCitationBody && !IsContainerFileCitationBody && !IsFilePath || !IsFileCitationBody && IsUrlCitationBody && !IsContainerFileCitationBody && !IsFilePath || !IsFileCitationBody && !IsUrlCitationBody && IsContainerFileCitationBody && !IsFilePath || !IsFileCitationBody && !IsUrlCitationBody && !IsContainerFileCitationBody && IsFilePath;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FileCitationBody?, TResult>? fileCitationBody = null,
            global::System.Func<global::tryAGI.OpenAI.UrlCitationBody?, TResult>? urlCitationBody = null,
            global::System.Func<global::tryAGI.OpenAI.ContainerFileCitationBody?, TResult>? containerFileCitationBody = null,
            global::System.Func<global::tryAGI.OpenAI.FilePath?, TResult>? filePath = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitationBody && fileCitationBody != null)
            {
                return fileCitationBody(FileCitationBody!);
            }
            else if (IsUrlCitationBody && urlCitationBody != null)
            {
                return urlCitationBody(UrlCitationBody!);
            }
            else if (IsContainerFileCitationBody && containerFileCitationBody != null)
            {
                return containerFileCitationBody(ContainerFileCitationBody!);
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
            global::System.Action<global::tryAGI.OpenAI.FileCitationBody?>? fileCitationBody = null,
            global::System.Action<global::tryAGI.OpenAI.UrlCitationBody?>? urlCitationBody = null,
            global::System.Action<global::tryAGI.OpenAI.ContainerFileCitationBody?>? containerFileCitationBody = null,
            global::System.Action<global::tryAGI.OpenAI.FilePath?>? filePath = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitationBody)
            {
                fileCitationBody?.Invoke(FileCitationBody!);
            }
            else if (IsUrlCitationBody)
            {
                urlCitationBody?.Invoke(UrlCitationBody!);
            }
            else if (IsContainerFileCitationBody)
            {
                containerFileCitationBody?.Invoke(ContainerFileCitationBody!);
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
                FileCitationBody,
                typeof(global::tryAGI.OpenAI.FileCitationBody),
                UrlCitationBody,
                typeof(global::tryAGI.OpenAI.UrlCitationBody),
                ContainerFileCitationBody,
                typeof(global::tryAGI.OpenAI.ContainerFileCitationBody),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileCitationBody?>.Default.Equals(FileCitationBody, other.FileCitationBody) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UrlCitationBody?>.Default.Equals(UrlCitationBody, other.UrlCitationBody) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ContainerFileCitationBody?>.Default.Equals(ContainerFileCitationBody, other.ContainerFileCitationBody) &&
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
