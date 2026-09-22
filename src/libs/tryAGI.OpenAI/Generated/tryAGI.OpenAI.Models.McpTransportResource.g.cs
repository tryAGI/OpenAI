#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The transport used to connect to an MCP server.
    /// </summary>
    public readonly partial struct McpTransportResource : global::System.IEquatable<McpTransportResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Connects to an MCP server over HTTP.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.McpTransportResourceHttp? Http { get; init; }
#else
        public global::tryAGI.OpenAI.McpTransportResourceHttp? Http { get; }
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
            out global::tryAGI.OpenAI.McpTransportResourceHttp? value)
        {
            value = Http;
            return IsHttp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceHttp PickHttp() => IsHttp
            ? Http!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Http' but the value was {ToString()}.");

        /// <summary>
        /// Starts an MCP server as a local process.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.McpTransportResourceStdio? Stdio { get; init; }
#else
        public global::tryAGI.OpenAI.McpTransportResourceStdio? Stdio { get; }
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
            out global::tryAGI.OpenAI.McpTransportResourceStdio? value)
        {
            value = Stdio;
            return IsStdio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportResourceStdio PickStdio() => IsStdio
            ? Stdio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stdio' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpTransportResource(global::tryAGI.OpenAI.McpTransportResourceHttp value) => new McpTransportResource((global::tryAGI.OpenAI.McpTransportResourceHttp?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.McpTransportResourceHttp?(McpTransportResource @this) => @this.Http;

        /// <summary>
        ///
        /// </summary>
        public McpTransportResource(global::tryAGI.OpenAI.McpTransportResourceHttp? value)
        {
            Http = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpTransportResource FromHttp(global::tryAGI.OpenAI.McpTransportResourceHttp? value) => new McpTransportResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpTransportResource(global::tryAGI.OpenAI.McpTransportResourceStdio value) => new McpTransportResource((global::tryAGI.OpenAI.McpTransportResourceStdio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.McpTransportResourceStdio?(McpTransportResource @this) => @this.Stdio;

        /// <summary>
        ///
        /// </summary>
        public McpTransportResource(global::tryAGI.OpenAI.McpTransportResourceStdio? value)
        {
            Stdio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpTransportResource FromStdio(global::tryAGI.OpenAI.McpTransportResourceStdio? value) => new McpTransportResource(value);

        /// <summary>
        ///
        /// </summary>
        public McpTransportResource(
            global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.McpTransportResourceHttp? http,
            global::tryAGI.OpenAI.McpTransportResourceStdio? stdio
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
            global::System.Func<global::tryAGI.OpenAI.McpTransportResourceHttp, TResult>? http = null,
            global::System.Func<global::tryAGI.OpenAI.McpTransportResourceStdio, TResult>? stdio = null,
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
            global::System.Action<global::tryAGI.OpenAI.McpTransportResourceHttp>? http = null,

            global::System.Action<global::tryAGI.OpenAI.McpTransportResourceStdio>? stdio = null,
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
            global::System.Action<global::tryAGI.OpenAI.McpTransportResourceHttp>? http = null,
            global::System.Action<global::tryAGI.OpenAI.McpTransportResourceStdio>? stdio = null,
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
                typeof(global::tryAGI.OpenAI.McpTransportResourceHttp),
                Stdio,
                typeof(global::tryAGI.OpenAI.McpTransportResourceStdio),
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
        public bool Equals(McpTransportResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.McpTransportResourceHttp?>.Default.Equals(Http, other.Http) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.McpTransportResourceStdio?>.Default.Equals(Stdio, other.Stdio)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(McpTransportResource obj1, McpTransportResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpTransportResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(McpTransportResource obj1, McpTransportResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpTransportResource o && Equals(o);
        }
    }
}
