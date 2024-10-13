using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
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
        public global::OpenAI.AssistantsApiToolChoiceOptionEnum? Value1 { get; init; }
#else
        public global::OpenAI.AssistantsApiToolChoiceOptionEnum? Value1 { get; }
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
        public static implicit operator AssistantsApiToolChoiceOption(global::OpenAI.AssistantsApiToolChoiceOptionEnum value) => new AssistantsApiToolChoiceOption(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantsApiToolChoiceOptionEnum?(AssistantsApiToolChoiceOption @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(global::OpenAI.AssistantsApiToolChoiceOptionEnum? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.AssistantsNamedToolChoice? Value2 { get; init; }
#else
        public global::OpenAI.AssistantsNamedToolChoice? Value2 { get; }
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
        public static implicit operator AssistantsApiToolChoiceOption(global::OpenAI.AssistantsNamedToolChoice value) => new AssistantsApiToolChoiceOption(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.AssistantsNamedToolChoice?(AssistantsApiToolChoiceOption @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(global::OpenAI.AssistantsNamedToolChoice? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiToolChoiceOption(
            global::OpenAI.AssistantsApiToolChoiceOptionEnum? value1,
            global::OpenAI.AssistantsNamedToolChoice? value2
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
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.AssistantsApiToolChoiceOptionEnum?, TResult>? value1 = null,
            global::System.Func<global::OpenAI.AssistantsNamedToolChoice?, TResult>? value2 = null,
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
            global::System.Action<global::OpenAI.AssistantsApiToolChoiceOptionEnum?>? value1 = null,
            global::System.Action<global::OpenAI.AssistantsNamedToolChoice?>? value2 = null,
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
                typeof(global::OpenAI.AssistantsApiToolChoiceOptionEnum),
                Value2,
                typeof(global::OpenAI.AssistantsNamedToolChoice),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AssistantsApiToolChoiceOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantsApiToolChoiceOptionEnum?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.AssistantsNamedToolChoice?>.Default.Equals(Value2, other.Value2) 
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


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::OpenAI.AssistantsApiToolChoiceOption? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.AssistantsApiToolChoiceOption),
                jsonSerializerContext) as global::OpenAI.AssistantsApiToolChoiceOption?;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.AssistantsApiToolChoiceOption? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.AssistantsApiToolChoiceOption>(
                json,
                jsonSerializerOptions);
        }

    }
}
