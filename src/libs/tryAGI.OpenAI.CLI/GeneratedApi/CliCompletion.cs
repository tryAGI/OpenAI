#nullable enable

using System.CommandLine;
using System.Text;

namespace tryAGI.OpenAI.Cli.GeneratedApi;

/// <summary>
/// Generates shell completion scripts from the command tree this CLI actually exposes.
/// </summary>
internal static class CliCompletion
{
    /// <summary>Shells a script can be emitted for.</summary>
    public static string[] SupportedShells { get; } = ["bash", "zsh", "fish"];

    /// <summary>
    /// Builds the `completion &lt;shell&gt;` command. Pass the root command so the script describes
    /// the tree as assembled, including any hand-written commands added alongside the generated ones.
    /// </summary>
    public static Command CreateCommand(Command root, string toolName)
    {
        var shell = new Argument<string>("shell")
        {
            Description = "Shell to emit a completion script for: bash, zsh, or fish.",
        };

        var command = new Command(
            "completion",
            "Print a shell completion script on stdout, generated from this CLI's command tree.")
        {
            shell,
        };

        command.SetAction(parseResult =>
        {
            var requested = (parseResult.GetValue(shell) ?? string.Empty).Trim().ToLowerInvariant();
            if (!SupportedShells.Contains(requested, StringComparer.Ordinal))
            {
                Console.Error.WriteLine(
                    "Unsupported shell '" + requested + "'. Accepted values: " + string.Join(", ", SupportedShells) + ".");
                return 2;
            }

            Console.WriteLine(Generate(requested, root, toolName));
            return 0;
        });

        return command;
    }

    public static string Generate(string shell, Command root, string toolName) => shell switch
    {
        "bash" => GenerateBash(root, toolName),
        "zsh" => GenerateZsh(root, toolName),
        "fish" => GenerateFish(root, toolName),
        _ => throw new ArgumentException("Unsupported shell '" + shell + "'.", nameof(shell)),
    };

    private static IEnumerable<Command> VisibleSubcommands(Command command) =>
        command.Subcommands.Where(x => !x.Hidden).OrderBy(x => x.Name, StringComparer.Ordinal);

    private static List<string> OptionNames(Command command) =>
        [.. command.Options
            .Where(option => !option.Hidden)
            .SelectMany(option => new[] { option.Name }.Concat(option.Aliases))
            .Distinct(StringComparer.Ordinal)
            .OrderBy(name => name, StringComparer.Ordinal)];

    /// <summary>
    /// Enum-typed options complete their own values, read from the option's value type rather than
    /// from the spec, so hand-added options are covered too.
    /// </summary>
    private static List<(string Option, string Values)> EnumOptions(Command command) =>
        [.. command.Options
            .Where(option => !option.Hidden)
            .Select(option => (option.Name, Type: Nullable.GetUnderlyingType(option.ValueType) ?? option.ValueType))
            .Where(x => x.Type.IsEnum)
            .Select(x => (x.Name, string.Join(" ", Enum.GetNames(x.Type))))];

    private static IEnumerable<(string Top, Command Command)> Walk(Command command, string top)
    {
        foreach (var child in VisibleSubcommands(command))
        {
            var childTop = string.IsNullOrEmpty(top) ? child.Name : top;
            yield return (childTop, child);
            foreach (var descendant in Walk(child, childTop))
            {
                yield return descendant;
            }
        }
    }

    private static string GenerateBash(Command root, string toolName)
    {
        var id = Identifier(toolName);
        var builder = new StringBuilder();
        builder.AppendLine("# " + toolName + " completion (bash), generated from the CLI command tree.");
        builder.AppendLine("_" + id + "_completions() {");
        builder.AppendLine("  local cur prev sub i");
        builder.AppendLine("  COMPREPLY=()");
        builder.AppendLine("  cur=\"${COMP_WORDS[COMP_CWORD]}\"");
        builder.AppendLine("  prev=\"${COMP_WORDS[COMP_CWORD-1]}\"");
        builder.AppendLine("  sub=\"\"");
        builder.AppendLine("  for ((i=1; i<COMP_CWORD; i++)); do");
        builder.AppendLine("    case \"${COMP_WORDS[i]}\" in");
        builder.AppendLine("      -*) ;;");
        builder.AppendLine("      *) if [[ -z \"$sub\" ]]; then sub=\"${COMP_WORDS[i]}\"; fi ;;");
        builder.AppendLine("    esac");
        builder.AppendLine("  done");
        builder.AppendLine();

        foreach (var (top, command) in Walk(root, string.Empty))
        {
            foreach (var (option, values) in EnumOptions(command))
            {
                builder.AppendLine("  if [[ \"$prev\" == \"" + option + "\" && \"$sub\" == \"" + top + "\" ]]; then");
                builder.AppendLine("    COMPREPLY=( $(compgen -W \"" + values + "\" -- \"$cur\") ); return 0");
                builder.AppendLine("  fi");
            }
        }

        builder.AppendLine("  if [[ \"$cur\" == -* ]]; then");
        builder.AppendLine("    local options=\"" + string.Join(" ", OptionNames(root)) + "\"");
        builder.AppendLine("    case \"$sub\" in");
        foreach (var command in VisibleSubcommands(root))
        {
            var options = OptionNames(command);
            if (options.Count > 0)
            {
                builder.AppendLine("      " + command.Name + ") options=\"$options " + string.Join(" ", options) + "\" ;;");
            }
        }

        builder.AppendLine("    esac");
        builder.AppendLine("    COMPREPLY=( $(compgen -W \"$options\" -- \"$cur\") ); return 0");
        builder.AppendLine("  fi");
        builder.AppendLine();
        builder.AppendLine("  if [[ -z \"$sub\" ]]; then");
        builder.AppendLine("    COMPREPLY=( $(compgen -W \"" + string.Join(" ", VisibleSubcommands(root).Select(x => x.Name)) + "\" -- \"$cur\") ); return 0");
        builder.AppendLine("  fi");
        builder.AppendLine();
        builder.AppendLine("  case \"$sub\" in");
        foreach (var command in VisibleSubcommands(root))
        {
            var children = VisibleSubcommands(command).Select(x => x.Name).ToList();
            if (children.Count > 0)
            {
                builder.AppendLine("    " + command.Name + ") COMPREPLY=( $(compgen -W \"" + string.Join(" ", children) + "\" -- \"$cur\") ) ;;");
            }
        }

        builder.AppendLine("  esac");
        builder.AppendLine("}");
        builder.AppendLine("complete -F _" + id + "_completions " + toolName);
        return builder.ToString();
    }

    private static string GenerateZsh(Command root, string toolName)
    {
        var id = Identifier(toolName);
        var builder = new StringBuilder();
        builder.AppendLine("#compdef " + toolName);
        builder.AppendLine("# " + toolName + " completion (zsh), generated from the CLI command tree.");
        builder.AppendLine("_" + id + "() {");
        builder.AppendLine("  local -a commands");
        builder.Append("  commands=(");
        foreach (var command in VisibleSubcommands(root))
        {
            builder.Append(" '" + command.Name + ":" + Describe(command.Description) + "'");
        }

        builder.AppendLine(" )");
        builder.AppendLine("  if (( CURRENT == 2 )); then");
        builder.AppendLine("    _describe -t commands 'command' commands && return");
        builder.AppendLine("  fi");
        builder.AppendLine("  local sub=\"${words[2]}\"");
        builder.AppendLine("  local previous=\"${words[CURRENT-1]}\"");

        foreach (var (top, command) in Walk(root, string.Empty))
        {
            foreach (var (option, values) in EnumOptions(command))
            {
                builder.AppendLine("  if [[ \"$previous\" == \"" + option + "\" && \"$sub\" == \"" + top + "\" ]]; then");
                builder.AppendLine("    _values '" + option.TrimStart('-') + "' " + values + " && return");
                builder.AppendLine("  fi");
            }
        }

        builder.AppendLine("  case \"$sub\" in");
        foreach (var command in VisibleSubcommands(root))
        {
            var words = VisibleSubcommands(command).Select(x => x.Name)
                .Concat(OptionNames(command))
                .Concat(OptionNames(root))
                .Distinct(StringComparer.Ordinal)
                .Select(x => "'" + x + "'");
            builder.AppendLine("    " + command.Name + ") _values 'argument' " + string.Join(" ", words) + " ;;");
        }

        builder.AppendLine("  esac");
        builder.AppendLine("}");
        builder.AppendLine("_" + id + " \"$@\"");
        return builder.ToString();
    }

    private static string GenerateFish(Command root, string toolName)
    {
        var builder = new StringBuilder();
        builder.AppendLine("# " + toolName + " completion (fish), generated from the CLI command tree.");
        builder.AppendLine("complete -c " + toolName + " -f");
        foreach (var command in VisibleSubcommands(root))
        {
            builder.AppendLine("complete -c " + toolName + " -n '__fish_use_subcommand' -a '" + command.Name + "' -d '" + Describe(command.Description) + "'");
            foreach (var child in VisibleSubcommands(command))
            {
                builder.AppendLine("complete -c " + toolName + " -n '__fish_seen_subcommand_from " + command.Name + "' -a '" + child.Name + "'");
            }

            foreach (var option in OptionNames(command).Where(x => x.StartsWith("--", StringComparison.Ordinal)))
            {
                builder.AppendLine("complete -c " + toolName + " -n '__fish_seen_subcommand_from " + command.Name + "' -l '" + option.Substring(2) + "'");
            }
        }

        foreach (var option in OptionNames(root).Where(x => x.StartsWith("--", StringComparison.Ordinal)))
        {
            builder.AppendLine("complete -c " + toolName + " -l '" + option.Substring(2) + "'");
        }

        foreach (var (top, command) in Walk(root, string.Empty))
        {
            foreach (var (option, values) in EnumOptions(command))
            {
                builder.AppendLine("complete -c " + toolName + " -n '__fish_seen_subcommand_from " + top + "' -l " + option.TrimStart('-') + " -x -a '" + values + "'");
            }
        }

        return builder.ToString();
    }

    private static string Describe(string? description) =>
        (description ?? string.Empty).Replace("'", " ", StringComparison.Ordinal).Replace("\n", " ", StringComparison.Ordinal);

    private static string Identifier(string toolName) =>
        new([.. toolName.Select(c => char.IsLetterOrDigit(c) ? c : '_')]);
}