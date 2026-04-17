using System.Diagnostics;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsyncApiSpecRoundtrip_BuildScriptOutputMatchesCheckedInFile()
    {
        var libDir = FindRealtimeLibDir();
        var script = Path.Combine(libDir, "build-asyncapi.py");
        var openapi = Path.Combine(libDir, "openapi.yaml");
        var committedAsyncApi = Path.Combine(libDir, "asyncapi.json");

        File.Exists(script).Should().BeTrue($"expected {script} to exist");
        File.Exists(openapi).Should().BeTrue($"expected {openapi} to exist — run generate.sh first");
        File.Exists(committedAsyncApi).Should().BeTrue($"expected {committedAsyncApi} to exist");

        var python = FindPython();
        var tempOutput = Path.Combine(Path.GetTempPath(), $"asyncapi-roundtrip-{Guid.NewGuid():N}.json");
        try
        {
            RunPython(python, script, openapi, tempOutput);

            var actual = File.ReadAllText(tempOutput);
            var expected = File.ReadAllText(committedAsyncApi);

            if (actual != expected)
            {
                throw new AssertFailedException(
                    $"asyncapi.json is out of sync with openapi.yaml. " +
                    $"Re-run `python3 build-asyncapi.py` in {libDir} and commit the result. " +
                    $"(script output: {tempOutput}; committed: {committedAsyncApi})");
            }
        }
        finally
        {
            if (File.Exists(tempOutput))
            {
                File.Delete(tempOutput);
            }
        }
    }

    private static string FindRealtimeLibDir()
    {
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir is not null)
        {
            var candidate = Path.Combine(dir.FullName, "src", "libs", "tryAGI.OpenAI");
            if (Directory.Exists(candidate))
            {
                return candidate;
            }
            dir = dir.Parent;
        }
        throw new AssertInconclusiveException("Could not locate src/libs/tryAGI.OpenAI relative to test binary.");
    }

    private static string FindPython()
    {
        foreach (var candidate in new[] { "python3", "python" })
        {
            try
            {
                using var probe = Process.Start(new ProcessStartInfo(candidate, "--version")
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                });
                if (probe is null)
                {
                    continue;
                }
                probe.WaitForExit(5_000);
                if (probe.ExitCode == 0)
                {
                    return candidate;
                }
            }
            catch (Exception)
            {
                // Try next candidate.
            }
        }
        throw new AssertInconclusiveException("python3/python not found on PATH — roundtrip check requires Python with PyYAML installed.");
    }

    private static void RunPython(string python, string script, string inputPath, string outputPath)
    {
        var psi = new ProcessStartInfo(python)
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
        };
        psi.ArgumentList.Add(script);
        psi.ArgumentList.Add("--input");
        psi.ArgumentList.Add(inputPath);
        psi.ArgumentList.Add("--output");
        psi.ArgumentList.Add(outputPath);

        using var proc = Process.Start(psi) ?? throw new AssertInconclusiveException($"Failed to start {python}");
        var stdout = proc.StandardOutput.ReadToEnd();
        var stderr = proc.StandardError.ReadToEnd();
        proc.WaitForExit(30_000);

        if (proc.ExitCode != 0)
        {
            if (stderr.Contains("ModuleNotFoundError", StringComparison.Ordinal) &&
                stderr.Contains("yaml", StringComparison.OrdinalIgnoreCase))
            {
                throw new AssertInconclusiveException(
                    $"build-asyncapi.py requires PyYAML (`pip install pyyaml`). stderr:\n{stderr}");
            }
            throw new AssertFailedException(
                $"build-asyncapi.py exited with code {proc.ExitCode}.\nstdout:\n{stdout}\nstderr:\n{stderr}");
        }
    }
}
