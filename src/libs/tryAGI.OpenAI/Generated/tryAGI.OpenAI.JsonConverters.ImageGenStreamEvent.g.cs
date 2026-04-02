#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ImageGenStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ImageGenStreamEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ImageGenStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("b64_json")) __score0++;
            if (__jsonProps.Contains("background")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("output_format")) __score0++;
            if (__jsonProps.Contains("partial_image_index")) __score0++;
            if (__jsonProps.Contains("quality")) __score0++;
            if (__jsonProps.Contains("size")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("b64_json")) __score1++;
            if (__jsonProps.Contains("background")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("output_format")) __score1++;
            if (__jsonProps.Contains("quality")) __score1++;
            if (__jsonProps.Contains("size")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("usage")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::tryAGI.OpenAI.ImageGenPartialImageEvent? imageGenerationPartialImage = default;
            global::tryAGI.OpenAI.ImageGenCompletedEvent? imageGenerationCompleted = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        imageGenerationPartialImage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ImageGenPartialImageEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        imageGenerationCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ImageGenCompletedEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (imageGenerationPartialImage == null && imageGenerationCompleted == null)
            {
                try
                {
                    imageGenerationPartialImage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ImageGenPartialImageEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    imageGenerationCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ImageGenCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ImageGenStreamEvent(
                imageGenerationPartialImage,

                imageGenerationCompleted
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ImageGenStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsImageGenerationPartialImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationPartialImage, typeof(global::tryAGI.OpenAI.ImageGenPartialImageEvent), options);
            }
            else if (value.IsImageGenerationCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationCompleted, typeof(global::tryAGI.OpenAI.ImageGenCompletedEvent), options);
            }
        }
    }
}