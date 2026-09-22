#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal static partial class AgentsUpdateAgentEnvironmentTemplateCommandApiCommand
{
    private static Argument<string> EnvironmentTemplateId { get; } = new(
        name: @"environment-template-id")
    {
        Description = @"The ID of the reusable environment template.",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"A replacement human-readable display name, or `null` to clear the name.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>?> SetupCommands { get; } = new(
        name: @"--setup-commands")
    {
        Description = @"Replacement confidential setup commands, never included in returned resources.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Env { get; } = new(
        name: @"--env")
    {
        Description = @"Replacement confidential environment values.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> CapabilityDirectories { get; } = new(
        name: @"--capability-directories")
    {
        Description = @"Directories that expose capabilities to the agent.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>?> Skills { get; } = new(
        name: @"--skills")
    {
        Description = @"Replacement skill configuration installed for each new session.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>?> Plugins { get; } = new(
        name: @"--plugins")
    {
        Description = @"Replacement plugin configuration installed for each new session.",
    };

    private static Option<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>?> Files { get; } = new(
        name: @"--files")
    {
        Description = @"Replacement file configuration materialized for each new session.",
    };
    private static readonly EnvironmentPackagesParamOptionSet PackagesOptions = EnvironmentPackagesParamOptionSet.Create(@"packages");

    private static readonly NetworkPolicyParamOptionSet NetworkOptions = NetworkPolicyParamOptionSet.Create(@"network");
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

                    private static string FormatResponse(ParseResult parseResult, global::tryAGI.OpenAI.EnvironmentTemplateResource value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::tryAGI.OpenAI.EnvironmentTemplateResource value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-agent-environment-template", @"Update an agent environment template
Updates reusable environment configuration without returning confidential values. See [reusing a hosted setup](https://developers.openai.com/api/docs/guides/agents-api/tools#reuse-a-hosted-plugin-setup).");
                        command.Arguments.Add(EnvironmentTemplateId);
                        command.Options.Add(NameOption);
                        command.Options.Add(SetupCommands);
                        command.Options.Add(Env);
                        command.Options.Add(CapabilityDirectories);
                        command.Options.Add(Skills);
                        command.Options.Add(Plugins);
                        command.Options.Add(Files);                        command.Options.Add(PackagesOptions.Python);
                        command.Options.Add(PackagesOptions.System);
                        command.Options.Add(PackagesOptions.Npm);                        command.Options.Add(NetworkOptions.Access);
                        command.Options.Add(NetworkOptions.AllowedDomains);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::tryAGI.OpenAI.UpdateEnvironmentTemplateParams>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::tryAGI.OpenAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var environmentTemplateId = parseResult.GetRequiredValue(EnvironmentTemplateId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var setupCommands = CliRuntime.WasSpecified(parseResult, SetupCommands) ? parseResult.GetValue(SetupCommands) : (__requestBase is { } __SetupCommandsBaseValue ? __SetupCommandsBaseValue.SetupCommands : default);
                        var env = CliRuntime.WasSpecified(parseResult, Env) ? parseResult.GetValue(Env) : (__requestBase is { } __EnvBaseValue ? __EnvBaseValue.Env : default);
                        var capabilityDirectories = CliRuntime.WasSpecified(parseResult, CapabilityDirectories) ? parseResult.GetValue(CapabilityDirectories) : (__requestBase is { } __CapabilityDirectoriesBaseValue ? __CapabilityDirectoriesBaseValue.CapabilityDirectories : default);
                        var skills = CliRuntime.WasSpecified(parseResult, Skills) ? parseResult.GetValue(Skills) : (__requestBase is { } __SkillsBaseValue ? __SkillsBaseValue.Skills : default);
                        var plugins = CliRuntime.WasSpecified(parseResult, Plugins) ? parseResult.GetValue(Plugins) : (__requestBase is { } __PluginsBaseValue ? __PluginsBaseValue.Plugins : default);
                        var files = CliRuntime.WasSpecified(parseResult, Files) ? parseResult.GetValue(Files) : (__requestBase is { } __FilesBaseValue ? __FilesBaseValue.Files : default);

                        var __PackagesBase = __requestBase is { } __PackagesBaseValue ? __PackagesBaseValue.Packages : default;                        var packagesPython = CliRuntime.WasSpecified(parseResult, PackagesOptions.Python) ? parseResult.GetValue(PackagesOptions.Python) : (__PackagesBase is { } __PackagespythonBaseValue ? __PackagespythonBaseValue.Python : default);
                        var packagesSystem = CliRuntime.WasSpecified(parseResult, PackagesOptions.System) ? parseResult.GetValue(PackagesOptions.System) : (__PackagesBase is { } __PackagessystemBaseValue ? __PackagessystemBaseValue.System : default);
                        var packagesNpm = CliRuntime.WasSpecified(parseResult, PackagesOptions.Npm) ? parseResult.GetValue(PackagesOptions.Npm) : (__PackagesBase is { } __PackagesnpmBaseValue ? __PackagesnpmBaseValue.Npm : default);
                        var __PackagesSpecified = CliRuntime.WasSpecified(parseResult, PackagesOptions.Python) || CliRuntime.WasSpecified(parseResult, PackagesOptions.System) || CliRuntime.WasSpecified(parseResult, PackagesOptions.Npm);
                        var packages =
                            __PackagesSpecified || __PackagesBase is not null
                                ? new global::tryAGI.OpenAI.EnvironmentPackagesParam
                                {
	                                Python = packagesPython,
                                System = packagesSystem,
                                Npm = packagesNpm,

                                }
                                : __PackagesBase;

                        var __NetworkBase = __requestBase is { } __NetworkBaseValue ? __NetworkBaseValue.Network : default;                        var networkAccess = parseResult.GetValue(NetworkOptions.Access);
                        var networkAllowedDomains = CliRuntime.WasSpecified(parseResult, NetworkOptions.AllowedDomains) ? parseResult.GetValue(NetworkOptions.AllowedDomains) : (__NetworkBase is { } __NetworkallowedDomainsBaseValue ? __NetworkallowedDomainsBaseValue.AllowedDomains : default);
                        var __NetworkSpecified = CliRuntime.WasSpecified(parseResult, NetworkOptions.Access) || CliRuntime.WasSpecified(parseResult, NetworkOptions.AllowedDomains);
                        var network =
                            __NetworkSpecified || __NetworkBase is not null
                                ? new global::tryAGI.OpenAI.NetworkPolicyParam
                                {
	                                Access = networkAccess!,
                                AllowedDomains = networkAllowedDomains,

                                }
                                : __NetworkBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.UpdateAgentEnvironmentTemplateAsync(
                                    environmentTemplateId: environmentTemplateId,
                                    name: name,
                                    setupCommands: setupCommands,
                                    env: env,
                                    capabilityDirectories: capabilityDirectories,
                                    skills: skills,
                                    plugins: plugins,
                                    files: files,
                                    packages: packages,
                                    network: network,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::tryAGI.OpenAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}