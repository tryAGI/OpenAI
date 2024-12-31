using System.CommandLine;

namespace OpenAI.CLI.Commands;

/// <summary>
/// 
/// </summary>
internal sealed class VoiceCommand : Command
{
    public VoiceCommand() : base(name: "voice", description: "Generates client sdk using a OpenAPI spec.")
    {
        var inputOption = new Argument<string>(
            name: "input",
            getDefaultValue: () => string.Empty,
            description: "Input file path");
        AddArgument(inputOption);

        this.SetHandler(
            HandleAsync,
            inputOption);
    }

    private static async Task HandleAsync(
        string input)
    {
        Console.WriteLine("Done.");
    }
}