#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that can be used to generate a response.
    /// </summary>
    public readonly partial struct BetaTool : global::System.IEquatable<BetaTool>
    {
        /// <summary>
        /// Defines a function in your own code the model can choose to call. Learn more about [function calling](https://platform.openai.com/docs/guides/function-calling).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionTool? Function { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionTool? Function { get; }
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
            out global::tryAGI.OpenAI.BetaFunctionTool? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionTool PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// A tool that searches for relevant content from uploaded files. Learn more about the [file search tool](https://platform.openai.com/docs/guides/tools-file-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFileSearchTool? FileSearch { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFileSearchTool? FileSearch { get; }
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
        public bool TryPickFileSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFileSearchTool? value)
        {
            value = FileSearch;
            return IsFileSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFileSearchTool PickFileSearch() => IsFileSearch
            ? FileSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearch' but the value was {ToString()}.");

        /// <summary>
        /// A tool that controls a virtual computer. Learn more about the [computer tool](https://platform.openai.com/docs/guides/tools-computer-use).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaComputerTool? Computer { get; init; }
#else
        public global::tryAGI.OpenAI.BetaComputerTool? Computer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Computer))]
#endif
        public bool IsComputer => Computer != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaComputerTool? value)
        {
            value = Computer;
            return IsComputer;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerTool PickComputer() => IsComputer
            ? Computer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Computer' but the value was {ToString()}.");

        /// <summary>
        /// A tool that controls a virtual computer. Learn more about the [computer tool](https://platform.openai.com/docs/guides/tools-computer-use).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaComputerUsePreviewTool? ComputerUsePreview { get; init; }
#else
        public global::tryAGI.OpenAI.BetaComputerUsePreviewTool? ComputerUsePreview { get; }
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
        public bool TryPickComputerUsePreview(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaComputerUsePreviewTool? value)
        {
            value = ComputerUsePreview;
            return IsComputerUsePreview;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaComputerUsePreviewTool PickComputerUsePreview() => IsComputerUsePreview
            ? ComputerUsePreview!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerUsePreview' but the value was {ToString()}.");

        /// <summary>
        /// Search the Internet for sources related to the prompt. Learn more about the<br/>
        /// [web search tool](/docs/guides/tools-web-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaWebSearchTool? WebSearch { get; init; }
#else
        public global::tryAGI.OpenAI.BetaWebSearchTool? WebSearch { get; }
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
            out global::tryAGI.OpenAI.BetaWebSearchTool? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchTool PickWebSearch() => IsWebSearch
            ? WebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");

        /// <summary>
        /// Give the model access to additional tools via remote Model Context Protocol<br/>
        /// (MCP) servers. [Learn more about MCP](/docs/guides/tools-remote-mcp).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaMCPTool? Mcp { get; init; }
#else
        public global::tryAGI.OpenAI.BetaMCPTool? Mcp { get; }
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
            out global::tryAGI.OpenAI.BetaMCPTool? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaMCPTool PickMcp() => IsMcp
            ? Mcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        /// A tool that runs Python code to help generate a response to a prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCodeInterpreterTool? CodeInterpreter { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCodeInterpreterTool? CodeInterpreter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreter))]
#endif
        public bool IsCodeInterpreter => CodeInterpreter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCodeInterpreter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCodeInterpreterTool? value)
        {
            value = CodeInterpreter;
            return IsCodeInterpreter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCodeInterpreterTool PickCodeInterpreter() => IsCodeInterpreter
            ? CodeInterpreter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreter' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? ProgrammaticToolCalling { get; init; }
#else
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? ProgrammaticToolCalling { get; }
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
            out global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? value)
        {
            value = ProgrammaticToolCalling;
            return IsProgrammaticToolCalling;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam PickProgrammaticToolCalling() => IsProgrammaticToolCalling
            ? ProgrammaticToolCalling!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProgrammaticToolCalling' but the value was {ToString()}.");

        /// <summary>
        /// A tool that generates images using the GPT image models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaImageGenTool? ImageGeneration { get; init; }
#else
        public global::tryAGI.OpenAI.BetaImageGenTool? ImageGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGeneration))]
#endif
        public bool IsImageGeneration => ImageGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaImageGenTool? value)
        {
            value = ImageGeneration;
            return IsImageGeneration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaImageGenTool PickImageGeneration() => IsImageGeneration
            ? ImageGeneration!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGeneration' but the value was {ToString()}.");

        /// <summary>
        /// A tool that allows the model to execute shell commands in a local environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaLocalShellToolParam? LocalShell { get; init; }
#else
        public global::tryAGI.OpenAI.BetaLocalShellToolParam? LocalShell { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShell))]
#endif
        public bool IsLocalShell => LocalShell != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLocalShell(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaLocalShellToolParam? value)
        {
            value = LocalShell;
            return IsLocalShell;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaLocalShellToolParam PickLocalShell() => IsLocalShell
            ? LocalShell!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LocalShell' but the value was {ToString()}.");

        /// <summary>
        /// A tool that allows the model to execute shell commands.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionShellToolParam? Shell { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionShellToolParam? Shell { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shell))]
#endif
        public bool IsShell => Shell != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickShell(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFunctionShellToolParam? value)
        {
            value = Shell;
            return IsShell;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellToolParam PickShell() => IsShell
            ? Shell!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shell' but the value was {ToString()}.");

        /// <summary>
        /// A custom tool that processes input using a specified format. Learn more about   [custom tools](/docs/guides/function-calling#custom-tools)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaCustomToolParam? Custom { get; init; }
#else
        public global::tryAGI.OpenAI.BetaCustomToolParam? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaCustomToolParam? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaCustomToolParam PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");

        /// <summary>
        /// Groups function/custom tools under a shared namespace.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaNamespaceToolParam? Namespace { get; init; }
#else
        public global::tryAGI.OpenAI.BetaNamespaceToolParam? Namespace { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Namespace))]
#endif
        public bool IsNamespace => Namespace != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNamespace(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaNamespaceToolParam? value)
        {
            value = Namespace;
            return IsNamespace;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaNamespaceToolParam PickNamespace() => IsNamespace
            ? Namespace!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Namespace' but the value was {ToString()}.");

        /// <summary>
        /// Hosted or BYOT tool search configuration for deferred tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolSearchToolParam? ToolSearch { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolSearchToolParam? ToolSearch { get; }
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
            out global::tryAGI.OpenAI.BetaToolSearchToolParam? value)
        {
            value = ToolSearch;
            return IsToolSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolSearchToolParam PickToolSearch() => IsToolSearch
            ? ToolSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearch' but the value was {ToString()}.");

        /// <summary>
        /// This tool searches the web for relevant results to use in a response. Learn more about the [web search tool](https://platform.openai.com/docs/guides/tools-web-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaWebSearchPreviewTool? WebSearchPreview { get; init; }
#else
        public global::tryAGI.OpenAI.BetaWebSearchPreviewTool? WebSearchPreview { get; }
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
        public bool TryPickWebSearchPreview(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaWebSearchPreviewTool? value)
        {
            value = WebSearchPreview;
            return IsWebSearchPreview;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaWebSearchPreviewTool PickWebSearchPreview() => IsWebSearchPreview
            ? WebSearchPreview!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchPreview' but the value was {ToString()}.");

        /// <summary>
        /// Allows the assistant to create, delete, or update files using unified diffs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchToolParam? ApplyPatch { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchToolParam? ApplyPatch { get; }
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
        public bool TryPickApplyPatch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaApplyPatchToolParam? value)
        {
            value = ApplyPatch;
            return IsApplyPatch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolParam PickApplyPatch() => IsApplyPatch
            ? ApplyPatch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatch' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaFunctionTool value) => new BetaTool((global::tryAGI.OpenAI.BetaFunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionTool?(BetaTool @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaFunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromFunction(global::tryAGI.OpenAI.BetaFunctionTool? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaFileSearchTool value) => new BetaTool((global::tryAGI.OpenAI.BetaFileSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFileSearchTool?(BetaTool @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaFileSearchTool? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromFileSearch(global::tryAGI.OpenAI.BetaFileSearchTool? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaComputerTool value) => new BetaTool((global::tryAGI.OpenAI.BetaComputerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaComputerTool?(BetaTool @this) => @this.Computer;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaComputerTool? value)
        {
            Computer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromComputer(global::tryAGI.OpenAI.BetaComputerTool? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaComputerUsePreviewTool value) => new BetaTool((global::tryAGI.OpenAI.BetaComputerUsePreviewTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaComputerUsePreviewTool?(BetaTool @this) => @this.ComputerUsePreview;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaComputerUsePreviewTool? value)
        {
            ComputerUsePreview = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromComputerUsePreview(global::tryAGI.OpenAI.BetaComputerUsePreviewTool? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaWebSearchTool value) => new BetaTool((global::tryAGI.OpenAI.BetaWebSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaWebSearchTool?(BetaTool @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaWebSearchTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromWebSearch(global::tryAGI.OpenAI.BetaWebSearchTool? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaMCPTool value) => new BetaTool((global::tryAGI.OpenAI.BetaMCPTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaMCPTool?(BetaTool @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaMCPTool? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromMcp(global::tryAGI.OpenAI.BetaMCPTool? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaCodeInterpreterTool value) => new BetaTool((global::tryAGI.OpenAI.BetaCodeInterpreterTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCodeInterpreterTool?(BetaTool @this) => @this.CodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaCodeInterpreterTool? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromCodeInterpreter(global::tryAGI.OpenAI.BetaCodeInterpreterTool? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam value) => new BetaTool((global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam?(BetaTool @this) => @this.ProgrammaticToolCalling;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? value)
        {
            ProgrammaticToolCalling = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromProgrammaticToolCalling(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaImageGenTool value) => new BetaTool((global::tryAGI.OpenAI.BetaImageGenTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaImageGenTool?(BetaTool @this) => @this.ImageGeneration;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaImageGenTool? value)
        {
            ImageGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromImageGeneration(global::tryAGI.OpenAI.BetaImageGenTool? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaLocalShellToolParam value) => new BetaTool((global::tryAGI.OpenAI.BetaLocalShellToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaLocalShellToolParam?(BetaTool @this) => @this.LocalShell;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaLocalShellToolParam? value)
        {
            LocalShell = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromLocalShell(global::tryAGI.OpenAI.BetaLocalShellToolParam? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaFunctionShellToolParam value) => new BetaTool((global::tryAGI.OpenAI.BetaFunctionShellToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionShellToolParam?(BetaTool @this) => @this.Shell;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaFunctionShellToolParam? value)
        {
            Shell = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromShell(global::tryAGI.OpenAI.BetaFunctionShellToolParam? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaCustomToolParam value) => new BetaTool((global::tryAGI.OpenAI.BetaCustomToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaCustomToolParam?(BetaTool @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaCustomToolParam? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromCustom(global::tryAGI.OpenAI.BetaCustomToolParam? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaNamespaceToolParam value) => new BetaTool((global::tryAGI.OpenAI.BetaNamespaceToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaNamespaceToolParam?(BetaTool @this) => @this.Namespace;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaNamespaceToolParam? value)
        {
            Namespace = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromNamespace(global::tryAGI.OpenAI.BetaNamespaceToolParam? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaToolSearchToolParam value) => new BetaTool((global::tryAGI.OpenAI.BetaToolSearchToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolSearchToolParam?(BetaTool @this) => @this.ToolSearch;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaToolSearchToolParam? value)
        {
            ToolSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromToolSearch(global::tryAGI.OpenAI.BetaToolSearchToolParam? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaWebSearchPreviewTool value) => new BetaTool((global::tryAGI.OpenAI.BetaWebSearchPreviewTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaWebSearchPreviewTool?(BetaTool @this) => @this.WebSearchPreview;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaWebSearchPreviewTool? value)
        {
            WebSearchPreview = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromWebSearchPreview(global::tryAGI.OpenAI.BetaWebSearchPreviewTool? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTool(global::tryAGI.OpenAI.BetaApplyPatchToolParam value) => new BetaTool((global::tryAGI.OpenAI.BetaApplyPatchToolParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchToolParam?(BetaTool @this) => @this.ApplyPatch;

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(global::tryAGI.OpenAI.BetaApplyPatchToolParam? value)
        {
            ApplyPatch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTool FromApplyPatch(global::tryAGI.OpenAI.BetaApplyPatchToolParam? value) => new BetaTool(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaTool(
            global::tryAGI.OpenAI.BetaFunctionTool? function,
            global::tryAGI.OpenAI.BetaFileSearchTool? fileSearch,
            global::tryAGI.OpenAI.BetaComputerTool? computer,
            global::tryAGI.OpenAI.BetaComputerUsePreviewTool? computerUsePreview,
            global::tryAGI.OpenAI.BetaWebSearchTool? webSearch,
            global::tryAGI.OpenAI.BetaMCPTool? mcp,
            global::tryAGI.OpenAI.BetaCodeInterpreterTool? codeInterpreter,
            global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam? programmaticToolCalling,
            global::tryAGI.OpenAI.BetaImageGenTool? imageGeneration,
            global::tryAGI.OpenAI.BetaLocalShellToolParam? localShell,
            global::tryAGI.OpenAI.BetaFunctionShellToolParam? shell,
            global::tryAGI.OpenAI.BetaCustomToolParam? custom,
            global::tryAGI.OpenAI.BetaNamespaceToolParam? @namespace,
            global::tryAGI.OpenAI.BetaToolSearchToolParam? toolSearch,
            global::tryAGI.OpenAI.BetaWebSearchPreviewTool? webSearchPreview,
            global::tryAGI.OpenAI.BetaApplyPatchToolParam? applyPatch
            )
        {
            Function = function;
            FileSearch = fileSearch;
            Computer = computer;
            ComputerUsePreview = computerUsePreview;
            WebSearch = webSearch;
            Mcp = mcp;
            CodeInterpreter = codeInterpreter;
            ProgrammaticToolCalling = programmaticToolCalling;
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
            ProgrammaticToolCalling as object ??
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
            ProgrammaticToolCalling?.ToString() ??
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
            return IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && IsNamespace && !IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && IsToolSearch && !IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && IsWebSearchPreview && !IsApplyPatch || !IsFunction && !IsFileSearch && !IsComputer && !IsComputerUsePreview && !IsWebSearch && !IsMcp && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsImageGeneration && !IsLocalShell && !IsShell && !IsCustom && !IsNamespace && !IsToolSearch && !IsWebSearchPreview && IsApplyPatch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionTool, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFileSearchTool, TResult>? fileSearch = null,
            global::System.Func<global::tryAGI.OpenAI.BetaComputerTool, TResult>? computer = null,
            global::System.Func<global::tryAGI.OpenAI.BetaComputerUsePreviewTool, TResult>? computerUsePreview = null,
            global::System.Func<global::tryAGI.OpenAI.BetaWebSearchTool, TResult>? webSearch = null,
            global::System.Func<global::tryAGI.OpenAI.BetaMCPTool, TResult>? mcp = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCodeInterpreterTool, TResult>? codeInterpreter = null,
            global::System.Func<global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam, TResult>? programmaticToolCalling = null,
            global::System.Func<global::tryAGI.OpenAI.BetaImageGenTool, TResult>? imageGeneration = null,
            global::System.Func<global::tryAGI.OpenAI.BetaLocalShellToolParam, TResult>? localShell = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionShellToolParam, TResult>? shell = null,
            global::System.Func<global::tryAGI.OpenAI.BetaCustomToolParam, TResult>? custom = null,
            global::System.Func<global::tryAGI.OpenAI.BetaNamespaceToolParam, TResult>? @namespace = null,
            global::System.Func<global::tryAGI.OpenAI.BetaToolSearchToolParam, TResult>? toolSearch = null,
            global::System.Func<global::tryAGI.OpenAI.BetaWebSearchPreviewTool, TResult>? webSearchPreview = null,
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchToolParam, TResult>? applyPatch = null,
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
            else if (IsProgrammaticToolCalling && programmaticToolCalling != null)
            {
                return programmaticToolCalling(ProgrammaticToolCalling!);
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
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionTool>? function = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFileSearchTool>? fileSearch = null,

            global::System.Action<global::tryAGI.OpenAI.BetaComputerTool>? computer = null,

            global::System.Action<global::tryAGI.OpenAI.BetaComputerUsePreviewTool>? computerUsePreview = null,

            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchTool>? webSearch = null,

            global::System.Action<global::tryAGI.OpenAI.BetaMCPTool>? mcp = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCodeInterpreterTool>? codeInterpreter = null,

            global::System.Action<global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam>? programmaticToolCalling = null,

            global::System.Action<global::tryAGI.OpenAI.BetaImageGenTool>? imageGeneration = null,

            global::System.Action<global::tryAGI.OpenAI.BetaLocalShellToolParam>? localShell = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellToolParam>? shell = null,

            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolParam>? custom = null,

            global::System.Action<global::tryAGI.OpenAI.BetaNamespaceToolParam>? @namespace = null,

            global::System.Action<global::tryAGI.OpenAI.BetaToolSearchToolParam>? toolSearch = null,

            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchPreviewTool>? webSearchPreview = null,

            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchToolParam>? applyPatch = null,
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
            else if (IsProgrammaticToolCalling)
            {
                programmaticToolCalling?.Invoke(ProgrammaticToolCalling!);
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
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionTool>? function = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFileSearchTool>? fileSearch = null,
            global::System.Action<global::tryAGI.OpenAI.BetaComputerTool>? computer = null,
            global::System.Action<global::tryAGI.OpenAI.BetaComputerUsePreviewTool>? computerUsePreview = null,
            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchTool>? webSearch = null,
            global::System.Action<global::tryAGI.OpenAI.BetaMCPTool>? mcp = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCodeInterpreterTool>? codeInterpreter = null,
            global::System.Action<global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam>? programmaticToolCalling = null,
            global::System.Action<global::tryAGI.OpenAI.BetaImageGenTool>? imageGeneration = null,
            global::System.Action<global::tryAGI.OpenAI.BetaLocalShellToolParam>? localShell = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellToolParam>? shell = null,
            global::System.Action<global::tryAGI.OpenAI.BetaCustomToolParam>? custom = null,
            global::System.Action<global::tryAGI.OpenAI.BetaNamespaceToolParam>? @namespace = null,
            global::System.Action<global::tryAGI.OpenAI.BetaToolSearchToolParam>? toolSearch = null,
            global::System.Action<global::tryAGI.OpenAI.BetaWebSearchPreviewTool>? webSearchPreview = null,
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchToolParam>? applyPatch = null,
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
            else if (IsProgrammaticToolCalling)
            {
                programmaticToolCalling?.Invoke(ProgrammaticToolCalling!);
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
                typeof(global::tryAGI.OpenAI.BetaFunctionTool),
                FileSearch,
                typeof(global::tryAGI.OpenAI.BetaFileSearchTool),
                Computer,
                typeof(global::tryAGI.OpenAI.BetaComputerTool),
                ComputerUsePreview,
                typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewTool),
                WebSearch,
                typeof(global::tryAGI.OpenAI.BetaWebSearchTool),
                Mcp,
                typeof(global::tryAGI.OpenAI.BetaMCPTool),
                CodeInterpreter,
                typeof(global::tryAGI.OpenAI.BetaCodeInterpreterTool),
                ProgrammaticToolCalling,
                typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam),
                ImageGeneration,
                typeof(global::tryAGI.OpenAI.BetaImageGenTool),
                LocalShell,
                typeof(global::tryAGI.OpenAI.BetaLocalShellToolParam),
                Shell,
                typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParam),
                Custom,
                typeof(global::tryAGI.OpenAI.BetaCustomToolParam),
                Namespace,
                typeof(global::tryAGI.OpenAI.BetaNamespaceToolParam),
                ToolSearch,
                typeof(global::tryAGI.OpenAI.BetaToolSearchToolParam),
                WebSearchPreview,
                typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewTool),
                ApplyPatch,
                typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParam),
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
        public bool Equals(BetaTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFileSearchTool?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaComputerTool?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaComputerUsePreviewTool?>.Default.Equals(ComputerUsePreview, other.ComputerUsePreview) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaWebSearchTool?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaMCPTool?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCodeInterpreterTool?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam?>.Default.Equals(ProgrammaticToolCalling, other.ProgrammaticToolCalling) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaImageGenTool?>.Default.Equals(ImageGeneration, other.ImageGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaLocalShellToolParam?>.Default.Equals(LocalShell, other.LocalShell) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionShellToolParam?>.Default.Equals(Shell, other.Shell) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaCustomToolParam?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaNamespaceToolParam?>.Default.Equals(Namespace, other.Namespace) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolSearchToolParam?>.Default.Equals(ToolSearch, other.ToolSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaWebSearchPreviewTool?>.Default.Equals(WebSearchPreview, other.WebSearchPreview) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchToolParam?>.Default.Equals(ApplyPatch, other.ApplyPatch) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaTool obj1, BetaTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaTool obj1, BetaTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaTool o && Equals(o);
        }
    }
}
