#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output format for generated text.
    /// </summary>
    public readonly partial struct TextFormatParam : global::System.IEquatable<TextFormatParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Generates ordinary text without a structured-output constraint.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TextFormatParamText? Text { get; init; }
#else
        public global::tryAGI.OpenAI.TextFormatParamText? Text { get; }
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
            out global::tryAGI.OpenAI.TextFormatParamText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamText PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Constrains generated text to a JSON Schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TextFormatParamJsonSchema? JsonSchema { get; init; }
#else
        public global::tryAGI.OpenAI.TextFormatParamJsonSchema? JsonSchema { get; }
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
            out global::tryAGI.OpenAI.TextFormatParamJsonSchema? value)
        {
            value = JsonSchema;
            return IsJsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatParamJsonSchema PickJsonSchema() => IsJsonSchema
            ? JsonSchema!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchema' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextFormatParam(global::tryAGI.OpenAI.TextFormatParamText value) => new TextFormatParam((global::tryAGI.OpenAI.TextFormatParamText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TextFormatParamText?(TextFormatParam @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public TextFormatParam(global::tryAGI.OpenAI.TextFormatParamText? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextFormatParam FromText(global::tryAGI.OpenAI.TextFormatParamText? value) => new TextFormatParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextFormatParam(global::tryAGI.OpenAI.TextFormatParamJsonSchema value) => new TextFormatParam((global::tryAGI.OpenAI.TextFormatParamJsonSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TextFormatParamJsonSchema?(TextFormatParam @this) => @this.JsonSchema;

        /// <summary>
        ///
        /// </summary>
        public TextFormatParam(global::tryAGI.OpenAI.TextFormatParamJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextFormatParam FromJsonSchema(global::tryAGI.OpenAI.TextFormatParamJsonSchema? value) => new TextFormatParam(value);

        /// <summary>
        ///
        /// </summary>
        public TextFormatParam(
            global::tryAGI.OpenAI.TextFormatParamDiscriminatorType? type,
            global::tryAGI.OpenAI.TextFormatParamText? text,
            global::tryAGI.OpenAI.TextFormatParamJsonSchema? jsonSchema
            )
        {
            Type = type;

            Text = text;
            JsonSchema = jsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            JsonSchema as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JsonSchema?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJsonSchema || !IsText && IsJsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.TextFormatParamText, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.TextFormatParamJsonSchema, TResult>? jsonSchema = null,
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

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.TextFormatParamText>? text = null,

            global::System.Action<global::tryAGI.OpenAI.TextFormatParamJsonSchema>? jsonSchema = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.TextFormatParamText>? text = null,
            global::System.Action<global::tryAGI.OpenAI.TextFormatParamJsonSchema>? jsonSchema = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::tryAGI.OpenAI.TextFormatParamText),
                JsonSchema,
                typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchema),
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
        public bool Equals(TextFormatParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TextFormatParamText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TextFormatParamJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextFormatParam obj1, TextFormatParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextFormatParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextFormatParam obj1, TextFormatParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextFormatParam o && Equals(o);
        }
    }
}
