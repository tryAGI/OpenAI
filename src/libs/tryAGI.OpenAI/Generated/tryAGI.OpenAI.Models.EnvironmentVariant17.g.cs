#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The environment to execute the shell commands in.
    /// </summary>
    public readonly partial struct EnvironmentVariant17 : global::System.IEquatable<EnvironmentVariant17>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParam? Local { get; init; }
#else
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParam? Local { get; }
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
            out global::tryAGI.OpenAI.BetaLocalEnvironmentParam? value)
        {
            value = Local;
            return IsLocal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParam PickLocal() => Local is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Local' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaContainerReferenceParam? ContainerReference { get; init; }
#else
        public global::tryAGI.OpenAI.BetaContainerReferenceParam? ContainerReference { get; }
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
            out global::tryAGI.OpenAI.BetaContainerReferenceParam? value)
        {
            value = ContainerReference;
            return IsContainerReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerReferenceParam PickContainerReference() => ContainerReference is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerReference' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant17(global::tryAGI.OpenAI.BetaLocalEnvironmentParam value) => new EnvironmentVariant17((global::tryAGI.OpenAI.BetaLocalEnvironmentParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaLocalEnvironmentParam?(EnvironmentVariant17 @this) => @this.Local;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant17(global::tryAGI.OpenAI.BetaLocalEnvironmentParam? value)
        {
            Local = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant17 FromLocal(global::tryAGI.OpenAI.BetaLocalEnvironmentParam? value) => new EnvironmentVariant17(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant17(global::tryAGI.OpenAI.BetaContainerReferenceParam value) => new EnvironmentVariant17((global::tryAGI.OpenAI.BetaContainerReferenceParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaContainerReferenceParam?(EnvironmentVariant17 @this) => @this.ContainerReference;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant17(global::tryAGI.OpenAI.BetaContainerReferenceParam? value)
        {
            ContainerReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant17 FromContainerReference(global::tryAGI.OpenAI.BetaContainerReferenceParam? value) => new EnvironmentVariant17(value);

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant17(
            global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType? type,
            global::tryAGI.OpenAI.BetaLocalEnvironmentParam? local,
            global::tryAGI.OpenAI.BetaContainerReferenceParam? containerReference
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
            global::System.Func<global::tryAGI.OpenAI.BetaLocalEnvironmentParam, TResult>? local = null,
            global::System.Func<global::tryAGI.OpenAI.BetaContainerReferenceParam, TResult>? containerReference = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaLocalEnvironmentParam>? local = null,

            global::System.Action<global::tryAGI.OpenAI.BetaContainerReferenceParam>? containerReference = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaLocalEnvironmentParam>? local = null,
            global::System.Action<global::tryAGI.OpenAI.BetaContainerReferenceParam>? containerReference = null,
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
                typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParam),
                ContainerReference,
                typeof(global::tryAGI.OpenAI.BetaContainerReferenceParam),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaLocalEnvironmentParam?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaContainerReferenceParam?>.Default.Equals(ContainerReference, other.ContainerReference)
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
