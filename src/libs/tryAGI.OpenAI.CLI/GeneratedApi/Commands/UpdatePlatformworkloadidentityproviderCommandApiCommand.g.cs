#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class UpdatePlatformworkloadidentityproviderCommandApiCommand
{
    private static Argument<string> WorkloadIdentityProviderId { get; } = new(
        name: @"workload-identity-provider-id")
    {
        Description = @"",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"",
    };

    private static Option<string?> Issuer { get; } = new(
        name: @"--issuer")
    {
        Description = @"",
    };

    private static Option<string?> Audience { get; } = new(
        name: @"--audience")
    {
        Description = @"",
    };

    private static Option<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerificationParam, global::tryAGI.OpenAI.UploadedJwksVerificationParam>?> Verification { get; } = new(
        name: @"--verification")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TransformationParam>?> AttributeTransformations { get; } = new(
        name: @"--attribute-transformations")
    {
        Description = @"",
    };

    private static Option<bool?> Enabled { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enabled",
        description: @"");
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.PlatformProvider value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.PlatformProvider value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"update-platformworkloadidentityprovider", @"Update Platform workload identity provider
Update supplied provider fields, preserving omitted fields.");
                        command.Arguments.Add(WorkloadIdentityProviderId);
                        command.Options.Add(NameOption);
                        command.Options.Add(Issuer);
                        command.Options.Add(Audience);
                        command.Options.Add(Verification);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(AttributeTransformations);
                        command.Options.Add(Enabled);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.UpdatePlatformWorkloadIdentityProviderBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var workloadIdentityProviderId = parseResult.GetRequiredValue(WorkloadIdentityProviderId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var issuer = CliRuntime.WasSpecified(parseResult, Issuer) ? parseResult.GetValue(Issuer) : (__requestBase is { } __IssuerBaseValue ? __IssuerBaseValue.Issuer : default);
                        var audience = CliRuntime.WasSpecified(parseResult, Audience) ? parseResult.GetValue(Audience) : (__requestBase is { } __AudienceBaseValue ? __AudienceBaseValue.Audience : default);
                        var verification = CliRuntime.WasSpecified(parseResult, Verification) ? parseResult.GetValue(Verification) : (__requestBase is { } __VerificationBaseValue ? __VerificationBaseValue.Verification : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var attributeTransformations = CliRuntime.WasSpecified(parseResult, AttributeTransformations) ? parseResult.GetValue(AttributeTransformations) : (__requestBase is { } __AttributeTransformationsBaseValue ? __AttributeTransformationsBaseValue.AttributeTransformations : default);
                        var enabled = CliRuntime.WasSpecified(parseResult, Enabled) ? parseResult.GetValue(Enabled) : (__requestBase is { } __EnabledBaseValue ? __EnabledBaseValue.Enabled : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UpdatePlatformworkloadidentityproviderAsync(
                                    workloadIdentityProviderId: workloadIdentityProviderId,
                                    name: name,
                                    issuer: issuer,
                                    audience: audience,
                                    verification: verification,
                                    description: description,
                                    attributeTransformations: attributeTransformations,
                                    enabled: enabled,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                        @"AttributeTransformations",
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
        CustomizeCommand(ref command);
        return command;
    }
}