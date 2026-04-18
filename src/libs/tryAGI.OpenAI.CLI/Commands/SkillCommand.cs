using System.CommandLine;
using System.Reflection;

namespace tryAGI.OpenAI.Cli.Commands;

internal static class SkillCommand
{
    public static Command Create()
    {
        var nameArg = new Argument<string?>("name")
        {
            Description = "Which bundled skill file to print: `skill` (default: SKILL.md), `commands`, `auth`, or `list` to enumerate files.",
            DefaultValueFactory = _ => null,
        };

        var cmd = new Command("skill", "Print a bundled Claude skill file (SKILL.md by default). Pass `list` to see available files, or a file name to print it.");
        cmd.Arguments.Add(nameArg);

        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            var name = parseResult.GetValue(nameArg);
            var directory = GetSkillDirectory();

            if (string.Equals(name, "list", StringComparison.OrdinalIgnoreCase))
            {
                foreach (var file in Directory.EnumerateFiles(directory, "*.md"))
                {
                    var info = new FileInfo(file);
                    await Console.Out.WriteLineAsync($"{Path.GetFileName(file),-20} {info.Length,7:N0} bytes").ConfigureAwait(false);
                }
                return;
            }

            var target = ResolveSkillFile(directory, name);
            if (!File.Exists(target))
            {
                var available = string.Join(
                    ", ",
                    Directory.EnumerateFiles(directory, "*.md").Select(Path.GetFileName));
                throw new CliException($"Skill file '{name}' not found (bundle: {directory}). Available: {available}");
            }

            var text = await File.ReadAllTextAsync(target, cancellationToken).ConfigureAwait(false);
            await Console.Out.WriteAsync(text).ConfigureAwait(false);
        }));

        return cmd;
    }

    private static string GetSkillDirectory()
    {
        // Files are bundled under `claude-skill/` inside the nupkg, which `dnx`/`dotnet tool`
        // unpacks alongside the executable. MSBuild's <CopyToOutputDirectory> lands them under
        // `skill/` in the bin dir during local development.
        var baseDir = AppContext.BaseDirectory;
        foreach (var candidate in new[]
                 {
                     Path.Combine(baseDir, "claude-skill"),
                     Path.Combine(baseDir, "skill"),
                     baseDir,
                 })
        {
            if (Directory.Exists(candidate) && Directory.EnumerateFiles(candidate, "*.md").Any())
            {
                return candidate;
            }
        }

        var assemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        if (!string.IsNullOrEmpty(assemblyDirectory))
        {
            var fallback = Path.Combine(assemblyDirectory, "claude-skill");
            if (Directory.Exists(fallback))
            {
                return fallback;
            }
        }

        return baseDir;
    }

    private static string ResolveSkillFile(string directory, string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Path.Combine(directory, "SKILL.md");
        }

        // Accept either a bare name ("commands"), a full filename ("commands.md"),
        // or a full path. Treat "skill" as an alias for SKILL.md.
        if (string.Equals(name, "skill", StringComparison.OrdinalIgnoreCase))
        {
            return Path.Combine(directory, "SKILL.md");
        }

        if (File.Exists(name))
        {
            return name;
        }

        var withExtension = name.EndsWith(".md", StringComparison.OrdinalIgnoreCase) ? name : $"{name}.md";
        return Path.Combine(directory, withExtension);
    }
}
