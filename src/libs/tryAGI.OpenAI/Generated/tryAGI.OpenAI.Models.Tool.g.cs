#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that can be used to generate a response.
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
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
        /// A tool that controls a virtual computer. Learn more about the [computer tool](https://platform.openai.com/docs/guides/tools-computer-use).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerTool? Computer { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerTool? Computer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Computer))]
#endif
        public bool IsComputer => Computer != null;

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
        /// Search the Internet for sources related to the prompt. Learn more about the<br/>
        /// [web search tool](/docs/guides/tools-web-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.WebSearchTool? WebSearch { get; init; }
#else
        public global::tryAGI.OpenAI.WebSearchTool? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        /// Give the model access to additional tools via remote Model Context Protocol<br/>
        /// (MCP) servers. [Learn more about MCP](/docs/guides/tools-remote-mcp).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.MCPTool? Mcp { get; init; }
#else
        public global::tryAGI.OpenAI.MCPTool? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// A tool that runs Python code to help generate a response to a prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CodeInterpreterTool? CodeInterpreter { get; init; }
#else
        public global::tryAGI.OpenAI.CodeInterpreterTool? CodeInterpreter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreter))]
#endif
        public bool IsCodeInterpreter => CodeInterpreter != null;

        /// <summary>
        /// A tool that generates images using the GPT image models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ImageGenTool? ImageGeneration { get; init; }
#else
        public global::tryAGI.OpenAI.ImageGenTool? ImageGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGeneration))]
#endif
        public bool IsImageGeneration => ImageGeneration != null;

        /// <summary>
        /// A tool that allows the model to execute shell commands in a local environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LocalShellToolParam? LocalShell { get; init; }
#else
        public global::tryAGI.OpenAI.LocalShellToolParam? LocalShell { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShell))]
#endif
        public bool IsLocalShell => LocalShell != null;

        /// <summary>
        /// A tool that allows the model to execute shell commands.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionShellToolParam? Shell { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionShellToolParam? Shell { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shell))]
#endif
        public bool IsShell => Shell != null;

        /// <summary>
        /// A custom tool that processes input using a specified format. Learn more about   [custom tools](/docs/guides/function-calling#custom-tools)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CustomToolParam? Custom { get; init; }
#else
        public global::tryAGI.OpenAI.CustomToolParam? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// Groups function/custom tools under a shared namespace.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.NamespaceToolParam? Namespace { get; init; }
#else
        public global::tryAGI.OpenAI.NamespaceToolParam? Namespace { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Namespace))]
#endif
        public bool IsNamespace => Namespace != null;

        /// <summary>
        /// Hosted or BYOT tool search configuration for deferred tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolSearchToolParam? ToolSearch { get; init; }
#else
        public global::tryAGI.OpenAI.ToolSearchToolParam? ToolSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearch))]
#endif
        public bool IsToolSearch => ToolSearch != null;

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
        /// Allows the assistant to create, delete, or update files using unified diffs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchToolParam? ApplyPatch { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchToolParam? ApplyPatch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatch))]
#endif
        public bool IsApplyPatch => ApplyPatch != null;
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
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.ComputerTool value) => new Tool((global::tryAGI.OpenAI.ComputerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerTool?(Tool @this) => @this.Computer;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.ComputerTool? value)
        {
            Computer = value;
        }

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
        public static implicit operator Tool(global::tryAGI.OpenAI.WebSearchTool value) => new Tool((global::tryAGI.OpenAI.WebSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.WebSearchTool?(Tool @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.WebSearchTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.MCPTool value) => new Tool((global::tryAGI.OpenAI.MCPTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.MCPTool?(Tool @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.MCPTool? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.CodeInterpreterTool value) => new Tool((global::tryAGI.OpenAI.CodeInterpreterTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterTool?(Tool @this) => @this.CodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.CodeInterpreterTool? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.ImageGenTool value) => new Tool((global::tryAGI.OpenAI.ImageGenTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ImageGenTool?(Tool @this) => @this.ImageGeneration;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.ImageGenTool? value)
        {
            ImageGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.LocalShellToolParam value) => new Tool((global::tryAGI.OpenAI.LocalShellToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LocalShellToolParam?(Tool @this) => @this.LocalShell;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.LocalShellToolParam? value)
        {
            LocalShell = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.FunctionShellToolParam value) => new Tool((global::tryAGI.OpenAI.FunctionShellToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellToolParam?(Tool @this) => @this.Shell;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.FunctionShellToolParam? value)
        {
            Shell = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.CustomToolParam value) => new Tool((global::tryAGI.OpenAI.CustomToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CustomToolParam?(Tool @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.CustomToolParam? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.NamespaceToolParam value) => new Tool((global::tryAGI.OpenAI.NamespaceToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.NamespaceToolParam?(Tool @this) => @this.Namespace;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.NamespaceToolParam? value)
        {
            Namespace = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.ToolSearchToolParam value) => new Tool((global::tryAGI.OpenAI.ToolSearchToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolSearchToolParam?(Tool @this) => @this.ToolSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.ToolSearchToolParam? value)
        {
            ToolSearch = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator Tool(global::tryAGI.OpenAI.ApplyPatchToolParam value) => new Tool((global::tryAGI.OpenAI.ApplyPatchToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchToolParam?(Tool @this) => @this.ApplyPatch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::tryAGI.OpenAI.ApplyPatchToolParam? value)
        {
            ApplyPatch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::tryAGI.OpenAI.FunctionTool? function,
            global::tryAGI.OpenAI.FileSearchTool? fileSearch,
            global::tryAGI.OpenAI.ComputerTool? computer,
            global::tryAGI.OpenAI.ComputerUsePreviewTool? computerUsePreview,
            global::tryAGI.OpenAI.WebSearchTool? webSearch,
            global::tryAGI.OpenAI.MCPTool? mcp,
            global::tryAGI.OpenAI.CodeInterpreterTool? codeInterpreter,
            global::tryAGI.OpenAI.ImageGenTool? imageGeneration,
            global::tryAGI.OpenAI.LocalShellToolParam? localShell,
            global::tryAGI.OpenAI.FunctionShellToolParam? shell,
            global::tryAGI.OpenAI.CustomToolParam? custom,
            global::tryAGI.OpenAI.NamespaceToolParam? @namespace,
            global::tryAGI.OpenAI.ToolSearchToolParam? toolSearch,
            global::tryAGI.OpenAI.WebSearchPreviewTool? webSearchPreview,
            global::tryAGI.OpenAI.ApplyPatchToolParam? applyPatch
            )
        {
            Function = function;
            FileSearch = fileSearch;
            Computer = computer;
            ComputerUsePreview = computerUsePreview;
            WebSearch = webSearch;
            Mcp = mcp;
            CodeInterpreter = codeInterpreter;
            ImageGeneration = imageGeneration;
            LocalShell = localShell;
            Shell = shell;
            Custom = custom;
            Namespace = @namespace;
            ToolSearch = toolSearch;
            WebSearchPreview = webSearchPreview;
            ApplyPatch = applyPatch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApplyPatch as object ??
            WebSearchPreview as object ??
            ToolSearch as object ??
            Namespace as object ??
            Custom as object ??
            Shell as object ??
            LocalShell as object ??
            ImageGeneration as object ??
            CodeInterpreter as object ??
            Mcp as object ??
            WebSearch as object ??
            ComputerUsePreview as object ??
            Computer as object ??
            FileSearch as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            FileSearch?.ToString() ??
            Computer?.ToString() ??
            ComputerUsePreview?.ToString() ??
            WebSearch?.ToString() ??
            Mcp?.ToString() ??
            CodeInterpreter?.ToString() ??
            ImageGeneration?.ToString() ??
            LocalShell?.ToString() ??
            Shell?.ToString() ??
            Custom?.ToString() ??
            Namespace?.ToString() ??
            ToolSearch?.ToString() ??
            WebSearchPreview?.ToString() ??
            ApplyPatch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && IsApplyPatch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FunctionTool?, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.FileSearchTool?, TResult>? fileSearch = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerTool?, TResult>? computer = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerUsePreviewTool?, TResult>? computerUsePreview = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchTool?, TResult>? webSearch = null,
            global::System.Func<global::tryAGI.OpenAI.MCPTool?, TResult>? mcp = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterTool?, TResult>? codeInterpreter = null,
            global::System.Func<global::tryAGI.OpenAI.ImageGenTool?, TResult>? imageGeneration = null,
            global::System.Func<global::tryAGI.OpenAI.LocalShellToolParam?, TResult>? localShell = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionShellToolParam?, TResult>? shell = null,
            global::System.Func<global::tryAGI.OpenAI.CustomToolParam?, TResult>? custom = null,
            global::System.Func<global::tryAGI.OpenAI.NamespaceToolParam?, TResult>? @namespace = null,
            global::System.Func<global::tryAGI.OpenAI.ToolSearchToolParam?, TResult>? toolSearch = null,
            global::System.Func<global::tryAGI.OpenAI.WebSearchPreviewTool?, TResult>? webSearchPreview = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchToolParam?, TResult>? applyPatch = null,
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
            else if (IsFileSearch && fileSearch != null)
            {
                return fileSearch(FileSearch!);
            }
            else if (IsComputer && computer != null)
            {
                return computer(Computer!);
            }
            else if (IsComputerUsePreview && computerUsePreview != null)
            {
                return computerUsePreview(ComputerUsePreview!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsCodeInterpreter && codeInterpreter != null)
            {
                return codeInterpreter(CodeInterpreter!);
            }
            else if (IsImageGeneration && imageGeneration != null)
            {
                return imageGeneration(ImageGeneration!);
            }
            else if (IsLocalShell && localShell != null)
            {
                return localShell(LocalShell!);
            }
            else if (IsShell && shell != null)
            {
                return shell(Shell!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsNamespace && @namespace != null)
            {
                return @namespace(Namespace!);
            }
            else if (IsToolSearch && toolSearch != null)
            {
                return toolSearch(ToolSearch!);
            }
            else if (IsWebSearchPreview && webSearchPreview != null)
            {
                return webSearchPreview(WebSearchPreview!);
            }
            else if (IsApplyPatch && applyPatch != null)
            {
                return applyPatch(ApplyPatch!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.FunctionTool?>? function = null,
            global::System.Action<global::tryAGI.OpenAI.FileSearchTool?>? fileSearch = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerTool?>? computer = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerUsePreviewTool?>? computerUsePreview = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchTool?>? webSearch = null,
            global::System.Action<global::tryAGI.OpenAI.MCPTool?>? mcp = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterTool?>? codeInterpreter = null,
            global::System.Action<global::tryAGI.OpenAI.ImageGenTool?>? imageGeneration = null,
            global::System.Action<global::tryAGI.OpenAI.LocalShellToolParam?>? localShell = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionShellToolParam?>? shell = null,
            global::System.Action<global::tryAGI.OpenAI.CustomToolParam?>? custom = null,
            global::System.Action<global::tryAGI.OpenAI.NamespaceToolParam?>? @namespace = null,
            global::System.Action<global::tryAGI.OpenAI.ToolSearchToolParam?>? toolSearch = null,
            global::System.Action<global::tryAGI.OpenAI.WebSearchPreviewTool?>? webSearchPreview = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchToolParam?>? applyPatch = null,
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
            else if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsComputer)
            {
                computer?.Invoke(Computer!);
            }
            else if (IsComputerUsePreview)
            {
                computerUsePreview?.Invoke(ComputerUsePreview!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsCodeInterpreter)
            {
                codeInterpreter?.Invoke(CodeInterpreter!);
            }
            else if (IsImageGeneration)
            {
                imageGeneration?.Invoke(ImageGeneration!);
            }
            else if (IsLocalShell)
            {
                localShell?.Invoke(LocalShell!);
            }
            else if (IsShell)
            {
                shell?.Invoke(Shell!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsNamespace)
            {
                @namespace?.Invoke(Namespace!);
            }
            else if (IsToolSearch)
            {
                toolSearch?.Invoke(ToolSearch!);
            }
            else if (IsWebSearchPreview)
            {
                webSearchPreview?.Invoke(WebSearchPreview!);
            }
            else if (IsApplyPatch)
            {
                applyPatch?.Invoke(ApplyPatch!);
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
                typeof(global::tryAGI.OpenAI.FunctionTool),
                FileSearch,
                typeof(global::tryAGI.OpenAI.FileSearchTool),
                Computer,
                typeof(global::tryAGI.OpenAI.ComputerTool),
                ComputerUsePreview,
                typeof(global::tryAGI.OpenAI.ComputerUsePreviewTool),
                WebSearch,
                typeof(global::tryAGI.OpenAI.WebSearchTool),
                Mcp,
                typeof(global::tryAGI.OpenAI.MCPTool),
                CodeInterpreter,
                typeof(global::tryAGI.OpenAI.CodeInterpreterTool),
                ImageGeneration,
                typeof(global::tryAGI.OpenAI.ImageGenTool),
                LocalShell,
                typeof(global::tryAGI.OpenAI.LocalShellToolParam),
                Shell,
                typeof(global::tryAGI.OpenAI.FunctionShellToolParam),
                Custom,
                typeof(global::tryAGI.OpenAI.CustomToolParam),
                Namespace,
                typeof(global::tryAGI.OpenAI.NamespaceToolParam),
                ToolSearch,
                typeof(global::tryAGI.OpenAI.ToolSearchToolParam),
                WebSearchPreview,
                typeof(global::tryAGI.OpenAI.WebSearchPreviewTool),
                ApplyPatch,
                typeof(global::tryAGI.OpenAI.ApplyPatchToolParam),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FileSearchTool?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerTool?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerUsePreviewTool?>.Default.Equals(ComputerUsePreview, other.ComputerUsePreview) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchTool?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.MCPTool?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterTool?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ImageGenTool?>.Default.Equals(ImageGeneration, other.ImageGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LocalShellToolParam?>.Default.Equals(LocalShell, other.LocalShell) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellToolParam?>.Default.Equals(Shell, other.Shell) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CustomToolParam?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.NamespaceToolParam?>.Default.Equals(Namespace, other.Namespace) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolSearchToolParam?>.Default.Equals(ToolSearch, other.ToolSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.WebSearchPreviewTool?>.Default.Equals(WebSearchPreview, other.WebSearchPreview) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchToolParam?>.Default.Equals(ApplyPatch, other.ApplyPatch) 
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
