#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolsItem16 : global::System.IEquatable<ToolsItem16>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A function tool available to the Responses backend when the Live model delegates a task.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Function { get; init; }
#else
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Function { get; }
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
            out global::tryAGI.OpenAI.LiveFunctionToolInputParam? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// A web search tool available to the Live session’s Responses backend.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? WebSearch { get; init; }
#else
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? WebSearch { get; }
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
            out global::tryAGI.OpenAI.LiveWebSearchToolInputParam? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam PickWebSearch() => WebSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParam? FileSearch { get; init; }
#else
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParam? FileSearch { get; }
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
            out global::tryAGI.OpenAI.LiveFileSearchToolInputParam? value)
        {
            value = FileSearch;
            return IsFileSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParam PickFileSearch() => FileSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? CodeInterpreter { get; init; }
#else
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? CodeInterpreter { get; }
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
            out global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? value)
        {
            value = CodeInterpreter;
            return IsCodeInterpreter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam PickCodeInterpreter() => CodeInterpreter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreter' but the value was {ToString()}.");

        /// <summary>
        /// A Responses shell tool. Use a hosted container or return local shell results with response.item.create. Domain secrets are not supported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParam? Shell { get; init; }
#else
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParam? Shell { get; }
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
            out global::tryAGI.OpenAI.LiveHostedShellToolInputParam? value)
        {
            value = Shell;
            return IsShell;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParam PickShell() => Shell is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shell' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? ImageGeneration { get; init; }
#else
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? ImageGeneration { get; }
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
            out global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? value)
        {
            value = ImageGeneration;
            return IsImageGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParam PickImageGeneration() => ImageGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGeneration' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveMCPToolInputParam? Mcp { get; init; }
#else
        public global::tryAGI.OpenAI.LiveMCPToolInputParam? Mcp { get; }
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
            out global::tryAGI.OpenAI.LiveMCPToolInputParam? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolInputParam PickMcp() => Mcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveCustomToolInputParam? Custom { get; init; }
#else
        public global::tryAGI.OpenAI.LiveCustomToolInputParam? Custom { get; }
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
            out global::tryAGI.OpenAI.LiveCustomToolInputParam? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCustomToolInputParam PickCustom() => Custom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParam? Namespace { get; init; }
#else
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParam? Namespace { get; }
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
            out global::tryAGI.OpenAI.LiveNamespaceToolInputParam? value)
        {
            value = Namespace;
            return IsNamespace;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveNamespaceToolInputParam PickNamespace() => Namespace is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Namespace' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParam? ToolSearch { get; init; }
#else
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParam? ToolSearch { get; }
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
            out global::tryAGI.OpenAI.LiveToolSearchToolInputParam? value)
        {
            value = ToolSearch;
            return IsToolSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveToolSearchToolInputParam PickToolSearch() => ToolSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParam? ProgrammaticToolCalling { get; init; }
#else
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParam? ProgrammaticToolCalling { get; }
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
            out global::tryAGI.OpenAI.LiveProgrammaticToolInputParam? value)
        {
            value = ProgrammaticToolCalling;
            return IsProgrammaticToolCalling;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveProgrammaticToolInputParam PickProgrammaticToolCalling() => ProgrammaticToolCalling is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProgrammaticToolCalling' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveComputerToolInputParam? Computer { get; init; }
#else
        public global::tryAGI.OpenAI.LiveComputerToolInputParam? Computer { get; }
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
            out global::tryAGI.OpenAI.LiveComputerToolInputParam? value)
        {
            value = Computer;
            return IsComputer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveComputerToolInputParam PickComputer() => Computer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Computer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParam? ApplyPatch { get; init; }
#else
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParam? ApplyPatch { get; }
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
            out global::tryAGI.OpenAI.LiveApplyPatchToolInputParam? value)
        {
            value = ApplyPatch;
            return IsApplyPatch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveApplyPatchToolInputParam PickApplyPatch() => ApplyPatch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveFunctionToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveFunctionToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveFunctionToolInputParam?(ToolsItem16 @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveFunctionToolInputParam? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromFunction(global::tryAGI.OpenAI.LiveFunctionToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveWebSearchToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveWebSearchToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveWebSearchToolInputParam?(ToolsItem16 @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveWebSearchToolInputParam? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromWebSearch(global::tryAGI.OpenAI.LiveWebSearchToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveFileSearchToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveFileSearchToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveFileSearchToolInputParam?(ToolsItem16 @this) => @this.FileSearch;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveFileSearchToolInputParam? value)
        {
            FileSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromFileSearch(global::tryAGI.OpenAI.LiveFileSearchToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam?(ToolsItem16 @this) => @this.CodeInterpreter;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromCodeInterpreter(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveHostedShellToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveHostedShellToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveHostedShellToolInputParam?(ToolsItem16 @this) => @this.Shell;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveHostedShellToolInputParam? value)
        {
            Shell = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromShell(global::tryAGI.OpenAI.LiveHostedShellToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveImageGenerationToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveImageGenerationToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveImageGenerationToolInputParam?(ToolsItem16 @this) => @this.ImageGeneration;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? value)
        {
            ImageGeneration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromImageGeneration(global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveMCPToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveMCPToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveMCPToolInputParam?(ToolsItem16 @this) => @this.Mcp;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveMCPToolInputParam? value)
        {
            Mcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromMcp(global::tryAGI.OpenAI.LiveMCPToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveCustomToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveCustomToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveCustomToolInputParam?(ToolsItem16 @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveCustomToolInputParam? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromCustom(global::tryAGI.OpenAI.LiveCustomToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveNamespaceToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveNamespaceToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveNamespaceToolInputParam?(ToolsItem16 @this) => @this.Namespace;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveNamespaceToolInputParam? value)
        {
            Namespace = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromNamespace(global::tryAGI.OpenAI.LiveNamespaceToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveToolSearchToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveToolSearchToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveToolSearchToolInputParam?(ToolsItem16 @this) => @this.ToolSearch;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveToolSearchToolInputParam? value)
        {
            ToolSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromToolSearch(global::tryAGI.OpenAI.LiveToolSearchToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveProgrammaticToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveProgrammaticToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveProgrammaticToolInputParam?(ToolsItem16 @this) => @this.ProgrammaticToolCalling;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveProgrammaticToolInputParam? value)
        {
            ProgrammaticToolCalling = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromProgrammaticToolCalling(global::tryAGI.OpenAI.LiveProgrammaticToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveComputerToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveComputerToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveComputerToolInputParam?(ToolsItem16 @this) => @this.Computer;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveComputerToolInputParam? value)
        {
            Computer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromComputer(global::tryAGI.OpenAI.LiveComputerToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem16(global::tryAGI.OpenAI.LiveApplyPatchToolInputParam value) => new ToolsItem16((global::tryAGI.OpenAI.LiveApplyPatchToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveApplyPatchToolInputParam?(ToolsItem16 @this) => @this.ApplyPatch;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(global::tryAGI.OpenAI.LiveApplyPatchToolInputParam? value)
        {
            ApplyPatch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem16 FromApplyPatch(global::tryAGI.OpenAI.LiveApplyPatchToolInputParam? value) => new ToolsItem16(value);

        /// <summary>
        ///
        /// </summary>
        public ToolsItem16(
            global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveFunctionToolInputParam? function,
            global::tryAGI.OpenAI.LiveWebSearchToolInputParam? webSearch,
            global::tryAGI.OpenAI.LiveFileSearchToolInputParam? fileSearch,
            global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? codeInterpreter,
            global::tryAGI.OpenAI.LiveHostedShellToolInputParam? shell,
            global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? imageGeneration,
            global::tryAGI.OpenAI.LiveMCPToolInputParam? mcp,
            global::tryAGI.OpenAI.LiveCustomToolInputParam? custom,
            global::tryAGI.OpenAI.LiveNamespaceToolInputParam? @namespace,
            global::tryAGI.OpenAI.LiveToolSearchToolInputParam? toolSearch,
            global::tryAGI.OpenAI.LiveProgrammaticToolInputParam? programmaticToolCalling,
            global::tryAGI.OpenAI.LiveComputerToolInputParam? computer,
            global::tryAGI.OpenAI.LiveApplyPatchToolInputParam? applyPatch
            )
        {
            Type = type;

            Function = function;
            WebSearch = webSearch;
            FileSearch = fileSearch;
            CodeInterpreter = codeInterpreter;
            Shell = shell;
            ImageGeneration = imageGeneration;
            Mcp = mcp;
            Custom = custom;
            Namespace = @namespace;
            ToolSearch = toolSearch;
            ProgrammaticToolCalling = programmaticToolCalling;
            Computer = computer;
            ApplyPatch = applyPatch;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ApplyPatch as object ??
            Computer as object ??
            ProgrammaticToolCalling as object ??
            ToolSearch as object ??
            Namespace as object ??
            Custom as object ??
            Mcp as object ??
            ImageGeneration as object ??
            Shell as object ??
            CodeInterpreter as object ??
            FileSearch as object ??
            WebSearch as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            WebSearch?.ToString() ??
            FileSearch?.ToString() ??
            CodeInterpreter?.ToString() ??
            Shell?.ToString() ??
            ImageGeneration?.ToString() ??
            Mcp?.ToString() ??
            Custom?.ToString() ??
            Namespace?.ToString() ??
            ToolSearch?.ToString() ??
            ProgrammaticToolCalling?.ToString() ??
            Computer?.ToString() ??
            ApplyPatch?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration && !IsMcp && !IsCustom && !IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration && !IsMcp && !IsCustom && !IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration && !IsMcp && !IsCustom && !IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && !IsFileSearch && IsCodeInterpreter && !IsShell && !IsImageGeneration && !IsMcp && !IsCustom && !IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && IsShell && !IsImageGeneration && !IsMcp && !IsCustom && !IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && IsImageGeneration && !IsMcp && !IsCustom && !IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration && IsMcp && !IsCustom && !IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration && !IsMcp && IsCustom && !IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration && !IsMcp && !IsCustom && IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration && !IsMcp && !IsCustom && !IsNamespace && IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration && !IsMcp && !IsCustom && !IsNamespace && !IsToolSearch && IsProgrammaticToolCalling && !IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration && !IsMcp && !IsCustom && !IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && IsComputer && !IsApplyPatch || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration && !IsMcp && !IsCustom && !IsNamespace && !IsToolSearch && !IsProgrammaticToolCalling && !IsComputer && IsApplyPatch;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveFunctionToolInputParam, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.LiveWebSearchToolInputParam, TResult>? webSearch = null,
            global::System.Func<global::tryAGI.OpenAI.LiveFileSearchToolInputParam, TResult>? fileSearch = null,
            global::System.Func<global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam, TResult>? codeInterpreter = null,
            global::System.Func<global::tryAGI.OpenAI.LiveHostedShellToolInputParam, TResult>? shell = null,
            global::System.Func<global::tryAGI.OpenAI.LiveImageGenerationToolInputParam, TResult>? imageGeneration = null,
            global::System.Func<global::tryAGI.OpenAI.LiveMCPToolInputParam, TResult>? mcp = null,
            global::System.Func<global::tryAGI.OpenAI.LiveCustomToolInputParam, TResult>? custom = null,
            global::System.Func<global::tryAGI.OpenAI.LiveNamespaceToolInputParam, TResult>? @namespace = null,
            global::System.Func<global::tryAGI.OpenAI.LiveToolSearchToolInputParam, TResult>? toolSearch = null,
            global::System.Func<global::tryAGI.OpenAI.LiveProgrammaticToolInputParam, TResult>? programmaticToolCalling = null,
            global::System.Func<global::tryAGI.OpenAI.LiveComputerToolInputParam, TResult>? computer = null,
            global::System.Func<global::tryAGI.OpenAI.LiveApplyPatchToolInputParam, TResult>? applyPatch = null,
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
            else if (WebSearch is { } __value1 && webSearch != null)
            {
                return webSearch(__value1);
            }
            else if (FileSearch is { } __value2 && fileSearch != null)
            {
                return fileSearch(__value2);
            }
            else if (CodeInterpreter is { } __value3 && codeInterpreter != null)
            {
                return codeInterpreter(__value3);
            }
            else if (Shell is { } __value4 && shell != null)
            {
                return shell(__value4);
            }
            else if (ImageGeneration is { } __value5 && imageGeneration != null)
            {
                return imageGeneration(__value5);
            }
            else if (Mcp is { } __value6 && mcp != null)
            {
                return mcp(__value6);
            }
            else if (Custom is { } __value7 && custom != null)
            {
                return custom(__value7);
            }
            else if (Namespace is { } __value8 && @namespace != null)
            {
                return @namespace(__value8);
            }
            else if (ToolSearch is { } __value9 && toolSearch != null)
            {
                return toolSearch(__value9);
            }
            else if (ProgrammaticToolCalling is { } __value10 && programmaticToolCalling != null)
            {
                return programmaticToolCalling(__value10);
            }
            else if (Computer is { } __value11 && computer != null)
            {
                return computer(__value11);
            }
            else if (ApplyPatch is { } __value12 && applyPatch != null)
            {
                return applyPatch(__value12);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveFunctionToolInputParam>? function = null,

            global::System.Action<global::tryAGI.OpenAI.LiveWebSearchToolInputParam>? webSearch = null,

            global::System.Action<global::tryAGI.OpenAI.LiveFileSearchToolInputParam>? fileSearch = null,

            global::System.Action<global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam>? codeInterpreter = null,

            global::System.Action<global::tryAGI.OpenAI.LiveHostedShellToolInputParam>? shell = null,

            global::System.Action<global::tryAGI.OpenAI.LiveImageGenerationToolInputParam>? imageGeneration = null,

            global::System.Action<global::tryAGI.OpenAI.LiveMCPToolInputParam>? mcp = null,

            global::System.Action<global::tryAGI.OpenAI.LiveCustomToolInputParam>? custom = null,

            global::System.Action<global::tryAGI.OpenAI.LiveNamespaceToolInputParam>? @namespace = null,

            global::System.Action<global::tryAGI.OpenAI.LiveToolSearchToolInputParam>? toolSearch = null,

            global::System.Action<global::tryAGI.OpenAI.LiveProgrammaticToolInputParam>? programmaticToolCalling = null,

            global::System.Action<global::tryAGI.OpenAI.LiveComputerToolInputParam>? computer = null,

            global::System.Action<global::tryAGI.OpenAI.LiveApplyPatchToolInputParam>? applyPatch = null,
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
            else if (WebSearch is { } __value1)
            {
                webSearch?.Invoke(__value1);
            }
            else if (FileSearch is { } __value2)
            {
                fileSearch?.Invoke(__value2);
            }
            else if (CodeInterpreter is { } __value3)
            {
                codeInterpreter?.Invoke(__value3);
            }
            else if (Shell is { } __value4)
            {
                shell?.Invoke(__value4);
            }
            else if (ImageGeneration is { } __value5)
            {
                imageGeneration?.Invoke(__value5);
            }
            else if (Mcp is { } __value6)
            {
                mcp?.Invoke(__value6);
            }
            else if (Custom is { } __value7)
            {
                custom?.Invoke(__value7);
            }
            else if (Namespace is { } __value8)
            {
                @namespace?.Invoke(__value8);
            }
            else if (ToolSearch is { } __value9)
            {
                toolSearch?.Invoke(__value9);
            }
            else if (ProgrammaticToolCalling is { } __value10)
            {
                programmaticToolCalling?.Invoke(__value10);
            }
            else if (Computer is { } __value11)
            {
                computer?.Invoke(__value11);
            }
            else if (ApplyPatch is { } __value12)
            {
                applyPatch?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveFunctionToolInputParam>? function = null,
            global::System.Action<global::tryAGI.OpenAI.LiveWebSearchToolInputParam>? webSearch = null,
            global::System.Action<global::tryAGI.OpenAI.LiveFileSearchToolInputParam>? fileSearch = null,
            global::System.Action<global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam>? codeInterpreter = null,
            global::System.Action<global::tryAGI.OpenAI.LiveHostedShellToolInputParam>? shell = null,
            global::System.Action<global::tryAGI.OpenAI.LiveImageGenerationToolInputParam>? imageGeneration = null,
            global::System.Action<global::tryAGI.OpenAI.LiveMCPToolInputParam>? mcp = null,
            global::System.Action<global::tryAGI.OpenAI.LiveCustomToolInputParam>? custom = null,
            global::System.Action<global::tryAGI.OpenAI.LiveNamespaceToolInputParam>? @namespace = null,
            global::System.Action<global::tryAGI.OpenAI.LiveToolSearchToolInputParam>? toolSearch = null,
            global::System.Action<global::tryAGI.OpenAI.LiveProgrammaticToolInputParam>? programmaticToolCalling = null,
            global::System.Action<global::tryAGI.OpenAI.LiveComputerToolInputParam>? computer = null,
            global::System.Action<global::tryAGI.OpenAI.LiveApplyPatchToolInputParam>? applyPatch = null,
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
            else if (WebSearch is { } __value1)
            {
                webSearch?.Invoke(__value1);
            }
            else if (FileSearch is { } __value2)
            {
                fileSearch?.Invoke(__value2);
            }
            else if (CodeInterpreter is { } __value3)
            {
                codeInterpreter?.Invoke(__value3);
            }
            else if (Shell is { } __value4)
            {
                shell?.Invoke(__value4);
            }
            else if (ImageGeneration is { } __value5)
            {
                imageGeneration?.Invoke(__value5);
            }
            else if (Mcp is { } __value6)
            {
                mcp?.Invoke(__value6);
            }
            else if (Custom is { } __value7)
            {
                custom?.Invoke(__value7);
            }
            else if (Namespace is { } __value8)
            {
                @namespace?.Invoke(__value8);
            }
            else if (ToolSearch is { } __value9)
            {
                toolSearch?.Invoke(__value9);
            }
            else if (ProgrammaticToolCalling is { } __value10)
            {
                programmaticToolCalling?.Invoke(__value10);
            }
            else if (Computer is { } __value11)
            {
                computer?.Invoke(__value11);
            }
            else if (ApplyPatch is { } __value12)
            {
                applyPatch?.Invoke(__value12);
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
                typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParam),
                WebSearch,
                typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParam),
                FileSearch,
                typeof(global::tryAGI.OpenAI.LiveFileSearchToolInputParam),
                CodeInterpreter,
                typeof(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam),
                Shell,
                typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParam),
                ImageGeneration,
                typeof(global::tryAGI.OpenAI.LiveImageGenerationToolInputParam),
                Mcp,
                typeof(global::tryAGI.OpenAI.LiveMCPToolInputParam),
                Custom,
                typeof(global::tryAGI.OpenAI.LiveCustomToolInputParam),
                Namespace,
                typeof(global::tryAGI.OpenAI.LiveNamespaceToolInputParam),
                ToolSearch,
                typeof(global::tryAGI.OpenAI.LiveToolSearchToolInputParam),
                ProgrammaticToolCalling,
                typeof(global::tryAGI.OpenAI.LiveProgrammaticToolInputParam),
                Computer,
                typeof(global::tryAGI.OpenAI.LiveComputerToolInputParam),
                ApplyPatch,
                typeof(global::tryAGI.OpenAI.LiveApplyPatchToolInputParam),
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
        public bool Equals(ToolsItem16 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveFunctionToolInputParam?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveWebSearchToolInputParam?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveFileSearchToolInputParam?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveHostedShellToolInputParam?>.Default.Equals(Shell, other.Shell) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveImageGenerationToolInputParam?>.Default.Equals(ImageGeneration, other.ImageGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveMCPToolInputParam?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveCustomToolInputParam?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveNamespaceToolInputParam?>.Default.Equals(Namespace, other.Namespace) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveToolSearchToolInputParam?>.Default.Equals(ToolSearch, other.ToolSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveProgrammaticToolInputParam?>.Default.Equals(ProgrammaticToolCalling, other.ProgrammaticToolCalling) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveComputerToolInputParam?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveApplyPatchToolInputParam?>.Default.Equals(ApplyPatch, other.ApplyPatch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolsItem16 obj1, ToolsItem16 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem16>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolsItem16 obj1, ToolsItem16 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem16 o && Equals(o);
        }
    }
}
