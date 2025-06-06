#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.<br/>
    /// `none` means the model will not call any tools and instead generates a message.<br/>
    /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.<br/>
    /// `required` means the model must call one or more tools before responding to the user.<br/>
    /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
    /// </summary>
    public readonly partial struct AssistantsApiToolChoiceOption : global::System.IEquatable<AssistantsApiToolChoiceOption>
    {
        /// <summary>
        /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum? Value1 { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum? Value1 { get; }
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
        public static implicit operator AssistantsApiToolChoiceOption(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum value) => new AssistantsApiToolChoiceOption((global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?(AssistantsApiToolChoiceOption @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AssistantsNamedToolChoice? Value2 { get; init; }
#else
        public global::tryAGI.OpenAI.AssistantsNamedToolChoice? Value2 { get; }
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
        public static implicit operator AssistantsApiToolChoiceOption(global::tryAGI.OpenAI.AssistantsNamedToolChoice value) => new AssistantsApiToolChoiceOption((global::tryAGI.OpenAI.AssistantsNamedToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AssistantsNamedToolChoice?(AssistantsApiToolChoiceOption @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(global::tryAGI.OpenAI.AssistantsNamedToolChoice? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(
            global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum? value1,
            global::tryAGI.OpenAI.AssistantsNamedToolChoice? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToValueString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?, TResult>? value1 = null,
            global::System.Func<global::tryAGI.OpenAI.AssistantsNamedToolChoice?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?>? value1 = null,
            global::System.Action<global::tryAGI.OpenAI.AssistantsNamedToolChoice?>? value2 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum),
                Value2,
                typeof(global::tryAGI.OpenAI.AssistantsNamedToolChoice),
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
        public bool Equals(AssistantsApiToolChoiceOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantsApiToolChoiceOptionEnum?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AssistantsNamedToolChoice?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AssistantsApiToolChoiceOption obj1, AssistantsApiToolChoiceOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssistantsApiToolChoiceOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AssistantsApiToolChoiceOption obj1, AssistantsApiToolChoiceOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssistantsApiToolChoiceOption o && Equals(o);
        }
    }
}
