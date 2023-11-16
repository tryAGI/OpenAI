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
        ImageModel model,
        ImageResolution resolution,
        ImageQuality? quality = null)
    {
        quality ??= ImageQuality.Standard;
        
        return (model.Value, quality.Value.Value, resolution.Value) switch
        {
            (ImageModel.DallE3Value, ImageQuality.StandardValue, ImageResolution._1024x1024Value) => 0.040,
            (ImageModel.DallE3Value, ImageQuality.StandardValue, ImageResolution._1024x1792Value) => 0.080,
            (ImageModel.DallE3Value, ImageQuality.StandardValue, ImageResolution._1792x1024Value) => 0.080,
            
            (ImageModel.DallE3Value, ImageQuality.HdValue, ImageResolution._1024x1024Value) => 0.080,
            (ImageModel.DallE3Value, ImageQuality.HdValue, ImageResolution._1024x1792Value) => 0.120,
            (ImageModel.DallE3Value, ImageQuality.HdValue, ImageResolution._1792x1024Value) => 0.120,
            
            (ImageModel.DallE2Value, _, ImageResolution._1024x1024Value) => 0.020,
            (ImageModel.DallE2Value, _, ImageResolution._512x512Value) => 0.018,
            (ImageModel.DallE2Value, _, ImageResolution._256x256Value) => 0.016,
            
            _ => null,
        };
    }
    
    /// <inheritdoc cref="TryGet(ImageModel, ImageResolution, ImageQuality?)"/>
    public static double Get(
        ImageModel model,
        ImageResolution resolution,
        ImageQuality? quality = null)
    {
        return TryGet(
                   model: model,
                   resolution: resolution,
                   quality: quality) ??
               throw new NotImplementedException();
    }
}