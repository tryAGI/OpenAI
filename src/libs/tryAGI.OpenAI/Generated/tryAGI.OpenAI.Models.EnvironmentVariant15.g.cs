#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The environment to execute the shell commands in.
    /// </summary>
    public readonly partial struct EnvironmentVariant15 : global::System.IEquatable<EnvironmentVariant15>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type { get; }

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
        public bool TryPickLocal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LocalEnvironmentParam? value)
        {
            value = Local;
            return IsLocal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LocalEnvironmentParam PickLocal() => Local is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Local' but the value was {ToString()}.");

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
        public bool TryPickContainerReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ContainerReferenceParam? value)
        {
            value = ContainerReference;
            return IsContainerReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ContainerReferenceParam PickContainerReference() => ContainerReference is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerReference' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant15(global::tryAGI.OpenAI.LocalEnvironmentParam value) => new EnvironmentVariant15((global::tryAGI.OpenAI.LocalEnvironmentParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalEnvironmentParam?(EnvironmentVariant15 @this) => @this.Local;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant15(global::tryAGI.OpenAI.LocalEnvironmentParam? value)
        {
            Local = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant15 FromLocal(global::tryAGI.OpenAI.LocalEnvironmentParam? value) => new EnvironmentVariant15(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant15(global::tryAGI.OpenAI.ContainerReferenceParam value) => new EnvironmentVariant15((global::tryAGI.OpenAI.ContainerReferenceParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ContainerReferenceParam?(EnvironmentVariant15 @this) => @this.ContainerReference;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant15(global::tryAGI.OpenAI.ContainerReferenceParam? value)
        {
            ContainerReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant15 FromContainerReference(global::tryAGI.OpenAI.ContainerReferenceParam? value) => new EnvironmentVariant15(value);

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant15(
            global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? type,
            global::tryAGI.OpenAI.LocalEnvironmentParam? local,
            global::tryAGI.OpenAI.ContainerReferenceParam? containerReference
            )
        {
            Type = type;

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
            global::System.Func<global::tryAGI.OpenAI.LocalEnvironmentParam, TResult>? local = null,
            global::System.Func<global::tryAGI.OpenAI.ContainerReferenceParam, TResult>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Local is { } __value0 && local != null)
            {
                return local(__value0);
            }
            else if (ContainerReference is { } __value1 && containerReference != null)
            {
                return containerReference(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LocalEnvironmentParam>? local = null,

            global::System.Action<global::tryAGI.OpenAI.ContainerReferenceParam>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Local is { } __value0)
            {
                local?.Invoke(__value0);
            }
            else if (ContainerReference is { } __value1)
            {
                containerReference?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LocalEnvironmentParam>? local = null,
            global::System.Action<global::tryAGI.OpenAI.ContainerReferenceParam>? containerReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Local is { } __value0)
            {
                local?.Invoke(__value0);
            }
            else if (ContainerReference is { } __value1)
            {
                containerReference?.Invoke(__value1);
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
        public bool Equals(EnvironmentVariant15 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalEnvironmentParam?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ContainerReferenceParam?>.Default.Equals(ContainerReference, other.ContainerReference)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EnvironmentVariant15 obj1, EnvironmentVariant15 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvironmentVariant15>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EnvironmentVariant15 obj1, EnvironmentVariant15 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvironmentVariant15 o && Equals(o);
        }
    }
}
