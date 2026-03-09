#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Network access policy for the container.
    /// </summary>
    public readonly partial struct NetworkPolicy : global::System.IEquatable<NetworkPolicy>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam? Disabled { get; init; }
#else
        public global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam? Disabled { get; }
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
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam? Allowlist { get; init; }
#else
        public global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam? Allowlist { get; }
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
        public static implicit operator NetworkPolicy(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam value) => new NetworkPolicy((global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam?(NetworkPolicy @this) => @this.Disabled;

        /// <summary>
        /// 
        /// </summary>
        public NetworkPolicy(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam? value)
        {
            Disabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NetworkPolicy(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam value) => new NetworkPolicy((global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam?(NetworkPolicy @this) => @this.Allowlist;

        /// <summary>
        /// 
        /// </summary>
        public NetworkPolicy(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam? value)
        {
            Allowlist = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NetworkPolicy(
            global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam? disabled,
            global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam? allowlist
            )
        {
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
            global::System.Func<global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam?, TResult>? disabled = null,
            global::System.Func<global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam?, TResult>? allowlist = null,
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
            global::System.Action<global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam?>? disabled = null,
            global::System.Action<global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam?>? allowlist = null,
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
                typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam),
                Allowlist,
                typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam),
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
        public bool Equals(NetworkPolicy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam?>.Default.Equals(Allowlist, other.Allowlist) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NetworkPolicy obj1, NetworkPolicy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NetworkPolicy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NetworkPolicy obj1, NetworkPolicy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NetworkPolicy o && Equals(o);
        }
    }
}
