#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The authentication configuration of a vault credential, excluding secrets.
    /// </summary>
    public readonly partial struct VaultCredentialAuthResource : global::System.IEquatable<VaultCredentialAuthResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Public metadata for an OAuth credential; tokens and client secrets are never returned.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? McpOauth { get; init; }
#else
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? McpOauth { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpOauth))]
#endif
        public bool IsMcpOauth => McpOauth != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpOauth(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? value)
        {
            value = McpOauth;
            return IsMcpOauth;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth PickMcpOauth() => IsMcpOauth
            ? McpOauth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpOauth' but the value was {ToString()}.");

        /// <summary>
        /// Metadata for a bearer-token credential, without automatic OAuth refresh.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? StaticBearer { get; init; }
#else
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? StaticBearer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StaticBearer))]
#endif
        public bool IsStaticBearer => StaticBearer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStaticBearer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? value)
        {
            value = StaticBearer;
            return IsStaticBearer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer PickStaticBearer() => IsStaticBearer
            ? StaticBearer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StaticBearer' but the value was {ToString()}.");

        /// <summary>
        /// Metadata for an HTTP credential used only in OpenAI-hosted environments. Sandbox code receives a placeholder. The proxy substitutes the secret for allowed HTTPS destinations on ports 443 and 8443. The real secret is not available to sandbox code for local computation and is never returned in this resource.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? EnvironmentVariable { get; init; }
#else
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? EnvironmentVariable { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentVariable))]
#endif
        public bool IsEnvironmentVariable => EnvironmentVariable != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnvironmentVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? value)
        {
            value = EnvironmentVariable;
            return IsEnvironmentVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable PickEnvironmentVariable() => IsEnvironmentVariable
            ? EnvironmentVariable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentVariable' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VaultCredentialAuthResource(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth value) => new VaultCredentialAuthResource((global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth?(VaultCredentialAuthResource @this) => @this.McpOauth;

        /// <summary>
        ///
        /// </summary>
        public VaultCredentialAuthResource(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? value)
        {
            McpOauth = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VaultCredentialAuthResource FromMcpOauth(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? value) => new VaultCredentialAuthResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VaultCredentialAuthResource(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer value) => new VaultCredentialAuthResource((global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer?(VaultCredentialAuthResource @this) => @this.StaticBearer;

        /// <summary>
        ///
        /// </summary>
        public VaultCredentialAuthResource(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? value)
        {
            StaticBearer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VaultCredentialAuthResource FromStaticBearer(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? value) => new VaultCredentialAuthResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VaultCredentialAuthResource(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable value) => new VaultCredentialAuthResource((global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable?(VaultCredentialAuthResource @this) => @this.EnvironmentVariable;

        /// <summary>
        ///
        /// </summary>
        public VaultCredentialAuthResource(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? value)
        {
            EnvironmentVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VaultCredentialAuthResource FromEnvironmentVariable(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? value) => new VaultCredentialAuthResource(value);

        /// <summary>
        ///
        /// </summary>
        public VaultCredentialAuthResource(
            global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? mcpOauth,
            global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? staticBearer,
            global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? environmentVariable
            )
        {
            Type = type;

            McpOauth = mcpOauth;
            StaticBearer = staticBearer;
            EnvironmentVariable = environmentVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EnvironmentVariable as object ??
            StaticBearer as object ??
            McpOauth as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            McpOauth?.ToString() ??
            StaticBearer?.ToString() ??
            EnvironmentVariable?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMcpOauth && !IsStaticBearer && !IsEnvironmentVariable || !IsMcpOauth && IsStaticBearer && !IsEnvironmentVariable || !IsMcpOauth && !IsStaticBearer && IsEnvironmentVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth, TResult>? mcpOauth = null,
            global::System.Func<global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer, TResult>? staticBearer = null,
            global::System.Func<global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable, TResult>? environmentVariable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpOauth && mcpOauth != null)
            {
                return mcpOauth(McpOauth!);
            }
            else if (IsStaticBearer && staticBearer != null)
            {
                return staticBearer(StaticBearer!);
            }
            else if (IsEnvironmentVariable && environmentVariable != null)
            {
                return environmentVariable(EnvironmentVariable!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth>? mcpOauth = null,

            global::System.Action<global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer>? staticBearer = null,

            global::System.Action<global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable>? environmentVariable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpOauth)
            {
                mcpOauth?.Invoke(McpOauth!);
            }
            else if (IsStaticBearer)
            {
                staticBearer?.Invoke(StaticBearer!);
            }
            else if (IsEnvironmentVariable)
            {
                environmentVariable?.Invoke(EnvironmentVariable!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth>? mcpOauth = null,
            global::System.Action<global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer>? staticBearer = null,
            global::System.Action<global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable>? environmentVariable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpOauth)
            {
                mcpOauth?.Invoke(McpOauth!);
            }
            else if (IsStaticBearer)
            {
                staticBearer?.Invoke(StaticBearer!);
            }
            else if (IsEnvironmentVariable)
            {
                environmentVariable?.Invoke(EnvironmentVariable!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                McpOauth,
                typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth),
                StaticBearer,
                typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer),
                EnvironmentVariable,
                typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable),
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
        public bool Equals(VaultCredentialAuthResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth?>.Default.Equals(McpOauth, other.McpOauth) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer?>.Default.Equals(StaticBearer, other.StaticBearer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable?>.Default.Equals(EnvironmentVariable, other.EnvironmentVariable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(VaultCredentialAuthResource obj1, VaultCredentialAuthResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VaultCredentialAuthResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultCredentialAuthResource obj1, VaultCredentialAuthResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultCredentialAuthResource o && Equals(o);
        }
    }
}
