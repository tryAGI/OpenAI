#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ContentItem4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ContentItem4>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ContentItem4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::tryAGI.OpenAI.UserMessageInputText? inputText = default;
            global::tryAGI.OpenAI.UserMessageQuotedText? quotedText = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UserMessageInputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UserMessageInputText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UserMessageInputText).Name}");
                        inputText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UserMessageQuotedText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UserMessageQuotedText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UserMessageQuotedText).Name}");
                        quotedText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputText == null && quotedText == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UserMessageInputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UserMessageInputText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UserMessageInputText).Name}");
                    inputText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UserMessageQuotedText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UserMessageQuotedText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UserMessageQuotedText).Name}");
                    quotedText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ContentItem4(
                inputText,

                quotedText
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ContentItem4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UserMessageInputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UserMessageInputText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UserMessageInputText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputText, typeInfo);
            }
            else if (value.IsQuotedText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UserMessageQuotedText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UserMessageQuotedText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UserMessageQuotedText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QuotedText, typeInfo);
            }
        }
    }
}