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
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? Value1 { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum value) => new ChatCompletionToolChoiceOption((global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?(ChatCompletionToolChoiceOption @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Constrains the tools available to the model to a pre-defined set.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? Value2 { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice value) => new ChatCompletionToolChoiceOption((global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?(ChatCompletionToolChoiceOption @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific function.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? Value3 { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice value) => new ChatCompletionToolChoiceOption((global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?(ChatCompletionToolChoiceOption @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific custom tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? Value4 { get; init; }
#else
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom value) => new ChatCompletionToolChoiceOption((global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?(ChatCompletionToolChoiceOption @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(
            global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? value1,
            global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? value2,
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? value3,
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? value4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToValueString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?, TResult>? value1 = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?, TResult>? value2 = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?, TResult>? value3 = null,
            global::System.Func<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?, TResult>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?>? value1 = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?>? value2 = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?>? value3 = null,
            global::System.Action<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum),
                Value2,
                typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice),
                Value3,
                typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice),
                Value4,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?>.Default.Equals(Value4, other.Value4) 
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
