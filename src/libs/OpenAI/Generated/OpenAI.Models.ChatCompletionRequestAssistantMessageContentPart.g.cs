using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionRequestAssistantMessageContentPart : global::System.IEquatable<ChatCompletionRequestAssistantMessageContentPart>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? Type { get; }

        /// <summary>
        /// Learn about [text inputs](/docs/guides/text-generation).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.ChatCompletionRequestMessageContentPartText? Text { get; init; }
#else
        public global::OpenAI.ChatCompletionRequestMessageContentPartText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestAssistantMessageContentPart(global::OpenAI.ChatCompletionRequestMessageContentPartText value) => new ChatCompletionRequestAssistantMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.ChatCompletionRequestMessageContentPartText?(ChatCompletionRequestAssistantMessageContentPart @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(global::OpenAI.ChatCompletionRequestMessageContentPartText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenAI.ChatCompletionRequestMessageContentPartRefusal? Refusal { get; init; }
#else
        public global::OpenAI.ChatCompletionRequestMessageContentPartRefusal? Refusal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionRequestAssistantMessageContentPart(global::OpenAI.ChatCompletionRequestMessageContentPartRefusal value) => new ChatCompletionRequestAssistantMessageContentPart(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenAI.ChatCompletionRequestMessageContentPartRefusal?(ChatCompletionRequestAssistantMessageContentPart @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(global::OpenAI.ChatCompletionRequestMessageContentPartRefusal? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPart(
            global::OpenAI.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? type,
            global::OpenAI.ChatCompletionRequestMessageContentPartText? text,
            global::OpenAI.ChatCompletionRequestMessageContentPartRefusal? refusal
            )
        {
            Type = type;

            Text = text;
            Refusal = refusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Refusal as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsRefusal || !IsText && IsRefusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenAI.ChatCompletionRequestMessageContentPartText?, TResult>? text = null,
            global::System.Func<global::OpenAI.ChatCompletionRequestMessageContentPartRefusal?, TResult>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsRefusal && refusal != null)
            {
                return refusal(Refusal!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenAI.ChatCompletionRequestMessageContentPartText?>? text = null,
            global::System.Action<global::OpenAI.ChatCompletionRequestMessageContentPartRefusal?>? refusal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText),
                Refusal,
                typeof(global::OpenAI.ChatCompletionRequestMessageContentPartRefusal),
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
        public bool Equals(ChatCompletionRequestAssistantMessageContentPart other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.ChatCompletionRequestMessageContentPartText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenAI.ChatCompletionRequestMessageContentPartRefusal?>.Default.Equals(Refusal, other.Refusal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionRequestAssistantMessageContentPart obj1, ChatCompletionRequestAssistantMessageContentPart obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionRequestAssistantMessageContentPart>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionRequestAssistantMessageContentPart obj1, ChatCompletionRequestAssistantMessageContentPart obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionRequestAssistantMessageContentPart o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::OpenAI.ChatCompletionRequestAssistantMessageContentPart? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::OpenAI.ChatCompletionRequestAssistantMessageContentPart),
                jsonSerializerContext) as global::OpenAI.ChatCompletionRequestAssistantMessageContentPart?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::OpenAI.ChatCompletionRequestAssistantMessageContentPart? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::OpenAI.ChatCompletionRequestAssistantMessageContentPart>(
                json,
                jsonSerializerOptions);
        }

    }
}
