#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// How the model should select which tool (or tools) to use when generating<br/>
    /// a response. See the `tools` parameter to see how to specify which tools<br/>
    /// the model can call.
    /// </summary>
    public readonly partial struct ToolChoiceParam : global::System.IEquatable<ToolChoiceParam>
    {
        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or<br/>
        /// more tools.<br/>
        /// `required` means the model must call one or more tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceOptions? ToolChoiceMode { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceOptions? ToolChoiceMode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolChoiceMode))]
#endif
        public bool IsToolChoiceMode => ToolChoiceMode != null;

        /// <summary>
        /// Constrains the tools available to the model to a pre-defined set.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceAllowed? AllowedTools { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceAllowed? AllowedTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AllowedTools))]
#endif
        public bool IsAllowedTools => AllowedTools != null;

        /// <summary>
        /// Indicates that the model should use a built-in tool to generate a response.<br/>
        /// [Learn more about built-in tools](/docs/guides/tools).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceTypes? HostedTool { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceTypes? HostedTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HostedTool))]
#endif
        public bool IsHostedTool => HostedTool != null;

        /// <summary>
        /// Use this option to force the model to call a specific function.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceFunction? FunctionTool { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceFunction? FunctionTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionTool))]
#endif
        public bool IsFunctionTool => FunctionTool != null;

        /// <summary>
        /// Use this option to force the model to call a specific tool on a remote MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceMCP? McpTool { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceMCP? McpTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpTool))]
#endif
        public bool IsMcpTool => McpTool != null;

        /// <summary>
        /// Use this option to force the model to call a specific custom tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceCustom? CustomTool { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceCustom? CustomTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomTool))]
#endif
        public bool IsCustomTool => CustomTool != null;

        /// <summary>
        /// Forces the model to call the apply_patch tool when executing a tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SpecificApplyPatchParam? SpecificApplyPatchToolChoice { get; init; }
#else
        public global::tryAGI.OpenAI.SpecificApplyPatchParam? SpecificApplyPatchToolChoice { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpecificApplyPatchToolChoice))]
#endif
        public bool IsSpecificApplyPatchToolChoice => SpecificApplyPatchToolChoice != null;

        /// <summary>
        /// Forces the model to call the shell tool when a tool call is required.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SpecificFunctionShellParam? SpecificShellToolChoice { get; init; }
#else
        public global::tryAGI.OpenAI.SpecificFunctionShellParam? SpecificShellToolChoice { get; }
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
        public static implicit operator ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceOptions value) => new ToolChoiceParam((global::tryAGI.OpenAI.ToolChoiceOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceOptions?(ToolChoiceParam @this) => @this.ToolChoiceMode;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceOptions? value)
        {
            ToolChoiceMode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceAllowed value) => new ToolChoiceParam((global::tryAGI.OpenAI.ToolChoiceAllowed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceAllowed?(ToolChoiceParam @this) => @this.AllowedTools;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceAllowed? value)
        {
            AllowedTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceTypes value) => new ToolChoiceParam((global::tryAGI.OpenAI.ToolChoiceTypes?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceTypes?(ToolChoiceParam @this) => @this.HostedTool;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceTypes? value)
        {
            HostedTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceFunction value) => new ToolChoiceParam((global::tryAGI.OpenAI.ToolChoiceFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceFunction?(ToolChoiceParam @this) => @this.FunctionTool;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceFunction? value)
        {
            FunctionTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceMCP value) => new ToolChoiceParam((global::tryAGI.OpenAI.ToolChoiceMCP?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceMCP?(ToolChoiceParam @this) => @this.McpTool;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceMCP? value)
        {
            McpTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceCustom value) => new ToolChoiceParam((global::tryAGI.OpenAI.ToolChoiceCustom?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceCustom?(ToolChoiceParam @this) => @this.CustomTool;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceParam(global::tryAGI.OpenAI.ToolChoiceCustom? value)
        {
            CustomTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoiceParam(global::tryAGI.OpenAI.SpecificApplyPatchParam value) => new ToolChoiceParam((global::tryAGI.OpenAI.SpecificApplyPatchParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SpecificApplyPatchParam?(ToolChoiceParam @this) => @this.SpecificApplyPatchToolChoice;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceParam(global::tryAGI.OpenAI.SpecificApplyPatchParam? value)
        {
            SpecificApplyPatchToolChoice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoiceParam(global::tryAGI.OpenAI.SpecificFunctionShellParam value) => new ToolChoiceParam((global::tryAGI.OpenAI.SpecificFunctionShellParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SpecificFunctionShellParam?(ToolChoiceParam @this) => @this.SpecificShellToolChoice;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceParam(global::tryAGI.OpenAI.SpecificFunctionShellParam? value)
        {
            SpecificShellToolChoice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolChoiceParam(
            global::tryAGI.OpenAI.ToolChoiceOptions? toolChoiceMode,
            global::tryAGI.OpenAI.ToolChoiceAllowed? allowedTools,
            global::tryAGI.OpenAI.ToolChoiceTypes? hostedTool,
            global::tryAGI.OpenAI.ToolChoiceFunction? functionTool,
            global::tryAGI.OpenAI.ToolChoiceMCP? mcpTool,
            global::tryAGI.OpenAI.ToolChoiceCustom? customTool,
            global::tryAGI.OpenAI.SpecificApplyPatchParam? specificApplyPatchToolChoice,
            global::tryAGI.OpenAI.SpecificFunctionShellParam? specificShellToolChoice
            )
        {
            ToolChoiceMode = toolChoiceMode;
            AllowedTools = allowedTools;
            HostedTool = hostedTool;
            FunctionTool = functionTool;
            McpTool = mcpTool;
            CustomTool = customTool;
            SpecificApplyPatchToolChoice = specificApplyPatchToolChoice;
            SpecificShellToolChoice = specificShellToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SpecificShellToolChoice as object ??
            SpecificApplyPatchToolChoice as object ??
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
            SpecificApplyPatchToolChoice?.ToString() ??
            SpecificShellToolChoice?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && IsMcpTool && !IsCustomTool && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && IsCustomTool && !IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && IsSpecificApplyPatchToolChoice && !IsSpecificShellToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsHostedTool && !IsFunctionTool && !IsMcpTool && !IsCustomTool && !IsSpecificApplyPatchToolChoice && IsSpecificShellToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceOptions?, TResult>? toolChoiceMode = null,
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceAllowed?, TResult>? allowedTools = null,
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceTypes?, TResult>? hostedTool = null,
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceFunction?, TResult>? functionTool = null,
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceMCP?, TResult>? mcpTool = null,
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceCustom?, TResult>? customTool = null,
            global::System.Func<global::tryAGI.OpenAI.SpecificApplyPatchParam?, TResult>? specificApplyPatchToolChoice = null,
            global::System.Func<global::tryAGI.OpenAI.SpecificFunctionShellParam?, TResult>? specificShellToolChoice = null,
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
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceOptions?>? toolChoiceMode = null,
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceAllowed?>? allowedTools = null,
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceTypes?>? hostedTool = null,
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceFunction?>? functionTool = null,
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceMCP?>? mcpTool = null,
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceCustom?>? customTool = null,
            global::System.Action<global::tryAGI.OpenAI.SpecificApplyPatchParam?>? specificApplyPatchToolChoice = null,
            global::System.Action<global::tryAGI.OpenAI.SpecificFunctionShellParam?>? specificShellToolChoice = null,
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
                typeof(global::tryAGI.OpenAI.ToolChoiceOptions),
                AllowedTools,
                typeof(global::tryAGI.OpenAI.ToolChoiceAllowed),
                HostedTool,
                typeof(global::tryAGI.OpenAI.ToolChoiceTypes),
                FunctionTool,
                typeof(global::tryAGI.OpenAI.ToolChoiceFunction),
                McpTool,
                typeof(global::tryAGI.OpenAI.ToolChoiceMCP),
                CustomTool,
                typeof(global::tryAGI.OpenAI.ToolChoiceCustom),
                SpecificApplyPatchToolChoice,
                typeof(global::tryAGI.OpenAI.SpecificApplyPatchParam),
                SpecificShellToolChoice,
                typeof(global::tryAGI.OpenAI.SpecificFunctionShellParam),
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
        public bool Equals(ToolChoiceParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceOptions?>.Default.Equals(ToolChoiceMode, other.ToolChoiceMode) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceAllowed?>.Default.Equals(AllowedTools, other.AllowedTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceTypes?>.Default.Equals(HostedTool, other.HostedTool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceFunction?>.Default.Equals(FunctionTool, other.FunctionTool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceMCP?>.Default.Equals(McpTool, other.McpTool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceCustom?>.Default.Equals(CustomTool, other.CustomTool) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SpecificApplyPatchParam?>.Default.Equals(SpecificApplyPatchToolChoice, other.SpecificApplyPatchToolChoice) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SpecificFunctionShellParam?>.Default.Equals(SpecificShellToolChoice, other.SpecificShellToolChoice) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolChoiceParam obj1, ToolChoiceParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChoiceParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolChoiceParam obj1, ToolChoiceParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChoiceParam o && Equals(o);
        }
    }
}
