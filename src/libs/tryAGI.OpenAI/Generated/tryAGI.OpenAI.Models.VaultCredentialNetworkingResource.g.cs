#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Destination permissions for an environment-variable credential. These do not grant network access to the environment.
    /// </summary>
    public readonly partial struct VaultCredentialNetworkingResource : global::System.IEquatable<VaultCredentialNetworkingResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Allows substitution for destinations permitted by the environment network policy. Requires `environment.network.access` to be `restricted`, with explicit `allowed_domains`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? Unrestricted { get; init; }
#else
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? Unrestricted { get; }
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
            out global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? value)
        {
            value = Unrestricted;
            return IsUnrestricted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted PickUnrestricted() => IsUnrestricted
            ? Unrestricted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unrestricted' but the value was {ToString()}.");

        /// <summary>
        /// Allows substitution only for the listed hosts. The environment network policy must also allow these hosts.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? Limited { get; init; }
#else
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? Limited { get; }
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
            out global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? value)
        {
            value = Limited;
            return IsLimited;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited PickLimited() => IsLimited
            ? Limited!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Limited' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VaultCredentialNetworkingResource(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted value) => new VaultCredentialNetworkingResource((global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted?(VaultCredentialNetworkingResource @this) => @this.Unrestricted;

        /// <summary>
        ///
        /// </summary>
        public VaultCredentialNetworkingResource(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? value)
        {
            Unrestricted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VaultCredentialNetworkingResource FromUnrestricted(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? value) => new VaultCredentialNetworkingResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VaultCredentialNetworkingResource(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited value) => new VaultCredentialNetworkingResource((global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited?(VaultCredentialNetworkingResource @this) => @this.Limited;

        /// <summary>
        ///
        /// </summary>
        public VaultCredentialNetworkingResource(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? value)
        {
            Limited = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VaultCredentialNetworkingResource FromLimited(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? value) => new VaultCredentialNetworkingResource(value);

        /// <summary>
        ///
        /// </summary>
        public VaultCredentialNetworkingResource(
            global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? unrestricted,
            global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? limited
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
            global::System.Func<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted, TResult>? unrestricted = null,
            global::System.Func<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited, TResult>? limited = null,
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
            global::System.Action<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted>? unrestricted = null,

            global::System.Action<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited>? limited = null,
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
            global::System.Action<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted>? unrestricted = null,
            global::System.Action<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited>? limited = null,
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
                typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted),
                Limited,
                typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited),
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
        public bool Equals(VaultCredentialNetworkingResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted?>.Default.Equals(Unrestricted, other.Unrestricted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited?>.Default.Equals(Limited, other.Limited)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(VaultCredentialNetworkingResource obj1, VaultCredentialNetworkingResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VaultCredentialNetworkingResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultCredentialNetworkingResource obj1, VaultCredentialNetworkingResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultCredentialNetworkingResource o && Equals(o);
        }
    }
}
