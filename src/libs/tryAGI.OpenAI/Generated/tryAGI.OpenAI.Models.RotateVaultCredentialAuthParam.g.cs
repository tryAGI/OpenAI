#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Updates to a vault credential without changing its authentication method or destination configuration.
    /// </summary>
    public readonly partial struct RotateVaultCredentialAuthParam : global::System.IEquatable<RotateVaultCredentialAuthParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Rotate an OAuth credential for an HTTPS MCP destination.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? McpOauth { get; init; }
#else
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? McpOauth { get; }
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
            out global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? value)
        {
            value = McpOauth;
            return IsMcpOauth;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth PickMcpOauth() => IsMcpOauth
            ? McpOauth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpOauth' but the value was {ToString()}.");

        /// <summary>
        /// Replace the bearer token for the credential's MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? StaticBearer { get; init; }
#else
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? StaticBearer { get; }
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
            out global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? value)
        {
            value = StaticBearer;
            return IsStaticBearer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer PickStaticBearer() => IsStaticBearer
            ? StaticBearer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StaticBearer' but the value was {ToString()}.");

        /// <summary>
        /// Replace the secret for an OpenAI-hosted environment credential. The environment variable name and networking configuration remain unchanged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? EnvironmentVariable { get; init; }
#else
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? EnvironmentVariable { get; }
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
            out global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? value)
        {
            value = EnvironmentVariable;
            return IsEnvironmentVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable PickEnvironmentVariable() => IsEnvironmentVariable
            ? EnvironmentVariable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentVariable' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RotateVaultCredentialAuthParam(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth value) => new RotateVaultCredentialAuthParam((global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth?(RotateVaultCredentialAuthParam @this) => @this.McpOauth;

        /// <summary>
        ///
        /// </summary>
        public RotateVaultCredentialAuthParam(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? value)
        {
            McpOauth = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RotateVaultCredentialAuthParam FromMcpOauth(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? value) => new RotateVaultCredentialAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RotateVaultCredentialAuthParam(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer value) => new RotateVaultCredentialAuthParam((global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer?(RotateVaultCredentialAuthParam @this) => @this.StaticBearer;

        /// <summary>
        ///
        /// </summary>
        public RotateVaultCredentialAuthParam(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? value)
        {
            StaticBearer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RotateVaultCredentialAuthParam FromStaticBearer(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? value) => new RotateVaultCredentialAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RotateVaultCredentialAuthParam(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable value) => new RotateVaultCredentialAuthParam((global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable?(RotateVaultCredentialAuthParam @this) => @this.EnvironmentVariable;

        /// <summary>
        ///
        /// </summary>
        public RotateVaultCredentialAuthParam(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? value)
        {
            EnvironmentVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RotateVaultCredentialAuthParam FromEnvironmentVariable(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? value) => new RotateVaultCredentialAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public RotateVaultCredentialAuthParam(
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType? type,
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? mcpOauth,
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? staticBearer,
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? environmentVariable
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
            global::System.Func<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth, TResult>? mcpOauth = null,
            global::System.Func<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer, TResult>? staticBearer = null,
            global::System.Func<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable, TResult>? environmentVariable = null,
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
            global::System.Action<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth>? mcpOauth = null,

            global::System.Action<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer>? staticBearer = null,

            global::System.Action<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable>? environmentVariable = null,
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
            global::System.Action<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth>? mcpOauth = null,
            global::System.Action<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer>? staticBearer = null,
            global::System.Action<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable>? environmentVariable = null,
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
                typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth),
                StaticBearer,
                typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer),
                EnvironmentVariable,
                typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable),
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
        public bool Equals(RotateVaultCredentialAuthParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth?>.Default.Equals(McpOauth, other.McpOauth) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer?>.Default.Equals(StaticBearer, other.StaticBearer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable?>.Default.Equals(EnvironmentVariable, other.EnvironmentVariable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RotateVaultCredentialAuthParam obj1, RotateVaultCredentialAuthParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RotateVaultCredentialAuthParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RotateVaultCredentialAuthParam obj1, RotateVaultCredentialAuthParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RotateVaultCredentialAuthParam o && Equals(o);
        }
    }
}
