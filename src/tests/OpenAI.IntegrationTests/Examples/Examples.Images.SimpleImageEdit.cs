namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task SimpleImageEdit()
    {
        using var api = GetAuthenticatedClient();

        FileInfo originalFileInfo = new($"{Guid.NewGuid()}.png");
        
        await File.WriteAllBytesAsync(originalFileInfo.FullName, H.Resources.images_flower_vase_png.AsBytes());
        
        Console.WriteLine($"Original Image available at:\n{new Uri(originalFileInfo.FullName).AbsoluteUri}");
        
        FileInfo maskFileInfo = new($"{Guid.NewGuid()}.png");
        
        await File.WriteAllBytesAsync(maskFileInfo.FullName, H.Resources.images_flower_vase_mask_png.AsBytes());
        
        Console.WriteLine($"Mask available at:\n{new Uri(maskFileInfo.FullName).AbsoluteUri}");
        
        ImagesResponse image = await api.Images.CreateImageEditAsync(
            image: H.Resources.images_flower_vase_png.AsBytes(),
            //imagename: H.Resources.images_flower_vase_png.FileName,
            prompt: "A vase full of beautiful flowers.",
            mask: H.Resources.images_flower_vase_mask_png.AsBytes(),
            maskname: H.Resources.images_flower_vase_mask_png.FileName,
            model: CreateImageEditRequestModel.DallE2,
            size: CreateImageEditRequestSize.x512x512,
            responseFormat: CreateImageEditRequestResponseFormat.B64Json);
        byte[] bytes = image.Data?[0].Bytes ?? throw new InvalidOperationException("No bytes returned from the API.");

        FileInfo fileInfo = new($"{Guid.NewGuid()}.png");
        
        await File.WriteAllBytesAsync(fileInfo.FullName, bytes);
        
        Console.WriteLine($"Image available at:\n{new Uri(fileInfo.FullName).AbsoluteUri}");
    }
}
