namespace tryAGI.OpenAI;

public partial class Image2
{
    /// <summary>
    /// Returns bytes of base64-encoded JSON of the generated image.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public byte[] Bytes => B64Json == null || string.IsNullOrWhiteSpace(B64Json)
        ? throw new InvalidOperationException("The image is not available in base64 format.")
        : Convert.FromBase64String(B64Json);

    /// <summary>
    /// Returns the image bytes from either the inline base64 payload or the
    /// provider-issued URL.
    /// </summary>
    /// <param name="httpClient">Optional client used to download a URL result.</param>
    /// <param name="cancellationToken">The token to cancel a URL download.</param>
    /// <returns>The decoded or downloaded image bytes.</returns>
    /// <exception cref="InvalidOperationException">The response contains neither base64 data nor a valid URL.</exception>
    public async Task<byte[]> GetBytesAsync(
        HttpClient? httpClient = null,
        CancellationToken cancellationToken = default)
    {
        if (!string.IsNullOrWhiteSpace(B64Json))
        {
            return Bytes;
        }

        if (!Uri.TryCreate(Url, UriKind.Absolute, out var imageUri))
        {
            throw new InvalidOperationException("The image is not available as base64 data or an absolute URL.");
        }

        HttpClient? ownedHttpClient = null;
        var effectiveHttpClient = httpClient ?? (ownedHttpClient = new HttpClient());
        try
        {
            return await effectiveHttpClient.GetByteArrayAsync(imageUri, cancellationToken).ConfigureAwait(false);
        }
        finally
        {
            ownedHttpClient?.Dispose();
        }
    }
}
