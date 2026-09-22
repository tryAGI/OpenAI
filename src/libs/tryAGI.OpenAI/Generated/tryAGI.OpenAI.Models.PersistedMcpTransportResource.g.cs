#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A credential-free transport used to connect to an MCP server.
    /// </summary>
    public readonly partial struct PersistedMcpTransportResource : global::System.IEquatable<PersistedMcpTransportResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Connects to an MCP server over HTTP.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? Http { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? Http { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Http))]
#endif
        public bool IsHttp => Http != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHttp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? value)
        {
            value = Http;
            return IsHttp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp PickHttp() => IsHttp
            ? Http!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Http' but the value was {ToString()}.");

        /// <summary>
        /// Starts an MCP server as a local process.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? Stdio { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? Stdio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stdio))]
#endif
        public bool IsStdio => Stdio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStdio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? value)
        {
            value = Stdio;
            return IsStdio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio PickStdio() => IsStdio
            ? Stdio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stdio' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedMcpTransportResource(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp value) => new PersistedMcpTransportResource((global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp?(PersistedMcpTransportResource @this) => @this.Http;

        /// <summary>
        ///
        /// </summary>
        public PersistedMcpTransportResource(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? value)
        {
            Http = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedMcpTransportResource FromHttp(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? value) => new PersistedMcpTransportResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedMcpTransportResource(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio value) => new PersistedMcpTransportResource((global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio?(PersistedMcpTransportResource @this) => @this.Stdio;

        /// <summary>
        ///
        /// </summary>
        public PersistedMcpTransportResource(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? value)
        {
            Stdio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedMcpTransportResource FromStdio(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? value) => new PersistedMcpTransportResource(value);

        /// <summary>
        ///
        /// </summary>
        public PersistedMcpTransportResource(
            global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp? http,
            global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio? stdio
            )
        {
            Type = type;

            Http = http;
            Stdio = stdio;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Stdio as object ??
            Http as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Http?.ToString() ??
            Stdio?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsHttp && !IsStdio || !IsHttp && IsStdio;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp, TResult>? http = null,
            global::System.Func<global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio, TResult>? stdio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHttp && http != null)
            {
                return http(Http!);
            }
            else if (IsStdio && stdio != null)
            {
                return stdio(Stdio!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp>? http = null,

            global::System.Action<global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio>? stdio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHttp)
            {
                http?.Invoke(Http!);
            }
            else if (IsStdio)
            {
                stdio?.Invoke(Stdio!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp>? http = null,
            global::System.Action<global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio>? stdio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHttp)
            {
                http?.Invoke(Http!);
            }
            else if (IsStdio)
            {
                stdio?.Invoke(Stdio!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Http,
                typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp),
                Stdio,
                typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio),
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
        public bool Equals(PersistedMcpTransportResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp?>.Default.Equals(Http, other.Http) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio?>.Default.Equals(Stdio, other.Stdio)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PersistedMcpTransportResource obj1, PersistedMcpTransportResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PersistedMcpTransportResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PersistedMcpTransportResource obj1, PersistedMcpTransportResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PersistedMcpTransportResource o && Equals(o);
        }
    }
}
