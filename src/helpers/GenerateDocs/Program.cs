var solutionDirectory = args.ElementAtOrDefault(0) ?? Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../.."));
var sampleDirectory = Path.Combine(solutionDirectory, "src", "tests", "OpenAI.IntegrationTests", "Examples");
var mkDocsPath = Path.Combine(solutionDirectory, "mkdocs.yml");

var newDir = Path.Combine(solutionDirectory, "docs", "samples");
Directory.CreateDirectory(newDir);

File.Copy(
    Path.Combine(solutionDirectory, "README.md"),
    Path.Combine(solutionDirectory, "docs", "index.md"),
    overwrite: true);

Console.WriteLine($"Generating samples from {sampleDirectory}...");
foreach (var path in Directory.EnumerateFiles(sampleDirectory, "Examples.*.cs", SearchOption.AllDirectories))
{
    var code = await File.ReadAllTextAsync(path);

    var startExample = code.IndexOf("// # START EXAMPLE #", StringComparison.Ordinal);
    if (startExample == -1)
    {
        var start = code.IndexOf("\n    {", StringComparison.Ordinal);
        var end = code.IndexOf("\n    }", StringComparison.Ordinal);
        code = code.Substring(start + 4, end - start + 4);
        
        var lines = code.Split('\n')[1..^2];
        code = string.Join('\n', lines.Select(x => x.Length > 8 ? x[8..] : string.Empty));
    }
    else
    {
        code = code[(startExample + "// # START EXAMPLE #".Length)..].Trim();
    }
    
    var newPath = Path.Combine(newDir, $"{Path.GetFileNameWithoutExtension(path).Replace("Examples.", string.Empty)}.md");
    await File.WriteAllTextAsync(newPath, $@"```csharp
{code}
```");
}

var mkDocs = await File.ReadAllTextAsync(mkDocsPath);
var startIndex = mkDocs.IndexOf("# START EXAMPLES #", StringComparison.Ordinal) + "# START EXAMPLES #".Length;
var endIndex = mkDocs.IndexOf("# END EXAMPLES #", StringComparison.Ordinal);
mkDocs = mkDocs.Remove(startIndex, endIndex - startIndex);
var newMkDocs = mkDocs.Insert(
    startIndex,
    $@"
- Examples:{string.Concat(Directory.EnumerateFiles(Path.Combine(solutionDirectory, "docs", "samples"), "*.md")
        .GroupBy(x => Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(x)))
        .Select(x => $@"
  - {x.Key}:{string.Concat(x.Select(y => $@"
    - {Path.GetExtension(Path.GetFileNameWithoutExtension(y)).TrimStart('.')}: samples/{Path.GetFileName(y)}"))}"))}
");
await File.WriteAllTextAsync(mkDocsPath, newMkDocs);

