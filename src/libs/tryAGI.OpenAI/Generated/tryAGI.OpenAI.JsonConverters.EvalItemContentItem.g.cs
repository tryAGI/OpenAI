#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class EvalItemContentItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.EvalItemContentItem>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.EvalItemContentItem Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("text")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("text")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("detail")) __score3++;
            if (__jsonProps.Contains("image_url")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("input_audio")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            string? textInput = default;
            global::tryAGI.OpenAI.InputTextContent? inputText = default;
            global::tryAGI.OpenAI.EvalItemContentOutputText? outputText = default;
            global::tryAGI.OpenAI.EvalItemInputImage? inputImage = default;
            global::tryAGI.OpenAI.InputAudio? inputAudio = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        textInput = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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
                        inputText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.InputTextContent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        outputText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.EvalItemContentOutputText>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        inputImage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.EvalItemInputImage>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        inputAudio = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.InputAudio>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textInput == null && inputText == null && outputText == null && inputImage == null && inputAudio == null)
            {
                try
                {
                    textInput = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.InputTextContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    outputText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.EvalItemContentOutputText>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputImage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.EvalItemInputImage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputAudio = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.InputAudio>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.EvalItemContentItem(
                textInput,

                inputText,

                outputText,

                inputImage,

                inputAudio
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.EvalItemContentItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextInput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextInput, typeof(string), options);
            }
            else if (value.IsInputText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputText, typeof(global::tryAGI.OpenAI.InputTextContent), options);
            }
            else if (value.IsOutputText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputText, typeof(global::tryAGI.OpenAI.EvalItemContentOutputText), options);
            }
            else if (value.IsInputImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputImage, typeof(global::tryAGI.OpenAI.EvalItemInputImage), options);
            }
            else if (value.IsInputAudio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudio, typeof(global::tryAGI.OpenAI.InputAudio), options);
            }
        }
    }
}