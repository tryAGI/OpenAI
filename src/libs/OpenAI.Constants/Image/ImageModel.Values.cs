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
    internal const string DallE3Value = "dall-e-3";
    
    /// <summary>
    /// The image generations endpoint allows you to create an original image given a text prompt. <br/>
    /// Images can have a size of 1024x1024, 1024x1792 or 1792x1024 pixels. <br/>
    /// </summary>
    internal const string DallE2Value = "dall-e-2";
    
    /// <inheritdoc cref="DallE3Value"/>
    public static ImageModel DallE3 { get; } = new(DallE3Value);
    
    /// <inheritdoc cref="DallE2Value"/>
    public static ImageModel DallE2 { get; } = new(DallE2Value);
}