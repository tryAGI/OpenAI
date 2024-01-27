// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ImageModels
{
    /// <summary>
    /// The image generations endpoint allows you to create an original image given a text prompt. <br/>
    /// Images can have a size of 1024x1024, 1024x1792 or 1792x1024 pixels. <br/>
    /// </summary>
    internal const string DallE2Id = "dall-e-2";
    
    /// <inheritdoc cref="DallE2Id"/>
    public static ImageModels DallE2 { get; } = new(DallE2Id);
}