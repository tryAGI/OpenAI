#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ResponsesServerEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ResponsesServerEvent Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            var __score5 = 0;
            var __score6 = 0;
            var __score7 = 0;
            var __score8 = 0;
            var __score9 = 0;
            var __score10 = 0;
            var __score11 = 0;
            var __score12 = 0;
            var __score13 = 0;
            var __score14 = 0;
            var __score15 = 0;
            var __score16 = 0;
            var __score17 = 0;
            var __score18 = 0;
            var __score19 = 0;
            var __score20 = 0;
            var __score21 = 0;
            var __score22 = 0;
            var __score23 = 0;
            var __score24 = 0;
            var __score25 = 0;
            var __score26 = 0;
            var __score27 = 0;
            var __score28 = 0;
            var __score29 = 0;
            var __score30 = 0;
            var __score31 = 0;
            var __score32 = 0;
            var __score33 = 0;
            var __score34 = 0;
            var __score35 = 0;
            var __score36 = 0;
            var __score37 = 0;
            var __score38 = 0;
            var __score39 = 0;
            var __score40 = 0;
            var __score41 = 0;
            var __score42 = 0;
            var __score43 = 0;
            var __score44 = 0;
            var __score45 = 0;
            var __score46 = 0;
            var __score47 = 0;
            var __score48 = 0;
            var __score49 = 0;
            var __score50 = 0;
            var __score51 = 0;
            var __score52 = 0;
            var __score53 = 0;
            var __score54 = 0;
            var __score55 = 0;
            var __score56 = 0;
            var __score57 = 0;
            var __score58 = 0;
            if (__jsonProps.Contains("error")) __score58++;
            if (__jsonProps.Contains("error.code")) __score58++;
            if (__jsonProps.Contains("error.headers")) __score58++;
            if (__jsonProps.Contains("error.message")) __score58++;
            if (__jsonProps.Contains("error.misalignment")) __score58++;
            if (__jsonProps.Contains("error.param")) __score58++;
            if (__jsonProps.Contains("error.type")) __score58++;
            if (__jsonProps.Contains("sequence_number")) __score58++;
            if (__jsonProps.Contains("status")) __score58++;
            if (__jsonProps.Contains("stream_id")) __score58++;
            if (__jsonProps.Contains("type")) __score58++;
            var __score59 = 0;
            if (__jsonProps.Contains("sequence_number")) __score59++;
            if (__jsonProps.Contains("steer")) __score59++;
            if (__jsonProps.Contains("steer.id")) __score59++;
            if (__jsonProps.Contains("steer.previous_response_id")) __score59++;
            if (__jsonProps.Contains("stream_id")) __score59++;
            if (__jsonProps.Contains("type")) __score59++;
            var __score60 = 0;
            if (__jsonProps.Contains("reason")) __score60++;
            if (__jsonProps.Contains("required_input")) __score60++;
            if (__jsonProps.Contains("sequence_number")) __score60++;
            if (__jsonProps.Contains("steer")) __score60++;
            if (__jsonProps.Contains("steer.id")) __score60++;
            if (__jsonProps.Contains("steer.previous_response_id")) __score60++;
            if (__jsonProps.Contains("stream_id")) __score60++;
            if (__jsonProps.Contains("type")) __score60++;
            var __score61 = 0;
            if (__jsonProps.Contains("error")) __score61++;
            if (__jsonProps.Contains("error.code")) __score61++;
            if (__jsonProps.Contains("error.message")) __score61++;
            if (__jsonProps.Contains("error.type")) __score61++;
            if (__jsonProps.Contains("sequence_number")) __score61++;
            if (__jsonProps.Contains("steer")) __score61++;
            if (__jsonProps.Contains("steer.id")) __score61++;
            if (__jsonProps.Contains("steer.input")) __score61++;
            if (__jsonProps.Contains("steer.previous_response_id")) __score61++;
            if (__jsonProps.Contains("stream_id")) __score61++;
            if (__jsonProps.Contains("type")) __score61++;
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
            if (__score26 > __bestScore) { __bestScore = __score26; __bestIndex = 26; }
            if (__score27 > __bestScore) { __bestScore = __score27; __bestIndex = 27; }
            if (__score28 > __bestScore) { __bestScore = __score28; __bestIndex = 28; }
            if (__score29 > __bestScore) { __bestScore = __score29; __bestIndex = 29; }
            if (__score30 > __bestScore) { __bestScore = __score30; __bestIndex = 30; }
            if (__score31 > __bestScore) { __bestScore = __score31; __bestIndex = 31; }
            if (__score32 > __bestScore) { __bestScore = __score32; __bestIndex = 32; }
            if (__score33 > __bestScore) { __bestScore = __score33; __bestIndex = 33; }
            if (__score34 > __bestScore) { __bestScore = __score34; __bestIndex = 34; }
            if (__score35 > __bestScore) { __bestScore = __score35; __bestIndex = 35; }
            if (__score36 > __bestScore) { __bestScore = __score36; __bestIndex = 36; }
            if (__score37 > __bestScore) { __bestScore = __score37; __bestIndex = 37; }
            if (__score38 > __bestScore) { __bestScore = __score38; __bestIndex = 38; }
            if (__score39 > __bestScore) { __bestScore = __score39; __bestIndex = 39; }
            if (__score40 > __bestScore) { __bestScore = __score40; __bestIndex = 40; }
            if (__score41 > __bestScore) { __bestScore = __score41; __bestIndex = 41; }
            if (__score42 > __bestScore) { __bestScore = __score42; __bestIndex = 42; }
            if (__score43 > __bestScore) { __bestScore = __score43; __bestIndex = 43; }
            if (__score44 > __bestScore) { __bestScore = __score44; __bestIndex = 44; }
            if (__score45 > __bestScore) { __bestScore = __score45; __bestIndex = 45; }
            if (__score46 > __bestScore) { __bestScore = __score46; __bestIndex = 46; }
            if (__score47 > __bestScore) { __bestScore = __score47; __bestIndex = 47; }
            if (__score48 > __bestScore) { __bestScore = __score48; __bestIndex = 48; }
            if (__score49 > __bestScore) { __bestScore = __score49; __bestIndex = 49; }
            if (__score50 > __bestScore) { __bestScore = __score50; __bestIndex = 50; }
            if (__score51 > __bestScore) { __bestScore = __score51; __bestIndex = 51; }
            if (__score52 > __bestScore) { __bestScore = __score52; __bestIndex = 52; }
            if (__score53 > __bestScore) { __bestScore = __score53; __bestIndex = 53; }
            if (__score54 > __bestScore) { __bestScore = __score54; __bestIndex = 54; }
            if (__score55 > __bestScore) { __bestScore = __score55; __bestIndex = 55; }
            if (__score56 > __bestScore) { __bestScore = __score56; __bestIndex = 56; }
            if (__score57 > __bestScore) { __bestScore = __score57; __bestIndex = 57; }
            if (__score58 > __bestScore) { __bestScore = __score58; __bestIndex = 58; }
            if (__score59 > __bestScore) { __bestScore = __score59; __bestIndex = 59; }
            if (__score60 > __bestScore) { __bestScore = __score60; __bestIndex = 60; }
            if (__score61 > __bestScore) { __bestScore = __score61; __bestIndex = 61; }

            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>? responseAudioWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>? responseAudioWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>? responseAudioTranscriptWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>? responseAudioTranscriptWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>? responseCodeInterpreterCallCodeWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>? responseCodeInterpreterCallCodeWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>? responseCodeInterpreterCallWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>? responseCodeInterpreterCallInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>? responseCodeInterpreterCallWsInterpreting = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>? responseCompactionWsCompacting = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>? responseWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>? responseContentPartWsAdded = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>? responseContentPartWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>? responseWsCreated = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>? responseFileSearchCallWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>? responseFileSearchCallInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>? responseFileSearchCallWsSearching = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>? responseFunctionCallArgumentsWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>? responseFunctionCallArgumentsWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>? responseShellCallCommandWsAdded = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>? responseShellCallCommandWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>? responseShellCallCommandWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>? responseShellCallOutputContentWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>? responseShellCallOutputContentWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>? responseInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>? responseWsFailed = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>? responseWsIncomplete = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>? responseOutputItemWsAdded = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>? responseOutputItemWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>? responseReasoningSummaryPartWsAdded = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>? responseReasoningSummaryPartWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>? responseReasoningSummaryTextWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>? responseReasoningSummaryTextWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>? responseReasoningTextWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>? responseReasoningTextWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>? responseRefusalWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>? responseRefusalWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>? responseTextWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>? responseTextWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>? responseWebSearchCallWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>? responseWebSearchCallInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>? responseWebSearchCallWsSearching = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>? responseImageGenCallWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>? responseImageGenCallWsGenerating = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>? responseImageGenCallInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>? responseImageGenCallPartialWsImage = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>? responseMcpCallArgumentsWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>? responseMcpCallArgumentsWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>? responseMcpCallWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>? responseMcpCallWsFailed = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>? responseMcpCallInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>? responseMcpListToolsWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>? responseMcpListToolsWsFailed = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>? responseMcpListToolsInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>? responseOutputTextAnnotationWsAdded = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>? responseWsQueued = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>? responseCustomToolCallInputWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>? responseCustomToolCallInputWsDone = default;
            global::tryAGI.OpenAI.ResponseWsError? error = default;
            global::tryAGI.OpenAI.ResponseSteerAcceptedEvent? responseSteerAccepted = default;
            global::tryAGI.OpenAI.ResponseSteerPendingEvent? responseSteerPending = default;
            global::tryAGI.OpenAI.ResponseSteerFailedEvent? responseSteerFailed = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>).Name}");
                        responseAudioWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>).Name}");
                        responseAudioWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>).Name}");
                        responseAudioTranscriptWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>).Name}");
                        responseAudioTranscriptWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>).Name}");
                        responseCodeInterpreterCallCodeWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>).Name}");
                        responseCodeInterpreterCallCodeWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>).Name}");
                        responseCodeInterpreterCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>).Name}");
                        responseCodeInterpreterCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>).Name}");
                        responseCodeInterpreterCallWsInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>).Name}");
                        responseCompactionWsCompacting = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>).Name}");
                        responseWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>).Name}");
                        responseContentPartWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>).Name}");
                        responseContentPartWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>).Name}");
                        responseWsCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>).Name}");
                        responseFileSearchCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>).Name}");
                        responseFileSearchCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>).Name}");
                        responseFileSearchCallWsSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>).Name}");
                        responseFunctionCallArgumentsWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>).Name}");
                        responseFunctionCallArgumentsWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>).Name}");
                        responseShellCallCommandWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>).Name}");
                        responseShellCallCommandWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>).Name}");
                        responseShellCallCommandWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>).Name}");
                        responseShellCallOutputContentWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>).Name}");
                        responseShellCallOutputContentWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>).Name}");
                        responseInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>).Name}");
                        responseWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 26)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>).Name}");
                        responseWsIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 27)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>).Name}");
                        responseOutputItemWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 28)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>).Name}");
                        responseOutputItemWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 29)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>).Name}");
                        responseReasoningSummaryPartWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 30)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>).Name}");
                        responseReasoningSummaryPartWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 31)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>).Name}");
                        responseReasoningSummaryTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 32)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>).Name}");
                        responseReasoningSummaryTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 33)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>).Name}");
                        responseReasoningTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 34)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>).Name}");
                        responseReasoningTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 35)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>).Name}");
                        responseRefusalWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 36)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>).Name}");
                        responseRefusalWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 37)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>).Name}");
                        responseTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 38)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>).Name}");
                        responseTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 39)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>).Name}");
                        responseWebSearchCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 40)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>).Name}");
                        responseWebSearchCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 41)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>).Name}");
                        responseWebSearchCallWsSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 42)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>).Name}");
                        responseImageGenCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 43)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>).Name}");
                        responseImageGenCallWsGenerating = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 44)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>).Name}");
                        responseImageGenCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 45)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>).Name}");
                        responseImageGenCallPartialWsImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 46)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>).Name}");
                        responseMcpCallArgumentsWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 47)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>).Name}");
                        responseMcpCallArgumentsWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 48)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>).Name}");
                        responseMcpCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 49)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>).Name}");
                        responseMcpCallWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 50)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>).Name}");
                        responseMcpCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 51)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>).Name}");
                        responseMcpListToolsWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 52)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>).Name}");
                        responseMcpListToolsWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 53)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>).Name}");
                        responseMcpListToolsInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 54)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>).Name}");
                        responseOutputTextAnnotationWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 55)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>).Name}");
                        responseWsQueued = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 56)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>).Name}");
                        responseCustomToolCallInputWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 57)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>).Name}");
                        responseCustomToolCallInputWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 58)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWsError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWsError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWsError).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 59)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerAcceptedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent).Name}");
                        responseSteerAccepted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 60)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerPendingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerPendingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerPendingEvent).Name}");
                        responseSteerPending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 61)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerFailedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerFailedEvent).Name}");
                        responseSteerFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>).Name}");
                    responseAudioWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>).Name}");
                    responseAudioWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>).Name}");
                    responseAudioTranscriptWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>).Name}");
                    responseAudioTranscriptWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>).Name}");
                    responseCodeInterpreterCallCodeWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>).Name}");
                    responseCodeInterpreterCallCodeWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>).Name}");
                    responseCodeInterpreterCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>).Name}");
                    responseCodeInterpreterCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>).Name}");
                    responseCodeInterpreterCallWsInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>).Name}");
                    responseCompactionWsCompacting = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>).Name}");
                    responseWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>).Name}");
                    responseContentPartWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>).Name}");
                    responseContentPartWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>).Name}");
                    responseWsCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>).Name}");
                    responseFileSearchCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>).Name}");
                    responseFileSearchCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>).Name}");
                    responseFileSearchCallWsSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>).Name}");
                    responseFunctionCallArgumentsWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>).Name}");
                    responseFunctionCallArgumentsWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>).Name}");
                    responseShellCallCommandWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>).Name}");
                    responseShellCallCommandWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>).Name}");
                    responseShellCallCommandWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>).Name}");
                    responseShellCallOutputContentWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>).Name}");
                    responseShellCallOutputContentWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>).Name}");
                    responseInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>).Name}");
                    responseWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>).Name}");
                    responseWsIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>).Name}");
                    responseOutputItemWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>).Name}");
                    responseOutputItemWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>).Name}");
                    responseReasoningSummaryPartWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>).Name}");
                    responseReasoningSummaryPartWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>).Name}");
                    responseReasoningSummaryTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>).Name}");
                    responseReasoningSummaryTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>).Name}");
                    responseReasoningTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>).Name}");
                    responseReasoningTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>).Name}");
                    responseRefusalWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>).Name}");
                    responseRefusalWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>).Name}");
                    responseTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>).Name}");
                    responseTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>).Name}");
                    responseWebSearchCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>).Name}");
                    responseWebSearchCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>).Name}");
                    responseWebSearchCallWsSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>).Name}");
                    responseImageGenCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>).Name}");
                    responseImageGenCallWsGenerating = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>).Name}");
                    responseImageGenCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>).Name}");
                    responseImageGenCallPartialWsImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>).Name}");
                    responseMcpCallArgumentsWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>).Name}");
                    responseMcpCallArgumentsWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>).Name}");
                    responseMcpCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>).Name}");
                    responseMcpCallWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>).Name}");
                    responseMcpCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>).Name}");
                    responseMcpListToolsWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>).Name}");
                    responseMcpListToolsWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>).Name}");
                    responseMcpListToolsInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>).Name}");
                    responseOutputTextAnnotationWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>).Name}");
                    responseWsQueued = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>).Name}");
                    responseCustomToolCallInputWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>).Name}");
                    responseCustomToolCallInputWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWsError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWsError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWsError).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerAcceptedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent).Name}");
                    responseSteerAccepted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerPendingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerPendingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerPendingEvent).Name}");
                    responseSteerPending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseAudioWsDelta == null && responseAudioWsDone == null && responseAudioTranscriptWsDelta == null && responseAudioTranscriptWsDone == null && responseCodeInterpreterCallCodeWsDelta == null && responseCodeInterpreterCallCodeWsDone == null && responseCodeInterpreterCallWsCompleted == null && responseCodeInterpreterCallInWsProgress == null && responseCodeInterpreterCallWsInterpreting == null && responseCompactionWsCompacting == null && responseWsCompleted == null && responseContentPartWsAdded == null && responseContentPartWsDone == null && responseWsCreated == null && responseFileSearchCallWsCompleted == null && responseFileSearchCallInWsProgress == null && responseFileSearchCallWsSearching == null && responseFunctionCallArgumentsWsDelta == null && responseFunctionCallArgumentsWsDone == null && responseShellCallCommandWsAdded == null && responseShellCallCommandWsDelta == null && responseShellCallCommandWsDone == null && responseShellCallOutputContentWsDelta == null && responseShellCallOutputContentWsDone == null && responseInWsProgress == null && responseWsFailed == null && responseWsIncomplete == null && responseOutputItemWsAdded == null && responseOutputItemWsDone == null && responseReasoningSummaryPartWsAdded == null && responseReasoningSummaryPartWsDone == null && responseReasoningSummaryTextWsDelta == null && responseReasoningSummaryTextWsDone == null && responseReasoningTextWsDelta == null && responseReasoningTextWsDone == null && responseRefusalWsDelta == null && responseRefusalWsDone == null && responseTextWsDelta == null && responseTextWsDone == null && responseWebSearchCallWsCompleted == null && responseWebSearchCallInWsProgress == null && responseWebSearchCallWsSearching == null && responseImageGenCallWsCompleted == null && responseImageGenCallWsGenerating == null && responseImageGenCallInWsProgress == null && responseImageGenCallPartialWsImage == null && responseMcpCallArgumentsWsDelta == null && responseMcpCallArgumentsWsDone == null && responseMcpCallWsCompleted == null && responseMcpCallWsFailed == null && responseMcpCallInWsProgress == null && responseMcpListToolsWsCompleted == null && responseMcpListToolsWsFailed == null && responseMcpListToolsInWsProgress == null && responseOutputTextAnnotationWsAdded == null && responseWsQueued == null && responseCustomToolCallInputWsDelta == null && responseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerFailedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerFailedEvent).Name}");
                    responseSteerFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ResponsesServerEvent(
                responseAudioWsDelta,

                responseAudioWsDone,

                responseAudioTranscriptWsDelta,

                responseAudioTranscriptWsDone,

                responseCodeInterpreterCallCodeWsDelta,

                responseCodeInterpreterCallCodeWsDone,

                responseCodeInterpreterCallWsCompleted,

                responseCodeInterpreterCallInWsProgress,

                responseCodeInterpreterCallWsInterpreting,

                responseCompactionWsCompacting,

                responseWsCompleted,

                responseContentPartWsAdded,

                responseContentPartWsDone,

                responseWsCreated,

                responseFileSearchCallWsCompleted,

                responseFileSearchCallInWsProgress,

                responseFileSearchCallWsSearching,

                responseFunctionCallArgumentsWsDelta,

                responseFunctionCallArgumentsWsDone,

                responseShellCallCommandWsAdded,

                responseShellCallCommandWsDelta,

                responseShellCallCommandWsDone,

                responseShellCallOutputContentWsDelta,

                responseShellCallOutputContentWsDone,

                responseInWsProgress,

                responseWsFailed,

                responseWsIncomplete,

                responseOutputItemWsAdded,

                responseOutputItemWsDone,

                responseReasoningSummaryPartWsAdded,

                responseReasoningSummaryPartWsDone,

                responseReasoningSummaryTextWsDelta,

                responseReasoningSummaryTextWsDone,

                responseReasoningTextWsDelta,

                responseReasoningTextWsDone,

                responseRefusalWsDelta,

                responseRefusalWsDone,

                responseTextWsDelta,

                responseTextWsDone,

                responseWebSearchCallWsCompleted,

                responseWebSearchCallInWsProgress,

                responseWebSearchCallWsSearching,

                responseImageGenCallWsCompleted,

                responseImageGenCallWsGenerating,

                responseImageGenCallInWsProgress,

                responseImageGenCallPartialWsImage,

                responseMcpCallArgumentsWsDelta,

                responseMcpCallArgumentsWsDone,

                responseMcpCallWsCompleted,

                responseMcpCallWsFailed,

                responseMcpCallInWsProgress,

                responseMcpListToolsWsCompleted,

                responseMcpListToolsWsFailed,

                responseMcpListToolsInWsProgress,

                responseOutputTextAnnotationWsAdded,

                responseWsQueued,

                responseCustomToolCallInputWsDelta,

                responseCustomToolCallInputWsDone,

                error,

                responseSteerAccepted,

                responseSteerPending,

                responseSteerFailed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ResponsesServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponseAudioWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseAudioWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseAudioTranscriptWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCodeWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCodeWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallCodeWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallWsCompleted!.Value, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInWsProgress!.Value, typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallWsInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCodeInterpreterCallWsInterpreting2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallWsInterpreting!.Value, typeInfo);
            }
            else if (value.IsResponseCompactionWsCompacting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCompactionWsCompacting2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCompactionWsCompacting!.Value, typeInfo);
            }
            else if (value.IsResponseWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWsCompleted!.Value, typeInfo);
            }
            else if (value.IsResponseContentPartWsAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsAdded2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartWsAdded!.Value, typeInfo);
            }
            else if (value.IsResponseContentPartWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseContentPartWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseWsCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsCreated2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWsCreated!.Value, typeInfo);
            }
            else if (value.IsResponseFileSearchCallWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallWsCompleted!.Value, typeInfo);
            }
            else if (value.IsResponseFileSearchCallInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallInWsProgress!.Value, typeInfo);
            }
            else if (value.IsResponseFileSearchCallWsSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFileSearchCallWsSearching2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallWsSearching!.Value, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseFunctionCallArgumentsWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseShellCallCommandWsAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsAdded2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseShellCallCommandWsAdded!.Value, typeInfo);
            }
            else if (value.IsResponseShellCallCommandWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseShellCallCommandWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseShellCallCommandWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallCommandWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseShellCallCommandWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseShellCallOutputContentWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseShellCallOutputContentWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseShellCallOutputContentWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseShellCallOutputContentWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseShellCallOutputContentWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseInWsProgress!.Value, typeInfo);
            }
            else if (value.IsResponseWsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsFailed2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWsFailed!.Value, typeInfo);
            }
            else if (value.IsResponseWsIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsIncomplete2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWsIncomplete!.Value, typeInfo);
            }
            else if (value.IsResponseOutputItemWsAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsAdded2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemWsAdded!.Value, typeInfo);
            }
            else if (value.IsResponseOutputItemWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputItemWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryPartWsAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsAdded2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryPartWsAdded!.Value, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryPartWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryPartWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryPartWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryTextWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryTextWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseReasoningSummaryTextWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningSummaryTextWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryTextWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseReasoningTextWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningTextWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseReasoningTextWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseReasoningTextWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningTextWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseRefusalWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseRefusalWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseRefusalWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseTextWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseTextWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseTextWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseWebSearchCallWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallWsCompleted!.Value, typeInfo);
            }
            else if (value.IsResponseWebSearchCallInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallInWsProgress!.Value, typeInfo);
            }
            else if (value.IsResponseWebSearchCallWsSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWebSearchCallWsSearching2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallWsSearching!.Value, typeInfo);
            }
            else if (value.IsResponseImageGenCallWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenCallWsCompleted!.Value, typeInfo);
            }
            else if (value.IsResponseImageGenCallWsGenerating)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallWsGenerating2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenCallWsGenerating!.Value, typeInfo);
            }
            else if (value.IsResponseImageGenCallInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenCallInWsProgress!.Value, typeInfo);
            }
            else if (value.IsResponseImageGenCallPartialWsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseImageGenCallPartialWsImage2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenCallPartialWsImage!.Value, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallArgumentsWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsWsDone!.Value, typeInfo);
            }
            else if (value.IsResponseMcpCallWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallWsCompleted!.Value, typeInfo);
            }
            else if (value.IsResponseMcpCallWsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallWsFailed2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallWsFailed!.Value, typeInfo);
            }
            else if (value.IsResponseMcpCallInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpCallInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallInWsProgress!.Value, typeInfo);
            }
            else if (value.IsResponseMcpListToolsWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsWsCompleted!.Value, typeInfo);
            }
            else if (value.IsResponseMcpListToolsWsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsWsFailed2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsWsFailed!.Value, typeInfo);
            }
            else if (value.IsResponseMcpListToolsInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseMcpListToolsInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsInWsProgress!.Value, typeInfo);
            }
            else if (value.IsResponseOutputTextAnnotationWsAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseOutputTextAnnotationWsAdded2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextAnnotationWsAdded!.Value, typeInfo);
            }
            else if (value.IsResponseWsQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseWsQueued2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWsQueued!.Value, typeInfo);
            }
            else if (value.IsResponseCustomToolCallInputWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCustomToolCallInputWsDelta!.Value, typeInfo);
            }
            else if (value.IsResponseCustomToolCallInputWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.ResponsesServerEventResponseCustomToolCallInputWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCustomToolCallInputWsDone!.Value, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWsError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWsError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWsError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsResponseSteerAccepted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerAcceptedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerAcceptedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseSteerAccepted!, typeInfo);
            }
            else if (value.IsResponseSteerPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerPendingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerPendingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerPendingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseSteerPending!, typeInfo);
            }
            else if (value.IsResponseSteerFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseSteerFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseSteerFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseSteerFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseSteerFailed!, typeInfo);
            }
        }
    }
}