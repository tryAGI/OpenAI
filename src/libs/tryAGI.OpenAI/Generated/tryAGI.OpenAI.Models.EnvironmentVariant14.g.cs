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
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam? ContainerAuto { get; init; }
#else
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam? ContainerAuto { get; }
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
            out global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam? value)
        {
            value = ContainerAuto;
            return IsContainerAuto;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam PickContainerAuto() => ContainerAuto is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerAuto' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveContainerReferenceParam? ContainerReference { get; init; }
#else
        public global::tryAGI.OpenAI.LiveContainerReferenceParam? ContainerReference { get; }
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
            out global::tryAGI.OpenAI.LiveContainerReferenceParam? value)
        {
            value = ContainerReference;
            return IsContainerReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerReferenceParam PickContainerReference() => ContainerReference is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerReference' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParam? Local { get; init; }
#else
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParam? Local { get; }
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
            out global::tryAGI.OpenAI.LiveLocalEnvironmentParam? value)
        {
            value = Local;
            return IsLocal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveLocalEnvironmentParam PickLocal() => Local is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Local' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant14(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam value) => new EnvironmentVariant14((global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam?(EnvironmentVariant14 @this) => @this.ContainerAuto;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant14(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam? value)
        {
            ContainerAuto = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant14 FromContainerAuto(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam? value) => new EnvironmentVariant14(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant14(global::tryAGI.OpenAI.LiveContainerReferenceParam value) => new EnvironmentVariant14((global::tryAGI.OpenAI.LiveContainerReferenceParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveContainerReferenceParam?(EnvironmentVariant14 @this) => @this.ContainerReference;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant14(global::tryAGI.OpenAI.LiveContainerReferenceParam? value)
        {
            ContainerReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant14 FromContainerReference(global::tryAGI.OpenAI.LiveContainerReferenceParam? value) => new EnvironmentVariant14(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentVariant14(global::tryAGI.OpenAI.LiveLocalEnvironmentParam value) => new EnvironmentVariant14((global::tryAGI.OpenAI.LiveLocalEnvironmentParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveLocalEnvironmentParam?(EnvironmentVariant14 @this) => @this.Local;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant14(global::tryAGI.OpenAI.LiveLocalEnvironmentParam? value)
        {
            Local = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentVariant14 FromLocal(global::tryAGI.OpenAI.LiveLocalEnvironmentParam? value) => new EnvironmentVariant14(value);

        /// <summary>
        ///
        /// </summary>
        public EnvironmentVariant14(
            global::tryAGI.OpenAI.LiveHostedShellToolInputParamEnvironmentVariant1DiscriminatorType? type,
            global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam? containerAuto,
            global::tryAGI.OpenAI.LiveContainerReferenceParam? containerReference,
            global::tryAGI.OpenAI.LiveLocalEnvironmentParam? local
            )
        {
            Type = type;

            ContainerAuto = containerAuto;
            ContainerReference = containerReference;
            Local = local;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Local as object ??
            ContainerReference as object ??
            ContainerAuto as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ContainerAuto?.ToString() ??
            ContainerReference?.ToString() ??
            Local?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsContainerAuto && !IsContainerReference && !IsLocal || !IsContainerAuto && IsContainerReference && !IsLocal || !IsContainerAuto && !IsContainerReference && IsLocal;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam, TResult>? containerAuto = null,
            global::System.Func<global::tryAGI.OpenAI.LiveContainerReferenceParam, TResult>? containerReference = null,
            global::System.Func<global::tryAGI.OpenAI.LiveLocalEnvironmentParam, TResult>? local = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContainerAuto is { } __value0 && containerAuto != null)
            {
                return containerAuto(__value0);
            }
            else if (ContainerReference is { } __value1 && containerReference != null)
            {
                return containerReference(__value1);
            }
            else if (Local is { } __value2 && local != null)
            {
                return local(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam>? containerAuto = null,

            global::System.Action<global::tryAGI.OpenAI.LiveContainerReferenceParam>? containerReference = null,

            global::System.Action<global::tryAGI.OpenAI.LiveLocalEnvironmentParam>? local = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContainerAuto is { } __value0)
            {
                containerAuto?.Invoke(__value0);
            }
            else if (ContainerReference is { } __value1)
            {
                containerReference?.Invoke(__value1);
            }
            else if (Local is { } __value2)
            {
                local?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam>? containerAuto = null,
            global::System.Action<global::tryAGI.OpenAI.LiveContainerReferenceParam>? containerReference = null,
            global::System.Action<global::tryAGI.OpenAI.LiveLocalEnvironmentParam>? local = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContainerAuto is { } __value0)
            {
                containerAuto?.Invoke(__value0);
            }
            else if (ContainerReference is { } __value1)
            {
                containerReference?.Invoke(__value1);
            }
            else if (Local is { } __value2)
            {
                local?.Invoke(__value2);
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
                typeof(global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam),
                ContainerReference,
                typeof(global::tryAGI.OpenAI.LiveContainerReferenceParam),
                Local,
                typeof(global::tryAGI.OpenAI.LiveLocalEnvironmentParam),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveHostedShellContainerAutoParam?>.Default.Equals(ContainerAuto, other.ContainerAuto) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveContainerReferenceParam?>.Default.Equals(ContainerReference, other.ContainerReference) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveLocalEnvironmentParam?>.Default.Equals(Local, other.Local)
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
