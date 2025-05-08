#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        /// A tool that searches for relevant content from uploaded files. Learn more about the [file search tool](https://platform.openai.com/docs/guides/tools-file-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FileSearchTool? FileSearch { get; init; }
#else
        public global::tryAGI.OpenAI.FileSearchTool? FileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearch))]
#endif
        public bool IsFileSearch => FileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.FileSearchTool value) => new Tool((global::tryAGI.OpenAI.FileSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FileSearchTool?(Tool @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.FileSearchTool? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// Defines a function in your own code the model can choose to call. Learn more about [function calling](https://platform.openai.com/docs/guides/function-calling).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionTool? Function { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionTool? Function { get; }
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
        public static implicit operator Tool(global::tryAGI.OpenAI.FunctionTool value) => new Tool((global::tryAGI.OpenAI.FunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionTool?(Tool @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.FunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        /// This tool searches the web for relevant results to use in a response. Learn more about the [web search tool](https://platform.openai.com/docs/guides/tools-web-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchPreviewTool? WebSearchPreview { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchPreviewTool? WebSearchPreview { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchPreview))]
#endif
        public bool IsWebSearchPreview => WebSearchPreview != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.WebSearchPreviewTool value) => new Tool((global::tryAGI.OpenAI.WebSearchPreviewTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchPreviewTool?(Tool @this) => @this.WebSearchPreview;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.WebSearchPreviewTool? value)
        {
            WebSearchPreview = value;
        }

        /// <summary>
        /// A tool that controls a virtual computer. Learn more about the [computer tool](https://platform.openai.com/docs/guides/tools-computer-use).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerUsePreviewTool? ComputerUsePreview { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerUsePreviewTool? ComputerUsePreview { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUsePreview))]
#endif
        public bool IsComputerUsePreview => ComputerUsePreview != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.ComputerUsePreviewTool value) => new Tool((global::tryAGI.OpenAI.ComputerUsePreviewTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerUsePreviewTool?(Tool @this) => @this.ComputerUsePreview;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.ComputerUsePreviewTool? value)
        {
            ComputerUsePreview = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::tryAGI.OpenAI.FileSearchTool? fileSearch,
            global::tryAGI.OpenAI.FunctionTool? function,
            global::tryAGI.OpenAI.WebSearchPreviewTool? webSearchPreview,
            global::tryAGI.OpenAI.ComputerUsePreviewTool? computerUsePreview
            )
        {
            FileSearch = fileSearch;
            Function = function;
            WebSearchPreview = webSearchPreview;
            ComputerUsePreview = computerUsePreview;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ComputerUsePreview as object ??
            WebSearchPreview as object ??
            Function as object ??
            FileSearch as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileSearch?.ToString() ??
            Function?.ToString() ??
            WebSearchPreview?.ToString() ??
            ComputerUsePreview?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileSearch && !IsFunction && !IsWebSearchPreview && !IsComputerUsePreview || !IsFileSearch && IsFunction && !IsWebSearchPreview && !IsComputerUsePreview || !IsFileSearch && !IsFunction && IsWebSearchPreview && !IsComputerUsePreview || !IsFileSearch && !IsFunction && !IsWebSearchPreview && IsComputerUsePreview;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FileSearchTool?, TResult>? fileSearch = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionTool?, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchPreviewTool?, TResult>? webSearchPreview = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerUsePreviewTool?, TResult>? computerUsePreview = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearch && fileSearch != null)
            {
                return fileSearch(FileSearch!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsWebSearchPreview && webSearchPreview != null)
            {
                return webSearchPreview(WebSearchPreview!);
            }
            else if (IsComputerUsePreview && computerUsePreview != null)
            {
                return computerUsePreview(ComputerUsePreview!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.FileSearchTool?>? fileSearch = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionTool?>? function = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchPreviewTool?>? webSearchPreview = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerUsePreviewTool?>? computerUsePreview = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsWebSearchPreview)
            {
                webSearchPreview?.Invoke(WebSearchPreview!);
            }
            else if (IsComputerUsePreview)
            {
                computerUsePreview?.Invoke(ComputerUsePreview!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileSearch,
                typeof(global::tryAGI.OpenAI.FileSearchTool),
                Function,
                typeof(global::tryAGI.OpenAI.FunctionTool),
                WebSearchPreview,
                typeof(global::tryAGI.OpenAI.WebSearchPreviewTool),
                ComputerUsePreview,
                typeof(global::tryAGI.OpenAI.ComputerUsePreviewTool),
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
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileSearchTool?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchPreviewTool?>.Default.Equals(WebSearchPreview, other.WebSearchPreview) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerUsePreviewTool?>.Default.Equals(ComputerUsePreview, other.ComputerUsePreview) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }
    }
}
