#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Annotation2 : global::System.IEquatable<Annotation2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FileCitationBody2? FileCitationBody2 { get; init; }
#else
        public global::tryAGI.OpenAI.FileCitationBody2? FileCitationBody2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileCitationBody2))]
#endif
        public bool IsFileCitationBody2 => FileCitationBody2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation2(global::tryAGI.OpenAI.FileCitationBody2 value) => new Annotation2((global::tryAGI.OpenAI.FileCitationBody2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileCitationBody2?(Annotation2 @this) => @this.FileCitationBody2;

        /// <summary>
        /// 
        /// </summary>
        public Annotation2(global::tryAGI.OpenAI.FileCitationBody2? value)
        {
            FileCitationBody2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.UrlCitationBody2? UrlCitationBody2 { get; init; }
#else
        public global::tryAGI.OpenAI.UrlCitationBody2? UrlCitationBody2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UrlCitationBody2))]
#endif
        public bool IsUrlCitationBody2 => UrlCitationBody2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation2(global::tryAGI.OpenAI.UrlCitationBody2 value) => new Annotation2((global::tryAGI.OpenAI.UrlCitationBody2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.UrlCitationBody2?(Annotation2 @this) => @this.UrlCitationBody2;

        /// <summary>
        /// 
        /// </summary>
        public Annotation2(global::tryAGI.OpenAI.UrlCitationBody2? value)
        {
            UrlCitationBody2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ContainerFileCitationBody2? ContainerFileCitationBody2 { get; init; }
#else
        public global::tryAGI.OpenAI.ContainerFileCitationBody2? ContainerFileCitationBody2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerFileCitationBody2))]
#endif
        public bool IsContainerFileCitationBody2 => ContainerFileCitationBody2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Annotation2(global::tryAGI.OpenAI.ContainerFileCitationBody2 value) => new Annotation2((global::tryAGI.OpenAI.ContainerFileCitationBody2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ContainerFileCitationBody2?(Annotation2 @this) => @this.ContainerFileCitationBody2;

        /// <summary>
        /// 
        /// </summary>
        public Annotation2(global::tryAGI.OpenAI.ContainerFileCitationBody2? value)
        {
            ContainerFileCitationBody2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Annotation2(
            global::tryAGI.OpenAI.FileCitationBody2? fileCitationBody2,
            global::tryAGI.OpenAI.UrlCitationBody2? urlCitationBody2,
            global::tryAGI.OpenAI.ContainerFileCitationBody2? containerFileCitationBody2
            )
        {
            FileCitationBody2 = fileCitationBody2;
            UrlCitationBody2 = urlCitationBody2;
            ContainerFileCitationBody2 = containerFileCitationBody2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContainerFileCitationBody2 as object ??
            UrlCitationBody2 as object ??
            FileCitationBody2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileCitationBody2?.ToString() ??
            UrlCitationBody2?.ToString() ??
            ContainerFileCitationBody2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileCitationBody2 || IsUrlCitationBody2 || IsContainerFileCitationBody2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FileCitationBody2?, TResult>? fileCitationBody2 = null,
            global::System.Func<global::tryAGI.OpenAI.UrlCitationBody2?, TResult>? urlCitationBody2 = null,
            global::System.Func<global::tryAGI.OpenAI.ContainerFileCitationBody2?, TResult>? containerFileCitationBody2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitationBody2 && fileCitationBody2 != null)
            {
                return fileCitationBody2(FileCitationBody2!);
            }
            else if (IsUrlCitationBody2 && urlCitationBody2 != null)
            {
                return urlCitationBody2(UrlCitationBody2!);
            }
            else if (IsContainerFileCitationBody2 && containerFileCitationBody2 != null)
            {
                return containerFileCitationBody2(ContainerFileCitationBody2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.FileCitationBody2?>? fileCitationBody2 = null,
            global::System.Action<global::tryAGI.OpenAI.UrlCitationBody2?>? urlCitationBody2 = null,
            global::System.Action<global::tryAGI.OpenAI.ContainerFileCitationBody2?>? containerFileCitationBody2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitationBody2)
            {
                fileCitationBody2?.Invoke(FileCitationBody2!);
            }
            else if (IsUrlCitationBody2)
            {
                urlCitationBody2?.Invoke(UrlCitationBody2!);
            }
            else if (IsContainerFileCitationBody2)
            {
                containerFileCitationBody2?.Invoke(ContainerFileCitationBody2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileCitationBody2,
                typeof(global::tryAGI.OpenAI.FileCitationBody2),
                UrlCitationBody2,
                typeof(global::tryAGI.OpenAI.UrlCitationBody2),
                ContainerFileCitationBody2,
                typeof(global::tryAGI.OpenAI.ContainerFileCitationBody2),
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
        public bool Equals(Annotation2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileCitationBody2?>.Default.Equals(FileCitationBody2, other.FileCitationBody2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.UrlCitationBody2?>.Default.Equals(UrlCitationBody2, other.UrlCitationBody2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ContainerFileCitationBody2?>.Default.Equals(ContainerFileCitationBody2, other.ContainerFileCitationBody2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Annotation2 obj1, Annotation2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Annotation2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Annotation2 obj1, Annotation2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Annotation2 o && Equals(o);
        }
    }
}
