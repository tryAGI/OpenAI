// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// All prices in USD. <br/>
/// According https://openai.com/pricing/ <br/>
/// </summary>
public static class ImagePrices
{
    /// <inheritdoc cref="ImagePrices"/>
    /// <param name="model"></param>
    /// <param name="quality"></param>
    /// <param name="resolution"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double? TryGet(
        ImageModels model,
        ImageResolutions resolution,
        ImageQualities? quality = null)
    {
        quality ??= ImageQualities.Standard;
        
        return (model.Id, quality.Value.Value, resolution.Value) switch
        {
            (ImageModels.DallE3Id, ImageQualities.StandardValue, ImageResolutions._1024x1024Value) => 0.040,
            (ImageModels.DallE3Id, ImageQualities.StandardValue, ImageResolutions._1024x1792Value) => 0.080,
            (ImageModels.DallE3Id, ImageQualities.StandardValue, ImageResolutions._1792x1024Value) => 0.080,
            
            (ImageModels.DallE3Id, ImageQualities.HdValue, ImageResolutions._1024x1024Value) => 0.080,
            (ImageModels.DallE3Id, ImageQualities.HdValue, ImageResolutions._1024x1792Value) => 0.120,
            (ImageModels.DallE3Id, ImageQualities.HdValue, ImageResolutions._1792x1024Value) => 0.120,
            
            (ImageModels.DallE2Id, _, ImageResolutions._1024x1024Value) => 0.020,
            (ImageModels.DallE2Id, _, ImageResolutions._512x512Value) => 0.018,
            (ImageModels.DallE2Id, _, ImageResolutions._256x256Value) => 0.016,
            
            _ => null,
        };
    }
    
    /// <inheritdoc cref="TryGet(ImageModels, ImageResolutions, ImageQualities?)"/>
    public static double Get(
        ImageModels model,
        ImageResolutions resolution,
        ImageQualities? quality = null)
    {
        return TryGet(
                   model: model,
                   resolution: resolution,
                   quality: quality) ??
               throw new NotImplementedException();
    }
}