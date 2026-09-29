namespace tryAGI.OpenAI;

public static class EmbeddingExtensions
{
    public static float[] GetFloatVector(this Embedding embedding)
    {
        ArgumentNullException.ThrowIfNull(embedding);

        object value = embedding.Embedding1;
        return value switch
        {
            IList<float> floats => floats.ToArray(),
            AnyOf<IList<float>, string> { Value1: { } floats } => floats.ToArray(),
            AnyOf<IList<float>, string> { Value2: { } base64 } => DecodeBase64(base64),
            _ => throw new InvalidOperationException("The embeddings response did not contain a float vector."),
        };
    }

    private static float[] DecodeBase64(string base64)
    {
        var bytes = Convert.FromBase64String(base64);
        if (bytes.Length % sizeof(float) != 0)
        {
            throw new FormatException("The base64 embedding does not contain complete float values.");
        }

        return System.Runtime.InteropServices.MemoryMarshal.Cast<byte, float>(bytes).ToArray();
    }
}
