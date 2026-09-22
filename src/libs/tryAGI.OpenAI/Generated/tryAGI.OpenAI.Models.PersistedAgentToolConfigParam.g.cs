#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that can be stored on a reusable agent without session credentials.
    /// </summary>
    public readonly partial struct PersistedAgentToolConfigParam : global::System.IEquatable<PersistedAgentToolConfigParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType? Type { get; }

        /// <summary>
        /// A function defined by the application.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? Function { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? Function { get; }
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
            out global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// Discovers deferred function tools and loads them into the model context.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? ToolSearch { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? ToolSearch { get; }
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
            out global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? value)
        {
            value = ToolSearch;
            return IsToolSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch PickToolSearch() => IsToolSearch
            ? ToolSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearch' but the value was {ToString()}.");

        /// <summary>
        /// Enables calling tools from model-generated code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? ProgrammaticToolCalling { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? ProgrammaticToolCalling { get; }
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
            out global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? value)
        {
            value = ProgrammaticToolCalling;
            return IsProgrammaticToolCalling;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling PickProgrammaticToolCalling() => IsProgrammaticToolCalling
            ? ProgrammaticToolCalling!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProgrammaticToolCalling' but the value was {ToString()}.");

        /// <summary>
        /// Tools provided by a remote MCP server without stored credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? Mcp { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? Mcp { get; }
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
            out global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp PickMcp() => IsMcp
            ? Mcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        /// Web search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? WebSearch { get; init; }
#else
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? WebSearch { get; }
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
            out global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch PickWebSearch() => IsWebSearch
            ? WebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedAgentToolConfigParam(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction value) => new PersistedAgentToolConfigParam((global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction?(PersistedAgentToolConfigParam @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolConfigParam(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedAgentToolConfigParam FromFunction(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? value) => new PersistedAgentToolConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedAgentToolConfigParam(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch value) => new PersistedAgentToolConfigParam((global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch?(PersistedAgentToolConfigParam @this) => @this.ToolSearch;

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolConfigParam(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? value)
        {
            ToolSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedAgentToolConfigParam FromToolSearch(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? value) => new PersistedAgentToolConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedAgentToolConfigParam(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling value) => new PersistedAgentToolConfigParam((global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling?(PersistedAgentToolConfigParam @this) => @this.ProgrammaticToolCalling;

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolConfigParam(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? value)
        {
            ProgrammaticToolCalling = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedAgentToolConfigParam FromProgrammaticToolCalling(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? value) => new PersistedAgentToolConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedAgentToolConfigParam(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp value) => new PersistedAgentToolConfigParam((global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp?(PersistedAgentToolConfigParam @this) => @this.Mcp;

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolConfigParam(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? value)
        {
            Mcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedAgentToolConfigParam FromMcp(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? value) => new PersistedAgentToolConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PersistedAgentToolConfigParam(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch value) => new PersistedAgentToolConfigParam((global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch?(PersistedAgentToolConfigParam @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolConfigParam(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PersistedAgentToolConfigParam FromWebSearch(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? value) => new PersistedAgentToolConfigParam(value);

        /// <summary>
        ///
        /// </summary>
        public PersistedAgentToolConfigParam(
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType? type,
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction? function,
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch? toolSearch,
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling? programmaticToolCalling,
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp? mcp,
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch? webSearch
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
            global::System.Func<global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch, TResult>? toolSearch = null,
            global::System.Func<global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling, TResult>? programmaticToolCalling = null,
            global::System.Func<global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp, TResult>? mcp = null,
            global::System.Func<global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch, TResult>? webSearch = null,
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
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction>? function = null,

            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch>? toolSearch = null,

            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling>? programmaticToolCalling = null,

            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp>? mcp = null,

            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch>? webSearch = null,
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
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction>? function = null,
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch>? toolSearch = null,
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling>? programmaticToolCalling = null,
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp>? mcp = null,
            global::System.Action<global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch>? webSearch = null,
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
                typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction),
                ToolSearch,
                typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch),
                ProgrammaticToolCalling,
                typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling),
                Mcp,
                typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp),
                WebSearch,
                typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch),
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
        public bool Equals(PersistedAgentToolConfigParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch?>.Default.Equals(ToolSearch, other.ToolSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling?>.Default.Equals(ProgrammaticToolCalling, other.ProgrammaticToolCalling) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch?>.Default.Equals(WebSearch, other.WebSearch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PersistedAgentToolConfigParam obj1, PersistedAgentToolConfigParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PersistedAgentToolConfigParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PersistedAgentToolConfigParam obj1, PersistedAgentToolConfigParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PersistedAgentToolConfigParam o && Equals(o);
        }
    }
}
