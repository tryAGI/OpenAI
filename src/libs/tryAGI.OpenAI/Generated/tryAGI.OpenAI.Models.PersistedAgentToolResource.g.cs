#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A credential-free tool available to a reusable agent.
    /// </summary>
    public readonly partial struct PersistedAgentToolResource : global::System.IEquatable<PersistedAgentToolResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A function defined by the application.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? Function { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? Function { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceFunction PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// Discovers deferred function tools and loads them into the model context.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? ToolSearch { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? ToolSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearch))]
#endif
        public bool IsToolSearch => ToolSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? value)
        {
            value = ToolSearch;
            return IsToolSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch PickToolSearch() => IsToolSearch
            ? ToolSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearch' but the value was {ToString()}.");

        /// <summary>
        /// Enables calling tools from model-generated code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? ProgrammaticToolCalling { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? ProgrammaticToolCalling { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProgrammaticToolCalling))]
#endif
        public bool IsProgrammaticToolCalling => ProgrammaticToolCalling != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProgrammaticToolCalling(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? value)
        {
            value = ProgrammaticToolCalling;
            return IsProgrammaticToolCalling;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling PickProgrammaticToolCalling() => IsProgrammaticToolCalling
            ? ProgrammaticToolCalling!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProgrammaticToolCalling' but the value was {ToString()}.");

        /// <summary>
        /// Tools provided by a remote MCP server without stored credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? Mcp { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? Mcp { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceMcp PickMcp() => IsMcp
            ? Mcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        /// Web search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? WebSearch { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? WebSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch PickWebSearch() => IsWebSearch
            ? WebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedAgentToolResource(global::tryAGI.OpenAI.PersistedAgentToolResourceFunction value) => new PersistedAgentToolResource((global::tryAGI.OpenAI.PersistedAgentToolResourceFunction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedAgentToolResourceFunction?(PersistedAgentToolResource @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolResource(global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedAgentToolResource FromFunction(global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? value) => new PersistedAgentToolResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedAgentToolResource(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch value) => new PersistedAgentToolResource((global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch?(PersistedAgentToolResource @this) => @this.ToolSearch;

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolResource(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? value)
        {
            ToolSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedAgentToolResource FromToolSearch(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? value) => new PersistedAgentToolResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedAgentToolResource(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling value) => new PersistedAgentToolResource((global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling?(PersistedAgentToolResource @this) => @this.ProgrammaticToolCalling;

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolResource(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? value)
        {
            ProgrammaticToolCalling = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedAgentToolResource FromProgrammaticToolCalling(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? value) => new PersistedAgentToolResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedAgentToolResource(global::tryAGI.OpenAI.PersistedAgentToolResourceMcp value) => new PersistedAgentToolResource((global::tryAGI.OpenAI.PersistedAgentToolResourceMcp?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedAgentToolResourceMcp?(PersistedAgentToolResource @this) => @this.Mcp;

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolResource(global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? value)
        {
            Mcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedAgentToolResource FromMcp(global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? value) => new PersistedAgentToolResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedAgentToolResource(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch value) => new PersistedAgentToolResource((global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch?(PersistedAgentToolResource @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolResource(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedAgentToolResource FromWebSearch(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? value) => new PersistedAgentToolResource(value);

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolResource(
            global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.PersistedAgentToolResourceFunction? function,
            global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch? toolSearch,
            global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling? programmaticToolCalling,
            global::tryAGI.OpenAI.PersistedAgentToolResourceMcp? mcp,
            global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch? webSearch
            )
        {
            Type = type;

            Function = function;
            ToolSearch = toolSearch;
            ProgrammaticToolCalling = programmaticToolCalling;
            Mcp = mcp;
            WebSearch = webSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            Mcp as object ??
            ProgrammaticToolCalling as object ??
            ToolSearch as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            ToolSearch?.ToString() ??
            ProgrammaticToolCalling?.ToString() ??
            Mcp?.ToString() ??
            WebSearch?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsToolSearch && !IsProgrammaticToolCalling && !IsMcp && !IsWebSearch || !IsFunction && IsToolSearch && !IsProgrammaticToolCalling && !IsMcp && !IsWebSearch || !IsFunction && !IsToolSearch && IsProgrammaticToolCalling && !IsMcp && !IsWebSearch || !IsFunction && !IsToolSearch && !IsProgrammaticToolCalling && IsMcp && !IsWebSearch || !IsFunction && !IsToolSearch && !IsProgrammaticToolCalling && !IsMcp && IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.PersistedAgentToolResourceFunction, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch, TResult>? toolSearch = null,
            global::System.Func<global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling, TResult>? programmaticToolCalling = null,
            global::System.Func<global::tryAGI.OpenAI.PersistedAgentToolResourceMcp, TResult>? mcp = null,
            global::System.Func<global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsToolSearch && toolSearch != null)
            {
                return toolSearch(ToolSearch!);
            }
            else if (IsProgrammaticToolCalling && programmaticToolCalling != null)
            {
                return programmaticToolCalling(ProgrammaticToolCalling!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolResourceFunction>? function = null,

            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch>? toolSearch = null,

            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling>? programmaticToolCalling = null,

            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolResourceMcp>? mcp = null,

            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsToolSearch)
            {
                toolSearch?.Invoke(ToolSearch!);
            }
            else if (IsProgrammaticToolCalling)
            {
                programmaticToolCalling?.Invoke(ProgrammaticToolCalling!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolResourceFunction>? function = null,
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch>? toolSearch = null,
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling>? programmaticToolCalling = null,
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolResourceMcp>? mcp = null,
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsToolSearch)
            {
                toolSearch?.Invoke(ToolSearch!);
            }
            else if (IsProgrammaticToolCalling)
            {
                programmaticToolCalling?.Invoke(ProgrammaticToolCalling!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunction),
                ToolSearch,
                typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch),
                ProgrammaticToolCalling,
                typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling),
                Mcp,
                typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcp),
                WebSearch,
                typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch),
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
        public bool Equals(PersistedAgentToolResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedAgentToolResourceFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch?>.Default.Equals(ToolSearch, other.ToolSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling?>.Default.Equals(ProgrammaticToolCalling, other.ProgrammaticToolCalling) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedAgentToolResourceMcp?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch?>.Default.Equals(WebSearch, other.WebSearch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PersistedAgentToolResource obj1, PersistedAgentToolResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PersistedAgentToolResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PersistedAgentToolResource obj1, PersistedAgentToolResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PersistedAgentToolResource o && Equals(o);
        }
    }
}
