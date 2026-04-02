#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ContentItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ContentItem3>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ContentItem3 Read(
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
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("annotations")) __score1++;
            if (__jsonProps.Contains("logprobs")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("text")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("text")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("text")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("refusal")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("detail")) __score6++;
            if (__jsonProps.Contains("file_id")) __score6++;
            if (__jsonProps.Contains("image_url")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("detail")) __score7++;
            if (__jsonProps.Contains("file_id")) __score7++;
            if (__jsonProps.Contains("image_url")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("file_data")) __score8++;
            if (__jsonProps.Contains("file_id")) __score8++;
            if (__jsonProps.Contains("file_url")) __score8++;
            if (__jsonProps.Contains("filename")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }

            global::tryAGI.OpenAI.InputTextContent? inputText = default;
            global::tryAGI.OpenAI.OutputTextContent? outputText = default;
            global::tryAGI.OpenAI.TextContent? text = default;
            global::tryAGI.OpenAI.SummaryTextContent? summaryText = default;
            global::tryAGI.OpenAI.ReasoningTextContent? reasoningText = default;
            global::tryAGI.OpenAI.RefusalContent? refusal = default;
            global::tryAGI.OpenAI.InputImageContent? inputImage = default;
            global::tryAGI.OpenAI.ComputerScreenshotContent? computerScreenshot = default;
            global::tryAGI.OpenAI.InputFileContent? inputFile = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
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
                else if (__bestIndex == 1)
                {
                    try
                    {
                        outputText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.OutputTextContent>(__rawJson, options);
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
                        text = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.TextContent>(__rawJson, options);
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
                        summaryText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.SummaryTextContent>(__rawJson, options);
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
                        reasoningText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ReasoningTextContent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        refusal = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RefusalContent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        inputImage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.InputImageContent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        computerScreenshot = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerScreenshotContent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        inputFile = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.InputFileContent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputText == null && outputText == null && text == null && summaryText == null && reasoningText == null && refusal == null && inputImage == null && computerScreenshot == null && inputFile == null)
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

                try
                {
                    outputText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.OutputTextContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    text = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.TextContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    summaryText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.SummaryTextContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    reasoningText = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ReasoningTextContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    refusal = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.RefusalContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputImage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.InputImageContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerScreenshot = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerScreenshotContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    inputFile = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.InputFileContent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ContentItem3(
                inputText,

                outputText,

                text,

                summaryText,

                reasoningText,

                refusal,

                inputImage,

                computerScreenshot,

                inputFile
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ContentItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInputText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputText, typeof(global::tryAGI.OpenAI.InputTextContent), options);
            }
            else if (value.IsOutputText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputText, typeof(global::tryAGI.OpenAI.OutputTextContent), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::tryAGI.OpenAI.TextContent), options);
            }
            else if (value.IsSummaryText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummaryText, typeof(global::tryAGI.OpenAI.SummaryTextContent), options);
            }
            else if (value.IsReasoningText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningText, typeof(global::tryAGI.OpenAI.ReasoningTextContent), options);
            }
            else if (value.IsRefusal)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Refusal, typeof(global::tryAGI.OpenAI.RefusalContent), options);
            }
            else if (value.IsInputImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputImage, typeof(global::tryAGI.OpenAI.InputImageContent), options);
            }
            else if (value.IsComputerScreenshot)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerScreenshot, typeof(global::tryAGI.OpenAI.ComputerScreenshotContent), options);
            }
            else if (value.IsInputFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFile, typeof(global::tryAGI.OpenAI.InputFileContent), options);
            }
        }
    }
}