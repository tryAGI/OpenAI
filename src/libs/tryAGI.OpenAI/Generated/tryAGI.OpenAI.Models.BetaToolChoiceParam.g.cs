#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// How the model should select which tool (or tools) to use when generating<br/>
    /// a response. See the `tools` parameter to see how to specify which tools<br/>
    /// the model can call.
    /// </summary>
    public readonly partial struct BetaToolChoiceParam : global::System.IEquatable<BetaToolChoiceParam>
    {
        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or<br/>
        /// more tools.<br/>
        /// `required` means the model must call one or more tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolChoiceOptions? ToolChoiceMode { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolChoiceOptions? ToolChoiceMode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolChoiceMode))]
#endif
        public bool IsToolChoiceMode => ToolChoiceMode != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolChoiceMode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaToolChoiceOptions? value)
        {
            value = ToolChoiceMode;
            return IsToolChoiceMode;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceOptions PickToolChoiceMode() => IsToolChoiceMode
            ? ToolChoiceMode!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolChoiceMode' but the value was {ToString()}.");

        /// <summary>
        /// Constrains the tools available to the model to a pre-defined set.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolChoiceAllowed? AllowedTools { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolChoiceAllowed? AllowedTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AllowedTools))]
#endif
        public bool IsAllowedTools => AllowedTools != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAllowedTools(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaToolChoiceAllowed? value)
        {
            value = AllowedTools;
            return IsAllowedTools;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceAllowed PickAllowedTools() => IsAllowedTools
            ? AllowedTools!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AllowedTools' but the value was {ToString()}.");

        /// <summary>
        /// Indicates that the model should use a built-in tool to generate a response.<br/>
        /// [Learn more about built-in tools](/docs/guides/tools).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolChoiceTypes? HostedTool { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolChoiceTypes? HostedTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HostedTool))]
#endif
        public bool IsHostedTool => HostedTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHostedTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaToolChoiceTypes? value)
        {
            value = HostedTool;
            return IsHostedTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceTypes PickHostedTool() => IsHostedTool
            ? HostedTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'HostedTool' but the value was {ToString()}.");

        /// <summary>
        /// Use this option to force the model to call a specific function.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolChoiceFunction? FunctionTool { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolChoiceFunction? FunctionTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionTool))]
#endif
        public bool IsFunctionTool => FunctionTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunctionTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaToolChoiceFunction? value)
        {
            value = FunctionTool;
            return IsFunctionTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceFunction PickFunctionTool() => IsFunctionTool
            ? FunctionTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionTool' but the value was {ToString()}.");

        /// <summary>
        /// Use this option to force the model to call a specific tool on a remote MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolChoiceMCP? McpTool { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolChoiceMCP? McpTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpTool))]
#endif
        public bool IsMcpTool => McpTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcpTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaToolChoiceMCP? value)
        {
            value = McpTool;
            return IsMcpTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceMCP PickMcpTool() => IsMcpTool
            ? McpTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpTool' but the value was {ToString()}.");

        /// <summary>
        /// Use this option to force the model to call a specific custom tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaToolChoiceCustom? CustomTool { get; init; }
#else
        public global::tryAGI.OpenAI.BetaToolChoiceCustom? CustomTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomTool))]
#endif
        public bool IsCustomTool => CustomTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustomTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaToolChoiceCustom? value)
        {
            value = CustomTool;
            return IsCustomTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolChoiceCustom PickCustomTool() => IsCustomTool
            ? CustomTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomTool' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? SpecificProgrammaticCalling { get; init; }
#else
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? SpecificProgrammaticCalling { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpecificProgrammaticCalling))]
#endif
        public bool IsSpecificProgrammaticCalling => SpecificProgrammaticCalling != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpecificProgrammaticCalling(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? value)
        {
            value = SpecificProgrammaticCalling;
            return IsSpecificProgrammaticCalling;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam PickSpecificProgrammaticCalling() => IsSpecificProgrammaticCalling
            ? SpecificProgrammaticCalling!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpecificProgrammaticCalling' but the value was {ToString()}.");

        /// <summary>
        /// Forces the model to call the apply_patch tool when executing a tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? SpecificApplyPatchToolChoice { get; init; }
#else
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? SpecificApplyPatchToolChoice { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpecificApplyPatchToolChoice))]
#endif
        public bool IsSpecificApplyPatchToolChoice => SpecificApplyPatchToolChoice != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpecificApplyPatchToolChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? value)
        {
            value = SpecificApplyPatchToolChoice;
            return IsSpecificApplyPatchToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificApplyPatchParam PickSpecificApplyPatchToolChoice() => IsSpecificApplyPatchToolChoice
            ? SpecificApplyPatchToolChoice!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpecificApplyPatchToolChoice' but the value was {ToString()}.");

        /// <summary>
        /// Forces the model to call the shell tool when a tool call is required.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? SpecificShellToolChoice { get; init; }
#else
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? SpecificShellToolChoice { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpecificShellToolChoice))]
#endif
        public bool IsSpecificShellToolChoice => SpecificShellToolChoice != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpecificShellToolChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? value)
        {
            value = SpecificShellToolChoice;
            return IsSpecificShellToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaSpecificFunctionShellParam PickSpecificShellToolChoice() => IsSpecificShellToolChoice
            ? SpecificShellToolChoice!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpecificShellToolChoice' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceOptions value) => new BetaToolChoiceParam((global::tryAGI.OpenAI.BetaToolChoiceOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolChoiceOptions?(BetaToolChoiceParam @this) => @this.ToolChoiceMode;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceOptions? value)
        {
            ToolChoiceMode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaToolChoiceParam FromToolChoiceMode(global::tryAGI.OpenAI.BetaToolChoiceOptions? value) => new BetaToolChoiceParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceAllowed value) => new BetaToolChoiceParam((global::tryAGI.OpenAI.BetaToolChoiceAllowed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolChoiceAllowed?(BetaToolChoiceParam @this) => @this.AllowedTools;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceAllowed? value)
        {
            AllowedTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaToolChoiceParam FromAllowedTools(global::tryAGI.OpenAI.BetaToolChoiceAllowed? value) => new BetaToolChoiceParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceTypes value) => new BetaToolChoiceParam((global::tryAGI.OpenAI.BetaToolChoiceTypes?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolChoiceTypes?(BetaToolChoiceParam @this) => @this.HostedTool;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceTypes? value)
        {
            HostedTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaToolChoiceParam FromHostedTool(global::tryAGI.OpenAI.BetaToolChoiceTypes? value) => new BetaToolChoiceParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceFunction value) => new BetaToolChoiceParam((global::tryAGI.OpenAI.BetaToolChoiceFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolChoiceFunction?(BetaToolChoiceParam @this) => @this.FunctionTool;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceFunction? value)
        {
            FunctionTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaToolChoiceParam FromFunctionTool(global::tryAGI.OpenAI.BetaToolChoiceFunction? value) => new BetaToolChoiceParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceMCP value) => new BetaToolChoiceParam((global::tryAGI.OpenAI.BetaToolChoiceMCP?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolChoiceMCP?(BetaToolChoiceParam @this) => @this.McpTool;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceMCP? value)
        {
            McpTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaToolChoiceParam FromMcpTool(global::tryAGI.OpenAI.BetaToolChoiceMCP? value) => new BetaToolChoiceParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceCustom value) => new BetaToolChoiceParam((global::tryAGI.OpenAI.BetaToolChoiceCustom?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaToolChoiceCustom?(BetaToolChoiceParam @this) => @this.CustomTool;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoiceParam(global::tryAGI.OpenAI.BetaToolChoiceCustom? value)
        {
            CustomTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaToolChoiceParam FromCustomTool(global::tryAGI.OpenAI.BetaToolChoiceCustom? value) => new BetaToolChoiceParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaToolChoiceParam(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam value) => new BetaToolChoiceParam((global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam?(BetaToolChoiceParam @this) => @this.SpecificProgrammaticCalling;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoiceParam(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? value)
        {
            SpecificProgrammaticCalling = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaToolChoiceParam FromSpecificProgrammaticCalling(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? value) => new BetaToolChoiceParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaToolChoiceParam(global::tryAGI.OpenAI.BetaSpecificApplyPatchParam value) => new BetaToolChoiceParam((global::tryAGI.OpenAI.BetaSpecificApplyPatchParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaSpecificApplyPatchParam?(BetaToolChoiceParam @this) => @this.SpecificApplyPatchToolChoice;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoiceParam(global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? value)
        {
            SpecificApplyPatchToolChoice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaToolChoiceParam FromSpecificApplyPatchToolChoice(global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? value) => new BetaToolChoiceParam(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaToolChoiceParam(global::tryAGI.OpenAI.BetaSpecificFunctionShellParam value) => new BetaToolChoiceParam((global::tryAGI.OpenAI.BetaSpecificFunctionShellParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaSpecificFunctionShellParam?(BetaToolChoiceParam @this) => @this.SpecificShellToolChoice;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoiceParam(global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? value)
        {
            SpecificShellToolChoice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaToolChoiceParam FromSpecificShellToolChoice(global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? value) => new BetaToolChoiceParam(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoiceParam(
            global::tryAGI.OpenAI.BetaToolChoiceOptions? toolChoiceMode,
            global::tryAGI.OpenAI.BetaToolChoiceAllowed? allowedTools,
            global::tryAGI.OpenAI.BetaToolChoiceTypes? hostedTool,
            global::tryAGI.OpenAI.BetaToolChoiceFunction? functionTool,
            global::tryAGI.OpenAI.BetaToolChoiceMCP? mcpTool,
            global::tryAGI.OpenAI.BetaToolChoiceCustom? customTool,
            global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam? specificProgrammaticCalling,
            global::tryAGI.OpenAI.BetaSpecificApplyPatchParam? specificApplyPatchToolChoice,
            global::tryAGI.OpenAI.BetaSpecificFunctionShellParam? specificShellToolChoice
            )
        {
            ToolChoiceMode = toolChoiceMode;
            AllowedTools = allowedTools;
            HostedTool = hostedTool;
            FunctionTool = functionTool;
            McpTool = mcpTool;
            CustomTool = customTool;
            SpecificProgrammaticCalling = specificProgrammaticCalling;
            SpecificApplyPatchToolChoice = specificApplyPatchToolChoice;
            SpecificShellToolChoice = specificShellToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SpecificShellToolChoice as object ??
            SpecificApplyPatchToolChoice as object ??
            SpecificProgrammaticCalling as object ??
            CustomTool as object ??
            McpTool as object ??
            FunctionTool as object ??
            HostedTool as object ??
            AllowedTools as object ??
            ToolChoiceMode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolChoiceMode?.ToValueString() ??
            AllowedTools?.ToString() ??
            HostedTool?.ToString() ??
            FunctionTool?.ToString() ??
            McpTool?.ToString() ??
            CustomTool?.ToString() ??
            SpecificProgrammaticCalling?.ToString() ??
            SpecificApplyPatchToolChoice?.ToString() ??
            SpecificShellToolChoice?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificProgrammaticCalling && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificProgrammaticCalling && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificProgrammaticCalling && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificProgrammaticCalling && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && IsMcpTool && !IsCustomTool && !IsSpecificProgrammaticCalling && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && IsCustomTool && !IsSpecificProgrammaticCalling && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && IsSpecificProgrammaticCalling && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificProgrammaticCalling && IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificProgrammaticCalling && !IsSpecificApplyPatchToolChoice && IsSpecificShellToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaToolChoiceOptions?, TResult>? toolChoiceMode = null,
            global::System.Func<global::tryAGI.OpenAI.BetaToolChoiceAllowed, TResult>? allowedTools = null,
            global::System.Func<global::tryAGI.OpenAI.BetaToolChoiceTypes, TResult>? hostedTool = null,
            global::System.Func<global::tryAGI.OpenAI.BetaToolChoiceFunction, TResult>? functionTool = null,
            global::System.Func<global::tryAGI.OpenAI.BetaToolChoiceMCP, TResult>? mcpTool = null,
            global::System.Func<global::tryAGI.OpenAI.BetaToolChoiceCustom, TResult>? customTool = null,
            global::System.Func<global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam, TResult>? specificProgrammaticCalling = null,
            global::System.Func<global::tryAGI.OpenAI.BetaSpecificApplyPatchParam, TResult>? specificApplyPatchToolChoice = null,
            global::System.Func<global::tryAGI.OpenAI.BetaSpecificFunctionShellParam, TResult>? specificShellToolChoice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolChoiceMode && toolChoiceMode != null)
            {
                return toolChoiceMode(ToolChoiceMode!);
            }
            else if (IsAllowedTools && allowedTools != null)
            {
                return allowedTools(AllowedTools!);
            }
            else if (IsHostedTool && hostedTool != null)
            {
                return hostedTool(HostedTool!);
            }
            else if (IsFunctionTool && functionTool != null)
            {
                return functionTool(FunctionTool!);
            }
            else if (IsMcpTool && mcpTool != null)
            {
                return mcpTool(McpTool!);
            }
            else if (IsCustomTool && customTool != null)
            {
                return customTool(CustomTool!);
            }
            else if (IsSpecificProgrammaticCalling && specificProgrammaticCalling != null)
            {
                return specificProgrammaticCalling(SpecificProgrammaticCalling!);
            }
            else if (IsSpecificApplyPatchToolChoice && specificApplyPatchToolChoice != null)
            {
                return specificApplyPatchToolChoice(SpecificApplyPatchToolChoice!);
            }
            else if (IsSpecificShellToolChoice && specificShellToolChoice != null)
            {
                return specificShellToolChoice(SpecificShellToolChoice!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceOptions?>? toolChoiceMode = null,

            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceAllowed>? allowedTools = null,

            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceTypes>? hostedTool = null,

            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceFunction>? functionTool = null,

            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceMCP>? mcpTool = null,

            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceCustom>? customTool = null,

            global::System.Action<global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam>? specificProgrammaticCalling = null,

            global::System.Action<global::tryAGI.OpenAI.BetaSpecificApplyPatchParam>? specificApplyPatchToolChoice = null,

            global::System.Action<global::tryAGI.OpenAI.BetaSpecificFunctionShellParam>? specificShellToolChoice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolChoiceMode)
            {
                toolChoiceMode?.Invoke(ToolChoiceMode!);
            }
            else if (IsAllowedTools)
            {
                allowedTools?.Invoke(AllowedTools!);
            }
            else if (IsHostedTool)
            {
                hostedTool?.Invoke(HostedTool!);
            }
            else if (IsFunctionTool)
            {
                functionTool?.Invoke(FunctionTool!);
            }
            else if (IsMcpTool)
            {
                mcpTool?.Invoke(McpTool!);
            }
            else if (IsCustomTool)
            {
                customTool?.Invoke(CustomTool!);
            }
            else if (IsSpecificProgrammaticCalling)
            {
                specificProgrammaticCalling?.Invoke(SpecificProgrammaticCalling!);
            }
            else if (IsSpecificApplyPatchToolChoice)
            {
                specificApplyPatchToolChoice?.Invoke(SpecificApplyPatchToolChoice!);
            }
            else if (IsSpecificShellToolChoice)
            {
                specificShellToolChoice?.Invoke(SpecificShellToolChoice!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceOptions?>? toolChoiceMode = null,
            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceAllowed>? allowedTools = null,
            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceTypes>? hostedTool = null,
            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceFunction>? functionTool = null,
            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceMCP>? mcpTool = null,
            global::System.Action<global::tryAGI.OpenAI.BetaToolChoiceCustom>? customTool = null,
            global::System.Action<global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam>? specificProgrammaticCalling = null,
            global::System.Action<global::tryAGI.OpenAI.BetaSpecificApplyPatchParam>? specificApplyPatchToolChoice = null,
            global::System.Action<global::tryAGI.OpenAI.BetaSpecificFunctionShellParam>? specificShellToolChoice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolChoiceMode)
            {
                toolChoiceMode?.Invoke(ToolChoiceMode!);
            }
            else if (IsAllowedTools)
            {
                allowedTools?.Invoke(AllowedTools!);
            }
            else if (IsHostedTool)
            {
                hostedTool?.Invoke(HostedTool!);
            }
            else if (IsFunctionTool)
            {
                functionTool?.Invoke(FunctionTool!);
            }
            else if (IsMcpTool)
            {
                mcpTool?.Invoke(McpTool!);
            }
            else if (IsCustomTool)
            {
                customTool?.Invoke(CustomTool!);
            }
            else if (IsSpecificProgrammaticCalling)
            {
                specificProgrammaticCalling?.Invoke(SpecificProgrammaticCalling!);
            }
            else if (IsSpecificApplyPatchToolChoice)
            {
                specificApplyPatchToolChoice?.Invoke(SpecificApplyPatchToolChoice!);
            }
            else if (IsSpecificShellToolChoice)
            {
                specificShellToolChoice?.Invoke(SpecificShellToolChoice!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolChoiceMode,
                typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions),
                AllowedTools,
                typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowed),
                HostedTool,
                typeof(global::tryAGI.OpenAI.BetaToolChoiceTypes),
                FunctionTool,
                typeof(global::tryAGI.OpenAI.BetaToolChoiceFunction),
                McpTool,
                typeof(global::tryAGI.OpenAI.BetaToolChoiceMCP),
                CustomTool,
                typeof(global::tryAGI.OpenAI.BetaToolChoiceCustom),
                SpecificProgrammaticCalling,
                typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam),
                SpecificApplyPatchToolChoice,
                typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParam),
                SpecificShellToolChoice,
                typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParam),
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
        public bool Equals(BetaToolChoiceParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolChoiceOptions?>.Default.Equals(ToolChoiceMode, other.ToolChoiceMode) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolChoiceAllowed?>.Default.Equals(AllowedTools, other.AllowedTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolChoiceTypes?>.Default.Equals(HostedTool, other.HostedTool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolChoiceFunction?>.Default.Equals(FunctionTool, other.FunctionTool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolChoiceMCP?>.Default.Equals(McpTool, other.McpTool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaToolChoiceCustom?>.Default.Equals(CustomTool, other.CustomTool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam?>.Default.Equals(SpecificProgrammaticCalling, other.SpecificProgrammaticCalling) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaSpecificApplyPatchParam?>.Default.Equals(SpecificApplyPatchToolChoice, other.SpecificApplyPatchToolChoice) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaSpecificFunctionShellParam?>.Default.Equals(SpecificShellToolChoice, other.SpecificShellToolChoice) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaToolChoiceParam obj1, BetaToolChoiceParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaToolChoiceParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaToolChoiceParam obj1, BetaToolChoiceParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaToolChoiceParam o && Equals(o);
        }
    }
}
