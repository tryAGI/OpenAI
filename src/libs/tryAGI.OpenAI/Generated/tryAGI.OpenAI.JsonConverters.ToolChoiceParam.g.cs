#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ToolChoiceParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ToolChoiceParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ToolChoiceParam Read(
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
            if (__jsonProps.Contains("mode")) __score1++;
            if (__jsonProps.Contains("tools")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("server_label")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("type")) __score7++;
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

            global::tryAGI.OpenAI.ToolChoiceOptions? toolChoiceMode = default;
            global::tryAGI.OpenAI.ToolChoiceAllowed? allowedTools = default;
            global::tryAGI.OpenAI.ToolChoiceTypes? hostedTool = default;
            global::tryAGI.OpenAI.ToolChoiceFunction? functionTool = default;
            global::tryAGI.OpenAI.ToolChoiceMCP? mcpTool = default;
            global::tryAGI.OpenAI.ToolChoiceCustom? customTool = default;
            global::tryAGI.OpenAI.SpecificApplyPatchParam? specificApplyPatchToolChoice = default;
            global::tryAGI.OpenAI.SpecificFunctionShellParam? specificShellToolChoice = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        toolChoiceMode = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceOptions>(__rawJson, options);
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
                        allowedTools = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceAllowed>(__rawJson, options);
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
                        hostedTool = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceTypes>(__rawJson, options);
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
                        functionTool = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceFunction>(__rawJson, options);
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
                        mcpTool = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceMCP>(__rawJson, options);
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
                        customTool = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceCustom>(__rawJson, options);
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
                        specificApplyPatchToolChoice = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.SpecificApplyPatchParam>(__rawJson, options);
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
                        specificShellToolChoice = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.SpecificFunctionShellParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (toolChoiceMode == null && allowedTools == null && hostedTool == null && functionTool == null && mcpTool == null && customTool == null && specificApplyPatchToolChoice == null && specificShellToolChoice == null)
            {
                try
                {
                    toolChoiceMode = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceOptions>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    allowedTools = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceAllowed>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    hostedTool = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceTypes>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionTool = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceFunction>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpTool = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceMCP>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    customTool = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolChoiceCustom>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    specificApplyPatchToolChoice = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.SpecificApplyPatchParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    specificShellToolChoice = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.SpecificFunctionShellParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ToolChoiceParam(
                toolChoiceMode,

                allowedTools,

                hostedTool,

                functionTool,

                mcpTool,

                customTool,

                specificApplyPatchToolChoice,

                specificShellToolChoice
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ToolChoiceParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsToolChoiceMode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolChoiceMode, typeof(global::tryAGI.OpenAI.ToolChoiceOptions), options);
            }
            else if (value.IsAllowedTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AllowedTools, typeof(global::tryAGI.OpenAI.ToolChoiceAllowed), options);
            }
            else if (value.IsHostedTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HostedTool, typeof(global::tryAGI.OpenAI.ToolChoiceTypes), options);
            }
            else if (value.IsFunctionTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionTool, typeof(global::tryAGI.OpenAI.ToolChoiceFunction), options);
            }
            else if (value.IsMcpTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpTool, typeof(global::tryAGI.OpenAI.ToolChoiceMCP), options);
            }
            else if (value.IsCustomTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomTool, typeof(global::tryAGI.OpenAI.ToolChoiceCustom), options);
            }
            else if (value.IsSpecificApplyPatchToolChoice)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpecificApplyPatchToolChoice, typeof(global::tryAGI.OpenAI.SpecificApplyPatchParam), options);
            }
            else if (value.IsSpecificShellToolChoice)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpecificShellToolChoice, typeof(global::tryAGI.OpenAI.SpecificFunctionShellParam), options);
            }
        }
    }
}