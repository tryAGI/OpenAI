#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnnotationsItem4 : global::System.IEquatable<AnnotationsItem4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFileCitationParam? FileCitation { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFileCitationParam? FileCitation { get; }
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
            out global::tryAGI.OpenAI.BetaFileCitationParam? value)
        {
            value = FileCitation;
            return IsFileCitation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileCitationParam PickFileCitation() => IsFileCitation
            ? FileCitation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileCitation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaUrlCitationParam? UrlCitation { get; init; }
#else
        public global::tryAGI.OpenAI.BetaUrlCitationParam? UrlCitation { get; }
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
            out global::tryAGI.OpenAI.BetaUrlCitationParam? value)
        {
            value = UrlCitation;
            return IsUrlCitation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaUrlCitationParam PickUrlCitation() => IsUrlCitation
            ? UrlCitation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UrlCitation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaContainerFileCitationParam? ContainerFileCitation { get; init; }
#else
        public global::tryAGI.OpenAI.BetaContainerFileCitationParam? ContainerFileCitation { get; }
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
            out global::tryAGI.OpenAI.BetaContainerFileCitationParam? value)
        {
            value = ContainerFileCitation;
            return IsContainerFileCitation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerFileCitationParam PickContainerFileCitation() => IsContainerFileCitation
            ? ContainerFileCitation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerFileCitation' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem4(global::tryAGI.OpenAI.BetaFileCitationParam value) => new AnnotationsItem4((global::tryAGI.OpenAI.BetaFileCitationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFileCitationParam?(AnnotationsItem4 @this) => @this.FileCitation;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem4(global::tryAGI.OpenAI.BetaFileCitationParam? value)
        {
            FileCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnnotationsItem4 FromFileCitation(global::tryAGI.OpenAI.BetaFileCitationParam? value) => new AnnotationsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem4(global::tryAGI.OpenAI.BetaUrlCitationParam value) => new AnnotationsItem4((global::tryAGI.OpenAI.BetaUrlCitationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaUrlCitationParam?(AnnotationsItem4 @this) => @this.UrlCitation;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem4(global::tryAGI.OpenAI.BetaUrlCitationParam? value)
        {
            UrlCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnnotationsItem4 FromUrlCitation(global::tryAGI.OpenAI.BetaUrlCitationParam? value) => new AnnotationsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnnotationsItem4(global::tryAGI.OpenAI.BetaContainerFileCitationParam value) => new AnnotationsItem4((global::tryAGI.OpenAI.BetaContainerFileCitationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaContainerFileCitationParam?(AnnotationsItem4 @this) => @this.ContainerFileCitation;

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem4(global::tryAGI.OpenAI.BetaContainerFileCitationParam? value)
        {
            ContainerFileCitation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnnotationsItem4 FromContainerFileCitation(global::tryAGI.OpenAI.BetaContainerFileCitationParam? value) => new AnnotationsItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsItem4(
            global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaFileCitationParam? fileCitation,
            global::tryAGI.OpenAI.BetaUrlCitationParam? urlCitation,
            global::tryAGI.OpenAI.BetaContainerFileCitationParam? containerFileCitation
            )
        {
            Type = type;

            FileCitation = fileCitation;
            UrlCitation = urlCitation;
            ContainerFileCitation = containerFileCitation;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            ContainerFileCitation?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileCitation && !IsUrlCitation && !IsContainerFileCitation || !IsFileCitation && IsUrlCitation && !IsContainerFileCitation || !IsFileCitation && !IsUrlCitation && IsContainerFileCitation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaFileCitationParam, TResult>? fileCitation = null,
            global::System.Func<global::tryAGI.OpenAI.BetaUrlCitationParam, TResult>? urlCitation = null,
            global::System.Func<global::tryAGI.OpenAI.BetaContainerFileCitationParam, TResult>? containerFileCitation = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaFileCitationParam>? fileCitation = null,

            global::System.Action<global::tryAGI.OpenAI.BetaUrlCitationParam>? urlCitation = null,

            global::System.Action<global::tryAGI.OpenAI.BetaContainerFileCitationParam>? containerFileCitation = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaFileCitationParam>? fileCitation = null,
            global::System.Action<global::tryAGI.OpenAI.BetaUrlCitationParam>? urlCitation = null,
            global::System.Action<global::tryAGI.OpenAI.BetaContainerFileCitationParam>? containerFileCitation = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileCitation,
                typeof(global::tryAGI.OpenAI.BetaFileCitationParam),
                UrlCitation,
                typeof(global::tryAGI.OpenAI.BetaUrlCitationParam),
                ContainerFileCitation,
                typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParam),
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
        public bool Equals(AnnotationsItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFileCitationParam?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaUrlCitationParam?>.Default.Equals(UrlCitation, other.UrlCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaContainerFileCitationParam?>.Default.Equals(ContainerFileCitation, other.ContainerFileCitation) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnnotationsItem4 obj1, AnnotationsItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnnotationsItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnnotationsItem4 obj1, AnnotationsItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnnotationsItem4 o && Equals(o);
        }
    }
}
