#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Network access policy for the container.
    /// </summary>
    public readonly partial struct NetworkPolicyVariant1 : global::System.IEquatable<NetworkPolicyVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam? Disabled { get; init; }
#else
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam? Disabled { get; }
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
            out global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam? Allowlist { get; init; }
#else
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam? Allowlist { get; }
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
            out global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam? value)
        {
            value = Allowlist;
            return IsAllowlist;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam PickAllowlist() => Allowlist is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Allowlist' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NetworkPolicyVariant1(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam value) => new NetworkPolicyVariant1((global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam?(NetworkPolicyVariant1 @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public NetworkPolicyVariant1(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NetworkPolicyVariant1 FromDisabled(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam? value) => new NetworkPolicyVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NetworkPolicyVariant1(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam value) => new NetworkPolicyVariant1((global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam?(NetworkPolicyVariant1 @this) => @this.Allowlist;

        /// <summary>
        ///
        /// </summary>
        public NetworkPolicyVariant1(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam? value)
        {
            Allowlist = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NetworkPolicyVariant1 FromAllowlist(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam? value) => new NetworkPolicyVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public NetworkPolicyVariant1(
            global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType? type,
            global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam? disabled,
            global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam? allowlist
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
            global::System.Func<global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam, TResult>? disabled = null,
            global::System.Func<global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam, TResult>? allowlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Disabled is { } __value0 && disabled != null)
            {
                return disabled(__value0);
            }
            else if (Allowlist is { } __value1 && allowlist != null)
            {
                return allowlist(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam>? disabled = null,

            global::System.Action<global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam>? allowlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Disabled is { } __value0)
            {
                disabled?.Invoke(__value0);
            }
            else if (Allowlist is { } __value1)
            {
                allowlist?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam>? disabled = null,
            global::System.Action<global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam>? allowlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Disabled is { } __value0)
            {
                disabled?.Invoke(__value0);
            }
            else if (Allowlist is { } __value1)
            {
                allowlist?.Invoke(__value1);
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
                typeof(global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam),
                Allowlist,
                typeof(global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam),
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
        public bool Equals(NetworkPolicyVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveContainerNetworkPolicyDisabledParam?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveHostedShellNetworkPolicyAllowlistParam?>.Default.Equals(Allowlist, other.Allowlist)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NetworkPolicyVariant1 obj1, NetworkPolicyVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NetworkPolicyVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NetworkPolicyVariant1 obj1, NetworkPolicyVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NetworkPolicyVariant1 o && Equals(o);
        }
    }
}
