# Decisions and Celeris

The `tryAGI.OpenAI` package supports the [OpenAI Decisions API](https://developers.openai.com/api/docs/guides/decisions)
through `client.Decisions.CreateDecisionAsync`. It returns typed predicate,
choice, score, and refusal answers, with token usage. The SDK also supports
[Celeris Decision](https://docs.celeris.ai/decisions) through the same API.

## OpenAI Decisions

```csharp
using tryAGI.OpenAI;

using var client = new OpenAiClient("OPENAI_API_KEY");
var response = await client.Decisions.CreateDecisionAsync(
    model: "gpt-6-luna",
    input: "I was charged twice. Please refund one payment.",
    questions:
    [
        new QuestionParamPredicate
        {
            Name = "refund",
            Instructions = "The customer is asking for a refund.",
        },
    ]);

var answer = response.Answers[0];
if (answer.IsRefusal)
{
    Console.WriteLine($"Refused: {answer.PickRefusal().Name}");
}
else
{
    Console.WriteLine(answer.PickPredicate().Probability);
}
```

OpenAI currently documents Decisions as a public beta using `gpt-6-luna`.
Use `QuestionParamChoice` with `ChoiceOptionParam` for fixed categories, or
`QuestionParamScore` with `ScoreLevelParam` for ordered levels. Answers follow
the order of the questions and echo their optional names. Choice values preserve
string and boolean types. Scores are probability-weighted level indices, starting
at zero; they can fall between levels.

## Celeris Decision

Use `CustomProviders.CelerisDecision` and model `celeris-1-decision`. Its base
URL differs from the Celeris chat endpoint. It calls `/v1/decisions` using
the OpenAI format; it does not call the separate System One endpoint.

```csharp
using System.Text.Json;
using tryAGI.OpenAI;

using var client = CustomProviders.CelerisDecision("CELERIS_API_KEY");
using var options = JsonDocument.Parse("""{"explain":true}""");
var response = await client.Decisions.CreateDecisionAsync(new DecisionRequest
{
    Model = "celeris-1-decision",
    Input = "I was charged twice. Please refund one payment.",
    Questions =
    [
        new QuestionParamPredicate
        {
            Name = "refund",
            Instructions = "The customer is asking for a refund.",
        },
    ],
    AdditionalProperties = new Dictionary<string, object>
    {
        ["x_celeris"] = options.RootElement.Clone(),
    },
});

Console.WriteLine(response.Answers[0].PickPredicate().Probability);
var extra = (JsonElement)response.AdditionalProperties["x_celeris"];
Console.WriteLine(extra.GetProperty("explanations")[0].GetString());
```

Use `JsonElement` for extension values to keep serialization compatible with
the SDK's source-generated JSON context. Celeris returns one explanation per
answer when `x_celeris.explain` is true; explanations add processing time.

For images, build `DecisionInput` from user messages with `DecisionInputText`
and `DecisionInputImage` parts:

```csharp
var input = new DecisionInput(null,
[
    new DecisionInputMessage
    {
        Content = new DecisionInputContent(null,
        [
            new DecisionInputText { Text = "The expense claim is for $13.50." },
            new DecisionInputImage
            {
                ImageUrl = "data:image/png;base64," + Convert.ToBase64String(imageBytes),
            },
        ]),
    },
]);
```

Celeris requires inline base64 data URLs. Set image resolution through
`x_celeris.max_soft_tokens`; image `detail` does not control its resolution.
Structured data should be serialized to a string for `input`. Celeris accepts
up to 512 questions, or 64 with explanations, and up to 8 images. It does not
support streaming, tools, audio, files, or message roles other than `user`.
Unknown fields can cause validation errors, so omit chat-specific options.
See the [Celeris reference](https://docs.celeris.ai/decisions) for current limits.

## Celeris chat

Use the separate `CustomProviders.Celeris` factory for Celeris-1 chat completions
and Responses:

```csharp
using var client = CustomProviders.Celeris("CELERIS_API_KEY");
var response = await client.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequestVariant2
{
    Model = "celeris-1",
    Messages = ["Rewrite as a search query: cheap flights Sydney to Tokyo in June."],
    MaxCompletionTokens = 256,
});
```

Set an explicit output budget for production calls; input plus requested output
must fit the model's context window. Check [Celeris's current parameter guidance](https://docs.celeris.ai/making-requests)
for the model's budget limits. Chat can also use `IChatClient`; Decision calls use
the dedicated Decisions surface. These
factories do not imply that Celeris supports embeddings or every OpenAI endpoint.
Both factories accept an optional caller-owned `HttpClient`, which remains usable
after the SDK client is disposed.

## Verification

The SDK's offline contract tests check both provider URLs, Bearer authentication,
all three question types, boolean/string choice values, refusal parsing, inline
image input, Celeris extension fields, and validation error preservation. They
do not establish live provider acceptance, latency, accuracy, or billing.
