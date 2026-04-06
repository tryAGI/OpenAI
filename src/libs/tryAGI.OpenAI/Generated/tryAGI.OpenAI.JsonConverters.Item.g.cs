#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Item>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Item Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("phase")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("queries")) __score2++;
            if (__jsonProps.Contains("results")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("action")) __score3++;
            if (__jsonProps.Contains("actions")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("pending_safety_checks")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("acknowledged_safety_checks")) __score4++;
            if (__jsonProps.Contains("call_id")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("output")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("action")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("arguments")) __score6++;
            if (__jsonProps.Contains("call_id")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("namespace")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("call_id")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("output")) __score7++;
            if (__jsonProps.Contains("status")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("arguments")) __score8++;
            if (__jsonProps.Contains("call_id")) __score8++;
            if (__jsonProps.Contains("execution")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("call_id")) __score9++;
            if (__jsonProps.Contains("execution")) __score9++;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("status")) __score9++;
            if (__jsonProps.Contains("tools")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("content")) __score10++;
            if (__jsonProps.Contains("encrypted_content")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("status")) __score10++;
            if (__jsonProps.Contains("summary")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("encrypted_content")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("result")) __score12++;
            if (__jsonProps.Contains("status")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("code")) __score13++;
            if (__jsonProps.Contains("container_id")) __score13++;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("outputs")) __score13++;
            if (__jsonProps.Contains("status")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("action")) __score14++;
            if (__jsonProps.Contains("call_id")) __score14++;
            if (__jsonProps.Contains("id")) __score14++;
            if (__jsonProps.Contains("status")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("id")) __score15++;
            if (__jsonProps.Contains("output")) __score15++;
            if (__jsonProps.Contains("status")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("action")) __score16++;
            if (__jsonProps.Contains("call_id")) __score16++;
            if (__jsonProps.Contains("environment")) __score16++;
            if (__jsonProps.Contains("id")) __score16++;
            if (__jsonProps.Contains("status")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("call_id")) __score17++;
            if (__jsonProps.Contains("id")) __score17++;
            if (__jsonProps.Contains("max_output_length")) __score17++;
            if (__jsonProps.Contains("output")) __score17++;
            if (__jsonProps.Contains("status")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("call_id")) __score18++;
            if (__jsonProps.Contains("id")) __score18++;
            if (__jsonProps.Contains("operation")) __score18++;
            if (__jsonProps.Contains("status")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("call_id")) __score19++;
            if (__jsonProps.Contains("id")) __score19++;
            if (__jsonProps.Contains("output")) __score19++;
            if (__jsonProps.Contains("status")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("error")) __score20++;
            if (__jsonProps.Contains("id")) __score20++;
            if (__jsonProps.Contains("server_label")) __score20++;
            if (__jsonProps.Contains("tools")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("arguments")) __score21++;
            if (__jsonProps.Contains("id")) __score21++;
            if (__jsonProps.Contains("name")) __score21++;
            if (__jsonProps.Contains("server_label")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("approval_request_id")) __score22++;
            if (__jsonProps.Contains("approve")) __score22++;
            if (__jsonProps.Contains("id")) __score22++;
            if (__jsonProps.Contains("reason")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("approval_request_id")) __score23++;
            if (__jsonProps.Contains("arguments")) __score23++;
            if (__jsonProps.Contains("error")) __score23++;
            if (__jsonProps.Contains("id")) __score23++;
            if (__jsonProps.Contains("name")) __score23++;
            if (__jsonProps.Contains("output")) __score23++;
            if (__jsonProps.Contains("server_label")) __score23++;
            if (__jsonProps.Contains("status")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("call_id")) __score24++;
            if (__jsonProps.Contains("id")) __score24++;
            if (__jsonProps.Contains("output")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("call_id")) __score25++;
            if (__jsonProps.Contains("id")) __score25++;
            if (__jsonProps.Contains("input")) __score25++;
            if (__jsonProps.Contains("name")) __score25++;
            if (__jsonProps.Contains("namespace")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
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
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }
            if (__score25 > __bestScore) { __bestScore = __score25; __bestIndex = 25; }

            global::tryAGI.OpenAI.InputMessage? message1 = default;
            global::tryAGI.OpenAI.OutputMessage? message2 = default;
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchCall = default;
            global::tryAGI.OpenAI.ComputerToolCall? computerCall = default;
            global::tryAGI.OpenAI.ComputerCallOutputItemParam? computerCallOutput = default;
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchCall = default;
            global::tryAGI.OpenAI.FunctionToolCall? functionCall = default;
            global::tryAGI.OpenAI.FunctionCallOutputItemParam? functionCallOutput = default;
            global::tryAGI.OpenAI.ToolSearchCallItemParam? toolSearchCall = default;
            global::tryAGI.OpenAI.ToolSearchOutputItemParam? toolSearchOutput = default;
            global::tryAGI.OpenAI.ReasoningItem? reasoning = default;
            global::tryAGI.OpenAI.CompactionSummaryItemParam? compaction = default;
            global::tryAGI.OpenAI.ImageGenToolCall? imageGenerationCall = default;
            global::tryAGI.OpenAI.CodeInterpreterToolCall? codeInterpreterCall = default;
            global::tryAGI.OpenAI.LocalShellToolCall? localShellCall = default;
            global::tryAGI.OpenAI.LocalShellToolCallOutput? localShellCallOutput = default;
            global::tryAGI.OpenAI.FunctionShellCallItemParam? shellCall = default;
            global::tryAGI.OpenAI.FunctionShellCallOutputItemParam? shellCallOutput = default;
            global::tryAGI.OpenAI.ApplyPatchToolCallItemParam? applyPatchCall = default;
            global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam? applyPatchCallOutput = default;
            global::tryAGI.OpenAI.MCPListTools? mcpListTools = default;
            global::tryAGI.OpenAI.MCPApprovalRequest? mcpApprovalRequest = default;
            global::tryAGI.OpenAI.MCPApprovalResponse? mcpApprovalResponse = default;
            global::tryAGI.OpenAI.MCPToolCall? mcpCall = default;
            global::tryAGI.OpenAI.CustomToolCallOutput? customToolCallOutput = default;
            global::tryAGI.OpenAI.CustomToolCall? customToolCall = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.InputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.InputMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.InputMessage).Name}");
                        message1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.OutputMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.OutputMessage).Name}");
                        message2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FileSearchToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FileSearchToolCall).Name}");
                        fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerToolCall).Name}");
                        computerCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerCallOutputItemParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam).Name}");
                        computerCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WebSearchToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WebSearchToolCall).Name}");
                        webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionToolCall).Name}");
                        functionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionCallOutputItemParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam).Name}");
                        functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ToolSearchCallItemParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam).Name}");
                        toolSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ToolSearchOutputItemParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParam).Name}");
                        toolSearchOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ReasoningItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ReasoningItem).Name}");
                        reasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CompactionSummaryItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CompactionSummaryItemParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CompactionSummaryItemParam).Name}");
                        compaction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ImageGenToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ImageGenToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ImageGenToolCall).Name}");
                        imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CodeInterpreterToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall).Name}");
                        codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LocalShellToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LocalShellToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LocalShellToolCall).Name}");
                        localShellCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LocalShellToolCallOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput).Name}");
                        localShellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionShellCallItemParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionShellCallItemParam).Name}");
                        shellCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionShellCallOutputItemParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam).Name}");
                        shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchToolCallItemParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam).Name}");
                        applyPatchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam).Name}");
                        applyPatchCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPListTools), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPListTools> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPListTools).Name}");
                        mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPApprovalRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPApprovalRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPApprovalRequest).Name}");
                        mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPApprovalResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPApprovalResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPApprovalResponse).Name}");
                        mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 23)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPToolCall).Name}");
                        mcpCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 24)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CustomToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CustomToolCallOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CustomToolCallOutput).Name}");
                        customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 25)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CustomToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CustomToolCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CustomToolCall).Name}");
                        customToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (message1 == null && message2 == null && fileSearchCall == null && computerCall == null && computerCallOutput == null && webSearchCall == null && functionCall == null && functionCallOutput == null && toolSearchCall == null && toolSearchOutput == null && reasoning == null && compaction == null && imageGenerationCall == null && codeInterpreterCall == null && localShellCall == null && localShellCallOutput == null && shellCall == null && shellCallOutput == null && applyPatchCall == null && applyPatchCallOutput == null && mcpListTools == null && mcpApprovalRequest == null && mcpApprovalResponse == null && mcpCall == null && customToolCallOutput == null && customToolCall == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.InputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.InputMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.InputMessage).Name}");
                    message1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.OutputMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.OutputMessage).Name}");
                    message2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FileSearchToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FileSearchToolCall).Name}");
                    fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerToolCall).Name}");
                    computerCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerCallOutputItemParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam).Name}");
                    computerCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WebSearchToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WebSearchToolCall).Name}");
                    webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionToolCall).Name}");
                    functionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionCallOutputItemParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam).Name}");
                    functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ToolSearchCallItemParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam).Name}");
                    toolSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ToolSearchOutputItemParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParam).Name}");
                    toolSearchOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ReasoningItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ReasoningItem).Name}");
                    reasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CompactionSummaryItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CompactionSummaryItemParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CompactionSummaryItemParam).Name}");
                    compaction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ImageGenToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ImageGenToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ImageGenToolCall).Name}");
                    imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CodeInterpreterToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall).Name}");
                    codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LocalShellToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LocalShellToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LocalShellToolCall).Name}");
                    localShellCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LocalShellToolCallOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput).Name}");
                    localShellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionShellCallItemParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionShellCallItemParam).Name}");
                    shellCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionShellCallOutputItemParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam).Name}");
                    shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchToolCallItemParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam).Name}");
                    applyPatchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam).Name}");
                    applyPatchCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPListTools), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPListTools> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPListTools).Name}");
                    mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPApprovalRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPApprovalRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPApprovalRequest).Name}");
                    mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPApprovalResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPApprovalResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPApprovalResponse).Name}");
                    mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPToolCall).Name}");
                    mcpCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CustomToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CustomToolCallOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CustomToolCallOutput).Name}");
                    customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CustomToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CustomToolCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CustomToolCall).Name}");
                    customToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.Item(
                message1,

                message2,

                fileSearchCall,

                computerCall,

                computerCallOutput,

                webSearchCall,

                functionCall,

                functionCallOutput,

                toolSearchCall,

                toolSearchOutput,

                reasoning,

                compaction,

                imageGenerationCall,

                codeInterpreterCall,

                localShellCall,

                localShellCallOutput,

                shellCall,

                shellCallOutput,

                applyPatchCall,

                applyPatchCallOutput,

                mcpListTools,

                mcpApprovalRequest,

                mcpApprovalResponse,

                mcpCall,

                customToolCallOutput,

                customToolCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.InputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.InputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.InputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message1!, typeInfo);
            }
            else if (value.IsMessage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.OutputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.OutputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message2!, typeInfo);
            }
            else if (value.IsFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FileSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FileSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall!, typeInfo);
            }
            else if (value.IsComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall!, typeInfo);
            }
            else if (value.IsComputerCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerCallOutputItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCallOutput!, typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WebSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WebSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall!, typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall!, typeInfo);
            }
            else if (value.IsFunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionCallOutputItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutput!, typeInfo);
            }
            else if (value.IsToolSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ToolSearchCallItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchCall!, typeInfo);
            }
            else if (value.IsToolSearchOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ToolSearchOutputItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchOutput!, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning!, typeInfo);
            }
            else if (value.IsCompaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CompactionSummaryItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CompactionSummaryItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CompactionSummaryItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction!, typeInfo);
            }
            else if (value.IsImageGenerationCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ImageGenToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ImageGenToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ImageGenToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationCall!, typeInfo);
            }
            else if (value.IsCodeInterpreterCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CodeInterpreterToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCall!, typeInfo);
            }
            else if (value.IsLocalShellCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LocalShellToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LocalShellToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LocalShellToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShellCall!, typeInfo);
            }
            else if (value.IsLocalShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LocalShellToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShellCallOutput!, typeInfo);
            }
            else if (value.IsShellCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionShellCallItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionShellCallItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCall!, typeInfo);
            }
            else if (value.IsShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionShellCallOutputItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCallOutput!, typeInfo);
            }
            else if (value.IsApplyPatchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchToolCallItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCall!, typeInfo);
            }
            else if (value.IsApplyPatchCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCallOutput!, typeInfo);
            }
            else if (value.IsMcpListTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPListTools), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPListTools?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPListTools).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListTools!, typeInfo);
            }
            else if (value.IsMcpApprovalRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPApprovalRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPApprovalRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPApprovalRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequest!, typeInfo);
            }
            else if (value.IsMcpApprovalResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPApprovalResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPApprovalResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPApprovalResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse!, typeInfo);
            }
            else if (value.IsMcpCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MCPToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MCPToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MCPToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall!, typeInfo);
            }
            else if (value.IsCustomToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CustomToolCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CustomToolCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CustomToolCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCallOutput!, typeInfo);
            }
            else if (value.IsCustomToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CustomToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CustomToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CustomToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCall!, typeInfo);
            }
        }
    }
}