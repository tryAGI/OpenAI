#nullable enable

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class RunStepDeltaStepDetailsMessageCreationObjectTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType>
    {
        /// <inheritdoc />
        public override global::OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType Read(
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
                        return global::OpenAI.RunStepDeltaStepDetailsMessageCreationObjectTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.RunStepDeltaStepDetailsMessageCreationObjectType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenAI.RunStepDeltaStepDetailsMessageCreationObjectTypeExtensions.ToValueString(value));
        }
    }
}
