#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The transport used to connect to an MCP server.
    /// </summary>
    public readonly partial struct McpTransportConfigParam : global::System.IEquatable<McpTransportConfigParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Connects to an MCP server over HTTP.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.McpTransportConfigParamHttp? Http { get; init; }
#else
        public global::tryAGI.OpenAI.McpTransportConfigParamHttp? Http { get; }
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
            out global::tryAGI.OpenAI.McpTransportConfigParamHttp? value)
        {
            value = Http;
            return IsHttp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamHttp PickHttp() => IsHttp
            ? Http!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Http' but the value was {ToString()}.");

        /// <summary>
        /// Starts an MCP server as a local process.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.McpTransportConfigParamStdio? Stdio { get; init; }
#else
        public global::tryAGI.OpenAI.McpTransportConfigParamStdio? Stdio { get; }
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
            out global::tryAGI.OpenAI.McpTransportConfigParamStdio? value)
        {
            value = Stdio;
            return IsStdio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.McpTransportConfigParamStdio PickStdio() => IsStdio
            ? Stdio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stdio' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpTransportConfigParam(global::tryAGI.OpenAI.McpTransportConfigParamHttp value) => new McpTransportConfigParam((global::tryAGI.OpenAI.McpTransportConfigParamHttp?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.McpTransportConfigParamHttp?(McpTransportConfigParam @this) => @this.Http;

        /// <summary>
        ///
        /// </summary>
        public McpTransportConfigParam(global::tryAGI.OpenAI.McpTransportConfigParamHttp? value)
        {
            Http = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpTransportConfigParam FromHttp(global::tryAGI.OpenAI.McpTransportConfigParamHttp? value) => new McpTransportConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpTransportConfigParam(global::tryAGI.OpenAI.McpTransportConfigParamStdio value) => new McpTransportConfigParam((global::tryAGI.OpenAI.McpTransportConfigParamStdio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.McpTransportConfigParamStdio?(McpTransportConfigParam @this) => @this.Stdio;

        /// <summary>
        ///
        /// </summary>
        public McpTransportConfigParam(global::tryAGI.OpenAI.McpTransportConfigParamStdio? value)
        {
            Stdio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpTransportConfigParam FromStdio(global::tryAGI.OpenAI.McpTransportConfigParamStdio? value) => new McpTransportConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public McpTransportConfigParam(
            global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType? type,
            global::tryAGI.OpenAI.McpTransportConfigParamHttp? http,
            global::tryAGI.OpenAI.McpTransportConfigParamStdio? stdio
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
            global::System.Func<global::tryAGI.OpenAI.McpTransportConfigParamHttp, TResult>? http = null,
            global::System.Func<global::tryAGI.OpenAI.McpTransportConfigParamStdio, TResult>? stdio = null,
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
            global::System.Action<global::tryAGI.OpenAI.McpTransportConfigParamHttp>? http = null,

            global::System.Action<global::tryAGI.OpenAI.McpTransportConfigParamStdio>? stdio = null,
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
            global::System.Action<global::tryAGI.OpenAI.McpTransportConfigParamHttp>? http = null,
            global::System.Action<global::tryAGI.OpenAI.McpTransportConfigParamStdio>? stdio = null,
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
                typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttp),
                Stdio,
                typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdio),
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
        public bool Equals(McpTransportConfigParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.McpTransportConfigParamHttp?>.Default.Equals(Http, other.Http) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.McpTransportConfigParamStdio?>.Default.Equals(Stdio, other.Stdio)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(McpTransportConfigParam obj1, McpTransportConfigParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpTransportConfigParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(McpTransportConfigParam obj1, McpTransportConfigParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpTransportConfigParam o && Equals(o);
        }
    }
}
