namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task SimpleImageGeneration()
    {
        using var api = GetAuthenticatedClient();

        ImagesResponse image = await api.Images.CreateImageAsync(
            prompt: "The concept for a living room that blends Scandinavian simplicity with Japanese minimalism for"
                    + " a serene and cozy atmosphere. It's a space that invites relaxation and mindfulness, with natural light"
                    + " and fresh air. Using neutral tones, including colors like white, beige, gray, and black, that create a"
                    + " sense of harmony. Featuring sleek wood furniture with clean lines and subtle curves to add warmth and"
                    + " elegance. Plants and flowers in ceramic pots adding color and life to a space. They can serve as focal"
                    + " points, creating a connection with nature. Soft textiles and cushions in organic fabrics adding comfort"
                    + " and softness to a space. They can serve as accents, adding contrast and texture.",
            model: CreateImageRequestModel.DallE3,
            quality: CreateImageRequestQuality.Hd,
            size: CreateImageRequestSize.x1792x1024,
            style: CreateImageRequestStyle.Vivid,
            responseFormat: CreateImageRequestResponseFormat.B64Json);
        byte[] bytes = image.Data[0].Bytes;

        FileInfo fileInfo = new($"{Guid.NewGuid()}.png");
        
        await File.WriteAllBytesAsync(fileInfo.FullName, bytes);
        
        Console.WriteLine($"Image available at:\n{new Uri(fileInfo.FullName).AbsoluteUri}");
    }
}
