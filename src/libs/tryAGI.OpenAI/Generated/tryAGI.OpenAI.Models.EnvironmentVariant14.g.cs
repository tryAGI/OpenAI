#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EnvironmentVariant14 : global::System.IEquatable<EnvironmentVariant14>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaContainerAutoParam? ContainerAuto { get; init; }
#else
        public global::tryAGI.OpenAI.BetaContainerAutoParam? ContainerAuto { get; }
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
        public bool TryPickContainerAuto(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaContainerAutoParam? value)
        {
            value = ContainerAuto;
            return IsContainerAuto;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParam PickContainerAuto() => IsContainerAuto
            ? ContainerAuto!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerAuto' but the value was {ToString()}.");

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
        public global::tryAGI.OpenAI.BetaLocalEnvironmentParam PickLocal() => IsLocal
            ? Local!
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
        public global::tryAGI.OpenAI.BetaContainerReferenceParam PickContainerReference() => IsContainerReference
            ? ContainerReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerReference' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant14(global::tryAGI.OpenAI.BetaContainerAutoParam value) => new EnvironmentVariant14((global::tryAGI.OpenAI.BetaContainerAutoParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaContainerAutoParam?(EnvironmentVariant14 @this) => @this.ContainerAuto;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant14(global::tryAGI.OpenAI.BetaContainerAutoParam? value)
        {
            ContainerAuto = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant14 FromContainerAuto(global::tryAGI.OpenAI.BetaContainerAutoParam? value) => new EnvironmentVariant14(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant14(global::tryAGI.OpenAI.BetaLocalEnvironmentParam value) => new EnvironmentVariant14((global::tryAGI.OpenAI.BetaLocalEnvironmentParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaLocalEnvironmentParam?(EnvironmentVariant14 @this) => @this.Local;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant14(global::tryAGI.OpenAI.BetaLocalEnvironmentParam? value)
        {
            Local = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant14 FromLocal(global::tryAGI.OpenAI.BetaLocalEnvironmentParam? value) => new EnvironmentVariant14(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant14(global::tryAGI.OpenAI.BetaContainerReferenceParam value) => new EnvironmentVariant14((global::tryAGI.OpenAI.BetaContainerReferenceParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaContainerReferenceParam?(EnvironmentVariant14 @this) => @this.ContainerReference;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant14(global::tryAGI.OpenAI.BetaContainerReferenceParam? value)
        {
            ContainerReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant14 FromContainerReference(global::tryAGI.OpenAI.BetaContainerReferenceParam? value) => new EnvironmentVariant14(value);

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant14(
            global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType? type,
            global::tryAGI.OpenAI.BetaContainerAutoParam? containerAuto,
            global::tryAGI.OpenAI.BetaLocalEnvironmentParam? local,
            global::tryAGI.OpenAI.BetaContainerReferenceParam? containerReference
            )
        {
            Type = type;

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
            global::System.Func<global::tryAGI.OpenAI.BetaContainerAutoParam, TResult>? containerAuto = null,
            global::System.Func<global::tryAGI.OpenAI.BetaLocalEnvironmentParam, TResult>? local = null,
            global::System.Func<global::tryAGI.OpenAI.BetaContainerReferenceParam, TResult>? containerReference = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaContainerAutoParam>? containerAuto = null,

            global::System.Action<global::tryAGI.OpenAI.BetaLocalEnvironmentParam>? local = null,

            global::System.Action<global::tryAGI.OpenAI.BetaContainerReferenceParam>? containerReference = null,
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
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaContainerAutoParam>? containerAuto = null,
            global::System.Action<global::tryAGI.OpenAI.BetaLocalEnvironmentParam>? local = null,
            global::System.Action<global::tryAGI.OpenAI.BetaContainerReferenceParam>? containerReference = null,
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
                typeof(global::tryAGI.OpenAI.BetaContainerAutoParam),
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
        public bool Equals(EnvironmentVariant14 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaContainerAutoParam?>.Default.Equals(ContainerAuto, other.ContainerAuto) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaLocalEnvironmentParam?>.Default.Equals(Local, other.Local) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaContainerReferenceParam?>.Default.Equals(ContainerReference, other.ContainerReference)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EnvironmentVariant14 obj1, EnvironmentVariant14 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvironmentVariant14>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EnvironmentVariant14 obj1, EnvironmentVariant14 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvironmentVariant14 o && Equals(o);
        }
    }
}
