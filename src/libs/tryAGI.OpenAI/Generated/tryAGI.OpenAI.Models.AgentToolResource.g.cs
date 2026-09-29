#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool available to the agent.
    /// </summary>
    public readonly partial struct AgentToolResource : global::System.IEquatable<AgentToolResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A function defined by the application.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentToolResourceFunction? Function { get; init; }
#else
        public global::tryAGI.OpenAI.AgentToolResourceFunction? Function { get; }
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
            out global::tryAGI.OpenAI.AgentToolResourceFunction? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceFunction PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// Enables calling tools from model-generated code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? ProgrammaticToolCalling { get; init; }
#else
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? ProgrammaticToolCalling { get; }
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
            out global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? value)
        {
            value = ProgrammaticToolCalling;
            return IsProgrammaticToolCalling;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling PickProgrammaticToolCalling() => ProgrammaticToolCalling is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProgrammaticToolCalling' but the value was {ToString()}.");

        /// <summary>
        /// Tools provided by a remote MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentToolResourceMcp? Mcp { get; init; }
#else
        public global::tryAGI.OpenAI.AgentToolResourceMcp? Mcp { get; }
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
            out global::tryAGI.OpenAI.AgentToolResourceMcp? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceMcp PickMcp() => Mcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        /// Web search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentToolResourceWebSearch? WebSearch { get; init; }
#else
        public global::tryAGI.OpenAI.AgentToolResourceWebSearch? WebSearch { get; }
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
            out global::tryAGI.OpenAI.AgentToolResourceWebSearch? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceWebSearch PickWebSearch() => WebSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");

        /// <summary>
        /// Browser use in an OpenAI-hosted session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AgentToolResourceComputerUse? ComputerUse { get; init; }
#else
        public global::tryAGI.OpenAI.AgentToolResourceComputerUse? ComputerUse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUse))]
#endif
        public bool IsComputerUse => ComputerUse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AgentToolResourceComputerUse? value)
        {
            value = ComputerUse;
            return IsComputerUse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AgentToolResourceComputerUse PickComputerUse() => ComputerUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerUse' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolResource(global::tryAGI.OpenAI.AgentToolResourceFunction value) => new AgentToolResource((global::tryAGI.OpenAI.AgentToolResourceFunction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentToolResourceFunction?(AgentToolResource @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public AgentToolResource(global::tryAGI.OpenAI.AgentToolResourceFunction? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolResource FromFunction(global::tryAGI.OpenAI.AgentToolResourceFunction? value) => new AgentToolResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolResource(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling value) => new AgentToolResource((global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling?(AgentToolResource @this) => @this.ProgrammaticToolCalling;

        /// <summary>
        ///
        /// </summary>
        public AgentToolResource(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? value)
        {
            ProgrammaticToolCalling = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolResource FromProgrammaticToolCalling(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? value) => new AgentToolResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolResource(global::tryAGI.OpenAI.AgentToolResourceMcp value) => new AgentToolResource((global::tryAGI.OpenAI.AgentToolResourceMcp?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentToolResourceMcp?(AgentToolResource @this) => @this.Mcp;

        /// <summary>
        ///
        /// </summary>
        public AgentToolResource(global::tryAGI.OpenAI.AgentToolResourceMcp? value)
        {
            Mcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolResource FromMcp(global::tryAGI.OpenAI.AgentToolResourceMcp? value) => new AgentToolResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolResource(global::tryAGI.OpenAI.AgentToolResourceWebSearch value) => new AgentToolResource((global::tryAGI.OpenAI.AgentToolResourceWebSearch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentToolResourceWebSearch?(AgentToolResource @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public AgentToolResource(global::tryAGI.OpenAI.AgentToolResourceWebSearch? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolResource FromWebSearch(global::tryAGI.OpenAI.AgentToolResourceWebSearch? value) => new AgentToolResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolResource(global::tryAGI.OpenAI.AgentToolResourceComputerUse value) => new AgentToolResource((global::tryAGI.OpenAI.AgentToolResourceComputerUse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AgentToolResourceComputerUse?(AgentToolResource @this) => @this.ComputerUse;

        /// <summary>
        ///
        /// </summary>
        public AgentToolResource(global::tryAGI.OpenAI.AgentToolResourceComputerUse? value)
        {
            ComputerUse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolResource FromComputerUse(global::tryAGI.OpenAI.AgentToolResourceComputerUse? value) => new AgentToolResource(value);

        /// <summary>
        ///
        /// </summary>
        public AgentToolResource(
            global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.AgentToolResourceFunction? function,
            global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling? programmaticToolCalling,
            global::tryAGI.OpenAI.AgentToolResourceMcp? mcp,
            global::tryAGI.OpenAI.AgentToolResourceWebSearch? webSearch,
            global::tryAGI.OpenAI.AgentToolResourceComputerUse? computerUse
            )
        {
            Type = type;

            Function = function;
            ProgrammaticToolCalling = programmaticToolCalling;
            Mcp = mcp;
            WebSearch = webSearch;
            ComputerUse = computerUse;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ComputerUse as object ??
            WebSearch as object ??
            Mcp as object ??
            ProgrammaticToolCalling as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            ProgrammaticToolCalling?.ToString() ??
            Mcp?.ToString() ??
            WebSearch?.ToString() ??
            ComputerUse?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsProgrammaticToolCalling && !IsMcp && !IsWebSearch && !IsComputerUse || !IsFunction && IsProgrammaticToolCalling && !IsMcp && !IsWebSearch && !IsComputerUse || !IsFunction && !IsProgrammaticToolCalling && IsMcp && !IsWebSearch && !IsComputerUse || !IsFunction && !IsProgrammaticToolCalling && !IsMcp && IsWebSearch && !IsComputerUse || !IsFunction && !IsProgrammaticToolCalling && !IsMcp && !IsWebSearch && IsComputerUse;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AgentToolResourceFunction, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling, TResult>? programmaticToolCalling = null,
            global::System.Func<global::tryAGI.OpenAI.AgentToolResourceMcp, TResult>? mcp = null,
            global::System.Func<global::tryAGI.OpenAI.AgentToolResourceWebSearch, TResult>? webSearch = null,
            global::System.Func<global::tryAGI.OpenAI.AgentToolResourceComputerUse, TResult>? computerUse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0 && function != null)
            {
                return function(__value0);
            }
            else if (ProgrammaticToolCalling is { } __value1 && programmaticToolCalling != null)
            {
                return programmaticToolCalling(__value1);
            }
            else if (Mcp is { } __value2 && mcp != null)
            {
                return mcp(__value2);
            }
            else if (WebSearch is { } __value3 && webSearch != null)
            {
                return webSearch(__value3);
            }
            else if (ComputerUse is { } __value4 && computerUse != null)
            {
                return computerUse(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AgentToolResourceFunction>? function = null,

            global::System.Action<global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling>? programmaticToolCalling = null,

            global::System.Action<global::tryAGI.OpenAI.AgentToolResourceMcp>? mcp = null,

            global::System.Action<global::tryAGI.OpenAI.AgentToolResourceWebSearch>? webSearch = null,

            global::System.Action<global::tryAGI.OpenAI.AgentToolResourceComputerUse>? computerUse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0)
            {
                function?.Invoke(__value0);
            }
            else if (ProgrammaticToolCalling is { } __value1)
            {
                programmaticToolCalling?.Invoke(__value1);
            }
            else if (Mcp is { } __value2)
            {
                mcp?.Invoke(__value2);
            }
            else if (WebSearch is { } __value3)
            {
                webSearch?.Invoke(__value3);
            }
            else if (ComputerUse is { } __value4)
            {
                computerUse?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AgentToolResourceFunction>? function = null,
            global::System.Action<global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling>? programmaticToolCalling = null,
            global::System.Action<global::tryAGI.OpenAI.AgentToolResourceMcp>? mcp = null,
            global::System.Action<global::tryAGI.OpenAI.AgentToolResourceWebSearch>? webSearch = null,
            global::System.Action<global::tryAGI.OpenAI.AgentToolResourceComputerUse>? computerUse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0)
            {
                function?.Invoke(__value0);
            }
            else if (ProgrammaticToolCalling is { } __value1)
            {
                programmaticToolCalling?.Invoke(__value1);
            }
            else if (Mcp is { } __value2)
            {
                mcp?.Invoke(__value2);
            }
            else if (WebSearch is { } __value3)
            {
                webSearch?.Invoke(__value3);
            }
            else if (ComputerUse is { } __value4)
            {
                computerUse?.Invoke(__value4);
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
                typeof(global::tryAGI.OpenAI.AgentToolResourceFunction),
                ProgrammaticToolCalling,
                typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling),
                Mcp,
                typeof(global::tryAGI.OpenAI.AgentToolResourceMcp),
                WebSearch,
                typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearch),
                ComputerUse,
                typeof(global::tryAGI.OpenAI.AgentToolResourceComputerUse),
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
        public bool Equals(AgentToolResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentToolResourceFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling?>.Default.Equals(ProgrammaticToolCalling, other.ProgrammaticToolCalling) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentToolResourceMcp?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentToolResourceWebSearch?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AgentToolResourceComputerUse?>.Default.Equals(ComputerUse, other.ComputerUse)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AgentToolResource obj1, AgentToolResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentToolResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AgentToolResource obj1, AgentToolResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentToolResource o && Equals(o);
        }
    }
}
