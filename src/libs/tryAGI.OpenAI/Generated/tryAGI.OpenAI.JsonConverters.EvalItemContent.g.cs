#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class EvalItemContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.EvalItemContent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.EvalItemContent Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.EvalItemContentItem), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::tryAGI.OpenAI.EvalItemContentItem? evalContentItem = default;
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>? anArrayOfInputTextOutputTextInputImageAndInputAudio = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.EvalItemContentItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.EvalItemContentItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.EvalItemContentItem).Name}");
                        evalContentItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>).Name}");
                        anArrayOfInputTextOutputTextInputImageAndInputAudio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (evalContentItem == null && anArrayOfInputTextOutputTextInputImageAndInputAudio == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.EvalItemContentItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.EvalItemContentItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.EvalItemContentItem).Name}");
                    evalContentItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>).Name}");
                    anArrayOfInputTextOutputTextInputImageAndInputAudio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.EvalItemContent(
                evalContentItem,

                anArrayOfInputTextOutputTextInputImageAndInputAudio
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.EvalItemContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEvalContentItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.EvalItemContentItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.EvalItemContentItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.EvalItemContentItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EvalContentItem!.Value, typeInfo);
            }
            else if (value.IsAnArrayOfInputTextOutputTextInputImageAndInputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalItemContentItem>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnArrayOfInputTextOutputTextInputImageAndInputAudio!, typeInfo);
            }
        }
    }
}