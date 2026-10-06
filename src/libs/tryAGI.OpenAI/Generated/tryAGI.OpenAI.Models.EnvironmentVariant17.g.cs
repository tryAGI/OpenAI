#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EnvironmentVariant17 : global::System.IEquatable<EnvironmentVariant17>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Represents the use of a local environment to perform shell actions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResource? Local { get; init; }
#else
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResource? Local { get; }
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
            out global::tryAGI.OpenAI.BetaLocalEnvironmentResource? value)
        {
            value = Local;
            return IsLocal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentResource PickLocal() => Local is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Local' but the value was {ToString()}.");

        /// <summary>
        /// Represents a container created with /v1/containers.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaContainerReferenceResource? ContainerReference { get; init; }
#else
        public global::tryAGI.OpenAI.BetaContainerReferenceResource? ContainerReference { get; }
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
            out global::tryAGI.OpenAI.BetaContainerReferenceResource? value)
        {
            value = ContainerReference;
            return IsContainerReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceResource PickContainerReference() => ContainerReference is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerReference' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant17(global::tryAGI.OpenAI.BetaLocalEnvironmentResource value) => new EnvironmentVariant17((global::tryAGI.OpenAI.BetaLocalEnvironmentResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaLocalEnvironmentResource?(EnvironmentVariant17 @this) => @this.Local;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant17(global::tryAGI.OpenAI.BetaLocalEnvironmentResource? value)
        {
            Local = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant17 FromLocal(global::tryAGI.OpenAI.BetaLocalEnvironmentResource? value) => new EnvironmentVariant17(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant17(global::tryAGI.OpenAI.BetaContainerReferenceResource value) => new EnvironmentVariant17((global::tryAGI.OpenAI.BetaContainerReferenceResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaContainerReferenceResource?(EnvironmentVariant17 @this) => @this.ContainerReference;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant17(global::tryAGI.OpenAI.BetaContainerReferenceResource? value)
        {
            ContainerReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant17 FromContainerReference(global::tryAGI.OpenAI.BetaContainerReferenceResource? value) => new EnvironmentVariant17(value);

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant17(
            global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType? type,
            global::tryAGI.OpenAI.BetaLocalEnvironmentResource? local,
            global::tryAGI.OpenAI.BetaContainerReferenceResource? containerReference
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
            global::System.Func<global::tryAGI.OpenAI.BetaLocalEnvironmentResource, TResult>? local = null,
            global::System.Func<global::tryAGI.OpenAI.BetaContainerReferenceResource, TResult>? containerReference = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaLocalEnvironmentResource>? local = null,

            global::System.Action<global::tryAGI.OpenAI.BetaContainerReferenceResource>? containerReference = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaLocalEnvironmentResource>? local = null,
            global::System.Action<global::tryAGI.OpenAI.BetaContainerReferenceResource>? containerReference = null,
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
                typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResource),
                ContainerReference,
                typeof(global::tryAGI.OpenAI.BetaContainerReferenceResource),
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
        public bool Equals(EnvironmentVariant17 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaLocalEnvironmentResource?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaContainerReferenceResource?>.Default.Equals(ContainerReference, other.ContainerReference)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EnvironmentVariant17 obj1, EnvironmentVariant17 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvironmentVariant17>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EnvironmentVariant17 obj1, EnvironmentVariant17 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvironmentVariant17 o && Equals(o);
        }
    }
}
