#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ResponseStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ResponseStreamEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ResponseStreamEvent Read(
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
            if (__jsonProps.Contains("delta")) __score0++;
            if (__jsonProps.Contains("sequence_number")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("sequence_number")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("delta")) __score2++;
            if (__jsonProps.Contains("sequence_number")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("sequence_number")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("delta")) __score4++;
            if (__jsonProps.Contains("item_id")) __score4++;
            if (__jsonProps.Contains("output_index")) __score4++;
            if (__jsonProps.Contains("sequence_number")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("code")) __score5++;
            if (__jsonProps.Contains("item_id")) __score5++;
            if (__jsonProps.Contains("output_index")) __score5++;
            if (__jsonProps.Contains("sequence_number")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("item_id")) __score6++;
            if (__jsonProps.Contains("output_index")) __score6++;
            if (__jsonProps.Contains("sequence_number")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("item_id")) __score7++;
            if (__jsonProps.Contains("output_index")) __score7++;
            if (__jsonProps.Contains("sequence_number")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("item_id")) __score8++;
            if (__jsonProps.Contains("output_index")) __score8++;
            if (__jsonProps.Contains("sequence_number")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("response")) __score9++;
            if (__jsonProps.Contains("sequence_number")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("content_index")) __score10++;
            if (__jsonProps.Contains("item_id")) __score10++;
            if (__jsonProps.Contains("output_index")) __score10++;
            if (__jsonProps.Contains("part")) __score10++;
            if (__jsonProps.Contains("sequence_number")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("content_index")) __score11++;
            if (__jsonProps.Contains("item_id")) __score11++;
            if (__jsonProps.Contains("output_index")) __score11++;
            if (__jsonProps.Contains("part")) __score11++;
            if (__jsonProps.Contains("sequence_number")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("response")) __score12++;
            if (__jsonProps.Contains("sequence_number")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("code")) __score13++;
            if (__jsonProps.Contains("message")) __score13++;
            if (__jsonProps.Contains("param")) __score13++;
            if (__jsonProps.Contains("sequence_number")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("item_id")) __score14++;
            if (__jsonProps.Contains("output_index")) __score14++;
            if (__jsonProps.Contains("sequence_number")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("item_id")) __score15++;
            if (__jsonProps.Contains("output_index")) __score15++;
            if (__jsonProps.Contains("sequence_number")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("item_id")) __score16++;
            if (__jsonProps.Contains("output_index")) __score16++;
            if (__jsonProps.Contains("sequence_number")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("delta")) __score17++;
            if (__jsonProps.Contains("item_id")) __score17++;
            if (__jsonProps.Contains("output_index")) __score17++;
            if (__jsonProps.Contains("sequence_number")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("arguments")) __score18++;
            if (__jsonProps.Contains("item_id")) __score18++;
            if (__jsonProps.Contains("name")) __score18++;
            if (__jsonProps.Contains("output_index")) __score18++;
            if (__jsonProps.Contains("sequence_number")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("response")) __score19++;
            if (__jsonProps.Contains("sequence_number")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("response")) __score20++;
            if (__jsonProps.Contains("sequence_number")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("response")) __score21++;
            if (__jsonProps.Contains("sequence_number")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("item")) __score22++;
            if (__jsonProps.Contains("output_index")) __score22++;
            if (__jsonProps.Contains("sequence_number")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("item")) __score23++;
            if (__jsonProps.Contains("output_index")) __score23++;
            if (__jsonProps.Contains("sequence_number")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("item_id")) __score24++;
            if (__jsonProps.Contains("output_index")) __score24++;
            if (__jsonProps.Contains("part")) __score24++;
            if (__jsonProps.Contains("sequence_number")) __score24++;
            if (__jsonProps.Contains("summary_index")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("item_id")) __score25++;
            if (__jsonProps.Contains("output_index")) __score25++;
            if (__jsonProps.Contains("part")) __score25++;
            if (__jsonProps.Contains("sequence_number")) __score25++;
            if (__jsonProps.Contains("summary_index")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("delta")) __score26++;
            if (__jsonProps.Contains("item_id")) __score26++;
            if (__jsonProps.Contains("output_index")) __score26++;
            if (__jsonProps.Contains("sequence_number")) __score26++;
            if (__jsonProps.Contains("summary_index")) __score26++;
            if (__jsonProps.Contains("type")) __score26++;
            var __score27 = 0;
            if (__jsonProps.Contains("item_id")) __score27++;
            if (__jsonProps.Contains("output_index")) __score27++;
            if (__jsonProps.Contains("sequence_number")) __score27++;
            if (__jsonProps.Contains("summary_index")) __score27++;
            if (__jsonProps.Contains("text")) __score27++;
            if (__jsonProps.Contains("type")) __score27++;
            var __score28 = 0;
            if (__jsonProps.Contains("content_index")) __score28++;
            if (__jsonProps.Contains("delta")) __score28++;
            if (__jsonProps.Contains("item_id")) __score28++;
            if (__jsonProps.Contains("output_index")) __score28++;
            if (__jsonProps.Contains("sequence_number")) __score28++;
            if (__jsonProps.Contains("type")) __score28++;
            var __score29 = 0;
            if (__jsonProps.Contains("content_index")) __score29++;
            if (__jsonProps.Contains("item_id")) __score29++;
            if (__jsonProps.Contains("output_index")) __score29++;
            if (__jsonProps.Contains("sequence_number")) __score29++;
            if (__jsonProps.Contains("text")) __score29++;
            if (__jsonProps.Contains("type")) __score29++;
            var __score30 = 0;
            if (__jsonProps.Contains("content_index")) __score30++;
            if (__jsonProps.Contains("delta")) __score30++;
            if (__jsonProps.Contains("item_id")) __score30++;
            if (__jsonProps.Contains("output_index")) __score30++;
            if (__jsonProps.Contains("sequence_number")) __score30++;
            if (__jsonProps.Contains("type")) __score30++;
            var __score31 = 0;
            if (__jsonProps.Contains("content_index")) __score31++;
            if (__jsonProps.Contains("item_id")) __score31++;
            if (__jsonProps.Contains("output_index")) __score31++;
            if (__jsonProps.Contains("refusal")) __score31++;
            if (__jsonProps.Contains("sequence_number")) __score31++;
            if (__jsonProps.Contains("type")) __score31++;
            var __score32 = 0;
            if (__jsonProps.Contains("content_index")) __score32++;
            if (__jsonProps.Contains("delta")) __score32++;
            if (__jsonProps.Contains("item_id")) __score32++;
            if (__jsonProps.Contains("logprobs")) __score32++;
            if (__jsonProps.Contains("output_index")) __score32++;
            if (__jsonProps.Contains("sequence_number")) __score32++;
            if (__jsonProps.Contains("type")) __score32++;
            var __score33 = 0;
            if (__jsonProps.Contains("content_index")) __score33++;
            if (__jsonProps.Contains("item_id")) __score33++;
            if (__jsonProps.Contains("logprobs")) __score33++;
            if (__jsonProps.Contains("output_index")) __score33++;
            if (__jsonProps.Contains("sequence_number")) __score33++;
            if (__jsonProps.Contains("text")) __score33++;
            if (__jsonProps.Contains("type")) __score33++;
            var __score34 = 0;
            if (__jsonProps.Contains("item_id")) __score34++;
            if (__jsonProps.Contains("output_index")) __score34++;
            if (__jsonProps.Contains("sequence_number")) __score34++;
            if (__jsonProps.Contains("type")) __score34++;
            var __score35 = 0;
            if (__jsonProps.Contains("item_id")) __score35++;
            if (__jsonProps.Contains("output_index")) __score35++;
            if (__jsonProps.Contains("sequence_number")) __score35++;
            if (__jsonProps.Contains("type")) __score35++;
            var __score36 = 0;
            if (__jsonProps.Contains("item_id")) __score36++;
            if (__jsonProps.Contains("output_index")) __score36++;
            if (__jsonProps.Contains("sequence_number")) __score36++;
            if (__jsonProps.Contains("type")) __score36++;
            var __score37 = 0;
            if (__jsonProps.Contains("item_id")) __score37++;
            if (__jsonProps.Contains("output_index")) __score37++;
            if (__jsonProps.Contains("sequence_number")) __score37++;
            if (__jsonProps.Contains("type")) __score37++;
            var __score38 = 0;
            if (__jsonProps.Contains("item_id")) __score38++;
            if (__jsonProps.Contains("output_index")) __score38++;
            if (__jsonProps.Contains("sequence_number")) __score38++;
            if (__jsonProps.Contains("type")) __score38++;
            var __score39 = 0;
            if (__jsonProps.Contains("item_id")) __score39++;
            if (__jsonProps.Contains("output_index")) __score39++;
            if (__jsonProps.Contains("sequence_number")) __score39++;
            if (__jsonProps.Contains("type")) __score39++;
            var __score40 = 0;
            if (__jsonProps.Contains("item_id")) __score40++;
            if (__jsonProps.Contains("output_index")) __score40++;
            if (__jsonProps.Contains("partial_image_b64")) __score40++;
            if (__jsonProps.Contains("partial_image_index")) __score40++;
            if (__jsonProps.Contains("sequence_number")) __score40++;
            if (__jsonProps.Contains("type")) __score40++;
            var __score41 = 0;
            if (__jsonProps.Contains("delta")) __score41++;
            if (__jsonProps.Contains("item_id")) __score41++;
            if (__jsonProps.Contains("output_index")) __score41++;
            if (__jsonProps.Contains("sequence_number")) __score41++;
            if (__jsonProps.Contains("type")) __score41++;
            var __score42 = 0;
            if (__jsonProps.Contains("arguments")) __score42++;
            if (__jsonProps.Contains("item_id")) __score42++;
            if (__jsonProps.Contains("output_index")) __score42++;
            if (__jsonProps.Contains("sequence_number")) __score42++;
            if (__jsonProps.Contains("type")) __score42++;
            var __score43 = 0;
            if (__jsonProps.Contains("item_id")) __score43++;
            if (__jsonProps.Contains("output_index")) __score43++;
            if (__jsonProps.Contains("sequence_number")) __score43++;
            if (__jsonProps.Contains("type")) __score43++;
            var __score44 = 0;
            if (__jsonProps.Contains("item_id")) __score44++;
            if (__jsonProps.Contains("output_index")) __score44++;
            if (__jsonProps.Contains("sequence_number")) __score44++;
            if (__jsonProps.Contains("type")) __score44++;
            var __score45 = 0;
            if (__jsonProps.Contains("item_id")) __score45++;
            if (__jsonProps.Contains("output_index")) __score45++;
            if (__jsonProps.Contains("sequence_number")) __score45++;
            if (__jsonProps.Contains("type")) __score45++;
            var __score46 = 0;
            if (__jsonProps.Contains("item_id")) __score46++;
            if (__jsonProps.Contains("output_index")) __score46++;
            if (__jsonProps.Contains("sequence_number")) __score46++;
            if (__jsonProps.Contains("type")) __score46++;
            var __score47 = 0;
            if (__jsonProps.Contains("item_id")) __score47++;
            if (__jsonProps.Contains("output_index")) __score47++;
            if (__jsonProps.Contains("sequence_number")) __score47++;
            if (__jsonProps.Contains("type")) __score47++;
            var __score48 = 0;
            if (__jsonProps.Contains("item_id")) __score48++;
            if (__jsonProps.Contains("output_index")) __score48++;
            if (__jsonProps.Contains("sequence_number")) __score48++;
            if (__jsonProps.Contains("type")) __score48++;
            var __score49 = 0;
            if (__jsonProps.Contains("annotation")) __score49++;
            if (__jsonProps.Contains("annotation_index")) __score49++;
            if (__jsonProps.Contains("content_index")) __score49++;
            if (__jsonProps.Contains("item_id")) __score49++;
            if (__jsonProps.Contains("output_index")) __score49++;
            if (__jsonProps.Contains("sequence_number")) __score49++;
            if (__jsonProps.Contains("type")) __score49++;
            var __score50 = 0;
            if (__jsonProps.Contains("response")) __score50++;
            if (__jsonProps.Contains("sequence_number")) __score50++;
            if (__jsonProps.Contains("type")) __score50++;
            var __score51 = 0;
            if (__jsonProps.Contains("delta")) __score51++;
            if (__jsonProps.Contains("item_id")) __score51++;
            if (__jsonProps.Contains("output_index")) __score51++;
            if (__jsonProps.Contains("sequence_number")) __score51++;
            if (__jsonProps.Contains("type")) __score51++;
            var __score52 = 0;
            if (__jsonProps.Contains("input")) __score52++;
            if (__jsonProps.Contains("item_id")) __score52++;
            if (__jsonProps.Contains("output_index")) __score52++;
            if (__jsonProps.Contains("sequence_number")) __score52++;
            if (__jsonProps.Contains("type")) __score52++;
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

            global::tryAGI.OpenAI.ResponseAudioDeltaEvent? responseAudioDelta = default;
            global::tryAGI.OpenAI.ResponseAudioDoneEvent? responseAudioDone = default;
            global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? responseAudioTranscriptDelta = default;
            global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? responseAudioTranscriptDone = default;
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta = default;
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone = default;
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted = default;
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress = default;
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting = default;
            global::tryAGI.OpenAI.ResponseCompletedEvent? responseCompleted = default;
            global::tryAGI.OpenAI.ResponseContentPartAddedEvent? responseContentPartAdded = default;
            global::tryAGI.OpenAI.ResponseContentPartDoneEvent? responseContentPartDone = default;
            global::tryAGI.OpenAI.ResponseCreatedEvent? responseCreated = default;
            global::tryAGI.OpenAI.ResponseErrorEvent? error = default;
            global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? responseFileSearchCallCompleted = default;
            global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? responseFileSearchCallInProgress = default;
            global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? responseFileSearchCallSearching = default;
            global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? responseFunctionCallArgumentsDelta = default;
            global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? responseFunctionCallArgumentsDone = default;
            global::tryAGI.OpenAI.ResponseInProgressEvent? responseInProgress = default;
            global::tryAGI.OpenAI.ResponseFailedEvent? responseFailed = default;
            global::tryAGI.OpenAI.ResponseIncompleteEvent? responseIncomplete = default;
            global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? responseOutputItemAdded = default;
            global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? responseOutputItemDone = default;
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? responseReasoningSummaryPartAdded = default;
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? responseReasoningSummaryPartDone = default;
            global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? responseReasoningSummaryTextDelta = default;
            global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? responseReasoningSummaryTextDone = default;
            global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent? responseReasoningTextDelta = default;
            global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent? responseReasoningTextDone = default;
            global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? responseRefusalDelta = default;
            global::tryAGI.OpenAI.ResponseRefusalDoneEvent? responseRefusalDone = default;
            global::tryAGI.OpenAI.ResponseTextDeltaEvent? responseOutputTextDelta = default;
            global::tryAGI.OpenAI.ResponseTextDoneEvent? responseOutputTextDone = default;
            global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? responseWebSearchCallCompleted = default;
            global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? responseWebSearchCallInProgress = default;
            global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? responseWebSearchCallSearching = default;
            global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent? responseImageGenerationCallCompleted = default;
            global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent? responseImageGenerationCallGenerating = default;
            global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent? responseImageGenerationCallInProgress = default;
            global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent? responseImageGenerationCallPartialImage = default;
            global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent? responseMcpCallArgumentsDelta = default;
            global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent? responseMcpCallArgumentsDone = default;
            global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent? responseMcpCallCompleted = default;
            global::tryAGI.OpenAI.ResponseMCPCallFailedEvent? responseMcpCallFailed = default;
            global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent? responseMcpCallInProgress = default;
            global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent? responseMcpListToolsCompleted = default;
            global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent? responseMcpListToolsFailed = default;
            global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent? responseMcpListToolsInProgress = default;
            global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent? responseOutputTextAnnotationAdded = default;
            global::tryAGI.OpenAI.ResponseQueuedEvent? responseQueued = default;
            global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent? responseCustomToolCallInputDelta = default;
            global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent? responseCustomToolCallInputDone = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseAudioDeltaEvent>(__rawJson, options);
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
                        responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseAudioDoneEvent>(__rawJson, options);
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
                        responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent>(__rawJson, options);
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
                        responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent>(__rawJson, options);
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
                        responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent>(__rawJson, options);
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
                        responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent>(__rawJson, options);
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
                        responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent>(__rawJson, options);
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
                        responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent>(__rawJson, options);
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
                        responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent>(__rawJson, options);
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
                        responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCompletedEvent>(__rawJson, options);
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
                        responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseContentPartAddedEvent>(__rawJson, options);
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
                        responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseContentPartDoneEvent>(__rawJson, options);
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
                        responseCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCreatedEvent>(__rawJson, options);
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
                        error = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseErrorEvent>(__rawJson, options);
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
                        responseFileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent>(__rawJson, options);
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
                        responseFileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent>(__rawJson, options);
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
                        responseFileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent>(__rawJson, options);
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
                        responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent>(__rawJson, options);
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
                        responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent>(__rawJson, options);
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
                        responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseInProgressEvent>(__rawJson, options);
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
                        responseFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFailedEvent>(__rawJson, options);
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
                        responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseIncompleteEvent>(__rawJson, options);
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
                        responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent>(__rawJson, options);
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
                        responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent>(__rawJson, options);
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
                        responseReasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent>(__rawJson, options);
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
                        responseReasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent>(__rawJson, options);
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
                        responseReasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent>(__rawJson, options);
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
                        responseReasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent>(__rawJson, options);
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
                        responseReasoningTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent>(__rawJson, options);
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
                        responseReasoningTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent>(__rawJson, options);
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
                        responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent>(__rawJson, options);
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
                        responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseRefusalDoneEvent>(__rawJson, options);
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
                        responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseTextDeltaEvent>(__rawJson, options);
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
                        responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseTextDoneEvent>(__rawJson, options);
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
                        responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent>(__rawJson, options);
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
                        responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent>(__rawJson, options);
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
                        responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent>(__rawJson, options);
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
                        responseImageGenerationCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent>(__rawJson, options);
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
                        responseImageGenerationCallGenerating = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent>(__rawJson, options);
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
                        responseImageGenerationCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent>(__rawJson, options);
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
                        responseImageGenerationCallPartialImage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent>(__rawJson, options);
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
                        responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent>(__rawJson, options);
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
                        responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent>(__rawJson, options);
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
                        responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent>(__rawJson, options);
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
                        responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent>(__rawJson, options);
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
                        responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent>(__rawJson, options);
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
                        responseMcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent>(__rawJson, options);
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
                        responseMcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent>(__rawJson, options);
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
                        responseMcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent>(__rawJson, options);
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
                        responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent>(__rawJson, options);
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
                        responseQueued = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseQueuedEvent>(__rawJson, options);
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
                        responseCustomToolCallInputDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent>(__rawJson, options);
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
                        responseCustomToolCallInputDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responseAudioDelta == null && responseAudioDone == null && responseAudioTranscriptDelta == null && responseAudioTranscriptDone == null && responseCodeInterpreterCallCodeDelta == null && responseCodeInterpreterCallCodeDone == null && responseCodeInterpreterCallCompleted == null && responseCodeInterpreterCallInProgress == null && responseCodeInterpreterCallInterpreting == null && responseCompleted == null && responseContentPartAdded == null && responseContentPartDone == null && responseCreated == null && error == null && responseFileSearchCallCompleted == null && responseFileSearchCallInProgress == null && responseFileSearchCallSearching == null && responseFunctionCallArgumentsDelta == null && responseFunctionCallArgumentsDone == null && responseInProgress == null && responseFailed == null && responseIncomplete == null && responseOutputItemAdded == null && responseOutputItemDone == null && responseReasoningSummaryPartAdded == null && responseReasoningSummaryPartDone == null && responseReasoningSummaryTextDelta == null && responseReasoningSummaryTextDone == null && responseReasoningTextDelta == null && responseReasoningTextDone == null && responseRefusalDelta == null && responseRefusalDone == null && responseOutputTextDelta == null && responseOutputTextDone == null && responseWebSearchCallCompleted == null && responseWebSearchCallInProgress == null && responseWebSearchCallSearching == null && responseImageGenerationCallCompleted == null && responseImageGenerationCallGenerating == null && responseImageGenerationCallInProgress == null && responseImageGenerationCallPartialImage == null && responseMcpCallArgumentsDelta == null && responseMcpCallArgumentsDone == null && responseMcpCallCompleted == null && responseMcpCallFailed == null && responseMcpCallInProgress == null && responseMcpListToolsCompleted == null && responseMcpListToolsFailed == null && responseMcpListToolsInProgress == null && responseOutputTextAnnotationAdded == null && responseQueued == null && responseCustomToolCallInputDelta == null && responseCustomToolCallInputDone == null)
            {
                try
                {
                    responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseAudioDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseAudioDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseContentPartAddedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseContentPartDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCreatedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    error = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseErrorEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseFailedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseIncompleteEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseReasoningTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseRefusalDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseTextDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseTextDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseImageGenerationCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseImageGenerationCallGenerating = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseImageGenerationCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseImageGenerationCallPartialImage = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPCallFailedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseMcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseQueued = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseQueuedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCustomToolCallInputDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    responseCustomToolCallInputDone = global::System.Text.Json.JsonSerializer.Deserialize<global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ResponseStreamEvent(
                responseAudioDelta,

                responseAudioDone,

                responseAudioTranscriptDelta,

                responseAudioTranscriptDone,

                responseCodeInterpreterCallCodeDelta,

                responseCodeInterpreterCallCodeDone,

                responseCodeInterpreterCallCompleted,

                responseCodeInterpreterCallInProgress,

                responseCodeInterpreterCallInterpreting,

                responseCompleted,

                responseContentPartAdded,

                responseContentPartDone,

                responseCreated,

                error,

                responseFileSearchCallCompleted,

                responseFileSearchCallInProgress,

                responseFileSearchCallSearching,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                responseInProgress,

                responseFailed,

                responseIncomplete,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseReasoningSummaryPartAdded,

                responseReasoningSummaryPartDone,

                responseReasoningSummaryTextDelta,

                responseReasoningSummaryTextDone,

                responseReasoningTextDelta,

                responseReasoningTextDone,

                responseRefusalDelta,

                responseRefusalDone,

                responseOutputTextDelta,

                responseOutputTextDone,

                responseWebSearchCallCompleted,

                responseWebSearchCallInProgress,

                responseWebSearchCallSearching,

                responseImageGenerationCallCompleted,

                responseImageGenerationCallGenerating,

                responseImageGenerationCallInProgress,

                responseImageGenerationCallPartialImage,

                responseMcpCallArgumentsDelta,

                responseMcpCallArgumentsDone,

                responseMcpCallCompleted,

                responseMcpCallFailed,

                responseMcpCallInProgress,

                responseMcpListToolsCompleted,

                responseMcpListToolsFailed,

                responseMcpListToolsInProgress,

                responseOutputTextAnnotationAdded,

                responseQueued,

                responseCustomToolCallInputDelta,

                responseCustomToolCallInputDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsResponseAudioDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta, typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent), options);
            }
            else if (value.IsResponseAudioDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone, typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent), options);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta, typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent), options);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone, typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDelta, typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCodeDone, typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallCompleted, typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInProgress, typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent), options);
            }
            else if (value.IsResponseCodeInterpreterCallInterpreting)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCodeInterpreterCallInterpreting, typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent), options);
            }
            else if (value.IsResponseCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCompleted, typeof(global::tryAGI.OpenAI.ResponseCompletedEvent), options);
            }
            else if (value.IsResponseContentPartAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded, typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent), options);
            }
            else if (value.IsResponseContentPartDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone, typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent), options);
            }
            else if (value.IsResponseCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeof(global::tryAGI.OpenAI.ResponseCreatedEvent), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::tryAGI.OpenAI.ResponseErrorEvent), options);
            }
            else if (value.IsResponseFileSearchCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallCompleted, typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent), options);
            }
            else if (value.IsResponseFileSearchCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallInProgress, typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent), options);
            }
            else if (value.IsResponseFileSearchCallSearching)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFileSearchCallSearching, typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent), options);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta, typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent), options);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent), options);
            }
            else if (value.IsResponseInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseInProgress, typeof(global::tryAGI.OpenAI.ResponseInProgressEvent), options);
            }
            else if (value.IsResponseFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFailed, typeof(global::tryAGI.OpenAI.ResponseFailedEvent), options);
            }
            else if (value.IsResponseIncomplete)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseIncomplete, typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent), options);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent), options);
            }
            else if (value.IsResponseOutputItemDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone, typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent), options);
            }
            else if (value.IsResponseReasoningSummaryPartAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryPartAdded, typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent), options);
            }
            else if (value.IsResponseReasoningSummaryPartDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryPartDone, typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent), options);
            }
            else if (value.IsResponseReasoningSummaryTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryTextDelta, typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent), options);
            }
            else if (value.IsResponseReasoningSummaryTextDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningSummaryTextDone, typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent), options);
            }
            else if (value.IsResponseReasoningTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningTextDelta, typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent), options);
            }
            else if (value.IsResponseReasoningTextDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseReasoningTextDone, typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent), options);
            }
            else if (value.IsResponseRefusalDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDelta, typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent), options);
            }
            else if (value.IsResponseRefusalDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseRefusalDone, typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent), options);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDelta, typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent), options);
            }
            else if (value.IsResponseOutputTextDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDone, typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent), options);
            }
            else if (value.IsResponseWebSearchCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallCompleted, typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent), options);
            }
            else if (value.IsResponseWebSearchCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallInProgress, typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent), options);
            }
            else if (value.IsResponseWebSearchCallSearching)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseWebSearchCallSearching, typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent), options);
            }
            else if (value.IsResponseImageGenerationCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallCompleted, typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent), options);
            }
            else if (value.IsResponseImageGenerationCallGenerating)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallGenerating, typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent), options);
            }
            else if (value.IsResponseImageGenerationCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallInProgress, typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent), options);
            }
            else if (value.IsResponseImageGenerationCallPartialImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseImageGenerationCallPartialImage, typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent), options);
            }
            else if (value.IsResponseMcpCallArgumentsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDelta, typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent), options);
            }
            else if (value.IsResponseMcpCallArgumentsDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDone, typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent), options);
            }
            else if (value.IsResponseMcpCallCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallCompleted, typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent), options);
            }
            else if (value.IsResponseMcpCallFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallFailed, typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent), options);
            }
            else if (value.IsResponseMcpCallInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallInProgress, typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent), options);
            }
            else if (value.IsResponseMcpListToolsCompleted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsCompleted, typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent), options);
            }
            else if (value.IsResponseMcpListToolsFailed)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsFailed, typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent), options);
            }
            else if (value.IsResponseMcpListToolsInProgress)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpListToolsInProgress, typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent), options);
            }
            else if (value.IsResponseOutputTextAnnotationAdded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextAnnotationAdded, typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent), options);
            }
            else if (value.IsResponseQueued)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseQueued, typeof(global::tryAGI.OpenAI.ResponseQueuedEvent), options);
            }
            else if (value.IsResponseCustomToolCallInputDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCustomToolCallInputDelta, typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent), options);
            }
            else if (value.IsResponseCustomToolCallInputDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCustomToolCallInputDone, typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent), options);
            }
        }
    }
}