#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolChoiceVariant22 : global::System.IEquatable<ToolChoiceVariant22>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? Function { get; init; }
#else
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? Function { get; }
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
            out global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolChoiceParam PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParam? Mcp { get; init; }
#else
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParam? Mcp { get; }
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
            out global::tryAGI.OpenAI.LiveMCPToolChoiceParam? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveMCPToolChoiceParam PickMcp() => Mcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParam? FileSearch { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParam? FileSearch { get; }
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
            out global::tryAGI.OpenAI.LiveSpecificFileSearchParam? value)
        {
            value = FileSearch;
            return IsFileSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFileSearchParam PickFileSearch() => FileSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParam? WebSearch { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParam? WebSearch { get; }
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
            out global::tryAGI.OpenAI.LiveSpecificWebSearchParam? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchParam PickWebSearch() => WebSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam? WebSearchPreview { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam? WebSearchPreview { get; }
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
            out global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam? value)
        {
            value = WebSearchPreview;
            return IsWebSearchPreview;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam PickWebSearchPreview() => WebSearchPreview is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchPreview' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSpecificImageGenParam? ImageGeneration { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSpecificImageGenParam? ImageGeneration { get; }
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
            out global::tryAGI.OpenAI.LiveSpecificImageGenParam? value)
        {
            value = ImageGeneration;
            return IsImageGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificImageGenParam PickImageGeneration() => ImageGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGeneration' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSpecificComputerParam? Computer { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSpecificComputerParam? Computer { get; }
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
            out global::tryAGI.OpenAI.LiveSpecificComputerParam? value)
        {
            value = Computer;
            return IsComputer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificComputerParam PickComputer() => Computer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Computer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam? CodeInterpreter { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam? CodeInterpreter { get; }
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
            out global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam? value)
        {
            value = CodeInterpreter;
            return IsCodeInterpreter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam PickCodeInterpreter() => CodeInterpreter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreter' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam? ProgrammaticToolCalling { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam? ProgrammaticToolCalling { get; }
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
            out global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam? value)
        {
            value = ProgrammaticToolCalling;
            return IsProgrammaticToolCalling;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam PickProgrammaticToolCalling() => ProgrammaticToolCalling is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProgrammaticToolCalling' but the value was {ToString()}.");

        /// <summary>
        /// Forces the model to call the shell tool when a tool call is required.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParam? Shell { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParam? Shell { get; }
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
            out global::tryAGI.OpenAI.LiveSpecificFunctionShellParam? value)
        {
            value = Shell;
            return IsShell;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificFunctionShellParam PickShell() => Shell is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shell' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParam? Custom { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParam? Custom { get; }
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
            out global::tryAGI.OpenAI.LiveSpecificCustomToolParam? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificCustomToolParam PickCustom() => Custom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");

        /// <summary>
        /// Forces the model to call the apply_patch tool when executing a tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParam? ApplyPatch { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParam? ApplyPatch { get; }
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
            out global::tryAGI.OpenAI.LiveSpecificApplyPatchParam? value)
        {
            value = ApplyPatch;
            return IsApplyPatch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSpecificApplyPatchParam PickApplyPatch() => ApplyPatch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveFunctionToolChoiceParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveFunctionToolChoiceParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveFunctionToolChoiceParam?(ToolChoiceVariant22 @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromFunction(global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveMCPToolChoiceParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveMCPToolChoiceParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveMCPToolChoiceParam?(ToolChoiceVariant22 @this) => @this.Mcp;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveMCPToolChoiceParam? value)
        {
            Mcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromMcp(global::tryAGI.OpenAI.LiveMCPToolChoiceParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificFileSearchParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveSpecificFileSearchParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSpecificFileSearchParam?(ToolChoiceVariant22 @this) => @this.FileSearch;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificFileSearchParam? value)
        {
            FileSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromFileSearch(global::tryAGI.OpenAI.LiveSpecificFileSearchParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificWebSearchParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveSpecificWebSearchParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSpecificWebSearchParam?(ToolChoiceVariant22 @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificWebSearchParam? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromWebSearch(global::tryAGI.OpenAI.LiveSpecificWebSearchParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam?(ToolChoiceVariant22 @this) => @this.WebSearchPreview;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam? value)
        {
            WebSearchPreview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromWebSearchPreview(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificImageGenParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveSpecificImageGenParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSpecificImageGenParam?(ToolChoiceVariant22 @this) => @this.ImageGeneration;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificImageGenParam? value)
        {
            ImageGeneration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromImageGeneration(global::tryAGI.OpenAI.LiveSpecificImageGenParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificComputerParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveSpecificComputerParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSpecificComputerParam?(ToolChoiceVariant22 @this) => @this.Computer;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificComputerParam? value)
        {
            Computer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromComputer(global::tryAGI.OpenAI.LiveSpecificComputerParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam?(ToolChoiceVariant22 @this) => @this.CodeInterpreter;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromCodeInterpreter(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam?(ToolChoiceVariant22 @this) => @this.ProgrammaticToolCalling;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam? value)
        {
            ProgrammaticToolCalling = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromProgrammaticToolCalling(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificFunctionShellParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveSpecificFunctionShellParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSpecificFunctionShellParam?(ToolChoiceVariant22 @this) => @this.Shell;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificFunctionShellParam? value)
        {
            Shell = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromShell(global::tryAGI.OpenAI.LiveSpecificFunctionShellParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificCustomToolParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveSpecificCustomToolParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSpecificCustomToolParam?(ToolChoiceVariant22 @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificCustomToolParam? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromCustom(global::tryAGI.OpenAI.LiveSpecificCustomToolParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificApplyPatchParam value) => new ToolChoiceVariant22((global::tryAGI.OpenAI.LiveSpecificApplyPatchParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSpecificApplyPatchParam?(ToolChoiceVariant22 @this) => @this.ApplyPatch;

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(global::tryAGI.OpenAI.LiveSpecificApplyPatchParam? value)
        {
            ApplyPatch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChoiceVariant22 FromApplyPatch(global::tryAGI.OpenAI.LiveSpecificApplyPatchParam? value) => new ToolChoiceVariant22(value);

        /// <summary>
        ///
        /// </summary>
        public ToolChoiceVariant22(
            global::tryAGI.OpenAI.LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType? type,
            global::tryAGI.OpenAI.LiveFunctionToolChoiceParam? function,
            global::tryAGI.OpenAI.LiveMCPToolChoiceParam? mcp,
            global::tryAGI.OpenAI.LiveSpecificFileSearchParam? fileSearch,
            global::tryAGI.OpenAI.LiveSpecificWebSearchParam? webSearch,
            global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam? webSearchPreview,
            global::tryAGI.OpenAI.LiveSpecificImageGenParam? imageGeneration,
            global::tryAGI.OpenAI.LiveSpecificComputerParam? computer,
            global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam? codeInterpreter,
            global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam? programmaticToolCalling,
            global::tryAGI.OpenAI.LiveSpecificFunctionShellParam? shell,
            global::tryAGI.OpenAI.LiveSpecificCustomToolParam? custom,
            global::tryAGI.OpenAI.LiveSpecificApplyPatchParam? applyPatch
            )
        {
            Type = type;

            Function = function;
            Mcp = mcp;
            FileSearch = fileSearch;
            WebSearch = webSearch;
            WebSearchPreview = webSearchPreview;
            ImageGeneration = imageGeneration;
            Computer = computer;
            CodeInterpreter = codeInterpreter;
            ProgrammaticToolCalling = programmaticToolCalling;
            Shell = shell;
            Custom = custom;
            ApplyPatch = applyPatch;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ApplyPatch as object ??
            Custom as object ??
            Shell as object ??
            ProgrammaticToolCalling as object ??
            CodeInterpreter as object ??
            Computer as object ??
            ImageGeneration as object ??
            WebSearchPreview as object ??
            WebSearch as object ??
            FileSearch as object ??
            Mcp as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Mcp?.ToString() ??
            FileSearch?.ToString() ??
            WebSearch?.ToString() ??
            WebSearchPreview?.ToString() ??
            ImageGeneration?.ToString() ??
            Computer?.ToString() ??
            CodeInterpreter?.ToString() ??
            ProgrammaticToolCalling?.ToString() ??
            Shell?.ToString() ??
            Custom?.ToString() ??
            ApplyPatch?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsMcp && !IsFileSearch && !IsWebSearch && !IsWebSearchPreview && !IsImageGeneration && !IsComputer && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsShell && !IsCustom && !IsApplyPatch || !IsFunction && IsMcp && !IsFileSearch && !IsWebSearch && !IsWebSearchPreview && !IsImageGeneration && !IsComputer && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsShell && !IsCustom && !IsApplyPatch || !IsFunction && !IsMcp && IsFileSearch && !IsWebSearch && !IsWebSearchPreview && !IsImageGeneration && !IsComputer && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsShell && !IsCustom && !IsApplyPatch || !IsFunction && !IsMcp && !IsFileSearch && IsWebSearch && !IsWebSearchPreview && !IsImageGeneration && !IsComputer && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsShell && !IsCustom && !IsApplyPatch || !IsFunction && !IsMcp && !IsFileSearch && !IsWebSearch && IsWebSearchPreview && !IsImageGeneration && !IsComputer && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsShell && !IsCustom && !IsApplyPatch || !IsFunction && !IsMcp && !IsFileSearch && !IsWebSearch && !IsWebSearchPreview && IsImageGeneration && !IsComputer && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsShell && !IsCustom && !IsApplyPatch || !IsFunction && !IsMcp && !IsFileSearch && !IsWebSearch && !IsWebSearchPreview && !IsImageGeneration && IsComputer && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsShell && !IsCustom && !IsApplyPatch || !IsFunction && !IsMcp && !IsFileSearch && !IsWebSearch && !IsWebSearchPreview && !IsImageGeneration && !IsComputer && IsCodeInterpreter && !IsProgrammaticToolCalling && !IsShell && !IsCustom && !IsApplyPatch || !IsFunction && !IsMcp && !IsFileSearch && !IsWebSearch && !IsWebSearchPreview && !IsImageGeneration && !IsComputer && !IsCodeInterpreter && IsProgrammaticToolCalling && !IsShell && !IsCustom && !IsApplyPatch || !IsFunction && !IsMcp && !IsFileSearch && !IsWebSearch && !IsWebSearchPreview && !IsImageGeneration && !IsComputer && !IsCodeInterpreter && !IsProgrammaticToolCalling && IsShell && !IsCustom && !IsApplyPatch || !IsFunction && !IsMcp && !IsFileSearch && !IsWebSearch && !IsWebSearchPreview && !IsImageGeneration && !IsComputer && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsShell && IsCustom && !IsApplyPatch || !IsFunction && !IsMcp && !IsFileSearch && !IsWebSearch && !IsWebSearchPreview && !IsImageGeneration && !IsComputer && !IsCodeInterpreter && !IsProgrammaticToolCalling && !IsShell && !IsCustom && IsApplyPatch;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveFunctionToolChoiceParam, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.LiveMCPToolChoiceParam, TResult>? mcp = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSpecificFileSearchParam, TResult>? fileSearch = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSpecificWebSearchParam, TResult>? webSearch = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam, TResult>? webSearchPreview = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSpecificImageGenParam, TResult>? imageGeneration = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSpecificComputerParam, TResult>? computer = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam, TResult>? codeInterpreter = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam, TResult>? programmaticToolCalling = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSpecificFunctionShellParam, TResult>? shell = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSpecificCustomToolParam, TResult>? custom = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSpecificApplyPatchParam, TResult>? applyPatch = null,
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
            else if (Mcp is { } __value1 && mcp != null)
            {
                return mcp(__value1);
            }
            else if (FileSearch is { } __value2 && fileSearch != null)
            {
                return fileSearch(__value2);
            }
            else if (WebSearch is { } __value3 && webSearch != null)
            {
                return webSearch(__value3);
            }
            else if (WebSearchPreview is { } __value4 && webSearchPreview != null)
            {
                return webSearchPreview(__value4);
            }
            else if (ImageGeneration is { } __value5 && imageGeneration != null)
            {
                return imageGeneration(__value5);
            }
            else if (Computer is { } __value6 && computer != null)
            {
                return computer(__value6);
            }
            else if (CodeInterpreter is { } __value7 && codeInterpreter != null)
            {
                return codeInterpreter(__value7);
            }
            else if (ProgrammaticToolCalling is { } __value8 && programmaticToolCalling != null)
            {
                return programmaticToolCalling(__value8);
            }
            else if (Shell is { } __value9 && shell != null)
            {
                return shell(__value9);
            }
            else if (Custom is { } __value10 && custom != null)
            {
                return custom(__value10);
            }
            else if (ApplyPatch is { } __value11 && applyPatch != null)
            {
                return applyPatch(__value11);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveFunctionToolChoiceParam>? function = null,

            global::System.Action<global::tryAGI.OpenAI.LiveMCPToolChoiceParam>? mcp = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSpecificFileSearchParam>? fileSearch = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSpecificWebSearchParam>? webSearch = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam>? webSearchPreview = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSpecificImageGenParam>? imageGeneration = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSpecificComputerParam>? computer = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam>? codeInterpreter = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam>? programmaticToolCalling = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSpecificFunctionShellParam>? shell = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSpecificCustomToolParam>? custom = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSpecificApplyPatchParam>? applyPatch = null,
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
            else if (Mcp is { } __value1)
            {
                mcp?.Invoke(__value1);
            }
            else if (FileSearch is { } __value2)
            {
                fileSearch?.Invoke(__value2);
            }
            else if (WebSearch is { } __value3)
            {
                webSearch?.Invoke(__value3);
            }
            else if (WebSearchPreview is { } __value4)
            {
                webSearchPreview?.Invoke(__value4);
            }
            else if (ImageGeneration is { } __value5)
            {
                imageGeneration?.Invoke(__value5);
            }
            else if (Computer is { } __value6)
            {
                computer?.Invoke(__value6);
            }
            else if (CodeInterpreter is { } __value7)
            {
                codeInterpreter?.Invoke(__value7);
            }
            else if (ProgrammaticToolCalling is { } __value8)
            {
                programmaticToolCalling?.Invoke(__value8);
            }
            else if (Shell is { } __value9)
            {
                shell?.Invoke(__value9);
            }
            else if (Custom is { } __value10)
            {
                custom?.Invoke(__value10);
            }
            else if (ApplyPatch is { } __value11)
            {
                applyPatch?.Invoke(__value11);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveFunctionToolChoiceParam>? function = null,
            global::System.Action<global::tryAGI.OpenAI.LiveMCPToolChoiceParam>? mcp = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSpecificFileSearchParam>? fileSearch = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSpecificWebSearchParam>? webSearch = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam>? webSearchPreview = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSpecificImageGenParam>? imageGeneration = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSpecificComputerParam>? computer = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam>? codeInterpreter = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam>? programmaticToolCalling = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSpecificFunctionShellParam>? shell = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSpecificCustomToolParam>? custom = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSpecificApplyPatchParam>? applyPatch = null,
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
            else if (Mcp is { } __value1)
            {
                mcp?.Invoke(__value1);
            }
            else if (FileSearch is { } __value2)
            {
                fileSearch?.Invoke(__value2);
            }
            else if (WebSearch is { } __value3)
            {
                webSearch?.Invoke(__value3);
            }
            else if (WebSearchPreview is { } __value4)
            {
                webSearchPreview?.Invoke(__value4);
            }
            else if (ImageGeneration is { } __value5)
            {
                imageGeneration?.Invoke(__value5);
            }
            else if (Computer is { } __value6)
            {
                computer?.Invoke(__value6);
            }
            else if (CodeInterpreter is { } __value7)
            {
                codeInterpreter?.Invoke(__value7);
            }
            else if (ProgrammaticToolCalling is { } __value8)
            {
                programmaticToolCalling?.Invoke(__value8);
            }
            else if (Shell is { } __value9)
            {
                shell?.Invoke(__value9);
            }
            else if (Custom is { } __value10)
            {
                custom?.Invoke(__value10);
            }
            else if (ApplyPatch is { } __value11)
            {
                applyPatch?.Invoke(__value11);
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
                typeof(global::tryAGI.OpenAI.LiveFunctionToolChoiceParam),
                Mcp,
                typeof(global::tryAGI.OpenAI.LiveMCPToolChoiceParam),
                FileSearch,
                typeof(global::tryAGI.OpenAI.LiveSpecificFileSearchParam),
                WebSearch,
                typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchParam),
                WebSearchPreview,
                typeof(global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam),
                ImageGeneration,
                typeof(global::tryAGI.OpenAI.LiveSpecificImageGenParam),
                Computer,
                typeof(global::tryAGI.OpenAI.LiveSpecificComputerParam),
                CodeInterpreter,
                typeof(global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam),
                ProgrammaticToolCalling,
                typeof(global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam),
                Shell,
                typeof(global::tryAGI.OpenAI.LiveSpecificFunctionShellParam),
                Custom,
                typeof(global::tryAGI.OpenAI.LiveSpecificCustomToolParam),
                ApplyPatch,
                typeof(global::tryAGI.OpenAI.LiveSpecificApplyPatchParam),
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
        public bool Equals(ToolChoiceVariant22 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveFunctionToolChoiceParam?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveMCPToolChoiceParam?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSpecificFileSearchParam?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSpecificWebSearchParam?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSpecificWebSearchPreviewParam?>.Default.Equals(WebSearchPreview, other.WebSearchPreview) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSpecificImageGenParam?>.Default.Equals(ImageGeneration, other.ImageGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSpecificComputerParam?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSpecificCodeInterpreterParam?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSpecificProgrammaticToolCallingParam?>.Default.Equals(ProgrammaticToolCalling, other.ProgrammaticToolCalling) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSpecificFunctionShellParam?>.Default.Equals(Shell, other.Shell) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSpecificCustomToolParam?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSpecificApplyPatchParam?>.Default.Equals(ApplyPatch, other.ApplyPatch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolChoiceVariant22 obj1, ToolChoiceVariant22 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChoiceVariant22>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolChoiceVariant22 obj1, ToolChoiceVariant22 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChoiceVariant22 o && Equals(o);
        }
    }
}
