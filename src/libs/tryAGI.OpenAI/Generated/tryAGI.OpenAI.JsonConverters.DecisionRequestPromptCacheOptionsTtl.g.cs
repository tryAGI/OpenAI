#nullable enable

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class DecisionRequestPromptCacheOptionsTtlJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtlExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtl value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::tryAGI.OpenAI.DecisionRequestPromptCacheOptionsTtlExtensions.ToValueString(value));
        }
    }
}
