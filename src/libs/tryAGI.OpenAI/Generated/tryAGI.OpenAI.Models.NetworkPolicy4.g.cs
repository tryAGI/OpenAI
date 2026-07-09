#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Network access policy for the container.
    /// </summary>
    public readonly partial struct NetworkPolicy4 : global::System.IEquatable<NetworkPolicy4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? Disabled { get; init; }
#else
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? Disabled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Disabled))]
#endif
        public bool IsDisabled => Disabled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDisabled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam PickDisabled() => IsDisabled
            ? Disabled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? Allowlist { get; init; }
#else
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? Allowlist { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Allowlist))]
#endif
        public bool IsAllowlist => Allowlist != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAllowlist(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? value)
        {
            value = Allowlist;
            return IsAllowlist;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam PickAllowlist() => IsAllowlist
            ? Allowlist!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Allowlist' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NetworkPolicy4(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam value) => new NetworkPolicy4((global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam?(NetworkPolicy4 @this) => @this.Disabled;

        /// <summary>
        /// 
        /// </summary>
        public NetworkPolicy4(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? value)
        {
            Disabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NetworkPolicy4 FromDisabled(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? value) => new NetworkPolicy4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NetworkPolicy4(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam value) => new NetworkPolicy4((global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam?(NetworkPolicy4 @this) => @this.Allowlist;

        /// <summary>
        /// 
        /// </summary>
        public NetworkPolicy4(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? value)
        {
            Allowlist = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NetworkPolicy4 FromAllowlist(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? value) => new NetworkPolicy4(value);

        /// <summary>
        /// 
        /// </summary>
        public NetworkPolicy4(
            global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? disabled,
            global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? allowlist
            )
        {
            Type = type;

            Disabled = disabled;
            Allowlist = allowlist;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Allowlist as object ??
            Disabled as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Disabled?.ToString() ??
            Allowlist?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDisabled && !IsAllowlist || !IsDisabled && IsAllowlist;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam, TResult>? disabled = null,
            global::System.Func<global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam, TResult>? allowlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDisabled && disabled != null)
            {
                return disabled(Disabled!);
            }
            else if (IsAllowlist && allowlist != null)
            {
                return allowlist(Allowlist!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam>? disabled = null,

            global::System.Action<global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam>? allowlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
            else if (IsAllowlist)
            {
                allowlist?.Invoke(Allowlist!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam>? disabled = null,
            global::System.Action<global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam>? allowlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
            else if (IsAllowlist)
            {
                allowlist?.Invoke(Allowlist!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Disabled,
                typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam),
                Allowlist,
                typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam),
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
        public bool Equals(NetworkPolicy4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam?>.Default.Equals(Allowlist, other.Allowlist) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NetworkPolicy4 obj1, NetworkPolicy4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NetworkPolicy4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NetworkPolicy4 obj1, NetworkPolicy4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NetworkPolicy4 o && Equals(o);
        }
    }
}
