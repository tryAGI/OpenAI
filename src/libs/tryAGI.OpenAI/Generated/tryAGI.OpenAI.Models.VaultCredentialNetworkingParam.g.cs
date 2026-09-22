#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Destination permissions for an environment-variable credential. These do not grant network access to the environment.
    /// </summary>
    public readonly partial struct VaultCredentialNetworkingParam : global::System.IEquatable<VaultCredentialNetworkingParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Allows substitution for destinations permitted by the environment network policy. Requires `environment.network.access` to be `restricted`, with explicit `allowed_domains`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? Unrestricted { get; init; }
#else
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? Unrestricted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unrestricted))]
#endif
        public bool IsUnrestricted => Unrestricted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnrestricted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? value)
        {
            value = Unrestricted;
            return IsUnrestricted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted PickUnrestricted() => IsUnrestricted
            ? Unrestricted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unrestricted' but the value was {ToString()}.");

        /// <summary>
        /// Allows substitution only for the listed hosts. The environment network policy must also allow these hosts.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? Limited { get; init; }
#else
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? Limited { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Limited))]
#endif
        public bool IsLimited => Limited != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLimited(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? value)
        {
            value = Limited;
            return IsLimited;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited PickLimited() => IsLimited
            ? Limited!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Limited' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VaultCredentialNetworkingParam(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted value) => new VaultCredentialNetworkingParam((global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted?(VaultCredentialNetworkingParam @this) => @this.Unrestricted;

        /// <summary>
        ///
        /// </summary>
        public VaultCredentialNetworkingParam(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? value)
        {
            Unrestricted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VaultCredentialNetworkingParam FromUnrestricted(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? value) => new VaultCredentialNetworkingParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VaultCredentialNetworkingParam(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited value) => new VaultCredentialNetworkingParam((global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited?(VaultCredentialNetworkingParam @this) => @this.Limited;

        /// <summary>
        ///
        /// </summary>
        public VaultCredentialNetworkingParam(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? value)
        {
            Limited = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VaultCredentialNetworkingParam FromLimited(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? value) => new VaultCredentialNetworkingParam(value);

        /// <summary>
        ///
        /// </summary>
        public VaultCredentialNetworkingParam(
            global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType? type,
            global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? unrestricted,
            global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? limited
            )
        {
            Type = type;

            Unrestricted = unrestricted;
            Limited = limited;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Limited as object ??
            Unrestricted as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Unrestricted?.ToString() ??
            Limited?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnrestricted && !IsLimited || !IsUnrestricted && IsLimited;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted, TResult>? unrestricted = null,
            global::System.Func<global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited, TResult>? limited = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnrestricted && unrestricted != null)
            {
                return unrestricted(Unrestricted!);
            }
            else if (IsLimited && limited != null)
            {
                return limited(Limited!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted>? unrestricted = null,

            global::System.Action<global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited>? limited = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnrestricted)
            {
                unrestricted?.Invoke(Unrestricted!);
            }
            else if (IsLimited)
            {
                limited?.Invoke(Limited!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted>? unrestricted = null,
            global::System.Action<global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited>? limited = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnrestricted)
            {
                unrestricted?.Invoke(Unrestricted!);
            }
            else if (IsLimited)
            {
                limited?.Invoke(Limited!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Unrestricted,
                typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted),
                Limited,
                typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited),
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
        public bool Equals(VaultCredentialNetworkingParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted?>.Default.Equals(Unrestricted, other.Unrestricted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited?>.Default.Equals(Limited, other.Limited)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(VaultCredentialNetworkingParam obj1, VaultCredentialNetworkingParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VaultCredentialNetworkingParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultCredentialNetworkingParam obj1, VaultCredentialNetworkingParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultCredentialNetworkingParam o && Equals(o);
        }
    }
}
