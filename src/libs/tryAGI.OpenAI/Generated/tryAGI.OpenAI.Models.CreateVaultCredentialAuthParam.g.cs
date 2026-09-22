#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Authentication credentials for an MCP server or an OpenAI-hosted environment.
    /// </summary>
    public readonly partial struct CreateVaultCredentialAuthParam : global::System.IEquatable<CreateVaultCredentialAuthParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType? Type { get; }

        /// <summary>
        /// An OAuth credential for an HTTPS MCP destination.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? McpOauth { get; init; }
#else
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? McpOauth { get; }
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
            out global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? value)
        {
            value = McpOauth;
            return IsMcpOauth;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth PickMcpOauth() => IsMcpOauth
            ? McpOauth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpOauth' but the value was {ToString()}.");

        /// <summary>
        /// A bearer token for an MCP server, without automatic OAuth refresh.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? StaticBearer { get; init; }
#else
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? StaticBearer { get; }
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
            out global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? value)
        {
            value = StaticBearer;
            return IsStaticBearer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer PickStaticBearer() => IsStaticBearer
            ? StaticBearer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StaticBearer' but the value was {ToString()}.");

        /// <summary>
        /// An HTTP credential for OpenAI-hosted environments only. The sandbox receives an environment variable containing a placeholder, not the secret. Use the placeholder unchanged in outgoing requests. The egress proxy replaces the placeholder with the secret for allowed HTTPS destinations on ports 443 and 8443. Sandbox code cannot read the real secret or use it for local computation, such as signing a request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? EnvironmentVariable { get; init; }
#else
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? EnvironmentVariable { get; }
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
            out global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? value)
        {
            value = EnvironmentVariable;
            return IsEnvironmentVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable PickEnvironmentVariable() => IsEnvironmentVariable
            ? EnvironmentVariable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentVariable' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVaultCredentialAuthParam(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth value) => new CreateVaultCredentialAuthParam((global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth?(CreateVaultCredentialAuthParam @this) => @this.McpOauth;

        /// <summary>
        ///
        /// </summary>
        public CreateVaultCredentialAuthParam(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? value)
        {
            McpOauth = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVaultCredentialAuthParam FromMcpOauth(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? value) => new CreateVaultCredentialAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVaultCredentialAuthParam(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer value) => new CreateVaultCredentialAuthParam((global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer?(CreateVaultCredentialAuthParam @this) => @this.StaticBearer;

        /// <summary>
        ///
        /// </summary>
        public CreateVaultCredentialAuthParam(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? value)
        {
            StaticBearer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVaultCredentialAuthParam FromStaticBearer(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? value) => new CreateVaultCredentialAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVaultCredentialAuthParam(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable value) => new CreateVaultCredentialAuthParam((global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable?(CreateVaultCredentialAuthParam @this) => @this.EnvironmentVariable;

        /// <summary>
        ///
        /// </summary>
        public CreateVaultCredentialAuthParam(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? value)
        {
            EnvironmentVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVaultCredentialAuthParam FromEnvironmentVariable(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? value) => new CreateVaultCredentialAuthParam(value);

        /// <summary>
        ///
        /// </summary>
        public CreateVaultCredentialAuthParam(
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType? type,
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? mcpOauth,
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? staticBearer,
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? environmentVariable
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
            global::System.Func<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth, TResult>? mcpOauth = null,
            global::System.Func<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer, TResult>? staticBearer = null,
            global::System.Func<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable, TResult>? environmentVariable = null,
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
            global::System.Action<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth>? mcpOauth = null,

            global::System.Action<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer>? staticBearer = null,

            global::System.Action<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable>? environmentVariable = null,
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
            global::System.Action<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth>? mcpOauth = null,
            global::System.Action<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer>? staticBearer = null,
            global::System.Action<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable>? environmentVariable = null,
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
                typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth),
                StaticBearer,
                typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer),
                EnvironmentVariable,
                typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable),
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
        public bool Equals(CreateVaultCredentialAuthParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth?>.Default.Equals(McpOauth, other.McpOauth) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer?>.Default.Equals(StaticBearer, other.StaticBearer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable?>.Default.Equals(EnvironmentVariable, other.EnvironmentVariable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateVaultCredentialAuthParam obj1, CreateVaultCredentialAuthParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateVaultCredentialAuthParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateVaultCredentialAuthParam obj1, CreateVaultCredentialAuthParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateVaultCredentialAuthParam o && Equals(o);
        }
    }
}
