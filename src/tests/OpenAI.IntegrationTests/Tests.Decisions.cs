using System.Net;
using System.Text;
using System.Text.Json;

namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public sealed class Tests_Decisions
{
    private const string Usage = """
        "usage": {
          "input_tokens": 122,
          "input_tokens_details": {"cached_tokens": 0, "cache_write_tokens": 0},
          "output_tokens": 0,
          "output_tokens_details": {"reasoning_tokens": 0},
          "total_tokens": 122
        }
        """;

    [TestMethod]
    [DataRow(false, false)]
    [DataRow(false, true)]
    [DataRow(true, false)]
    [DataRow(true, true)]
    public async Task Decisions_MixedQuestions_PreserveTypedAnswers(bool celeris, bool readAsString)
    {
        var baseUrl = celeris ? CustomProviders.CelerisDecisionBaseUrl : OpenAiClient.DefaultBaseUrl;
        var model = celeris ? "celeris-1-decision" : "gpt-6-luna";
        using var httpClient = new HttpClient(new Handler(async (request, cancellationToken) =>
        {
            AssertRequest(request, baseUrl + "/decisions");
            using var body = JsonDocument.Parse(await request.Content!.ReadAsStringAsync(cancellationToken));
            var root = body.RootElement;
            root.GetProperty("model").GetString().Should().Be(model);
            root.GetProperty("input").GetString().Should().Be("Please refund the duplicate charge.");
            root.TryGetProperty("stream", out _).Should().BeFalse();
            var questions = root.GetProperty("questions");
            questions.GetArrayLength().Should().Be(3);
            questions[0].GetProperty("type").GetString().Should().Be("predicate");
            questions[1].GetProperty("type").GetString().Should().Be("choice");
            questions[1].GetProperty("choices")[0].GetProperty("value").GetBoolean().Should().BeTrue();
            questions[1].GetProperty("choices")[1].GetProperty("value").GetString().Should().Be("billing");
            questions[2].GetProperty("type").GetString().Should().Be("score");
            questions[2].GetProperty("levels")[1].GetProperty("label").GetString().Should().Be("Angry");
            if (celeris)
            {
                root.GetProperty("x_celeris").GetProperty("explain").GetBoolean().Should().BeTrue();
            }
            else
            {
                root.TryGetProperty("x_celeris", out _).Should().BeFalse();
            }

            var extension = celeris
                ? """, "x_celeris": {"explanations": ["A refund was requested.", "Billing handles charges.", "The customer is annoyed."]}"""
                : "";
            return JsonResponse($$"""
                {
                  "model": "{{model}}",
                  "answers": [
                    {"type": "predicate", "name": "refund", "probability": 0.98},
                    {"type": "choice", "name": "team", "choice": "billing",
                     "probabilities": [{"value": true, "probability": 0.03}, {"value": "billing", "probability": 0.97}],
                     "confidence": 0.94},
                    {"type": "score", "name": "frustration", "score": 0.6,
                     "probabilities": [{"value": 0, "label": "Calm", "probability": 0.4}, {"value": 1, "label": "Angry", "probability": 0.6}],
                     "confidence": 0.2}
                  ],
                  {{Usage}}{{extension}}
                }
                """);
        }));
        using var api = celeris
            ? CustomProviders.CelerisDecision("test-api-key", httpClient)
            : new OpenAiClient("test-api-key", httpClient: httpClient, disposeHttpClient: false);
        var decisions = api.Decisions;
        decisions.ReadResponseAsString = readAsString;
        var request = new DecisionRequest
        {
            Model = model,
            Input = "Please refund the duplicate charge.",
            Questions =
            [
                new QuestionParamPredicate { Name = "refund", Instructions = "The customer requests a refund." },
                new QuestionParamChoice
                {
                    Name = "team", Instructions = "Which team should handle this?",
                    Choices = [new ChoiceOptionParam { Value = true }, new ChoiceOptionParam { Value = "billing" }],
                },
                new QuestionParamScore
                {
                    Name = "frustration", Instructions = "How frustrated is the customer?",
                    Levels = [new ScoreLevelParam { Label = "Calm" }, new ScoreLevelParam { Label = "Angry" }],
                },
            ],
        };
        if (celeris)
        {
            request.AdditionalProperties["x_celeris"] = JsonSerializer.SerializeToElement(
                new Dictionary<string, bool> { ["explain"] = true });
        }

        var response = await decisions.CreateDecisionAsync(request);

        response.Model.Should().Be(model);
        response.Answers.Should().HaveCount(3);
        response.Answers[0].PickPredicate().Probability.Should().Be(0.98);
        response.Answers[0].PickPredicate().Name.Should().Be("refund");
        var choice = response.Answers[1].PickChoice();
        choice.Choice.ChoiceValueResourceVariant1.Should().Be("billing");
        choice.Probabilities[0].Value.ChoiceValueResourceVariant2.Should().BeTrue();
        choice.Probabilities[1].Value.ChoiceValueResourceVariant1.Should().Be("billing");
        choice.Confidence.Should().Be(0.94);
        response.Answers[2].PickScore().Score.Should().Be(0.6);
        response.Answers[2].PickScore().Probabilities[1].Label.Should().Be("Angry");
        response.Usage.InputTokens.Should().Be(122);
        response.Usage.OutputTokens.Should().Be(0);
        if (celeris)
        {
            var extra = (JsonElement)response.AdditionalProperties["x_celeris"];
            extra.GetProperty("explanations")[0].GetString().Should().Be("A refund was requested.");
            extra.GetProperty("explanations").GetArrayLength().Should().Be(3);
        }
    }

    [TestMethod]
    public async Task CelerisDecision_Images_SendInlineContentAndResolution()
    {
        const string image = "data:image/png;base64,iVBORw0KGgo=";
        using var httpClient = new HttpClient(new Handler(async (request, cancellationToken) =>
        {
            AssertRequest(request, CustomProviders.CelerisDecisionBaseUrl + "/decisions");
            using var body = JsonDocument.Parse(await request.Content!.ReadAsStringAsync(cancellationToken));
            var message = body.RootElement.GetProperty("input")[0];
            message.GetProperty("role").GetString().Should().Be("user");
            var content = message.GetProperty("content");
            content[0].GetProperty("type").GetString().Should().Be("input_text");
            content[0].GetProperty("text").GetString().Should().Be("Inspect this receipt.");
            content[1].GetProperty("type").GetString().Should().Be("input_image");
            content[1].GetProperty("image_url").GetString().Should().Be(image);
            body.RootElement.GetProperty("x_celeris").GetProperty("max_soft_tokens").GetInt32().Should().Be(560);
            return JsonResponse($$"""
                {"model":"celeris-1-decision","answers":[{"type":"predicate","name":null,"probability":0.95}],{{Usage}}}
                """);
        }));
        using var api = CustomProviders.CelerisDecision("test-api-key", httpClient);
        var response = await api.Decisions.CreateDecisionAsync(new DecisionRequest
        {
            Model = "celeris-1-decision",
            Input = new DecisionInput(null,
            [
                new DecisionInputMessage
                {
                    Role = DecisionInputMessageRole.User,
                    Content = new DecisionInputContent(null,
                    [new DecisionInputText { Text = "Inspect this receipt." }, new DecisionInputImage { ImageUrl = image }]),
                },
            ]),
            Questions = [new QuestionParamPredicate { Instructions = "The total is $13.50." }],
            AdditionalProperties = new Dictionary<string, object>
            {
                ["x_celeris"] = JsonSerializer.SerializeToElement(new Dictionary<string, int> { ["max_soft_tokens"] = 560 }),
            },
        });

        response.Answers[0].PickPredicate().Name.Should().BeNull();
        response.Answers[0].PickPredicate().Probability.Should().Be(0.95);
    }

    [TestMethod]
    public async Task Decisions_Refusal_PreservesQuestionName()
    {
        using var httpClient = new HttpClient(new Handler((_, _) => Task.FromResult(JsonResponse($$"""
            {"model":"gpt-6-luna","answers":[{"type":"refusal","name":"restricted"}],{{Usage}}}
            """))));
        using var api = new OpenAiClient("test-api-key", httpClient: httpClient, disposeHttpClient: false);
        var response = await api.Decisions.CreateDecisionAsync(
            model: "gpt-6-luna", input: "Restricted input",
            questions: [new QuestionParamPredicate { Name = "restricted", Instructions = "Evaluate this input." }]);

        response.Answers[0].PickRefusal().Name.Should().Be("restricted");
    }

    [TestMethod]
    public async Task CelerisDecision_ValidationError_PreservesErrorEnvelope()
    {
        const string error = """{"error":{"type":"invalid_request","message":"Invalid questions","param":"questions"}}""";
        using var httpClient = new HttpClient(new Handler((_, _) =>
            Task.FromResult(JsonResponse(error, HttpStatusCode.BadRequest))));
        using var api = CustomProviders.CelerisDecision("test-api-key", httpClient);

        var action = () => api.Decisions.CreateDecisionAsync(
            model: "celeris-1-decision", input: "Input", questions: []);

        var exception = await action.Should().ThrowAsync<ApiException>();
        exception.Which.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        exception.Which.ResponseBody.Should().Be(error);
    }

    [TestMethod]
    public async Task Celeris_Chat_UsesSeparateEndpointAndPreservesCallerHttpClient()
    {
        using var httpClient = new HttpClient(new Handler(async (request, cancellationToken) =>
        {
            AssertRequest(request, CustomProviders.CelerisBaseUrl + "/chat/completions");
            using var body = JsonDocument.Parse(await request.Content!.ReadAsStringAsync(cancellationToken));
            body.RootElement.GetProperty("model").GetString().Should().Be("celeris-1");
            body.RootElement.GetProperty("max_completion_tokens").GetInt32().Should().Be(256);
            return JsonResponse("""
                {"id":"chat-test","object":"chat.completion","created":0,"model":"celeris-1",
                 "choices":[{"index":0,"message":{"role":"assistant","content":"fast"},"finish_reason":"stop"}]}
                """);
        }));
        using (var api = CustomProviders.Celeris("test-api-key", httpClient))
        {
            string response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequestVariant2
            { Model = "celeris-1", Messages = ["Reply fast."], MaxCompletionTokens = 256 });
            response.Should().Be("fast");
        }

        using var secondClient = CustomProviders.Celeris("test-api-key", httpClient);
        await secondClient.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequestVariant2
        { Model = "celeris-1", Messages = ["Reply fast."], MaxCompletionTokens = 256 });
    }

    private static void AssertRequest(HttpRequestMessage request, string url)
    {
        request.Method.Should().Be(HttpMethod.Post);
        request.RequestUri.Should().Be(new Uri(url));
        request.Headers.Authorization?.Scheme.Should().Be("Bearer");
        request.Headers.Authorization?.Parameter.Should().Be("test-api-key");
    }

    private static HttpResponseMessage JsonResponse(string json, HttpStatusCode statusCode = HttpStatusCode.OK)
        => new(statusCode) { Content = new StringContent(json, Encoding.UTF8, "application/json") };

    private sealed class Handler(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> send) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            => send(request, cancellationToken);
    }
}
