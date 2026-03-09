#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EnvironmentVariant1 : global::System.IEquatable<EnvironmentVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ContainerAutoParam? ContainerAuto { get; init; }
#else
        public global::tryAGI.OpenAI.ContainerAutoParam? ContainerAuto { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerAuto))]
#endif
        public bool IsContainerAuto => ContainerAuto != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LocalEnvironmentParam? Local { get; init; }
#else
        public global::tryAGI.OpenAI.LocalEnvironmentParam? Local { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Local))]
#endif
        public bool IsLocal => Local != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ContainerReferenceParam? ContainerReference { get; init; }
#else
        public global::tryAGI.OpenAI.ContainerReferenceParam? ContainerReference { get; }
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
        public static implicit operator EnvironmentVariant1(global::tryAGI.OpenAI.ContainerAutoParam value) => new EnvironmentVariant1((global::tryAGI.OpenAI.ContainerAutoParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ContainerAutoParam?(EnvironmentVariant1 @this) => @this.ContainerAuto;

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariant1(global::tryAGI.OpenAI.ContainerAutoParam? value)
        {
            ContainerAuto = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EnvironmentVariant1(global::tryAGI.OpenAI.LocalEnvironmentParam value) => new EnvironmentVariant1((global::tryAGI.OpenAI.LocalEnvironmentParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalEnvironmentParam?(EnvironmentVariant1 @this) => @this.Local;

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariant1(global::tryAGI.OpenAI.LocalEnvironmentParam? value)
        {
            Local = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EnvironmentVariant1(global::tryAGI.OpenAI.ContainerReferenceParam value) => new EnvironmentVariant1((global::tryAGI.OpenAI.ContainerReferenceParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ContainerReferenceParam?(EnvironmentVariant1 @this) => @this.ContainerReference;

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariant1(global::tryAGI.OpenAI.ContainerReferenceParam? value)
        {
            ContainerReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariant1(
            global::tryAGI.OpenAI.ContainerAutoParam? containerAuto,
            global::tryAGI.OpenAI.LocalEnvironmentParam? local,
            global::tryAGI.OpenAI.ContainerReferenceParam? containerReference
            )
        {
            ContainerAuto = containerAuto;
            Local = local;
            ContainerReference = containerReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContainerReference as object ??
            Local as object ??
            ContainerAuto as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ContainerAuto?.ToString() ??
            Local?.ToString() ??
            ContainerReference?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsContainerAuto && !IsLocal && !IsContainerReference || !IsContainerAuto && IsLocal && !IsContainerReference || !IsContainerAuto && !IsLocal && IsContainerReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ContainerAutoParam?, TResult>? containerAuto = null,
            global::System.Func<global::tryAGI.OpenAI.LocalEnvironmentParam?, TResult>? local = null,
            global::System.Func<global::tryAGI.OpenAI.ContainerReferenceParam?, TResult>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContainerAuto && containerAuto != null)
            {
                return containerAuto(ContainerAuto!);
            }
            else if (IsLocal && local != null)
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
            global::System.Action<global::tryAGI.OpenAI.ContainerAutoParam?>? containerAuto = null,
            global::System.Action<global::tryAGI.OpenAI.LocalEnvironmentParam?>? local = null,
            global::System.Action<global::tryAGI.OpenAI.ContainerReferenceParam?>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContainerAuto)
            {
                containerAuto?.Invoke(ContainerAuto!);
            }
            else if (IsLocal)
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
                ContainerAuto,
                typeof(global::tryAGI.OpenAI.ContainerAutoParam),
                Local,
                typeof(global::tryAGI.OpenAI.LocalEnvironmentParam),
                ContainerReference,
                typeof(global::tryAGI.OpenAI.ContainerReferenceParam),
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
        public bool Equals(EnvironmentVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ContainerAutoParam?>.Default.Equals(ContainerAuto, other.ContainerAuto) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalEnvironmentParam?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ContainerReferenceParam?>.Default.Equals(ContainerReference, other.ContainerReference) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EnvironmentVariant1 obj1, EnvironmentVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvironmentVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EnvironmentVariant1 obj1, EnvironmentVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvironmentVariant1 o && Equals(o);
        }
    }
}
