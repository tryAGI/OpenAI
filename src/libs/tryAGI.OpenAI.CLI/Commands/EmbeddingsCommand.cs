using System.CommandLine;
using System.Globalization;
using System.Text;

namespace tryAGI.OpenAI.Cli.Commands;

internal static class EmbeddingsCommand
{
    public static Command Create()
    {
        var cmd = new Command("embeddings", "Text embeddings.");
        cmd.Subcommands.Add(CreateEmbedCommand());
        return cmd;
    }

    private static Command CreateEmbedCommand()
    {
        var inputArg = new Argument<string>("input")
        {
            Description = "Text to embed. Pass `-` for stdin, or a file path.",
        };
        var modelOpt = new Option<string>("--model")
        {
            DefaultValueFactory = _ => "text-embedding-3-small",
            Description = "Embedding model id.",
        };
        var dimensionsOpt = new Option<int?>("--dimensions")
        {
            Description = "Target dimensionality (only supported by text-embedding-3-* models).",
        };

        var cmd = new Command("create", "Create an embedding vector for the given input.");
        cmd.Arguments.Add(inputArg);
        cmd.Options.Add(modelOpt);
        cmd.Options.Add(dimensionsOpt);

        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

            var inputValue = CliRuntime.GetRequiredArgument(parseResult, inputArg);
            var input = await CliRuntime.ReadInputOrFileAsync(inputValue, cancellationToken).ConfigureAwait(false);
            var modelValue = parseResult.GetValue(modelOpt) ?? "text-embedding-3-small";
            var dimensions = parseResult.GetValue(dimensionsOpt);

            var model = CreateEmbeddingRequestModelExtensions.ToEnum(modelValue);

            var response = await client.Embeddings.CreateEmbeddingsAsync(
                input: input,
                model: model,
                dimensions: dimensions,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var vectors = response.Data ?? [];
            var summary = new StringBuilder();
            var first = vectors.FirstOrDefault();
            if (first is not null)
            {
                var vector = first.Embedding1 ?? [];
                CliRuntime.AppendInvariant(summary, $"dimensions: {vector.Count}");
                CliRuntime.AppendInvariant(summary, $"model: {response.Model}");
                summary.AppendLine("[vector]");
                summary.AppendLine(string.Join(", ", vector.Select(x => x.ToString("G", CultureInfo.InvariantCulture))));
            }
            else
            {
                summary.AppendLine("no embeddings returned.");
            }

            await CliRuntime.WriteOutputAsync(parseResult, summary.ToString().TrimEnd(), response, cancellationToken).ConfigureAwait(false);
        }));

        return cmd;
    }
}
