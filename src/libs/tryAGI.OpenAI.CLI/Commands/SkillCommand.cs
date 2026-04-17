using System.CommandLine;
using System.Reflection;

namespace tryAGI.OpenAI.Cli.Commands;

internal static class SkillCommand
{
    public static Command Create()
    {
        var cmd = new Command("skill", "Print the bundled Claude skill manifest (SKILL.md) to stdout.");
        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            _ = parseResult;
            var path = Path.Combine(AppContext.BaseDirectory, "SKILL.md");
            if (!File.Exists(path))
            {
                // fallback: try assembly-adjacent
                var assemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                if (!string.IsNullOrEmpty(assemblyDirectory))
                {
                    var fallback = Path.Combine(assemblyDirectory, "SKILL.md");
                    if (File.Exists(fallback))
                    {
                        path = fallback;
                    }
                }
            }

            if (!File.Exists(path))
            {
                throw new CliException($"SKILL.md was not found in the tool bundle (expected at {path}).");
            }

            var text = await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false);
            await Console.Out.WriteAsync(text).ConfigureAwait(false);
        }));
        return cmd;
    }
}
