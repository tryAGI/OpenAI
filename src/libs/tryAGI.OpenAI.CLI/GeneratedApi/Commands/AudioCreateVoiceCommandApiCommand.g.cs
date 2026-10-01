#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AudioCreateVoiceCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"The name of the new voice.",
    };

    private static Option<global::tryAGI.OpenAI.CreateVoicePromptRequestType> Type { get; } = new(
        name: @"--type")
    {
        Description = @"Set to `prompt` to create a voice from a text description.",
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"A description of the desired voice. Must not contain only whitespace.",
        Required = true,
    };

    private static Option<string?> ScriptHint { get; } = new(
        name: @"--script-hint")
    {
        Description = @"Optional text for the voice to speak during creation. If omitted, a script is generated from the prompt. Must not be blank after trimming whitespace; scripts that are too short are rejected.",
    };

    private static Option<global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The voice creation model to use. Defaults to `auto`.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.VoiceResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.VoiceResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-voice", @"Create voice
Creates a voice from a text prompt or from a consent recording and an audio sample.

For prompt-based creation, send `type: ""prompt""` with a `name` and `prompt` as JSON or multipart form data. Consent-based creation requires multipart form data and is the default when `type` is omitted.

Returns the saved voice's metadata. Use the voice ID in supported audio output endpoints. The response does not include preview audio.
");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(Type);
                        command.Options.Add(Prompt);
                        command.Options.Add(ScriptHint);
                        command.Options.Add(Model);
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
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.CreateVoicePromptRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var type = CliRuntime.WasSpecified(parseResult, Type) ? parseResult.GetValue(Type) : (__requestBase is { } __TypeBaseValue ? __TypeBaseValue.Type : default);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var scriptHint = CliRuntime.WasSpecified(parseResult, ScriptHint) ? parseResult.GetValue(ScriptHint) : (__requestBase is { } __ScriptHintBaseValue ? __ScriptHintBaseValue.ScriptHint : default);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Audio.CreateVoiceAsync(
                                    name: name,
                                    type: type,
                                    prompt: prompt,
                                    scriptHint: scriptHint,
                                    model: model,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}