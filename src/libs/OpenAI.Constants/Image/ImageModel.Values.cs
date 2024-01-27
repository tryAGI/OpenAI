// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/guides/images/introduction
/// </summary>
public readonly partial record struct ImageModel
{
    /// <summary>
    /// The image generations endpoint allows you to create an original image given a text prompt. <br/>
    /// Images can have a size of 1024x1024, 1024x1792 or 1792x1024 pixels. <br/>
    /// </summary>
    internal const string DallE3Id = "dall-e-3";
    
    /// <summary>
    /// The image generations endpoint allows you to create an original image given a text prompt. <br/>
    /// Images can have a size of 1024x1024, 1024x1792 or 1792x1024 pixels. <br/>
    /// </summary>
    internal const string DallE2Id = "dall-e-2";
    
    /// <inheritdoc cref="DallE3Id"/>
    public static ImageModel DallE3 { get; } = new(DallE3Id);
    
    /// <inheritdoc cref="DallE2Id"/>
    public static ImageModel DallE2 { get; } = new(DallE2Id);
}