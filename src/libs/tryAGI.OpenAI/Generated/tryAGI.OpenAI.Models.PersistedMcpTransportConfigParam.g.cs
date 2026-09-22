#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A credential-free transport used to connect to an MCP server.
    /// </summary>
    public readonly partial struct PersistedMcpTransportConfigParam : global::System.IEquatable<PersistedMcpTransportConfigParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Connects to an MCP server over HTTP.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? Http { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? Http { get; }
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
            out global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? value)
        {
            value = Http;
            return IsHttp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp PickHttp() => IsHttp
            ? Http!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Http' but the value was {ToString()}.");

        /// <summary>
        /// Starts an MCP server as a local process.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? Stdio { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? Stdio { get; }
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
            out global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? value)
        {
            value = Stdio;
            return IsStdio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio PickStdio() => IsStdio
            ? Stdio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stdio' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedMcpTransportConfigParam(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp value) => new PersistedMcpTransportConfigParam((global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp?(PersistedMcpTransportConfigParam @this) => @this.Http;

        /// <summary>
        ///
        /// </summary>
        public PersistedMcpTransportConfigParam(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? value)
        {
            Http = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedMcpTransportConfigParam FromHttp(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? value) => new PersistedMcpTransportConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedMcpTransportConfigParam(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio value) => new PersistedMcpTransportConfigParam((global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio?(PersistedMcpTransportConfigParam @this) => @this.Stdio;

        /// <summary>
        ///
        /// </summary>
        public PersistedMcpTransportConfigParam(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? value)
        {
            Stdio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedMcpTransportConfigParam FromStdio(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? value) => new PersistedMcpTransportConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public PersistedMcpTransportConfigParam(
            global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType? type,
            global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? http,
            global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? stdio
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
            global::System.Func<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp, TResult>? http = null,
            global::System.Func<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio, TResult>? stdio = null,
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
            global::System.Action<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp>? http = null,

            global::System.Action<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio>? stdio = null,
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
            global::System.Action<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp>? http = null,
            global::System.Action<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio>? stdio = null,
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
                typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp),
                Stdio,
                typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio),
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
        public bool Equals(PersistedMcpTransportConfigParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp?>.Default.Equals(Http, other.Http) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio?>.Default.Equals(Stdio, other.Stdio)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PersistedMcpTransportConfigParam obj1, PersistedMcpTransportConfigParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PersistedMcpTransportConfigParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PersistedMcpTransportConfigParam obj1, PersistedMcpTransportConfigParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PersistedMcpTransportConfigParam o && Equals(o);
        }
    }
}
