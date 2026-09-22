#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An input stub identifying an outstanding client-owned tool result or<br/>
    /// approval decision. Copy the stub and fill the result fields using the<br/>
    /// corresponding `response.create` input schema. Use saved results without<br/>
    /// rerunning the tool. The server does not supply results, approval decisions,<br/>
    /// or safety acknowledgements in these stubs.
    /// </summary>
    public readonly partial struct BetaResponseSteerRequiredInput : global::System.IEquatable<BetaResponseSteerRequiredInput>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType? Type { get; }

        /// <summary>
        /// Supply `output` using the function tool call output input schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? FunctionCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutput))]
#endif
        public bool IsFunctionCallOutput => FunctionCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput PickFunctionCallOutput() => IsFunctionCallOutput
            ? FunctionCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `output` using the custom tool call output input schema. The<br/>
        /// original custom tool call supplies the tool's name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? CustomToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? CustomToolCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutput))]
#endif
        public bool IsCustomToolCallOutput => CustomToolCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? value)
        {
            value = CustomToolCallOutput;
            return IsCustomToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput PickCustomToolCallOutput() => IsCustomToolCallOutput
            ? CustomToolCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `output` using the computer tool call output input schema,<br/>
        /// including any required `acknowledged_safety_checks`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? ComputerCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? ComputerCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCallOutput))]
#endif
        public bool IsComputerCallOutput => ComputerCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? value)
        {
            value = ComputerCallOutput;
            return IsComputerCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput PickComputerCallOutput() => IsComputerCallOutput
            ? ComputerCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `output` using the shell tool call output input schema. Each<br/>
        /// output entry includes `stdout`, `stderr`, and `outcome`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? ShellCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? ShellCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCallOutput))]
#endif
        public bool IsShellCallOutput => ShellCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShellCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? value)
        {
            value = ShellCallOutput;
            return IsShellCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput PickShellCallOutput() => IsShellCallOutput
            ? ShellCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `status` and optional `output` using the apply patch tool call<br/>
        /// output input schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? ApplyPatchCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? ApplyPatchCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOutput))]
#endif
        public bool IsApplyPatchCallOutput => ApplyPatchCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApplyPatchCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? value)
        {
            value = ApplyPatchCallOutput;
            return IsApplyPatchCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput PickApplyPatchCallOutput() => IsApplyPatchCallOutput
            ? ApplyPatchCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `tools` using the tool search output input schema, retaining<br/>
        /// `execution: "client"`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? ToolSearchOutput { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? ToolSearchOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchOutput))]
#endif
        public bool IsToolSearchOutput => ToolSearchOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolSearchOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? value)
        {
            value = ToolSearchOutput;
            return IsToolSearchOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput PickToolSearchOutput() => IsToolSearchOutput
            ? ToolSearchOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `approve` using the MCP approval response input schema. An<br/>
        /// optional `reason` can be supplied when denying the request. The original<br/>
        /// approval request identifies the tool and server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? McpApprovalResponse { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? McpApprovalResponse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalResponse))]
#endif
        public bool IsMcpApprovalResponse => McpApprovalResponse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpApprovalResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? value)
        {
            value = McpApprovalResponse;
            return IsMcpApprovalResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse PickMcpApprovalResponse() => IsMcpApprovalResponse
            ? McpApprovalResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpApprovalResponse' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput value) => new BetaResponseSteerRequiredInput((global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput?(BetaResponseSteerRequiredInput @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerRequiredInput FromFunctionCallOutput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? value) => new BetaResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput value) => new BetaResponseSteerRequiredInput((global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput?(BetaResponseSteerRequiredInput @this) => @this.CustomToolCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerRequiredInput FromCustomToolCallOutput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? value) => new BetaResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput value) => new BetaResponseSteerRequiredInput((global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput?(BetaResponseSteerRequiredInput @this) => @this.ComputerCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? value)
        {
            ComputerCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerRequiredInput FromComputerCallOutput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? value) => new BetaResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput value) => new BetaResponseSteerRequiredInput((global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput?(BetaResponseSteerRequiredInput @this) => @this.ShellCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerRequiredInput FromShellCallOutput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? value) => new BetaResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput value) => new BetaResponseSteerRequiredInput((global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput?(BetaResponseSteerRequiredInput @this) => @this.ApplyPatchCallOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? value)
        {
            ApplyPatchCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerRequiredInput FromApplyPatchCallOutput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? value) => new BetaResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput value) => new BetaResponseSteerRequiredInput((global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput?(BetaResponseSteerRequiredInput @this) => @this.ToolSearchOutput;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? value)
        {
            ToolSearchOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerRequiredInput FromToolSearchOutput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? value) => new BetaResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse value) => new BetaResponseSteerRequiredInput((global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse?(BetaResponseSteerRequiredInput @this) => @this.McpApprovalResponse;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerRequiredInput(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseSteerRequiredInput FromMcpApprovalResponse(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? value) => new BetaResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponseSteerRequiredInput(
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput? functionCallOutput,
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput? customToolCallOutput,
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput? computerCallOutput,
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput? shellCallOutput,
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? applyPatchCallOutput,
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput? toolSearchOutput,
            global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse? mcpApprovalResponse
            )
        {
            Type = type;

            FunctionCallOutput = functionCallOutput;
            CustomToolCallOutput = customToolCallOutput;
            ComputerCallOutput = computerCallOutput;
            ShellCallOutput = shellCallOutput;
            ApplyPatchCallOutput = applyPatchCallOutput;
            ToolSearchOutput = toolSearchOutput;
            McpApprovalResponse = mcpApprovalResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            McpApprovalResponse as object ??
            ToolSearchOutput as object ??
            ApplyPatchCallOutput as object ??
            ShellCallOutput as object ??
            ComputerCallOutput as object ??
            CustomToolCallOutput as object ??
            FunctionCallOutput as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            FunctionCallOutput?.ToString() ??
            CustomToolCallOutput?.ToString() ??
            ComputerCallOutput?.ToString() ??
            ShellCallOutput?.ToString() ??
            ApplyPatchCallOutput?.ToString() ??
            ToolSearchOutput?.ToString() ??
            McpApprovalResponse?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunctionCallOutput && !IsCustomToolCallOutput && !IsComputerCallOutput && !IsShellCallOutput && !IsApplyPatchCallOutput && !IsToolSearchOutput && !IsMcpApprovalResponse || !IsFunctionCallOutput && IsCustomToolCallOutput && !IsComputerCallOutput && !IsShellCallOutput && !IsApplyPatchCallOutput && !IsToolSearchOutput && !IsMcpApprovalResponse || !IsFunctionCallOutput && !IsCustomToolCallOutput && IsComputerCallOutput && !IsShellCallOutput && !IsApplyPatchCallOutput && !IsToolSearchOutput && !IsMcpApprovalResponse || !IsFunctionCallOutput && !IsCustomToolCallOutput && !IsComputerCallOutput && IsShellCallOutput && !IsApplyPatchCallOutput && !IsToolSearchOutput && !IsMcpApprovalResponse || !IsFunctionCallOutput && !IsCustomToolCallOutput && !IsComputerCallOutput && !IsShellCallOutput && IsApplyPatchCallOutput && !IsToolSearchOutput && !IsMcpApprovalResponse || !IsFunctionCallOutput && !IsCustomToolCallOutput && !IsComputerCallOutput && !IsShellCallOutput && !IsApplyPatchCallOutput && IsToolSearchOutput && !IsMcpApprovalResponse || !IsFunctionCallOutput && !IsCustomToolCallOutput && !IsComputerCallOutput && !IsShellCallOutput && !IsApplyPatchCallOutput && !IsToolSearchOutput && IsMcpApprovalResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput, TResult>? customToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput, TResult>? computerCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput, TResult>? shellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput, TResult>? applyPatchCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput, TResult>? toolSearchOutput = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse, TResult>? mcpApprovalResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutput && functionCallOutput != null)
            {
                return functionCallOutput(FunctionCallOutput!);
            }
            else if (IsCustomToolCallOutput && customToolCallOutput != null)
            {
                return customToolCallOutput(CustomToolCallOutput!);
            }
            else if (IsComputerCallOutput && computerCallOutput != null)
            {
                return computerCallOutput(ComputerCallOutput!);
            }
            else if (IsShellCallOutput && shellCallOutput != null)
            {
                return shellCallOutput(ShellCallOutput!);
            }
            else if (IsApplyPatchCallOutput && applyPatchCallOutput != null)
            {
                return applyPatchCallOutput(ApplyPatchCallOutput!);
            }
            else if (IsToolSearchOutput && toolSearchOutput != null)
            {
                return toolSearchOutput(ToolSearchOutput!);
            }
            else if (IsMcpApprovalResponse && mcpApprovalResponse != null)
            {
                return mcpApprovalResponse(McpApprovalResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput>? functionCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput>? customToolCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput>? computerCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput>? shellCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput>? applyPatchCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput>? toolSearchOutput = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse>? mcpApprovalResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsCustomToolCallOutput)
            {
                customToolCallOutput?.Invoke(CustomToolCallOutput!);
            }
            else if (IsComputerCallOutput)
            {
                computerCallOutput?.Invoke(ComputerCallOutput!);
            }
            else if (IsShellCallOutput)
            {
                shellCallOutput?.Invoke(ShellCallOutput!);
            }
            else if (IsApplyPatchCallOutput)
            {
                applyPatchCallOutput?.Invoke(ApplyPatchCallOutput!);
            }
            else if (IsToolSearchOutput)
            {
                toolSearchOutput?.Invoke(ToolSearchOutput!);
            }
            else if (IsMcpApprovalResponse)
            {
                mcpApprovalResponse?.Invoke(McpApprovalResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput>? customToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput>? computerCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput>? shellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput>? applyPatchCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput>? toolSearchOutput = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse>? mcpApprovalResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutput)
            {
                functionCallOutput?.Invoke(FunctionCallOutput!);
            }
            else if (IsCustomToolCallOutput)
            {
                customToolCallOutput?.Invoke(CustomToolCallOutput!);
            }
            else if (IsComputerCallOutput)
            {
                computerCallOutput?.Invoke(ComputerCallOutput!);
            }
            else if (IsShellCallOutput)
            {
                shellCallOutput?.Invoke(ShellCallOutput!);
            }
            else if (IsApplyPatchCallOutput)
            {
                applyPatchCallOutput?.Invoke(ApplyPatchCallOutput!);
            }
            else if (IsToolSearchOutput)
            {
                toolSearchOutput?.Invoke(ToolSearchOutput!);
            }
            else if (IsMcpApprovalResponse)
            {
                mcpApprovalResponse?.Invoke(McpApprovalResponse!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FunctionCallOutput,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput),
                CustomToolCallOutput,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput),
                ComputerCallOutput,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput),
                ShellCallOutput,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput),
                ApplyPatchCallOutput,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput),
                ToolSearchOutput,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput),
                McpApprovalResponse,
                typeof(global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse),
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
        public bool Equals(BetaResponseSteerRequiredInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredFunctionToolCallOutput?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredCustomToolCallOutput?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredComputerToolCallOutput?>.Default.Equals(ComputerCallOutput, other.ComputerCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredShellToolCallOutput?>.Default.Equals(ShellCallOutput, other.ShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredApplyPatchToolCallOutput?>.Default.Equals(ApplyPatchCallOutput, other.ApplyPatchCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredToolSearchOutput?>.Default.Equals(ToolSearchOutput, other.ToolSearchOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseSteerRequiredInputRequiredMcpApprovalResponse?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponseSteerRequiredInput obj1, BetaResponseSteerRequiredInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponseSteerRequiredInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponseSteerRequiredInput obj1, BetaResponseSteerRequiredInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponseSteerRequiredInput o && Equals(o);
        }
    }
}
