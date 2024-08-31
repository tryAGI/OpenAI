namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task SimpleImageVariation()
    {
        using var api = GetAuthenticatedClient();

        FileInfo originalFileInfo = new($"{Guid.NewGuid()}.png");
        
        await File.WriteAllBytesAsync(originalFileInfo.FullName, H.Resources.images_dog_and_cat_png.AsBytes());
        
        Console.WriteLine($"Original Image available at:\n{new Uri(originalFileInfo.FullName).AbsoluteUri}");
        
        ImagesResponse image = await api.Images.CreateImageVariationAsync(
            image: H.Resources.images_dog_and_cat_png.AsBytes(),
            imagename: H.Resources.images_dog_and_cat_png.FileName,
            model: CreateImageVariationRequestModel.DallE2,
            size: CreateImageVariationRequestSize.x256x256,
            responseFormat: CreateImageVariationRequestResponseFormat.B64Json);
        byte[] bytes = image.Data[0].Bytes;

        FileInfo fileInfo = new($"{Guid.NewGuid()}.png");
        
        await File.WriteAllBytesAsync(fileInfo.FullName, bytes);
        
        Console.WriteLine($"Image available at:\n{new Uri(fileInfo.FullName).AbsoluteUri}");
    }
}
