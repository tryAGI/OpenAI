#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ConversationItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ConversationItem>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ConversationItem Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("phase")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("queries")) __score3++;
            if (__jsonProps.Contains("results")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("action")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("result")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("action")) __score6++;
            if (__jsonProps.Contains("actions")) __score6++;
            if (__jsonProps.Contains("call_id")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("pending_safety_checks")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            var __score8 = 0;
            if (__jsonProps.Contains("arguments")) __score8++;
            if (__jsonProps.Contains("call_id")) __score8++;
            if (__jsonProps.Contains("created_by")) __score8++;
            if (__jsonProps.Contains("execution")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("call_id")) __score9++;
            if (__jsonProps.Contains("created_by")) __score9++;
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
            if (__jsonProps.Contains("created_by")) __score11++;
            if (__jsonProps.Contains("encrypted_content")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("code")) __score12++;
            if (__jsonProps.Contains("container_id")) __score12++;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("outputs")) __score12++;
            if (__jsonProps.Contains("status")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("action")) __score13++;
            if (__jsonProps.Contains("call_id")) __score13++;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("status")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("id")) __score14++;
            if (__jsonProps.Contains("output")) __score14++;
            if (__jsonProps.Contains("status")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("action")) __score15++;
            if (__jsonProps.Contains("call_id")) __score15++;
            if (__jsonProps.Contains("created_by")) __score15++;
            if (__jsonProps.Contains("environment")) __score15++;
            if (__jsonProps.Contains("id")) __score15++;
            if (__jsonProps.Contains("status")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("call_id")) __score16++;
            if (__jsonProps.Contains("created_by")) __score16++;
            if (__jsonProps.Contains("id")) __score16++;
            if (__jsonProps.Contains("max_output_length")) __score16++;
            if (__jsonProps.Contains("output")) __score16++;
            if (__jsonProps.Contains("status")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("call_id")) __score17++;
            if (__jsonProps.Contains("created_by")) __score17++;
            if (__jsonProps.Contains("id")) __score17++;
            if (__jsonProps.Contains("operation")) __score17++;
            if (__jsonProps.Contains("status")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("call_id")) __score18++;
            if (__jsonProps.Contains("created_by")) __score18++;
            if (__jsonProps.Contains("id")) __score18++;
            if (__jsonProps.Contains("output")) __score18++;
            if (__jsonProps.Contains("status")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("error")) __score19++;
            if (__jsonProps.Contains("id")) __score19++;
            if (__jsonProps.Contains("server_label")) __score19++;
            if (__jsonProps.Contains("tools")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("arguments")) __score20++;
            if (__jsonProps.Contains("id")) __score20++;
            if (__jsonProps.Contains("name")) __score20++;
            if (__jsonProps.Contains("server_label")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("approval_request_id")) __score21++;
            if (__jsonProps.Contains("approve")) __score21++;
            if (__jsonProps.Contains("id")) __score21++;
            if (__jsonProps.Contains("reason")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("approval_request_id")) __score22++;
            if (__jsonProps.Contains("arguments")) __score22++;
            if (__jsonProps.Contains("error")) __score22++;
            if (__jsonProps.Contains("id")) __score22++;
            if (__jsonProps.Contains("name")) __score22++;
            if (__jsonProps.Contains("output")) __score22++;
            if (__jsonProps.Contains("server_label")) __score22++;
            if (__jsonProps.Contains("status")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("call_id")) __score23++;
            if (__jsonProps.Contains("id")) __score23++;
            if (__jsonProps.Contains("input")) __score23++;
            if (__jsonProps.Contains("name")) __score23++;
            if (__jsonProps.Contains("namespace")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("call_id")) __score24++;
            if (__jsonProps.Contains("id")) __score24++;
            if (__jsonProps.Contains("output")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
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

            global::tryAGI.OpenAI.Message? message = default;
            global::tryAGI.OpenAI.FunctionToolCallResource? functionToolCallResource = default;
            global::tryAGI.OpenAI.FunctionToolCallOutputResource? functionToolCallOutputResource = default;
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchCall = default;
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchCall = default;
            global::tryAGI.OpenAI.ImageGenToolCall? imageGenerationCall = default;
            global::tryAGI.OpenAI.ComputerToolCall? computerCall = default;
            global::tryAGI.OpenAI.ComputerToolCallOutputResource? computerToolCallOutputResource = default;
            global::tryAGI.OpenAI.ToolSearchCall? toolSearchCall = default;
            global::tryAGI.OpenAI.ToolSearchOutput? toolSearchOutput = default;
            global::tryAGI.OpenAI.ReasoningItem? reasoning = default;
            global::tryAGI.OpenAI.CompactionBody? compaction = default;
            global::tryAGI.OpenAI.CodeInterpreterToolCall? codeInterpreterCall = default;
            global::tryAGI.OpenAI.LocalShellToolCall? localShellCall = default;
            global::tryAGI.OpenAI.LocalShellToolCallOutput? localShellCallOutput = default;
            global::tryAGI.OpenAI.FunctionShellCall? shellCall = default;
            global::tryAGI.OpenAI.FunctionShellCallOutput? shellCallOutput = default;
            global::tryAGI.OpenAI.ApplyPatchToolCall? applyPatchCall = default;
            global::tryAGI.OpenAI.ApplyPatchToolCallOutput? applyPatchCallOutput = default;
            global::tryAGI.OpenAI.MCPListTools? mcpListTools = default;
            global::tryAGI.OpenAI.MCPApprovalRequest? mcpApprovalRequest = default;
            global::tryAGI.OpenAI.MCPApprovalResponseResource? mcpApprovalResponse = default;
            global::tryAGI.OpenAI.MCPToolCall? mcpCall = default;
            global::tryAGI.OpenAI.CustomToolCall? customToolCall = default;
            global::tryAGI.OpenAI.CustomToolCallOutput? customToolCallOutput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        message = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.Message>(__rawJson, options);
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
                        functionToolCallResource = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionToolCallResource>(__rawJson, options);
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
                        functionToolCallOutputResource = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionToolCallOutputResource>(__rawJson, options);
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
                        fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FileSearchToolCall>(__rawJson, options);
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
                        webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchToolCall>(__rawJson, options);
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
                        imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ImageGenToolCall>(__rawJson, options);
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
                        computerCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerToolCall>(__rawJson, options);
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
                        computerToolCallOutputResource = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerToolCallOutputResource>(__rawJson, options);
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
                        toolSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolSearchCall>(__rawJson, options);
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
                        toolSearchOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolSearchOutput>(__rawJson, options);
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
                        reasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ReasoningItem>(__rawJson, options);
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
                        compaction = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CompactionBody>(__rawJson, options);
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
                        codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CodeInterpreterToolCall>(__rawJson, options);
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
                        localShellCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.LocalShellToolCall>(__rawJson, options);
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
                        localShellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.LocalShellToolCallOutput>(__rawJson, options);
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
                        shellCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionShellCall>(__rawJson, options);
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
                        shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionShellCallOutput>(__rawJson, options);
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
                        applyPatchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchToolCall>(__rawJson, options);
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
                        applyPatchCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchToolCallOutput>(__rawJson, options);
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
                        mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.MCPListTools>(__rawJson, options);
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
                        mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.MCPApprovalRequest>(__rawJson, options);
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
                        mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.MCPApprovalResponseResource>(__rawJson, options);
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
                        mcpCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.MCPToolCall>(__rawJson, options);
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
                        customToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CustomToolCall>(__rawJson, options);
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
                        customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CustomToolCallOutput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (message == null && functionToolCallResource == null && functionToolCallOutputResource == null && fileSearchCall == null && webSearchCall == null && imageGenerationCall == null && computerCall == null && computerToolCallOutputResource == null && toolSearchCall == null && toolSearchOutput == null && reasoning == null && compaction == null && codeInterpreterCall == null && localShellCall == null && localShellCallOutput == null && shellCall == null && shellCallOutput == null && applyPatchCall == null && applyPatchCallOutput == null && mcpListTools == null && mcpApprovalRequest == null && mcpApprovalResponse == null && mcpCall == null && customToolCall == null && customToolCallOutput == null)
            {
                try
                {
                    message = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.Message>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionToolCallResource = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionToolCallResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    functionToolCallOutputResource = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionToolCallOutputResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FileSearchToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.WebSearchToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ImageGenToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computerToolCallOutputResource = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ComputerToolCallOutputResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolSearchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolSearchCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolSearchOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ToolSearchOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    reasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ReasoningItem>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    compaction = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CompactionBody>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CodeInterpreterToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    localShellCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.LocalShellToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    localShellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.LocalShellToolCallOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    shellCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionShellCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.FunctionShellCallOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    applyPatchCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    applyPatchCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ApplyPatchToolCallOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpListTools = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.MCPListTools>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.MCPApprovalRequest>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpApprovalResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.MCPApprovalResponseResource>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mcpCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.MCPToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    customToolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CustomToolCall>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.CustomToolCallOutput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ConversationItem(
                message,

                functionToolCallResource,

                functionToolCallOutputResource,

                fileSearchCall,

                webSearchCall,

                imageGenerationCall,

                computerCall,

                computerToolCallOutputResource,

                toolSearchCall,

                toolSearchOutput,

                reasoning,

                compaction,

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

                customToolCall,

                customToolCallOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ConversationItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeof(global::tryAGI.OpenAI.Message), options);
            }
            else if (value.IsFunctionToolCallResource)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCallResource, typeof(global::tryAGI.OpenAI.FunctionToolCallResource), options);
            }
            else if (value.IsFunctionToolCallOutputResource)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCallOutputResource, typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResource), options);
            }
            else if (value.IsFileSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall, typeof(global::tryAGI.OpenAI.FileSearchToolCall), options);
            }
            else if (value.IsWebSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall, typeof(global::tryAGI.OpenAI.WebSearchToolCall), options);
            }
            else if (value.IsImageGenerationCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationCall, typeof(global::tryAGI.OpenAI.ImageGenToolCall), options);
            }
            else if (value.IsComputerCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall, typeof(global::tryAGI.OpenAI.ComputerToolCall), options);
            }
            else if (value.IsComputerToolCallOutputResource)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCallOutputResource, typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResource), options);
            }
            else if (value.IsToolSearchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchCall, typeof(global::tryAGI.OpenAI.ToolSearchCall), options);
            }
            else if (value.IsToolSearchOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchOutput, typeof(global::tryAGI.OpenAI.ToolSearchOutput), options);
            }
            else if (value.IsReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning, typeof(global::tryAGI.OpenAI.ReasoningItem), options);
            }
            else if (value.IsCompaction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction, typeof(global::tryAGI.OpenAI.CompactionBody), options);
            }
            else if (value.IsCodeInterpreterCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCall, typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall), options);
            }
            else if (value.IsLocalShellCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShellCall, typeof(global::tryAGI.OpenAI.LocalShellToolCall), options);
            }
            else if (value.IsLocalShellCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShellCallOutput, typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput), options);
            }
            else if (value.IsShellCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCall, typeof(global::tryAGI.OpenAI.FunctionShellCall), options);
            }
            else if (value.IsShellCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCallOutput, typeof(global::tryAGI.OpenAI.FunctionShellCallOutput), options);
            }
            else if (value.IsApplyPatchCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCall, typeof(global::tryAGI.OpenAI.ApplyPatchToolCall), options);
            }
            else if (value.IsApplyPatchCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCallOutput, typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutput), options);
            }
            else if (value.IsMcpListTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListTools, typeof(global::tryAGI.OpenAI.MCPListTools), options);
            }
            else if (value.IsMcpApprovalRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequest, typeof(global::tryAGI.OpenAI.MCPApprovalRequest), options);
            }
            else if (value.IsMcpApprovalResponse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponse, typeof(global::tryAGI.OpenAI.MCPApprovalResponseResource), options);
            }
            else if (value.IsMcpCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCall, typeof(global::tryAGI.OpenAI.MCPToolCall), options);
            }
            else if (value.IsCustomToolCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCall, typeof(global::tryAGI.OpenAI.CustomToolCall), options);
            }
            else if (value.IsCustomToolCallOutput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCallOutput, typeof(global::tryAGI.OpenAI.CustomToolCallOutput), options);
            }
        }
    }
}