#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class GradersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Graders>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Graders Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderMultiGradersDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderMultiGradersDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.GraderMultiGradersDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.GraderStringCheck? stringCheck = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType.StringCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderStringCheck), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderStringCheck> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.GraderStringCheck)}");
                stringCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.GraderTextSimilarity? textSimilarity = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType.TextSimilarity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderTextSimilarity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderTextSimilarity> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.GraderTextSimilarity)}");
                textSimilarity = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.GraderPython? python = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType.Python)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderPython), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderPython> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.GraderPython)}");
                python = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.GraderScoreModel? scoreModel = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType.ScoreModel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderScoreModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderScoreModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.GraderScoreModel)}");
                scoreModel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.GraderLabelModel? labelModel = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.GraderMultiGradersDiscriminatorType.LabelModel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderLabelModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderLabelModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.GraderLabelModel)}");
                labelModel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.Graders(
                discriminator?.Type,
                stringCheck,

                textSimilarity,

                python,

                scoreModel,

                labelModel
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Graders value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderStringCheck), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderStringCheck?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.GraderStringCheck).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickStringCheck(), typeInfo);
            }
            else if (value.IsTextSimilarity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderTextSimilarity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderTextSimilarity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.GraderTextSimilarity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextSimilarity(), typeInfo);
            }
            else if (value.IsPython)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderPython), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderPython?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.GraderPython).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPython(), typeInfo);
            }
            else if (value.IsScoreModel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderScoreModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderScoreModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.GraderScoreModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScoreModel(), typeInfo);
            }
            else if (value.IsLabelModel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.GraderLabelModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.GraderLabelModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.GraderLabelModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLabelModel(), typeInfo);
            }
        }
    }
}