#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class FineTuningCreateFineTuningJobCommandApiCommand
{
    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateFineTuningJobRequestModel?>> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The name of the model to fine-tune. You can select one of the
[supported models](/docs/guides/fine-tuning#which-models-can-be-fine-tuned).
",
        Required = true,
    };

    private static Option<string> TrainingFile { get; } = new(
        name: @"--training-file")
    {
        Description = @"The ID of an uploaded file that contains training data.

See [upload file](/docs/api-reference/files/create) for how to upload a file.

Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.

The contents of the file should differ depending on if the model uses the [chat](/docs/api-reference/fine-tuning/chat-input), [completions](/docs/api-reference/fine-tuning/completions-input) format, or if the fine-tuning method uses the [preference](/docs/api-reference/fine-tuning/preference-input) format.

See the [fine-tuning guide](/docs/guides/model-optimization) for more details.
",
        Required = true,
    };

    private static Option<string?> Suffix { get; } = new(
        name: @"--suffix")
    {
        Description = @"A string of up to 64 characters that will be added to your fine-tuned model name.

For example, a `suffix` of ""custom-model-name"" would produce a model name like `ft:gpt-4o-mini:openai:custom-model-name:7p4lURel`.
",
    };

    private static Option<string?> ValidationFile { get; } = new(
        name: @"--validation-file")
    {
        Description = @"The ID of an uploaded file that contains validation data.

If you provide this file, the data is used to generate validation
metrics periodically during fine-tuning. These metrics can be viewed in
the fine-tuning results file.
The same data should not be present in both train and validation files.

Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.

See the [fine-tuning guide](/docs/guides/model-optimization) for more details.
",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateFineTuningJobRequestIntegration>?> Integrations { get; } = new(
        name: @"--integrations")
    {
        Description = @"A list of integrations to enable for your fine-tuning job.",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.
If a seed is not specified, one will be generated for you.
",
    };

    private static Option<global::tryAGI.OpenAI.FineTuneMethod?> Method { get; } = new(
        name: @"--method")
    {
        Description = @"The method used for fine-tuning.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new("--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new("--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new("--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.FineTuningJob value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.FineTuningJob value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-fine-tuning-job", @"Creates a fine-tuning job which begins the process of creating a new model from a given dataset.

Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.

[Learn more about fine-tuning](/docs/guides/model-optimization)
");
                        command.Options.Add(Model);
                        command.Options.Add(TrainingFile);
                        command.Options.Add(Suffix);
                        command.Options.Add(ValidationFile);
                        command.Options.Add(Integrations);
                        command.Options.Add(Seed);
                        command.Options.Add(Method);
                        command.Options.Add(Metadata);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError("Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateFineTuningJobRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var trainingFile = parseResult.GetRequiredValue(TrainingFile);
                        var suffix = parseResult.GetValue(Suffix) ?? __requestBase?.Suffix;
                        var validationFile = parseResult.GetValue(ValidationFile) ?? __requestBase?.ValidationFile;
                        var integrations = parseResult.GetValue(Integrations) ?? __requestBase?.Integrations;
                        var seed = parseResult.GetValue(Seed) ?? __requestBase?.Seed;
                        var method = parseResult.GetValue(Method) ?? __requestBase?.Method;
                        var metadata = parseResult.GetValue(Metadata) ?? __requestBase?.Metadata;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.FineTuning.CreateFineTuningJobAsync(
                                    model: model,
                                    trainingFile: trainingFile,
                                    suffix: suffix,
                                    validationFile: validationFile,
                                    integrations: integrations,
                                    seed: seed,
                                    method: method,
                                    metadata: metadata,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"ResultFiles",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}