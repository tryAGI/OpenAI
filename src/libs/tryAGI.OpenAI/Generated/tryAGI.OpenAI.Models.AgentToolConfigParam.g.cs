#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool available to the agent.
    /// </summary>
    public readonly partial struct AgentToolConfigParam : global::System.IEquatable<AgentToolConfigParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType? Type { get; }

        /// <summary>
        /// A function defined by the application.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentToolConfigParamFunction? Function { get; init; }
#else
        public global::tryAGI.OpenAI.AgentToolConfigParamFunction? Function { get; }
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
            out global::tryAGI.OpenAI.AgentToolConfigParamFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamFunction PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// Discovers deferred function tools and loads them into the model context.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? ToolSearch { get; init; }
#else
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? ToolSearch { get; }
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
            out global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? value)
        {
            value = ToolSearch;
            return IsToolSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamToolSearch PickToolSearch() => IsToolSearch
            ? ToolSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearch' but the value was {ToString()}.");

        /// <summary>
        /// Enables calling tools from model-generated code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? ProgrammaticToolCalling { get; init; }
#else
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? ProgrammaticToolCalling { get; }
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
            out global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? value)
        {
            value = ProgrammaticToolCalling;
            return IsProgrammaticToolCalling;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling PickProgrammaticToolCalling() => IsProgrammaticToolCalling
            ? ProgrammaticToolCalling!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProgrammaticToolCalling' but the value was {ToString()}.");

        /// <summary>
        /// Tools provided by a remote MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentToolConfigParamMcp? Mcp { get; init; }
#else
        public global::tryAGI.OpenAI.AgentToolConfigParamMcp? Mcp { get; }
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
            out global::tryAGI.OpenAI.AgentToolConfigParamMcp? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamMcp PickMcp() => IsMcp
            ? Mcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        /// Web search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? WebSearch { get; init; }
#else
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? WebSearch { get; }
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
            out global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolConfigParamWebSearch PickWebSearch() => IsWebSearch
            ? WebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolConfigParam(global::tryAGI.OpenAI.AgentToolConfigParamFunction value) => new AgentToolConfigParam((global::tryAGI.OpenAI.AgentToolConfigParamFunction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentToolConfigParamFunction?(AgentToolConfigParam @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfigParam(global::tryAGI.OpenAI.AgentToolConfigParamFunction? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolConfigParam FromFunction(global::tryAGI.OpenAI.AgentToolConfigParamFunction? value) => new AgentToolConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolConfigParam(global::tryAGI.OpenAI.AgentToolConfigParamToolSearch value) => new AgentToolConfigParam((global::tryAGI.OpenAI.AgentToolConfigParamToolSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentToolConfigParamToolSearch?(AgentToolConfigParam @this) => @this.ToolSearch;

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfigParam(global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? value)
        {
            ToolSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolConfigParam FromToolSearch(global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? value) => new AgentToolConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolConfigParam(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling value) => new AgentToolConfigParam((global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling?(AgentToolConfigParam @this) => @this.ProgrammaticToolCalling;

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfigParam(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? value)
        {
            ProgrammaticToolCalling = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolConfigParam FromProgrammaticToolCalling(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? value) => new AgentToolConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolConfigParam(global::tryAGI.OpenAI.AgentToolConfigParamMcp value) => new AgentToolConfigParam((global::tryAGI.OpenAI.AgentToolConfigParamMcp?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentToolConfigParamMcp?(AgentToolConfigParam @this) => @this.Mcp;

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfigParam(global::tryAGI.OpenAI.AgentToolConfigParamMcp? value)
        {
            Mcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolConfigParam FromMcp(global::tryAGI.OpenAI.AgentToolConfigParamMcp? value) => new AgentToolConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolConfigParam(global::tryAGI.OpenAI.AgentToolConfigParamWebSearch value) => new AgentToolConfigParam((global::tryAGI.OpenAI.AgentToolConfigParamWebSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentToolConfigParamWebSearch?(AgentToolConfigParam @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfigParam(global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolConfigParam FromWebSearch(global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? value) => new AgentToolConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfigParam(
            global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType? type,
            global::tryAGI.OpenAI.AgentToolConfigParamFunction? function,
            global::tryAGI.OpenAI.AgentToolConfigParamToolSearch? toolSearch,
            global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling? programmaticToolCalling,
            global::tryAGI.OpenAI.AgentToolConfigParamMcp? mcp,
            global::tryAGI.OpenAI.AgentToolConfigParamWebSearch? webSearch
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
            global::System.Func<global::tryAGI.OpenAI.AgentToolConfigParamFunction, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.AgentToolConfigParamToolSearch, TResult>? toolSearch = null,
            global::System.Func<global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling, TResult>? programmaticToolCalling = null,
            global::System.Func<global::tryAGI.OpenAI.AgentToolConfigParamMcp, TResult>? mcp = null,
            global::System.Func<global::tryAGI.OpenAI.AgentToolConfigParamWebSearch, TResult>? webSearch = null,
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
            global::System.Action<global::tryAGI.OpenAI.AgentToolConfigParamFunction>? function = null,

            global::System.Action<global::tryAGI.OpenAI.AgentToolConfigParamToolSearch>? toolSearch = null,

            global::System.Action<global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling>? programmaticToolCalling = null,

            global::System.Action<global::tryAGI.OpenAI.AgentToolConfigParamMcp>? mcp = null,

            global::System.Action<global::tryAGI.OpenAI.AgentToolConfigParamWebSearch>? webSearch = null,
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
            global::System.Action<global::tryAGI.OpenAI.AgentToolConfigParamFunction>? function = null,
            global::System.Action<global::tryAGI.OpenAI.AgentToolConfigParamToolSearch>? toolSearch = null,
            global::System.Action<global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling>? programmaticToolCalling = null,
            global::System.Action<global::tryAGI.OpenAI.AgentToolConfigParamMcp>? mcp = null,
            global::System.Action<global::tryAGI.OpenAI.AgentToolConfigParamWebSearch>? webSearch = null,
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
                typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunction),
                ToolSearch,
                typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearch),
                ProgrammaticToolCalling,
                typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling),
                Mcp,
                typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcp),
                WebSearch,
                typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearch),
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
        public bool Equals(AgentToolConfigParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentToolConfigParamFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentToolConfigParamToolSearch?>.Default.Equals(ToolSearch, other.ToolSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling?>.Default.Equals(ProgrammaticToolCalling, other.ProgrammaticToolCalling) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentToolConfigParamMcp?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentToolConfigParamWebSearch?>.Default.Equals(WebSearch, other.WebSearch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AgentToolConfigParam obj1, AgentToolConfigParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentToolConfigParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AgentToolConfigParam obj1, AgentToolConfigParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentToolConfigParam o && Equals(o);
        }
    }
}
