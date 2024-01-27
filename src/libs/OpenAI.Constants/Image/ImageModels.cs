// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/guides/images/introduction
/// </summary>
/// <param name="Id">Id of the model.</param>
public readonly partial record struct ImageModels(string Id)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="ImageModels"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ImageModels model)
    {
        return model.Id;
    }
    
    /// <summary>
    /// All prices in USD. <br/>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="quality"></param>
    /// <param name="resolution"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public double GetPriceInUsd(
        ImageResolutions resolution,
        ImageQualities? quality = null)
    {
        quality ??= ImageQualities.Standard;
        
        return (Id, quality.Value.Value, resolution.Value) switch
        {
            (DallE3Id, ImageQualities.StandardValue, ImageResolutions._1024x1024Value) => 0.040,
            (DallE3Id, ImageQualities.StandardValue, ImageResolutions._1024x1792Value) => 0.080,
            (DallE3Id, ImageQualities.StandardValue, ImageResolutions._1792x1024Value) => 0.080,
            
            (DallE3Id, ImageQualities.HdValue, ImageResolutions._1024x1024Value) => 0.080,
            (DallE3Id, ImageQualities.HdValue, ImageResolutions._1024x1792Value) => 0.120,
            (DallE3Id, ImageQualities.HdValue, ImageResolutions._1792x1024Value) => 0.120,
            
            (DallE2Id, _, ImageResolutions._1024x1024Value) => 0.020,
            (DallE2Id, _, ImageResolutions._512x512Value) => 0.018,
            (DallE2Id, _, ImageResolutions._256x256Value) => 0.016,
            
            _ => throw new NotImplementedException(),
        };
    }

    /// <summary>
    /// Returns <see cref="ImageModels"/> by <paramref name="id"/>. <br/>
    /// Returns <see langword="null"/> if <paramref name="id"/> is not found.
    /// </summary>
    /// <param name="id">Id of the model.</param>
    /// <returns></returns>
    public static ImageModels? ById(string id)
    {
        return id switch
        {
            DallE2Id => DallE2,
            DallE3Id => DallE3,
    
            _ => null,
        };
    }
}