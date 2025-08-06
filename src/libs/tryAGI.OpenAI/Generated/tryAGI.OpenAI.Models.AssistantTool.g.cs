#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AssistantTool : global::System.IEquatable<AssistantTool>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantToolsCode? ToolsCode { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantToolsCode? ToolsCode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolsCode))]
#endif
        public bool IsToolsCode => ToolsCode != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantTool(global::tryAGI.OpenAI.AssistantToolsCode value) => new AssistantTool((global::tryAGI.OpenAI.AssistantToolsCode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantToolsCode?(AssistantTool @this) => @this.ToolsCode;

        /// <summary>
        /// 
        /// </summary>
        public AssistantTool(global::tryAGI.OpenAI.AssistantToolsCode? value)
        {
            ToolsCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantToolsFileSearch? ToolsFileSearch { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantToolsFileSearch? ToolsFileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolsFileSearch))]
#endif
        public bool IsToolsFileSearch => ToolsFileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantTool(global::tryAGI.OpenAI.AssistantToolsFileSearch value) => new AssistantTool((global::tryAGI.OpenAI.AssistantToolsFileSearch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantToolsFileSearch?(AssistantTool @this) => @this.ToolsFileSearch;

        /// <summary>
        /// 
        /// </summary>
        public AssistantTool(global::tryAGI.OpenAI.AssistantToolsFileSearch? value)
        {
            ToolsFileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantToolsFunction? ToolsFunction { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantToolsFunction? ToolsFunction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolsFunction))]
#endif
        public bool IsToolsFunction => ToolsFunction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantTool(global::tryAGI.OpenAI.AssistantToolsFunction value) => new AssistantTool((global::tryAGI.OpenAI.AssistantToolsFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantToolsFunction?(AssistantTool @this) => @this.ToolsFunction;

        /// <summary>
        /// 
        /// </summary>
        public AssistantTool(global::tryAGI.OpenAI.AssistantToolsFunction? value)
        {
            ToolsFunction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantTool(
            global::tryAGI.OpenAI.AssistantToolsCode? toolsCode,
            global::tryAGI.OpenAI.AssistantToolsFileSearch? toolsFileSearch,
            global::tryAGI.OpenAI.AssistantToolsFunction? toolsFunction
            )
        {
            ToolsCode = toolsCode;
            ToolsFileSearch = toolsFileSearch;
            ToolsFunction = toolsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolsFunction as object ??
            ToolsFileSearch as object ??
            ToolsCode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolsCode?.ToString() ??
            ToolsFileSearch?.ToString() ??
            ToolsFunction?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolsCode || IsToolsFileSearch || IsToolsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AssistantToolsCode?, TResult>? toolsCode = null,
            global::System.Func<global::tryAGI.OpenAI.AssistantToolsFileSearch?, TResult>? toolsFileSearch = null,
            global::System.Func<global::tryAGI.OpenAI.AssistantToolsFunction?, TResult>? toolsFunction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolsCode && toolsCode != null)
            {
                return toolsCode(ToolsCode!);
            }
            else if (IsToolsFileSearch && toolsFileSearch != null)
            {
                return toolsFileSearch(ToolsFileSearch!);
            }
            else if (IsToolsFunction && toolsFunction != null)
            {
                return toolsFunction(ToolsFunction!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AssistantToolsCode?>? toolsCode = null,
            global::System.Action<global::tryAGI.OpenAI.AssistantToolsFileSearch?>? toolsFileSearch = null,
            global::System.Action<global::tryAGI.OpenAI.AssistantToolsFunction?>? toolsFunction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolsCode)
            {
                toolsCode?.Invoke(ToolsCode!);
            }
            else if (IsToolsFileSearch)
            {
                toolsFileSearch?.Invoke(ToolsFileSearch!);
            }
            else if (IsToolsFunction)
            {
                toolsFunction?.Invoke(ToolsFunction!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolsCode,
                typeof(global::tryAGI.OpenAI.AssistantToolsCode),
                ToolsFileSearch,
                typeof(global::tryAGI.OpenAI.AssistantToolsFileSearch),
                ToolsFunction,
                typeof(global::tryAGI.OpenAI.AssistantToolsFunction),
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
        public bool Equals(AssistantTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantToolsCode?>.Default.Equals(ToolsCode, other.ToolsCode) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantToolsFileSearch?>.Default.Equals(ToolsFileSearch, other.ToolsFileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantToolsFunction?>.Default.Equals(ToolsFunction, other.ToolsFunction) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AssistantTool obj1, AssistantTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssistantTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AssistantTool obj1, AssistantTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssistantTool o && Equals(o);
        }
    }
}
