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
    public readonly partial struct ResponseSteerRequiredInput : global::System.IEquatable<ResponseSteerRequiredInput>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType? Type { get; }

        /// <summary>
        /// Supply `output` using the function tool call output input schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? FunctionCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? FunctionCallOutput { get; }
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
            out global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? value)
        {
            value = FunctionCallOutput;
            return IsFunctionCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput PickFunctionCallOutput() => IsFunctionCallOutput
            ? FunctionCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `output` using the custom tool call output input schema. The<br/>
        /// original custom tool call supplies the tool's name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? CustomToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? CustomToolCallOutput { get; }
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
            out global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? value)
        {
            value = CustomToolCallOutput;
            return IsCustomToolCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput PickCustomToolCallOutput() => IsCustomToolCallOutput
            ? CustomToolCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `output` using the computer tool call output input schema,<br/>
        /// including any required `acknowledged_safety_checks`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? ComputerCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? ComputerCallOutput { get; }
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
            out global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? value)
        {
            value = ComputerCallOutput;
            return IsComputerCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput PickComputerCallOutput() => IsComputerCallOutput
            ? ComputerCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `output` using the shell tool call output input schema. Each<br/>
        /// output entry includes `stdout`, `stderr`, and `outcome`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? ShellCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? ShellCallOutput { get; }
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
            out global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? value)
        {
            value = ShellCallOutput;
            return IsShellCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput PickShellCallOutput() => IsShellCallOutput
            ? ShellCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `status` and optional `output` using the apply patch tool call<br/>
        /// output input schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? ApplyPatchCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? ApplyPatchCallOutput { get; }
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
            out global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? value)
        {
            value = ApplyPatchCallOutput;
            return IsApplyPatchCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput PickApplyPatchCallOutput() => IsApplyPatchCallOutput
            ? ApplyPatchCallOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `tools` using the tool search output input schema, retaining<br/>
        /// `execution: "client"`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? ToolSearchOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? ToolSearchOutput { get; }
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
            out global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? value)
        {
            value = ToolSearchOutput;
            return IsToolSearchOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput PickToolSearchOutput() => IsToolSearchOutput
            ? ToolSearchOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchOutput' but the value was {ToString()}.");

        /// <summary>
        /// Supply `approve` using the MCP approval response input schema. An<br/>
        /// optional `reason` can be supplied when denying the request. The original<br/>
        /// approval request identifies the tool and server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? McpApprovalResponse { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? McpApprovalResponse { get; }
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
            out global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? value)
        {
            value = McpApprovalResponse;
            return IsMcpApprovalResponse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse PickMcpApprovalResponse() => IsMcpApprovalResponse
            ? McpApprovalResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpApprovalResponse' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput value) => new ResponseSteerRequiredInput((global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput?(ResponseSteerRequiredInput @this) => @this.FunctionCallOutput;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? value)
        {
            FunctionCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerRequiredInput FromFunctionCallOutput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? value) => new ResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput value) => new ResponseSteerRequiredInput((global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput?(ResponseSteerRequiredInput @this) => @this.CustomToolCallOutput;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? value)
        {
            CustomToolCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerRequiredInput FromCustomToolCallOutput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? value) => new ResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput value) => new ResponseSteerRequiredInput((global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput?(ResponseSteerRequiredInput @this) => @this.ComputerCallOutput;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? value)
        {
            ComputerCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerRequiredInput FromComputerCallOutput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? value) => new ResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput value) => new ResponseSteerRequiredInput((global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput?(ResponseSteerRequiredInput @this) => @this.ShellCallOutput;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerRequiredInput FromShellCallOutput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? value) => new ResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput value) => new ResponseSteerRequiredInput((global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput?(ResponseSteerRequiredInput @this) => @this.ApplyPatchCallOutput;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? value)
        {
            ApplyPatchCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerRequiredInput FromApplyPatchCallOutput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? value) => new ResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput value) => new ResponseSteerRequiredInput((global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput?(ResponseSteerRequiredInput @this) => @this.ToolSearchOutput;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? value)
        {
            ToolSearchOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerRequiredInput FromToolSearchOutput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? value) => new ResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse value) => new ResponseSteerRequiredInput((global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse?(ResponseSteerRequiredInput @this) => @this.McpApprovalResponse;

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerRequiredInput(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? value)
        {
            McpApprovalResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseSteerRequiredInput FromMcpApprovalResponse(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? value) => new ResponseSteerRequiredInput(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseSteerRequiredInput(
            global::tryAGI.OpenAI.ResponseSteerRequiredInputDiscriminatorType? type,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput? functionCallOutput,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput? customToolCallOutput,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput? computerCallOutput,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput? shellCallOutput,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput? applyPatchCallOutput,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput? toolSearchOutput,
            global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse? mcpApprovalResponse
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
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput, TResult>? functionCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput, TResult>? customToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput, TResult>? computerCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput, TResult>? shellCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput, TResult>? applyPatchCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput, TResult>? toolSearchOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse, TResult>? mcpApprovalResponse = null,
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
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput>? functionCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput>? customToolCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput>? computerCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput>? shellCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput>? applyPatchCallOutput = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput>? toolSearchOutput = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse>? mcpApprovalResponse = null,
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
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput>? functionCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput>? customToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput>? computerCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput>? shellCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput>? applyPatchCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput>? toolSearchOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse>? mcpApprovalResponse = null,
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
                typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput),
                CustomToolCallOutput,
                typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput),
                ComputerCallOutput,
                typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput),
                ShellCallOutput,
                typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput),
                ApplyPatchCallOutput,
                typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput),
                ToolSearchOutput,
                typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput),
                McpApprovalResponse,
                typeof(global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse),
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
        public bool Equals(ResponseSteerRequiredInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredFunctionToolCallOutput?>.Default.Equals(FunctionCallOutput, other.FunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredCustomToolCallOutput?>.Default.Equals(CustomToolCallOutput, other.CustomToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredComputerToolCallOutput?>.Default.Equals(ComputerCallOutput, other.ComputerCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredShellToolCallOutput?>.Default.Equals(ShellCallOutput, other.ShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredApplyPatchToolCallOutput?>.Default.Equals(ApplyPatchCallOutput, other.ApplyPatchCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredToolSearchOutput?>.Default.Equals(ToolSearchOutput, other.ToolSearchOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerRequiredInputRequiredMcpApprovalResponse?>.Default.Equals(McpApprovalResponse, other.McpApprovalResponse)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseSteerRequiredInput obj1, ResponseSteerRequiredInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseSteerRequiredInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseSteerRequiredInput obj1, ResponseSteerRequiredInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseSteerRequiredInput o && Equals(o);
        }
    }
}
