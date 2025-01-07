namespace tryAGI.OpenAI;

public partial class Image
{
    /// <summary>
    /// Returns bytes of base64-encoded JSON of the generated image.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public byte[] Bytes => B64Json == null || string.IsNullOrWhiteSpace(B64Json)
        ? throw new InvalidOperationException("The image is not available in base64 format.")
        : Convert.FromBase64String(B64Json);
}