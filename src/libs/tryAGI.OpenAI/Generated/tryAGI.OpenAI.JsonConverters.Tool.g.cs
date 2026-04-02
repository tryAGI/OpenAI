#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Tool>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Tool Read(
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
            if (__jsonProps.Contains("defer_loading")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("parameters")) __score0++;
            if (__jsonProps.Contains("strict")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("filters")) __score1++;
            if (__jsonProps.Contains("max_num_results")) __score1++;
            if (__jsonProps.Contains("ranking_options")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("vector_store_ids")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("display_height")) __score3++;
            if (__jsonProps.Contains("display_width")) __score3++;
            if (__jsonProps.Contains("environment")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("filters")) __score4++;
            if (__jsonProps.Contains("search_context_size")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("user_location")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("allowed_tools")) __score5++;
            if (__jsonProps.Contains("authorization")) __score5++;
            if (__jsonProps.Contains("connector_id")) __score5++;
            if (__jsonProps.Contains("defer_loading")) __score5++;
            if (__jsonProps.Contains("headers")) __score5++;
            if (__jsonProps.Contains("require_approval")) __score5++;
            if (__jsonProps.Contains("server_description")) __score5++;
            if (__jsonProps.Contains("server_label")) __score5++;
            if (__jsonProps.Contains("server_url")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("container")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("action")) __score7++;
            if (__jsonProps.Contains("background")) __score7++;
            if (__jsonProps.Contains("input_fidelity")) __score7++;
            if (__jsonProps.Contains("input_image_mask")) __score7++;
            if (__jsonProps.Contains("model")) __score7++;
            if (__jsonProps.Contains("moderation")) __score7++;
            if (__jsonProps.Contains("output_compression")) __score7++;
            if (__jsonProps.Contains("output_format")) __score7++;
            if (__jsonProps.Contains("partial_images")) __score7++;
            if (__jsonProps.Contains("quality")) __score7++;
            if (__jsonProps.Contains("size")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("environment")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("defer_loading")) __score10++;
            if (__jsonProps.Contains("description")) __score10++;
            if (__jsonProps.Contains("format")) __score10++;
            if (__jsonProps.Contains("name")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("description")) __score11++;
            if (__jsonProps.Contains("name")) __score11++;
            if (__jsonProps.Contains("tools")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("description")) __score12++;
            if (__jsonProps.Contains("execution")) __score12++;
            if (__jsonProps.Contains("parameters")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("search_content_types")) __score13++;
            if (__jsonProps.Contains("search_context_size")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            if (__jsonProps.Contains("user_location")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("type")) __score14++;
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
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }

            global::tryAGI.OpenAI.FunctionTool? function = default;
            global::tryAGI.OpenAI.FileSearchTool? fileSearch = default;
            global::tryAGI.OpenAI.ComputerTool? computer = default;
            global::tryAGI.OpenAI.ComputerUsePreviewTool? computerUsePreview = default;
            global::tryAGI.OpenAI.WebSearchTool? webSearch = default;
            global::tryAGI.OpenAI.MCPTool? mcp = default;
            global::tryAGI.OpenAI.CodeInterpreterTool? codeInterpreter = default;
            global::tryAGI.OpenAI.ImageGenTool? imageGeneration = default;
            global::tryAGI.OpenAI.LocalShellToolParam? localShell = default;
            global::tryAGI.OpenAI.FunctionShellToolParam? shell = default;
            global::tryAGI.OpenAI.CustomToolParam? custom = default;
            global::tryAGI.OpenAI.NamespaceToolParam? @namespace = default;
            global::tryAGI.OpenAI.ToolSearchToolParam? toolSearch = default;
            global::tryAGI.OpenAI.WebSearchPreviewTool? webSearchPreview = default;
            global::tryAGI.OpenAI.ApplyPatchToolParam? applyPatch = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        function = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionTool>(__rawJson, options);
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
                        fileSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FileSearchTool>(__rawJson, options);
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
                        computer = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerTool>(__rawJson, options);
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
                        computerUsePreview = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerUsePreviewTool>(__rawJson, options);
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
                        webSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchTool>(__rawJson, options);
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
                        mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.MCPTool>(__rawJson, options);
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
                        codeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CodeInterpreterTool>(__rawJson, options);
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
                        imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ImageGenTool>(__rawJson, options);
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
                        localShell = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.LocalShellToolParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        shell = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionShellToolParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        custom = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CustomToolParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        @namespace = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.NamespaceToolParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        toolSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolSearchToolParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        webSearchPreview = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchPreviewTool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        applyPatch = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchToolParam>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (function == null && fileSearch == null && computer == null && computerUsePreview == null && webSearch == null && mcp == null && codeInterpreter == null && imageGeneration == null && localShell == null && shell == null && custom == null && @namespace == null && toolSearch == null && webSearchPreview == null && applyPatch == null)
            {
                try
                {
                    function = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fileSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FileSearchTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computer = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerUsePreview = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerUsePreviewTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    webSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.MCPTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    codeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CodeInterpreterTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ImageGenTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    localShell = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.LocalShellToolParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    shell = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionShellToolParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    custom = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CustomToolParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    @namespace = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.NamespaceToolParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolSearchToolParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    webSearchPreview = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchPreviewTool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    applyPatch = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchToolParam>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.Tool(
                function,

                fileSearch,

                computer,

                computerUsePreview,

                webSearch,

                mcp,

                codeInterpreter,

                imageGeneration,

                localShell,

                shell,

                custom,

                @namespace,

                toolSearch,

                webSearchPreview,

                applyPatch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::tryAGI.OpenAI.FunctionTool), options);
            }
            else if (value.IsFileSearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearch, typeof(global::tryAGI.OpenAI.FileSearchTool), options);
            }
            else if (value.IsComputer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeof(global::tryAGI.OpenAI.ComputerTool), options);
            }
            else if (value.IsComputerUsePreview)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerUsePreview, typeof(global::tryAGI.OpenAI.ComputerUsePreviewTool), options);
            }
            else if (value.IsWebSearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeof(global::tryAGI.OpenAI.WebSearchTool), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::tryAGI.OpenAI.MCPTool), options);
            }
            else if (value.IsCodeInterpreter)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreter, typeof(global::tryAGI.OpenAI.CodeInterpreterTool), options);
            }
            else if (value.IsImageGeneration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGeneration, typeof(global::tryAGI.OpenAI.ImageGenTool), options);
            }
            else if (value.IsLocalShell)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShell, typeof(global::tryAGI.OpenAI.LocalShellToolParam), options);
            }
            else if (value.IsShell)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shell, typeof(global::tryAGI.OpenAI.FunctionShellToolParam), options);
            }
            else if (value.IsCustom)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom, typeof(global::tryAGI.OpenAI.CustomToolParam), options);
            }
            else if (value.IsNamespace)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Namespace, typeof(global::tryAGI.OpenAI.NamespaceToolParam), options);
            }
            else if (value.IsToolSearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearch, typeof(global::tryAGI.OpenAI.ToolSearchToolParam), options);
            }
            else if (value.IsWebSearchPreview)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchPreview, typeof(global::tryAGI.OpenAI.WebSearchPreviewTool), options);
            }
            else if (value.IsApplyPatch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatch, typeof(global::tryAGI.OpenAI.ApplyPatchToolParam), options);
            }
        }
    }
}