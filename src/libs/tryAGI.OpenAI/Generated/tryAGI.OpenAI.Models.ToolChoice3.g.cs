#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// How the model should select which tool (or tools) to use when generating<br/>
    /// a response. See the `tools` parameter to see how to specify which tools<br/>
    /// the model can call.
    /// </summary>
    public readonly partial struct ToolChoice3 : global::System.IEquatable<ToolChoice3>
    {
        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or<br/>
        /// more tools.<br/>
        /// `required` means the model must call one or more tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceOptions? ChoiceOptions { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceOptions? ChoiceOptions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChoiceOptions))]
#endif
        public bool IsChoiceOptions => ChoiceOptions != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice3(global::tryAGI.OpenAI.ToolChoiceOptions value) => new ToolChoice3((global::tryAGI.OpenAI.ToolChoiceOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceOptions?(ToolChoice3 @this) => @this.ChoiceOptions;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice3(global::tryAGI.OpenAI.ToolChoiceOptions? value)
        {
            ChoiceOptions = value;
        }

        /// <summary>
        /// Constrains the tools available to the model to a pre-defined set.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceAllowed? ChoiceAllowed { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceAllowed? ChoiceAllowed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChoiceAllowed))]
#endif
        public bool IsChoiceAllowed => ChoiceAllowed != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice3(global::tryAGI.OpenAI.ToolChoiceAllowed value) => new ToolChoice3((global::tryAGI.OpenAI.ToolChoiceAllowed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceAllowed?(ToolChoice3 @this) => @this.ChoiceAllowed;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice3(global::tryAGI.OpenAI.ToolChoiceAllowed? value)
        {
            ChoiceAllowed = value;
        }

        /// <summary>
        /// Indicates that the model should use a built-in tool to generate a response.<br/>
        /// [Learn more about built-in tools](https://platform.openai.com/docs/guides/tools).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceTypes? ChoiceTypes { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceTypes? ChoiceTypes { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChoiceTypes))]
#endif
        public bool IsChoiceTypes => ChoiceTypes != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice3(global::tryAGI.OpenAI.ToolChoiceTypes value) => new ToolChoice3((global::tryAGI.OpenAI.ToolChoiceTypes?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceTypes?(ToolChoice3 @this) => @this.ChoiceTypes;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice3(global::tryAGI.OpenAI.ToolChoiceTypes? value)
        {
            ChoiceTypes = value;
        }

        /// <summary>
        /// Use this option to force the model to call a specific function.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceFunction? ChoiceFunction { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceFunction? ChoiceFunction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChoiceFunction))]
#endif
        public bool IsChoiceFunction => ChoiceFunction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice3(global::tryAGI.OpenAI.ToolChoiceFunction value) => new ToolChoice3((global::tryAGI.OpenAI.ToolChoiceFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceFunction?(ToolChoice3 @this) => @this.ChoiceFunction;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice3(global::tryAGI.OpenAI.ToolChoiceFunction? value)
        {
            ChoiceFunction = value;
        }

        /// <summary>
        /// Use this option to force the model to call a specific tool on a remote MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceMCP? ChoiceMCP { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceMCP? ChoiceMCP { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChoiceMCP))]
#endif
        public bool IsChoiceMCP => ChoiceMCP != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice3(global::tryAGI.OpenAI.ToolChoiceMCP value) => new ToolChoice3((global::tryAGI.OpenAI.ToolChoiceMCP?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceMCP?(ToolChoice3 @this) => @this.ChoiceMCP;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice3(global::tryAGI.OpenAI.ToolChoiceMCP? value)
        {
            ChoiceMCP = value;
        }

        /// <summary>
        /// Use this option to force the model to call a specific custom tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ToolChoiceCustom? ChoiceCustom { get; init; }
#else
        public global::tryAGI.OpenAI.ToolChoiceCustom? ChoiceCustom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChoiceCustom))]
#endif
        public bool IsChoiceCustom => ChoiceCustom != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice3(global::tryAGI.OpenAI.ToolChoiceCustom value) => new ToolChoice3((global::tryAGI.OpenAI.ToolChoiceCustom?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ToolChoiceCustom?(ToolChoice3 @this) => @this.ChoiceCustom;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice3(global::tryAGI.OpenAI.ToolChoiceCustom? value)
        {
            ChoiceCustom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice3(
            global::tryAGI.OpenAI.ToolChoiceOptions? choiceOptions,
            global::tryAGI.OpenAI.ToolChoiceAllowed? choiceAllowed,
            global::tryAGI.OpenAI.ToolChoiceTypes? choiceTypes,
            global::tryAGI.OpenAI.ToolChoiceFunction? choiceFunction,
            global::tryAGI.OpenAI.ToolChoiceMCP? choiceMCP,
            global::tryAGI.OpenAI.ToolChoiceCustom? choiceCustom
            )
        {
            ChoiceOptions = choiceOptions;
            ChoiceAllowed = choiceAllowed;
            ChoiceTypes = choiceTypes;
            ChoiceFunction = choiceFunction;
            ChoiceMCP = choiceMCP;
            ChoiceCustom = choiceCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChoiceCustom as object ??
            ChoiceMCP as object ??
            ChoiceFunction as object ??
            ChoiceTypes as object ??
            ChoiceAllowed as object ??
            ChoiceOptions as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChoiceOptions?.ToValueString() ??
            ChoiceAllowed?.ToString() ??
            ChoiceTypes?.ToString() ??
            ChoiceFunction?.ToString() ??
            ChoiceMCP?.ToString() ??
            ChoiceCustom?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChoiceOptions || IsChoiceAllowed || IsChoiceTypes || IsChoiceFunction || IsChoiceMCP || IsChoiceCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceOptions?, TResult>? choiceOptions = null,
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceAllowed?, TResult>? choiceAllowed = null,
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceTypes?, TResult>? choiceTypes = null,
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceFunction?, TResult>? choiceFunction = null,
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceMCP?, TResult>? choiceMCP = null,
            global::System.Func<global::tryAGI.OpenAI.ToolChoiceCustom?, TResult>? choiceCustom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChoiceOptions && choiceOptions != null)
            {
                return choiceOptions(ChoiceOptions!);
            }
            else if (IsChoiceAllowed && choiceAllowed != null)
            {
                return choiceAllowed(ChoiceAllowed!);
            }
            else if (IsChoiceTypes && choiceTypes != null)
            {
                return choiceTypes(ChoiceTypes!);
            }
            else if (IsChoiceFunction && choiceFunction != null)
            {
                return choiceFunction(ChoiceFunction!);
            }
            else if (IsChoiceMCP && choiceMCP != null)
            {
                return choiceMCP(ChoiceMCP!);
            }
            else if (IsChoiceCustom && choiceCustom != null)
            {
                return choiceCustom(ChoiceCustom!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceOptions?>? choiceOptions = null,
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceAllowed?>? choiceAllowed = null,
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceTypes?>? choiceTypes = null,
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceFunction?>? choiceFunction = null,
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceMCP?>? choiceMCP = null,
            global::System.Action<global::tryAGI.OpenAI.ToolChoiceCustom?>? choiceCustom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChoiceOptions)
            {
                choiceOptions?.Invoke(ChoiceOptions!);
            }
            else if (IsChoiceAllowed)
            {
                choiceAllowed?.Invoke(ChoiceAllowed!);
            }
            else if (IsChoiceTypes)
            {
                choiceTypes?.Invoke(ChoiceTypes!);
            }
            else if (IsChoiceFunction)
            {
                choiceFunction?.Invoke(ChoiceFunction!);
            }
            else if (IsChoiceMCP)
            {
                choiceMCP?.Invoke(ChoiceMCP!);
            }
            else if (IsChoiceCustom)
            {
                choiceCustom?.Invoke(ChoiceCustom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChoiceOptions,
                typeof(global::tryAGI.OpenAI.ToolChoiceOptions),
                ChoiceAllowed,
                typeof(global::tryAGI.OpenAI.ToolChoiceAllowed),
                ChoiceTypes,
                typeof(global::tryAGI.OpenAI.ToolChoiceTypes),
                ChoiceFunction,
                typeof(global::tryAGI.OpenAI.ToolChoiceFunction),
                ChoiceMCP,
                typeof(global::tryAGI.OpenAI.ToolChoiceMCP),
                ChoiceCustom,
                typeof(global::tryAGI.OpenAI.ToolChoiceCustom),
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
        public bool Equals(ToolChoice3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceOptions?>.Default.Equals(ChoiceOptions, other.ChoiceOptions) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceAllowed?>.Default.Equals(ChoiceAllowed, other.ChoiceAllowed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceTypes?>.Default.Equals(ChoiceTypes, other.ChoiceTypes) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceFunction?>.Default.Equals(ChoiceFunction, other.ChoiceFunction) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceMCP?>.Default.Equals(ChoiceMCP, other.ChoiceMCP) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ToolChoiceCustom?>.Default.Equals(ChoiceCustom, other.ChoiceCustom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolChoice3 obj1, ToolChoice3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChoice3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolChoice3 obj1, ToolChoice3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChoice3 o && Equals(o);
        }
    }
}
