using System.CommandLine;
using OpenAI.CLI.Commands;

var rootCommand = new RootCommand(
    description: "CLI tool to use AutoSDK");
rootCommand.AddCommand(new VoiceCommand());

return await rootCommand.InvokeAsync(args).ConfigureAwait(false);