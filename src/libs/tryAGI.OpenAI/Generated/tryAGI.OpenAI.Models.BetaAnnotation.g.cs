#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An annotation that applies to a span of output text.
    /// </summary>
    public readonly partial struct BetaAnnotation : global::System.IEquatable<BetaAnnotation>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType? Type { get; }

        /// <summary>
        /// A citation to a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFileCitationBody? FileCitation { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFileCitationBody? FileCitation { get; }
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
        public bool TryPickFileCitation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFileCitationBody? value)
        {
            value = FileCitation;
            return IsFileCitation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationBody PickFileCitation() => IsFileCitation
            ? FileCitation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileCitation' but the value was {ToString()}.");

        /// <summary>
        /// A citation for a web resource used to generate a model response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaUrlCitationBody? UrlCitation { get; init; }
#else
        public global::tryAGI.OpenAI.BetaUrlCitationBody? UrlCitation { get; }
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
        public bool TryPickUrlCitation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaUrlCitationBody? value)
        {
            value = UrlCitation;
            return IsUrlCitation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationBody PickUrlCitation() => IsUrlCitation
            ? UrlCitation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UrlCitation' but the value was {ToString()}.");

        /// <summary>
        /// A citation for a container file used to generate a model response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaContainerFileCitationBody? ContainerFileCitation { get; init; }
#else
        public global::tryAGI.OpenAI.BetaContainerFileCitationBody? ContainerFileCitation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerFileCitation))]
#endif
        public bool IsContainerFileCitation => ContainerFileCitation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContainerFileCitation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaContainerFileCitationBody? value)
        {
            value = ContainerFileCitation;
            return IsContainerFileCitation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationBody PickContainerFileCitation() => IsContainerFileCitation
            ? ContainerFileCitation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerFileCitation' but the value was {ToString()}.");

        /// <summary>
        /// A path to a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFilePath? FilePath { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFilePath? FilePath { get; }
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
        public bool TryPickFilePath(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFilePath? value)
        {
            value = FilePath;
            return IsFilePath;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFilePath PickFilePath() => IsFilePath
            ? FilePath!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FilePath' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnnotation(global::tryAGI.OpenAI.BetaFileCitationBody value) => new BetaAnnotation((global::tryAGI.OpenAI.BetaFileCitationBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFileCitationBody?(BetaAnnotation @this) => @this.FileCitation;

        /// <summary>
        ///
        /// </summary>
        public BetaAnnotation(global::tryAGI.OpenAI.BetaFileCitationBody? value)
        {
            FileCitation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnnotation FromFileCitation(global::tryAGI.OpenAI.BetaFileCitationBody? value) => new BetaAnnotation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnnotation(global::tryAGI.OpenAI.BetaUrlCitationBody value) => new BetaAnnotation((global::tryAGI.OpenAI.BetaUrlCitationBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaUrlCitationBody?(BetaAnnotation @this) => @this.UrlCitation;

        /// <summary>
        ///
        /// </summary>
        public BetaAnnotation(global::tryAGI.OpenAI.BetaUrlCitationBody? value)
        {
            UrlCitation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnnotation FromUrlCitation(global::tryAGI.OpenAI.BetaUrlCitationBody? value) => new BetaAnnotation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnnotation(global::tryAGI.OpenAI.BetaContainerFileCitationBody value) => new BetaAnnotation((global::tryAGI.OpenAI.BetaContainerFileCitationBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaContainerFileCitationBody?(BetaAnnotation @this) => @this.ContainerFileCitation;

        /// <summary>
        ///
        /// </summary>
        public BetaAnnotation(global::tryAGI.OpenAI.BetaContainerFileCitationBody? value)
        {
            ContainerFileCitation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnnotation FromContainerFileCitation(global::tryAGI.OpenAI.BetaContainerFileCitationBody? value) => new BetaAnnotation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnnotation(global::tryAGI.OpenAI.BetaFilePath value) => new BetaAnnotation((global::tryAGI.OpenAI.BetaFilePath?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFilePath?(BetaAnnotation @this) => @this.FilePath;

        /// <summary>
        ///
        /// </summary>
        public BetaAnnotation(global::tryAGI.OpenAI.BetaFilePath? value)
        {
            FilePath = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnnotation FromFilePath(global::tryAGI.OpenAI.BetaFilePath? value) => new BetaAnnotation(value);

        /// <summary>
        ///
        /// </summary>
        public BetaAnnotation(
            global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaFileCitationBody? fileCitation,
            global::tryAGI.OpenAI.BetaUrlCitationBody? urlCitation,
            global::tryAGI.OpenAI.BetaContainerFileCitationBody? containerFileCitation,
            global::tryAGI.OpenAI.BetaFilePath? filePath
            )
        {
            Type = type;

            FileCitation = fileCitation;
            UrlCitation = urlCitation;
            ContainerFileCitation = containerFileCitation;
            FilePath = filePath;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FilePath as object ??
            ContainerFileCitation as object ??
            UrlCitation as object ??
            FileCitation as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            FileCitation?.ToString() ??
            UrlCitation?.ToString() ??
            ContainerFileCitation?.ToString() ??
            FilePath?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFileCitation && !IsUrlCitation && !IsContainerFileCitation && !IsFilePath || !IsFileCitation && IsUrlCitation && !IsContainerFileCitation && !IsFilePath || !IsFileCitation && !IsUrlCitation && IsContainerFileCitation && !IsFilePath || !IsFileCitation && !IsUrlCitation && !IsContainerFileCitation && IsFilePath;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaFileCitationBody, TResult>? fileCitation = null,
            global::System.Func<global::tryAGI.OpenAI.BetaUrlCitationBody, TResult>? urlCitation = null,
            global::System.Func<global::tryAGI.OpenAI.BetaContainerFileCitationBody, TResult>? containerFileCitation = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFilePath, TResult>? filePath = null,
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
            else if (IsContainerFileCitation && containerFileCitation != null)
            {
                return containerFileCitation(ContainerFileCitation!);
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
            global::System.Action<global::tryAGI.OpenAI.BetaFileCitationBody>? fileCitation = null,

            global::System.Action<global::tryAGI.OpenAI.BetaUrlCitationBody>? urlCitation = null,

            global::System.Action<global::tryAGI.OpenAI.BetaContainerFileCitationBody>? containerFileCitation = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFilePath>? filePath = null,
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
            else if (IsContainerFileCitation)
            {
                containerFileCitation?.Invoke(ContainerFileCitation!);
            }
            else if (IsFilePath)
            {
                filePath?.Invoke(FilePath!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaFileCitationBody>? fileCitation = null,
            global::System.Action<global::tryAGI.OpenAI.BetaUrlCitationBody>? urlCitation = null,
            global::System.Action<global::tryAGI.OpenAI.BetaContainerFileCitationBody>? containerFileCitation = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFilePath>? filePath = null,
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
            else if (IsContainerFileCitation)
            {
                containerFileCitation?.Invoke(ContainerFileCitation!);
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
                typeof(global::tryAGI.OpenAI.BetaFileCitationBody),
                UrlCitation,
                typeof(global::tryAGI.OpenAI.BetaUrlCitationBody),
                ContainerFileCitation,
                typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBody),
                FilePath,
                typeof(global::tryAGI.OpenAI.BetaFilePath),
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
        public bool Equals(BetaAnnotation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFileCitationBody?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaUrlCitationBody?>.Default.Equals(UrlCitation, other.UrlCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaContainerFileCitationBody?>.Default.Equals(ContainerFileCitation, other.ContainerFileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFilePath?>.Default.Equals(FilePath, other.FilePath)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaAnnotation obj1, BetaAnnotation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaAnnotation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaAnnotation obj1, BetaAnnotation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaAnnotation o && Equals(o);
        }
    }
}
