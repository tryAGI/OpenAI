using System.CommandLine;
using System.Text;

namespace tryAGI.OpenAI.Cli.Commands;

internal static class ModelsCommand
{
    public static Command Create()
    {
        var cmd = new Command("models", "List or inspect OpenAI models.");
        cmd.Subcommands.Add(CreateListCommand());
        return cmd;
    }

    private static Command CreateListCommand()
    {
        var cmd = new Command("list", "List all models accessible to the API key.");
        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

            var response = await client.Models.ListModelsAsync(cancellationToken: cancellationToken).ConfigureAwait(false);

            var builder = new StringBuilder();
            var count = 0;
            foreach (var model in response.Data ?? [])
            {
                count++;
                builder.AppendLine(model.Id);
            }

            CliRuntime.AppendInvariant(builder, $"total: {count}");

            await CliRuntime.WriteOutputAsync(parseResult, builder.ToString().TrimEnd(), response, cancellationToken).ConfigureAwait(false);
        }));
        return cmd;
    }
}
