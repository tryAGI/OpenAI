#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class BetaResponsesServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.BetaResponsesServerEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.BetaResponsesServerEvent Read(
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
            if (__jsonProps.Contains("agent")) __score58++;
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
            var __score62 = 0;
            if (__jsonProps.Contains("response_id")) __score62++;
            if (__jsonProps.Contains("sequence_number")) __score62++;
            if (__jsonProps.Contains("stream_id")) __score62++;
            if (__jsonProps.Contains("type")) __score62++;
            var __score63 = 0;
            if (__jsonProps.Contains("error")) __score63++;
            if (__jsonProps.Contains("error.code")) __score63++;
            if (__jsonProps.Contains("error.message")) __score63++;
            if (__jsonProps.Contains("input")) __score63++;
            if (__jsonProps.Contains("response_id")) __score63++;
            if (__jsonProps.Contains("sequence_number")) __score63++;
            if (__jsonProps.Contains("stream_id")) __score63++;
            if (__jsonProps.Contains("type")) __score63++;
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
            if (__score62 > __bestScore) { __bestScore = __score62; __bestIndex = 62; }
            if (__score63 > __bestScore) { __bestScore = __score63; __bestIndex = 63; }

            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>? betaResponseAudioWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>? betaResponseAudioWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>? betaResponseAudioTranscriptWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>? betaResponseAudioTranscriptWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>? betaResponseCodeInterpreterCallCodeWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>? betaResponseCodeInterpreterCallCodeWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>? betaResponseCodeInterpreterCallWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>? betaResponseCodeInterpreterCallInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>? betaResponseCodeInterpreterCallWsInterpreting = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>? betaResponseCompactionWsCompacting = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>? betaResponseWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>? betaResponseContentPartWsAdded = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>? betaResponseContentPartWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>? betaResponseWsCreated = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>? betaResponseFileSearchCallWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>? betaResponseFileSearchCallInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>? betaResponseFileSearchCallWsSearching = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>? betaResponseFunctionCallArgumentsWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>? betaResponseFunctionCallArgumentsWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>? betaResponseShellCallCommandWsAdded = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>? betaResponseShellCallCommandWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>? betaResponseShellCallCommandWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>? betaResponseShellCallOutputContentWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>? betaResponseShellCallOutputContentWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>? betaResponseInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>? betaResponseWsFailed = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>? betaResponseWsIncomplete = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>? betaResponseOutputItemWsAdded = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>? betaResponseOutputItemWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>? betaResponseReasoningSummaryPartWsAdded = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>? betaResponseReasoningSummaryPartWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>? betaResponseReasoningSummaryTextWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>? betaResponseReasoningSummaryTextWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>? betaResponseReasoningTextWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>? betaResponseReasoningTextWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>? betaResponseRefusalWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>? betaResponseRefusalWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>? betaResponseTextWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>? betaResponseTextWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>? betaResponseWebSearchCallWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>? betaResponseWebSearchCallInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>? betaResponseWebSearchCallWsSearching = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>? betaResponseImageGenCallWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>? betaResponseImageGenCallWsGenerating = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>? betaResponseImageGenCallInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>? betaResponseImageGenCallPartialWsImage = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>? betaResponseMcpCallArgumentsWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>? betaResponseMcpCallArgumentsWsDone = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>? betaResponseMcpCallWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>? betaResponseMcpCallWsFailed = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>? betaResponseMcpCallInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>? betaResponseMcpListToolsWsCompleted = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>? betaResponseMcpListToolsWsFailed = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>? betaResponseMcpListToolsInWsProgress = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>? betaResponseOutputTextAnnotationWsAdded = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>? betaResponseWsQueued = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>? betaResponseCustomToolCallInputWsDelta = default;
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>? betaResponseCustomToolCallInputWsDone = default;
            global::tryAGI.OpenAI.BetaResponseWsError? error = default;
            global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent? responseSteerAccepted = default;
            global::tryAGI.OpenAI.BetaResponseSteerPendingEvent? responseSteerPending = default;
            global::tryAGI.OpenAI.BetaResponseSteerFailedEvent? responseSteerFailed = default;
            global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? responseInjectCreated = default;
            global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? responseInjectFailed = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>).Name}");
                        betaResponseAudioWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>).Name}");
                        betaResponseAudioWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>).Name}");
                        betaResponseAudioTranscriptWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>).Name}");
                        betaResponseAudioTranscriptWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>).Name}");
                        betaResponseCodeInterpreterCallCodeWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>).Name}");
                        betaResponseCodeInterpreterCallCodeWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>).Name}");
                        betaResponseCodeInterpreterCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>).Name}");
                        betaResponseCodeInterpreterCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>).Name}");
                        betaResponseCodeInterpreterCallWsInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>).Name}");
                        betaResponseCompactionWsCompacting = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>).Name}");
                        betaResponseWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>).Name}");
                        betaResponseContentPartWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>).Name}");
                        betaResponseContentPartWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>).Name}");
                        betaResponseWsCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>).Name}");
                        betaResponseFileSearchCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>).Name}");
                        betaResponseFileSearchCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>).Name}");
                        betaResponseFileSearchCallWsSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>).Name}");
                        betaResponseFunctionCallArgumentsWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>).Name}");
                        betaResponseFunctionCallArgumentsWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>).Name}");
                        betaResponseShellCallCommandWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>).Name}");
                        betaResponseShellCallCommandWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>).Name}");
                        betaResponseShellCallCommandWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>).Name}");
                        betaResponseShellCallOutputContentWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>).Name}");
                        betaResponseShellCallOutputContentWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>).Name}");
                        betaResponseInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>).Name}");
                        betaResponseWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>).Name}");
                        betaResponseWsIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>).Name}");
                        betaResponseOutputItemWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>).Name}");
                        betaResponseOutputItemWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>).Name}");
                        betaResponseReasoningSummaryPartWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>).Name}");
                        betaResponseReasoningSummaryPartWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>).Name}");
                        betaResponseReasoningSummaryTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>).Name}");
                        betaResponseReasoningSummaryTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>).Name}");
                        betaResponseReasoningTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>).Name}");
                        betaResponseReasoningTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>).Name}");
                        betaResponseRefusalWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>).Name}");
                        betaResponseRefusalWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>).Name}");
                        betaResponseTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>).Name}");
                        betaResponseTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>).Name}");
                        betaResponseWebSearchCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>).Name}");
                        betaResponseWebSearchCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>).Name}");
                        betaResponseWebSearchCallWsSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>).Name}");
                        betaResponseImageGenCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>).Name}");
                        betaResponseImageGenCallWsGenerating = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>).Name}");
                        betaResponseImageGenCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>).Name}");
                        betaResponseImageGenCallPartialWsImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>).Name}");
                        betaResponseMcpCallArgumentsWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>).Name}");
                        betaResponseMcpCallArgumentsWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>).Name}");
                        betaResponseMcpCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>).Name}");
                        betaResponseMcpCallWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>).Name}");
                        betaResponseMcpCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>).Name}");
                        betaResponseMcpListToolsWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>).Name}");
                        betaResponseMcpListToolsWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>).Name}");
                        betaResponseMcpListToolsInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>).Name}");
                        betaResponseOutputTextAnnotationWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>).Name}");
                        betaResponseWsQueued = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>).Name}");
                        betaResponseCustomToolCallInputWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>).Name}");
                        betaResponseCustomToolCallInputWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseWsError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseWsError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseWsError).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerPendingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerFailedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent).Name}");
                        responseSteerFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 62)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent).Name}");
                        responseInjectCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 63)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent).Name}");
                        responseInjectFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>).Name}");
                    betaResponseAudioWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>).Name}");
                    betaResponseAudioWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>).Name}");
                    betaResponseAudioTranscriptWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>).Name}");
                    betaResponseAudioTranscriptWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>).Name}");
                    betaResponseCodeInterpreterCallCodeWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>).Name}");
                    betaResponseCodeInterpreterCallCodeWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>).Name}");
                    betaResponseCodeInterpreterCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>).Name}");
                    betaResponseCodeInterpreterCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>).Name}");
                    betaResponseCodeInterpreterCallWsInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>).Name}");
                    betaResponseCompactionWsCompacting = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>).Name}");
                    betaResponseWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>).Name}");
                    betaResponseContentPartWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>).Name}");
                    betaResponseContentPartWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>).Name}");
                    betaResponseWsCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>).Name}");
                    betaResponseFileSearchCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>).Name}");
                    betaResponseFileSearchCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>).Name}");
                    betaResponseFileSearchCallWsSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>).Name}");
                    betaResponseFunctionCallArgumentsWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>).Name}");
                    betaResponseFunctionCallArgumentsWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>).Name}");
                    betaResponseShellCallCommandWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>).Name}");
                    betaResponseShellCallCommandWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>).Name}");
                    betaResponseShellCallCommandWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>).Name}");
                    betaResponseShellCallOutputContentWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>).Name}");
                    betaResponseShellCallOutputContentWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>).Name}");
                    betaResponseInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>).Name}");
                    betaResponseWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>).Name}");
                    betaResponseWsIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>).Name}");
                    betaResponseOutputItemWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>).Name}");
                    betaResponseOutputItemWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>).Name}");
                    betaResponseReasoningSummaryPartWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>).Name}");
                    betaResponseReasoningSummaryPartWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>).Name}");
                    betaResponseReasoningSummaryTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>).Name}");
                    betaResponseReasoningSummaryTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>).Name}");
                    betaResponseReasoningTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>).Name}");
                    betaResponseReasoningTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>).Name}");
                    betaResponseRefusalWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>).Name}");
                    betaResponseRefusalWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>).Name}");
                    betaResponseTextWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>).Name}");
                    betaResponseTextWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>).Name}");
                    betaResponseWebSearchCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>).Name}");
                    betaResponseWebSearchCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>).Name}");
                    betaResponseWebSearchCallWsSearching = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>).Name}");
                    betaResponseImageGenCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>).Name}");
                    betaResponseImageGenCallWsGenerating = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>).Name}");
                    betaResponseImageGenCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>).Name}");
                    betaResponseImageGenCallPartialWsImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>).Name}");
                    betaResponseMcpCallArgumentsWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>).Name}");
                    betaResponseMcpCallArgumentsWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>).Name}");
                    betaResponseMcpCallWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>).Name}");
                    betaResponseMcpCallWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>).Name}");
                    betaResponseMcpCallInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>).Name}");
                    betaResponseMcpListToolsWsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>).Name}");
                    betaResponseMcpListToolsWsFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>).Name}");
                    betaResponseMcpListToolsInWsProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>).Name}");
                    betaResponseOutputTextAnnotationWsAdded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>).Name}");
                    betaResponseWsQueued = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>).Name}");
                    betaResponseCustomToolCallInputWsDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>).Name}");
                    betaResponseCustomToolCallInputWsDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseWsError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseWsError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseWsError).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent).Name}");
                    responseSteerAccepted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerPendingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent).Name}");
                    responseSteerPending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerFailedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent).Name}");
                    responseSteerFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent).Name}");
                    responseInjectCreated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (betaResponseAudioWsDelta == null && betaResponseAudioWsDone == null && betaResponseAudioTranscriptWsDelta == null && betaResponseAudioTranscriptWsDone == null && betaResponseCodeInterpreterCallCodeWsDelta == null && betaResponseCodeInterpreterCallCodeWsDone == null && betaResponseCodeInterpreterCallWsCompleted == null && betaResponseCodeInterpreterCallInWsProgress == null && betaResponseCodeInterpreterCallWsInterpreting == null && betaResponseCompactionWsCompacting == null && betaResponseWsCompleted == null && betaResponseContentPartWsAdded == null && betaResponseContentPartWsDone == null && betaResponseWsCreated == null && betaResponseFileSearchCallWsCompleted == null && betaResponseFileSearchCallInWsProgress == null && betaResponseFileSearchCallWsSearching == null && betaResponseFunctionCallArgumentsWsDelta == null && betaResponseFunctionCallArgumentsWsDone == null && betaResponseShellCallCommandWsAdded == null && betaResponseShellCallCommandWsDelta == null && betaResponseShellCallCommandWsDone == null && betaResponseShellCallOutputContentWsDelta == null && betaResponseShellCallOutputContentWsDone == null && betaResponseInWsProgress == null && betaResponseWsFailed == null && betaResponseWsIncomplete == null && betaResponseOutputItemWsAdded == null && betaResponseOutputItemWsDone == null && betaResponseReasoningSummaryPartWsAdded == null && betaResponseReasoningSummaryPartWsDone == null && betaResponseReasoningSummaryTextWsDelta == null && betaResponseReasoningSummaryTextWsDone == null && betaResponseReasoningTextWsDelta == null && betaResponseReasoningTextWsDone == null && betaResponseRefusalWsDelta == null && betaResponseRefusalWsDone == null && betaResponseTextWsDelta == null && betaResponseTextWsDone == null && betaResponseWebSearchCallWsCompleted == null && betaResponseWebSearchCallInWsProgress == null && betaResponseWebSearchCallWsSearching == null && betaResponseImageGenCallWsCompleted == null && betaResponseImageGenCallWsGenerating == null && betaResponseImageGenCallInWsProgress == null && betaResponseImageGenCallPartialWsImage == null && betaResponseMcpCallArgumentsWsDelta == null && betaResponseMcpCallArgumentsWsDone == null && betaResponseMcpCallWsCompleted == null && betaResponseMcpCallWsFailed == null && betaResponseMcpCallInWsProgress == null && betaResponseMcpListToolsWsCompleted == null && betaResponseMcpListToolsWsFailed == null && betaResponseMcpListToolsInWsProgress == null && betaResponseOutputTextAnnotationWsAdded == null && betaResponseWsQueued == null && betaResponseCustomToolCallInputWsDelta == null && betaResponseCustomToolCallInputWsDone == null && error == null && responseSteerAccepted == null && responseSteerPending == null && responseSteerFailed == null && responseInjectCreated == null && responseInjectFailed == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent).Name}");
                    responseInjectFailed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.BetaResponsesServerEvent(
                betaResponseAudioWsDelta,

                betaResponseAudioWsDone,

                betaResponseAudioTranscriptWsDelta,

                betaResponseAudioTranscriptWsDone,

                betaResponseCodeInterpreterCallCodeWsDelta,

                betaResponseCodeInterpreterCallCodeWsDone,

                betaResponseCodeInterpreterCallWsCompleted,

                betaResponseCodeInterpreterCallInWsProgress,

                betaResponseCodeInterpreterCallWsInterpreting,

                betaResponseCompactionWsCompacting,

                betaResponseWsCompleted,

                betaResponseContentPartWsAdded,

                betaResponseContentPartWsDone,

                betaResponseWsCreated,

                betaResponseFileSearchCallWsCompleted,

                betaResponseFileSearchCallInWsProgress,

                betaResponseFileSearchCallWsSearching,

                betaResponseFunctionCallArgumentsWsDelta,

                betaResponseFunctionCallArgumentsWsDone,

                betaResponseShellCallCommandWsAdded,

                betaResponseShellCallCommandWsDelta,

                betaResponseShellCallCommandWsDone,

                betaResponseShellCallOutputContentWsDelta,

                betaResponseShellCallOutputContentWsDone,

                betaResponseInWsProgress,

                betaResponseWsFailed,

                betaResponseWsIncomplete,

                betaResponseOutputItemWsAdded,

                betaResponseOutputItemWsDone,

                betaResponseReasoningSummaryPartWsAdded,

                betaResponseReasoningSummaryPartWsDone,

                betaResponseReasoningSummaryTextWsDelta,

                betaResponseReasoningSummaryTextWsDone,

                betaResponseReasoningTextWsDelta,

                betaResponseReasoningTextWsDone,

                betaResponseRefusalWsDelta,

                betaResponseRefusalWsDone,

                betaResponseTextWsDelta,

                betaResponseTextWsDone,

                betaResponseWebSearchCallWsCompleted,

                betaResponseWebSearchCallInWsProgress,

                betaResponseWebSearchCallWsSearching,

                betaResponseImageGenCallWsCompleted,

                betaResponseImageGenCallWsGenerating,

                betaResponseImageGenCallInWsProgress,

                betaResponseImageGenCallPartialWsImage,

                betaResponseMcpCallArgumentsWsDelta,

                betaResponseMcpCallArgumentsWsDone,

                betaResponseMcpCallWsCompleted,

                betaResponseMcpCallWsFailed,

                betaResponseMcpCallInWsProgress,

                betaResponseMcpListToolsWsCompleted,

                betaResponseMcpListToolsWsFailed,

                betaResponseMcpListToolsInWsProgress,

                betaResponseOutputTextAnnotationWsAdded,

                betaResponseWsQueued,

                betaResponseCustomToolCallInputWsDelta,

                betaResponseCustomToolCallInputWsDone,

                error,

                responseSteerAccepted,

                responseSteerPending,

                responseSteerFailed,

                responseInjectCreated,

                responseInjectFailed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.BetaResponsesServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBetaResponseAudioWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseAudioWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseAudioWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseAudioWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseAudioTranscriptWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseAudioTranscriptWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseAudioTranscriptWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseAudioTranscriptWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseAudioTranscriptWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseCodeInterpreterCallCodeWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseCodeInterpreterCallCodeWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseCodeInterpreterCallCodeWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallCodeWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseCodeInterpreterCallCodeWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseCodeInterpreterCallWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseCodeInterpreterCallWsCompleted!.Value, typeInfo);
            }
            else if (value.IsBetaResponseCodeInterpreterCallInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseCodeInterpreterCallInWsProgress!.Value, typeInfo);
            }
            else if (value.IsBetaResponseCodeInterpreterCallWsInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCodeInterpreterCallWsInterpreting2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseCodeInterpreterCallWsInterpreting!.Value, typeInfo);
            }
            else if (value.IsBetaResponseCompactionWsCompacting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCompactionWsCompacting2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseCompactionWsCompacting!.Value, typeInfo);
            }
            else if (value.IsBetaResponseWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseWsCompleted!.Value, typeInfo);
            }
            else if (value.IsBetaResponseContentPartWsAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsAdded2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseContentPartWsAdded!.Value, typeInfo);
            }
            else if (value.IsBetaResponseContentPartWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseContentPartWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseContentPartWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseWsCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsCreated2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseWsCreated!.Value, typeInfo);
            }
            else if (value.IsBetaResponseFileSearchCallWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseFileSearchCallWsCompleted!.Value, typeInfo);
            }
            else if (value.IsBetaResponseFileSearchCallInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseFileSearchCallInWsProgress!.Value, typeInfo);
            }
            else if (value.IsBetaResponseFileSearchCallWsSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFileSearchCallWsSearching2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseFileSearchCallWsSearching!.Value, typeInfo);
            }
            else if (value.IsBetaResponseFunctionCallArgumentsWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseFunctionCallArgumentsWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseFunctionCallArgumentsWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseFunctionCallArgumentsWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseFunctionCallArgumentsWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseShellCallCommandWsAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsAdded2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseShellCallCommandWsAdded!.Value, typeInfo);
            }
            else if (value.IsBetaResponseShellCallCommandWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseShellCallCommandWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseShellCallCommandWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallCommandWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseShellCallCommandWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseShellCallOutputContentWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseShellCallOutputContentWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseShellCallOutputContentWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseShellCallOutputContentWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseShellCallOutputContentWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseInWsProgress!.Value, typeInfo);
            }
            else if (value.IsBetaResponseWsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsFailed2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseWsFailed!.Value, typeInfo);
            }
            else if (value.IsBetaResponseWsIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsIncomplete2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseWsIncomplete!.Value, typeInfo);
            }
            else if (value.IsBetaResponseOutputItemWsAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsAdded2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseOutputItemWsAdded!.Value, typeInfo);
            }
            else if (value.IsBetaResponseOutputItemWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputItemWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseOutputItemWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseReasoningSummaryPartWsAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsAdded2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseReasoningSummaryPartWsAdded!.Value, typeInfo);
            }
            else if (value.IsBetaResponseReasoningSummaryPartWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryPartWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseReasoningSummaryPartWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseReasoningSummaryTextWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseReasoningSummaryTextWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseReasoningSummaryTextWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningSummaryTextWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseReasoningSummaryTextWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseReasoningTextWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseReasoningTextWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseReasoningTextWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseReasoningTextWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseReasoningTextWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseRefusalWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseRefusalWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseRefusalWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseRefusalWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseRefusalWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseTextWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseTextWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseTextWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseTextWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseTextWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseWebSearchCallWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseWebSearchCallWsCompleted!.Value, typeInfo);
            }
            else if (value.IsBetaResponseWebSearchCallInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseWebSearchCallInWsProgress!.Value, typeInfo);
            }
            else if (value.IsBetaResponseWebSearchCallWsSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWebSearchCallWsSearching2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseWebSearchCallWsSearching!.Value, typeInfo);
            }
            else if (value.IsBetaResponseImageGenCallWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseImageGenCallWsCompleted!.Value, typeInfo);
            }
            else if (value.IsBetaResponseImageGenCallWsGenerating)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallWsGenerating2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseImageGenCallWsGenerating!.Value, typeInfo);
            }
            else if (value.IsBetaResponseImageGenCallInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseImageGenCallInWsProgress!.Value, typeInfo);
            }
            else if (value.IsBetaResponseImageGenCallPartialWsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseImageGenCallPartialWsImage2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseImageGenCallPartialWsImage!.Value, typeInfo);
            }
            else if (value.IsBetaResponseMcpCallArgumentsWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseMcpCallArgumentsWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseMcpCallArgumentsWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallArgumentsWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseMcpCallArgumentsWsDone!.Value, typeInfo);
            }
            else if (value.IsBetaResponseMcpCallWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseMcpCallWsCompleted!.Value, typeInfo);
            }
            else if (value.IsBetaResponseMcpCallWsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallWsFailed2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseMcpCallWsFailed!.Value, typeInfo);
            }
            else if (value.IsBetaResponseMcpCallInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpCallInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseMcpCallInWsProgress!.Value, typeInfo);
            }
            else if (value.IsBetaResponseMcpListToolsWsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsCompleted2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseMcpListToolsWsCompleted!.Value, typeInfo);
            }
            else if (value.IsBetaResponseMcpListToolsWsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsWsFailed2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseMcpListToolsWsFailed!.Value, typeInfo);
            }
            else if (value.IsBetaResponseMcpListToolsInWsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseMcpListToolsInWsProgress2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseMcpListToolsInWsProgress!.Value, typeInfo);
            }
            else if (value.IsBetaResponseOutputTextAnnotationWsAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseOutputTextAnnotationWsAdded2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseOutputTextAnnotationWsAdded!.Value, typeInfo);
            }
            else if (value.IsBetaResponseWsQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseWsQueued2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseWsQueued!.Value, typeInfo);
            }
            else if (value.IsBetaResponseCustomToolCallInputWsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDelta2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseCustomToolCallInputWsDelta!.Value, typeInfo);
            }
            else if (value.IsBetaResponseCustomToolCallInputWsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent, global::tryAGI.OpenAI.BetaResponsesServerEventBetaResponseCustomToolCallInputWsDone2>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BetaResponseCustomToolCallInputWsDone!.Value, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseWsError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseWsError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseWsError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsResponseSteerAccepted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerAcceptedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseSteerAccepted!, typeInfo);
            }
            else if (value.IsResponseSteerPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerPendingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerPendingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseSteerPending!, typeInfo);
            }
            else if (value.IsResponseSteerFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseSteerFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseSteerFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseSteerFailed!, typeInfo);
            }
            else if (value.IsResponseInjectCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseInjectCreated!, typeInfo);
            }
            else if (value.IsResponseInjectFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseInjectFailed!, typeInfo);
            }
        }
    }
}