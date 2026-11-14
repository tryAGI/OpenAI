#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use a JSON schema for structured output or text to return to plain text.
    /// </summary>
    public readonly partial struct Format7 : global::System.IEquatable<Format7>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseConfigurationUpdateTextFormatDiscriminatorType? Type { get; }

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
        public global::tryAGI.OpenAI.BetaResponseFormatText PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// JSON Schema response format. Used to generate structured JSON responses.<br/>
        /// Learn more about [Structured Outputs](https://developers.openai.com/api/docs/guides/structured-outputs).
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
        public global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema PickJsonSchema() => JsonSchema is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchema' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Format7(global::tryAGI.OpenAI.BetaResponseFormatText value) => new Format7((global::tryAGI.OpenAI.BetaResponseFormatText?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseFormatText?(Format7 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public Format7(global::tryAGI.OpenAI.BetaResponseFormatText? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Format7 FromText(global::tryAGI.OpenAI.BetaResponseFormatText? value) => new Format7(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Format7(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema value) => new Format7((global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema?(Format7 @this) => @this.JsonSchema;

        /// <summary>
        ///
        /// </summary>
        public Format7(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Format7 FromJsonSchema(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? value) => new Format7(value);

        /// <summary>
        ///
        /// </summary>
        public Format7(
            global::tryAGI.OpenAI.BetaResponseConfigurationUpdateTextFormatDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaResponseFormatText? text,
            global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? jsonSchema
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
            global::System.Func<global::tryAGI.OpenAI.BetaResponseFormatText, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema, TResult>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (JsonSchema is { } __value1 && jsonSchema != null)
            {
                return jsonSchema(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFormatText>? text = null,

            global::System.Action<global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (JsonSchema is { } __value1)
            {
                jsonSchema?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseFormatText>? text = null,
            global::System.Action<global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (JsonSchema is { } __value1)
            {
                jsonSchema?.Invoke(__value1);
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
        public bool Equals(Format7 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseFormatText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Format7 obj1, Format7 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Format7>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Format7 obj1, Format7 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Format7 o && Equals(o);
        }
    }
}
