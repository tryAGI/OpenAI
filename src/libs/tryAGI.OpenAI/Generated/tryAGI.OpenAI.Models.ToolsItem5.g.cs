#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem5 : global::System.IEquatable<ToolsItem5>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeFunctionTool? RealtimeFunctionTool { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeFunctionTool? RealtimeFunctionTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeFunctionTool))]
#endif
        public bool IsRealtimeFunctionTool => RealtimeFunctionTool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::tryAGI.OpenAI.RealtimeFunctionTool value) => new ToolsItem5((global::tryAGI.OpenAI.RealtimeFunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeFunctionTool?(ToolsItem5 @this) => @this.RealtimeFunctionTool;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::tryAGI.OpenAI.RealtimeFunctionTool? value)
        {
            RealtimeFunctionTool = value;
        }

        /// <summary>
        /// Give the model access to additional tools via remote Model Context Protocol <br/>
        /// (MCP) servers. [Learn more about MCP](https://platform.openai.com/docs/guides/tools-remote-mcp).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPTool? MCPTool { get; init; }
#else
        public global::tryAGI.OpenAI.MCPTool? MCPTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPTool))]
#endif
        public bool IsMCPTool => MCPTool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::tryAGI.OpenAI.MCPTool value) => new ToolsItem5((global::tryAGI.OpenAI.MCPTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPTool?(ToolsItem5 @this) => @this.MCPTool;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::tryAGI.OpenAI.MCPTool? value)
        {
            MCPTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(
            global::tryAGI.OpenAI.RealtimeFunctionTool? realtimeFunctionTool,
            global::tryAGI.OpenAI.MCPTool? mCPTool
            )
        {
            RealtimeFunctionTool = realtimeFunctionTool;
            MCPTool = mCPTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MCPTool as object ??
            RealtimeFunctionTool as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RealtimeFunctionTool?.ToString() ??
            MCPTool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeFunctionTool || IsMCPTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeFunctionTool?, TResult>? realtimeFunctionTool = null,
            global::System.Func<global::tryAGI.OpenAI.MCPTool?, TResult>? mCPTool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeFunctionTool && realtimeFunctionTool != null)
            {
                return realtimeFunctionTool(RealtimeFunctionTool!);
            }
            else if (IsMCPTool && mCPTool != null)
            {
                return mCPTool(MCPTool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeFunctionTool?>? realtimeFunctionTool = null,
            global::System.Action<global::tryAGI.OpenAI.MCPTool?>? mCPTool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeFunctionTool)
            {
                realtimeFunctionTool?.Invoke(RealtimeFunctionTool!);
            }
            else if (IsMCPTool)
            {
                mCPTool?.Invoke(MCPTool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RealtimeFunctionTool,
                typeof(global::tryAGI.OpenAI.RealtimeFunctionTool),
                MCPTool,
                typeof(global::tryAGI.OpenAI.MCPTool),
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
        public bool Equals(ToolsItem5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeFunctionTool?>.Default.Equals(RealtimeFunctionTool, other.RealtimeFunctionTool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPTool?>.Default.Equals(MCPTool, other.MCPTool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem5 obj1, ToolsItem5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem5 obj1, ToolsItem5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem5 o && Equals(o);
        }
    }
}
