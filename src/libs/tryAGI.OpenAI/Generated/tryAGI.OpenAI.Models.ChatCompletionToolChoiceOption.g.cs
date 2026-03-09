#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.<br/>
    /// `none` means the model will not call any tool and instead generates a message.<br/>
    /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
    /// `required` means the model must call one or more tools.<br/>
    /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
    /// `none` is the default when no tools are present. `auto` is the default if tools are present.
    /// </summary>
    public readonly partial struct ChatCompletionToolChoiceOption : global::System.IEquatable<ChatCompletionToolChoiceOption>
    {
        /// <summary>
        /// `none` means the model will not call any tool and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? ToolChoiceMode { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? ToolChoiceMode { get; }
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
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? AllowedTools { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? AllowedTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AllowedTools))]
#endif
        public bool IsAllowedTools => AllowedTools != null;

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific function.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? FunctionToolChoice { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? FunctionToolChoice { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionToolChoice))]
#endif
        public bool IsFunctionToolChoice => FunctionToolChoice != null;

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific custom tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? CustomToolChoice { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? CustomToolChoice { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolChoice))]
#endif
        public bool IsCustomToolChoice => CustomToolChoice != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum value) => new ChatCompletionToolChoiceOption((global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?(ChatCompletionToolChoiceOption @this) => @this.ToolChoiceMode;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? value)
        {
            ToolChoiceMode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice value) => new ChatCompletionToolChoiceOption((global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?(ChatCompletionToolChoiceOption @this) => @this.AllowedTools;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? value)
        {
            AllowedTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice value) => new ChatCompletionToolChoiceOption((global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?(ChatCompletionToolChoiceOption @this) => @this.FunctionToolChoice;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? value)
        {
            FunctionToolChoice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom value) => new ChatCompletionToolChoiceOption((global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?(ChatCompletionToolChoiceOption @this) => @this.CustomToolChoice;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? value)
        {
            CustomToolChoice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(
            global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? toolChoiceMode,
            global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? allowedTools,
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? functionToolChoice,
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? customToolChoice
            )
        {
            ToolChoiceMode = toolChoiceMode;
            AllowedTools = allowedTools;
            FunctionToolChoice = functionToolChoice;
            CustomToolChoice = customToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomToolChoice as object ??
            FunctionToolChoice as object ??
            AllowedTools as object ??
            ToolChoiceMode as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolChoiceMode?.ToValueString() ??
            AllowedTools?.ToString() ??
            FunctionToolChoice?.ToString() ??
            CustomToolChoice?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolChoiceMode && !IsAllowedTools && !IsFunctionToolChoice && !IsCustomToolChoice || !IsToolChoiceMode && IsAllowedTools && !IsFunctionToolChoice && !IsCustomToolChoice || !IsToolChoiceMode && !IsAllowedTools && IsFunctionToolChoice && !IsCustomToolChoice || !IsToolChoiceMode && !IsAllowedTools && !IsFunctionToolChoice && IsCustomToolChoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?, TResult>? toolChoiceMode = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?, TResult>? allowedTools = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?, TResult>? functionToolChoice = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?, TResult>? customToolChoice = null,
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
            else if (IsFunctionToolChoice && functionToolChoice != null)
            {
                return functionToolChoice(FunctionToolChoice!);
            }
            else if (IsCustomToolChoice && customToolChoice != null)
            {
                return customToolChoice(CustomToolChoice!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?>? toolChoiceMode = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?>? allowedTools = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?>? functionToolChoice = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?>? customToolChoice = null,
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
            else if (IsFunctionToolChoice)
            {
                functionToolChoice?.Invoke(FunctionToolChoice!);
            }
            else if (IsCustomToolChoice)
            {
                customToolChoice?.Invoke(CustomToolChoice!);
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
                typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum),
                AllowedTools,
                typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice),
                FunctionToolChoice,
                typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice),
                CustomToolChoice,
                typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom),
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
        public bool Equals(ChatCompletionToolChoiceOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?>.Default.Equals(ToolChoiceMode, other.ToolChoiceMode) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?>.Default.Equals(AllowedTools, other.AllowedTools) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?>.Default.Equals(FunctionToolChoice, other.FunctionToolChoice) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?>.Default.Equals(CustomToolChoice, other.CustomToolChoice) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionToolChoiceOption obj1, ChatCompletionToolChoiceOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionToolChoiceOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionToolChoiceOption obj1, ChatCompletionToolChoiceOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionToolChoiceOption o && Equals(o);
        }
    }
}
