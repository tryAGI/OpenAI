#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An object specifying the format that the model must output.<br/>
    /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
    /// Structured Outputs which ensures the model will match your supplied JSON<br/>
    /// schema. Learn more in the [Structured Outputs<br/>
    /// guide](/docs/guides/structured-outputs).<br/>
    /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures<br/>
    /// the message the model generates is valid JSON.<br/>
    /// **Important:** when using JSON mode, you **must** also instruct the model<br/>
    /// to produce JSON yourself via a system or user message. Without this, the<br/>
    /// model may generate an unending stream of whitespace until the generation<br/>
    /// reaches the token limit, resulting in a long-running and seemingly "stuck"<br/>
    /// request. Also note that the message content may be partially cut off if<br/>
    /// `finish_reason="length"`, which indicates the generation exceeded<br/>
    /// `max_tokens` or the conversation exceeded the max context length.
    /// </summary>
    public readonly partial struct ResponseFormat : global::System.IEquatable<ResponseFormat>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.CreateChatCompletionRequestResponseFormatDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFormatText? Text { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFormatText? Text { get; }
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
        public static implicit operator ResponseFormat(global::tryAGI.OpenAI.ResponseFormatText value) => new ResponseFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFormatText?(ResponseFormat @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(global::tryAGI.OpenAI.ResponseFormatText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFormatJsonObject? JsonObject { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFormatJsonObject? JsonObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonObject))]
#endif
        public bool IsJsonObject => JsonObject != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormat(global::tryAGI.OpenAI.ResponseFormatJsonObject value) => new ResponseFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFormatJsonObject?(ResponseFormat @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(global::tryAGI.OpenAI.ResponseFormatJsonObject? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseFormatJsonSchema? JsonSchema { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseFormatJsonSchema? JsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormat(global::tryAGI.OpenAI.ResponseFormatJsonSchema value) => new ResponseFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseFormatJsonSchema?(ResponseFormat @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(global::tryAGI.OpenAI.ResponseFormatJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(
            global::tryAGI.OpenAI.CreateChatCompletionRequestResponseFormatDiscriminatorType? type,
            global::tryAGI.OpenAI.ResponseFormatText? text,
            global::tryAGI.OpenAI.ResponseFormatJsonObject? jsonObject,
            global::tryAGI.OpenAI.ResponseFormatJsonSchema? jsonSchema
            )
        {
            Type = type;

            Text = text;
            JsonObject = jsonObject;
            JsonSchema = jsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonSchema as object ??
            JsonObject as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJsonObject && !IsJsonSchema || !IsText && IsJsonObject && !IsJsonSchema || !IsText && !IsJsonObject && IsJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponseFormatText?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFormatJsonObject?, TResult>? jsonObject = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseFormatJsonSchema?, TResult>? jsonSchema = null,
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
            else if (IsJsonObject && jsonObject != null)
            {
                return jsonObject(JsonObject!);
            }
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponseFormatText?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFormatJsonObject?>? jsonObject = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseFormatJsonSchema?>? jsonSchema = null,
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
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
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
                typeof(global::tryAGI.OpenAI.ResponseFormatText),
                JsonObject,
                typeof(global::tryAGI.OpenAI.ResponseFormatJsonObject),
                JsonSchema,
                typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchema),
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
        public bool Equals(ResponseFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFormatText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFormatJsonObject?>.Default.Equals(JsonObject, other.JsonObject) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseFormatJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormat obj1, ResponseFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormat obj1, ResponseFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormat o && Equals(o);
        }
    }
}
