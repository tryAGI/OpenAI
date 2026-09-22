#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The effective output format for generated text.
    /// </summary>
    public readonly partial struct TextFormatResource : global::System.IEquatable<TextFormatResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Generates ordinary text without a structured-output constraint.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TextFormatResourceText? Text { get; init; }
#else
        public global::tryAGI.OpenAI.TextFormatResourceText? Text { get; }
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
            out global::tryAGI.OpenAI.TextFormatResourceText? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceText PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Constrains generated text to a JSON Schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchema? JsonSchema { get; init; }
#else
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchema? JsonSchema { get; }
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
            out global::tryAGI.OpenAI.TextFormatResourceJsonSchema? value)
        {
            value = JsonSchema;
            return IsJsonSchema;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.TextFormatResourceJsonSchema PickJsonSchema() => IsJsonSchema
            ? JsonSchema!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchema' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextFormatResource(global::tryAGI.OpenAI.TextFormatResourceText value) => new TextFormatResource((global::tryAGI.OpenAI.TextFormatResourceText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TextFormatResourceText?(TextFormatResource @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public TextFormatResource(global::tryAGI.OpenAI.TextFormatResourceText? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextFormatResource FromText(global::tryAGI.OpenAI.TextFormatResourceText? value) => new TextFormatResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextFormatResource(global::tryAGI.OpenAI.TextFormatResourceJsonSchema value) => new TextFormatResource((global::tryAGI.OpenAI.TextFormatResourceJsonSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TextFormatResourceJsonSchema?(TextFormatResource @this) => @this.JsonSchema;

        /// <summary>
        ///
        /// </summary>
        public TextFormatResource(global::tryAGI.OpenAI.TextFormatResourceJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextFormatResource FromJsonSchema(global::tryAGI.OpenAI.TextFormatResourceJsonSchema? value) => new TextFormatResource(value);

        /// <summary>
        ///
        /// </summary>
        public TextFormatResource(
            global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.TextFormatResourceText? text,
            global::tryAGI.OpenAI.TextFormatResourceJsonSchema? jsonSchema
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
            global::System.Func<global::tryAGI.OpenAI.TextFormatResourceText, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.TextFormatResourceJsonSchema, TResult>? jsonSchema = null,
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
            global::System.Action<global::tryAGI.OpenAI.TextFormatResourceText>? text = null,

            global::System.Action<global::tryAGI.OpenAI.TextFormatResourceJsonSchema>? jsonSchema = null,
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
            global::System.Action<global::tryAGI.OpenAI.TextFormatResourceText>? text = null,
            global::System.Action<global::tryAGI.OpenAI.TextFormatResourceJsonSchema>? jsonSchema = null,
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
                typeof(global::tryAGI.OpenAI.TextFormatResourceText),
                JsonSchema,
                typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchema),
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
        public bool Equals(TextFormatResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TextFormatResourceText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TextFormatResourceJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextFormatResource obj1, TextFormatResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextFormatResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextFormatResource obj1, TextFormatResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextFormatResource o && Equals(o);
        }
    }
}
