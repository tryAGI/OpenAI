#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An object specifying the format that the model must output.<br/>
    /// Configuring `{ "type": "json_schema" }` enables Structured Outputs, <br/>
    /// which ensures the model will match your supplied JSON schema. Learn more in the <br/>
    /// [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
    /// The default format is `{ "type": "text" }` with no additional options.<br/>
    /// **Not recommended for gpt-4o and newer models:**<br/>
    /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
    /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
    /// is preferred for models that support it.
    /// </summary>
    public readonly partial struct BetaTextResponseFormatConfiguration : global::System.IEquatable<BetaTextResponseFormatConfiguration>
    {
        /// <summary>
        /// Default response format. Used to generate text responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseFormatText? Text { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseFormatText? Text { get; }
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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseFormatText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatText PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// JSON Schema response format. Used to generate structured JSON responses.<br/>
        /// Learn more about [Structured Outputs](/docs/guides/structured-outputs).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? JsonSchema { get; init; }
#else
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? JsonSchema { get; }
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
        public bool TryPickJsonSchema(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? value)
        {
            value = JsonSchema;
            return IsJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema PickJsonSchema() => IsJsonSchema
            ? JsonSchema!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchema' but the value was {ToString()}.");

        /// <summary>
        /// JSON object response format. An older method of generating JSON responses.<br/>
        /// Using `json_schema` is recommended for models that support it. Note that the<br/>
        /// model will not generate JSON without a system or user message instructing it<br/>
        /// to do so.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObject? JsonObject { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObject? JsonObject { get; }
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
        public bool TryPickJsonObject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseFormatJsonObject? value)
        {
            value = JsonObject;
            return IsJsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseFormatJsonObject PickJsonObject() => IsJsonObject
            ? JsonObject!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonObject' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTextResponseFormatConfiguration(global::tryAGI.OpenAI.BetaResponseFormatText value) => new BetaTextResponseFormatConfiguration((global::tryAGI.OpenAI.BetaResponseFormatText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseFormatText?(BetaTextResponseFormatConfiguration @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaTextResponseFormatConfiguration(global::tryAGI.OpenAI.BetaResponseFormatText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTextResponseFormatConfiguration FromText(global::tryAGI.OpenAI.BetaResponseFormatText? value) => new BetaTextResponseFormatConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTextResponseFormatConfiguration(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema value) => new BetaTextResponseFormatConfiguration((global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema?(BetaTextResponseFormatConfiguration @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public BetaTextResponseFormatConfiguration(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTextResponseFormatConfiguration FromJsonSchema(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? value) => new BetaTextResponseFormatConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaTextResponseFormatConfiguration(global::tryAGI.OpenAI.BetaResponseFormatJsonObject value) => new BetaTextResponseFormatConfiguration((global::tryAGI.OpenAI.BetaResponseFormatJsonObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseFormatJsonObject?(BetaTextResponseFormatConfiguration @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public BetaTextResponseFormatConfiguration(global::tryAGI.OpenAI.BetaResponseFormatJsonObject? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaTextResponseFormatConfiguration FromJsonObject(global::tryAGI.OpenAI.BetaResponseFormatJsonObject? value) => new BetaTextResponseFormatConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaTextResponseFormatConfiguration(
            global::tryAGI.OpenAI.BetaResponseFormatText? text,
            global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? jsonSchema,
            global::tryAGI.OpenAI.BetaResponseFormatJsonObject? jsonObject
            )
        {
            Text = text;
            JsonSchema = jsonSchema;
            JsonObject = jsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonObject as object ??
            JsonSchema as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JsonSchema?.ToString() ??
            JsonObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJsonSchema && !IsJsonObject || !IsText && IsJsonSchema && !IsJsonObject || !IsText && !IsJsonSchema && IsJsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaResponseFormatText, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema, TResult>? jsonSchema = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseFormatJsonObject, TResult>? jsonObject = null,
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
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }
            else if (IsJsonObject && jsonObject != null)
            {
                return jsonObject(JsonObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFormatText>? text = null,

            global::System.Action<global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema>? jsonSchema = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseFormatJsonObject>? jsonObject = null,
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
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFormatText>? text = null,
            global::System.Action<global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema>? jsonSchema = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFormatJsonObject>? jsonObject = null,
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
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
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
                typeof(global::tryAGI.OpenAI.BetaResponseFormatText),
                JsonSchema,
                typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema),
                JsonObject,
                typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObject),
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
        public bool Equals(BetaTextResponseFormatConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseFormatText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseFormatJsonObject?>.Default.Equals(JsonObject, other.JsonObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaTextResponseFormatConfiguration obj1, BetaTextResponseFormatConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaTextResponseFormatConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaTextResponseFormatConfiguration obj1, BetaTextResponseFormatConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaTextResponseFormatConfiguration o && Equals(o);
        }
    }
}
