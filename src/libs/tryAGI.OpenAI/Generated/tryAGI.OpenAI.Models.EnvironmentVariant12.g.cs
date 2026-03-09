#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EnvironmentVariant12 : global::System.IEquatable<EnvironmentVariant12>
    {
        /// <summary>
        /// Represents the use of a local environment to perform shell actions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LocalEnvironmentResource? Local { get; init; }
#else
        public global::tryAGI.OpenAI.LocalEnvironmentResource? Local { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Local))]
#endif
        public bool IsLocal => Local != null;

        /// <summary>
        /// Represents a container created with /v1/containers.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ContainerReferenceResource? ContainerReference { get; init; }
#else
        public global::tryAGI.OpenAI.ContainerReferenceResource? ContainerReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerReference))]
#endif
        public bool IsContainerReference => ContainerReference != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EnvironmentVariant12(global::tryAGI.OpenAI.LocalEnvironmentResource value) => new EnvironmentVariant12((global::tryAGI.OpenAI.LocalEnvironmentResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalEnvironmentResource?(EnvironmentVariant12 @this) => @this.Local;

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariant12(global::tryAGI.OpenAI.LocalEnvironmentResource? value)
        {
            Local = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EnvironmentVariant12(global::tryAGI.OpenAI.ContainerReferenceResource value) => new EnvironmentVariant12((global::tryAGI.OpenAI.ContainerReferenceResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ContainerReferenceResource?(EnvironmentVariant12 @this) => @this.ContainerReference;

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariant12(global::tryAGI.OpenAI.ContainerReferenceResource? value)
        {
            ContainerReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariant12(
            global::tryAGI.OpenAI.LocalEnvironmentResource? local,
            global::tryAGI.OpenAI.ContainerReferenceResource? containerReference
            )
        {
            Local = local;
            ContainerReference = containerReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContainerReference as object ??
            Local as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Local?.ToString() ??
            ContainerReference?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLocal && !IsContainerReference || !IsLocal && IsContainerReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LocalEnvironmentResource?, TResult>? local = null,
            global::System.Func<global::tryAGI.OpenAI.ContainerReferenceResource?, TResult>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLocal && local != null)
            {
                return local(Local!);
            }
            else if (IsContainerReference && containerReference != null)
            {
                return containerReference(ContainerReference!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LocalEnvironmentResource?>? local = null,
            global::System.Action<global::tryAGI.OpenAI.ContainerReferenceResource?>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLocal)
            {
                local?.Invoke(Local!);
            }
            else if (IsContainerReference)
            {
                containerReference?.Invoke(ContainerReference!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Local,
                typeof(global::tryAGI.OpenAI.LocalEnvironmentResource),
                ContainerReference,
                typeof(global::tryAGI.OpenAI.ContainerReferenceResource),
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
        public bool Equals(EnvironmentVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalEnvironmentResource?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ContainerReferenceResource?>.Default.Equals(ContainerReference, other.ContainerReference) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EnvironmentVariant12 obj1, EnvironmentVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvironmentVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EnvironmentVariant12 obj1, EnvironmentVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvironmentVariant12 o && Equals(o);
        }
    }
}
