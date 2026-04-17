using System.CommandLine;

namespace tryAGI.OpenAI.Cli.Commands;

internal static class ImagesCommand
{
    public static Command Create()
    {
        var cmd = new Command("images", "Image generation.");
        cmd.Subcommands.Add(CreateGenerateCommand());
        return cmd;
    }

    private static Command CreateGenerateCommand()
    {
        var promptArg = new Argument<string>("prompt")
        {
            Description = "Text description of the image to generate.",
        };
        var modelOpt = new Option<string>("--model")
        {
            DefaultValueFactory = _ => "gpt-image-1-mini",
            Description = "Model id. `gpt-image-1-mini` | `gpt-image-1` | `dall-e-3` | `dall-e-2`.",
        };
        var sizeOpt = new Option<string>("--size")
        {
            DefaultValueFactory = _ => "1024x1024",
            Description = "Image size (e.g. `1024x1024`, `1792x1024`).",
        };
        var qualityOpt = new Option<string?>("--quality")
        {
            Description = "Quality: `low` | `medium` | `high`.",
        };
        var nOpt = new Option<int>("--n")
        {
            DefaultValueFactory = _ => 1,
            Description = "Number of images to generate.",
        };
        var saveOpt = new Option<string?>("--save-to")
        {
            Description = "Directory to save generated images into. Each image is written as `image-N.png`.",
        };

        var cmd = new Command("generate", "Generate an image from a text prompt.");
        cmd.Arguments.Add(promptArg);
        cmd.Options.Add(modelOpt);
        cmd.Options.Add(sizeOpt);
        cmd.Options.Add(qualityOpt);
        cmd.Options.Add(nOpt);
        cmd.Options.Add(saveOpt);

        cmd.SetAction(CliRuntime.Wrap(async (parseResult, cancellationToken) =>
        {
            using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

            var prompt = CliRuntime.GetRequiredArgument(parseResult, promptArg);
            var modelValue = parseResult.GetValue(modelOpt) ?? "gpt-image-1-mini";
            var sizeValue = parseResult.GetValue(sizeOpt) ?? "1024x1024";
            var qualityValue = parseResult.GetValue(qualityOpt);
            var n = parseResult.GetValue(nOpt);
            var saveTo = parseResult.GetValue(saveOpt);

            var model = CreateImageRequestModelExtensions.ToEnum(modelValue);
            var size = CreateImageRequestSizeExtensions.ToEnum(sizeValue);
            var quality = string.IsNullOrWhiteSpace(qualityValue)
                ? default(CreateImageRequestQuality?)
                : CreateImageRequestQualityExtensions.ToEnum(qualityValue);

            var response = await client.Images.CreateImageAsync(
                prompt: prompt,
                model: model,
                n: n,
                size: size,
                quality: quality,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var images = response.Data ?? [];
            if (!string.IsNullOrWhiteSpace(saveTo))
            {
                Directory.CreateDirectory(saveTo);
                var index = 0;
                foreach (var image in images)
                {
                    index++;
                    var destination = Path.Combine(saveTo, $"image-{index}.png");
                    if (!string.IsNullOrWhiteSpace(image.B64Json))
                    {
                        var bytes = Convert.FromBase64String(image.B64Json);
                        await File.WriteAllBytesAsync(destination, bytes, cancellationToken).ConfigureAwait(false);
                    }
                    else if (!string.IsNullOrWhiteSpace(image.Url))
                    {
                        using var httpClient = new HttpClient();
                        var bytes = await httpClient.GetByteArrayAsync(new Uri(image.Url), cancellationToken).ConfigureAwait(false);
                        await File.WriteAllBytesAsync(destination, bytes, cancellationToken).ConfigureAwait(false);
                    }
                }
            }

            var summaryLines = new List<string>
            {
                $"generated: {images.Count} image(s)",
            };
            var i = 0;
            foreach (var image in images)
            {
                i++;
                if (!string.IsNullOrWhiteSpace(image.Url))
                {
                    summaryLines.Add($"image-{i}: {image.Url}");
                }
                else if (!string.IsNullOrWhiteSpace(image.B64Json))
                {
                    summaryLines.Add($"image-{i}: {image.B64Json.Length} base64 chars");
                }
            }

            if (!string.IsNullOrWhiteSpace(saveTo))
            {
                summaryLines.Add($"saved-to: {saveTo}");
            }

            await CliRuntime.WriteOutputAsync(parseResult, string.Join(Environment.NewLine, summaryLines), response, cancellationToken).ConfigureAwait(false);
        }));

        return cmd;
    }
}
