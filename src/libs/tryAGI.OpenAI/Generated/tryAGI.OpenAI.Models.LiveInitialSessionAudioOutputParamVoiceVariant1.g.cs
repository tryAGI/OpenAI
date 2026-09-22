
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveInitialSessionAudioOutputParamVoiceVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Alloy,
        /// <summary>
        ///
        /// </summary>
        Ash,
        /// <summary>
        ///
        /// </summary>
        Ballad,
        /// <summary>
        ///
        /// </summary>
        Beacon,
        /// <summary>
        ///
        /// </summary>
        Bossa,
        /// <summary>
        ///
        /// </summary>
        Cedar,
        /// <summary>
        ///
        /// </summary>
        Cinder,
        /// <summary>
        ///
        /// </summary>
        Coral,
        /// <summary>
        ///
        /// </summary>
        Delta,
        /// <summary>
        ///
        /// </summary>
        Echo,
        /// <summary>
        ///
        /// </summary>
        Gleam,
        /// <summary>
        ///
        /// </summary>
        Marin,
        /// <summary>
        ///
        /// </summary>
        Meridian,
        /// <summary>
        ///
        /// </summary>
        Quartz,
        /// <summary>
        ///
        /// </summary>
        Ripple,
        /// <summary>
        ///
        /// </summary>
        Sage,
        /// <summary>
        ///
        /// </summary>
        Shimmer,
        /// <summary>
        ///
        /// </summary>
        Stone,
        /// <summary>
        ///
        /// </summary>
        Tempo,
        /// <summary>
        ///
        /// </summary>
        Verse,
        /// <summary>
        ///
        /// </summary>
        Vesper,
        /// <summary>
        ///
        /// </summary>
        Willow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialSessionAudioOutputParamVoiceVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialSessionAudioOutputParamVoiceVariant1 value)
        {
            return value switch
            {
                LiveInitialSessionAudioOutputParamVoiceVariant1.Alloy => "alloy",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Ash => "ash",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Ballad => "ballad",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Beacon => "beacon",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Bossa => "bossa",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Cedar => "cedar",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Cinder => "cinder",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Coral => "coral",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Delta => "delta",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Echo => "echo",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Gleam => "gleam",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Marin => "marin",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Meridian => "meridian",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Quartz => "quartz",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Ripple => "ripple",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Sage => "sage",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Shimmer => "shimmer",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Stone => "stone",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Tempo => "tempo",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Verse => "verse",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Vesper => "vesper",
                LiveInitialSessionAudioOutputParamVoiceVariant1.Willow => "willow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialSessionAudioOutputParamVoiceVariant1? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => LiveInitialSessionAudioOutputParamVoiceVariant1.Alloy,
                "ash" => LiveInitialSessionAudioOutputParamVoiceVariant1.Ash,
                "ballad" => LiveInitialSessionAudioOutputParamVoiceVariant1.Ballad,
                "beacon" => LiveInitialSessionAudioOutputParamVoiceVariant1.Beacon,
                "bossa" => LiveInitialSessionAudioOutputParamVoiceVariant1.Bossa,
                "cedar" => LiveInitialSessionAudioOutputParamVoiceVariant1.Cedar,
                "cinder" => LiveInitialSessionAudioOutputParamVoiceVariant1.Cinder,
                "coral" => LiveInitialSessionAudioOutputParamVoiceVariant1.Coral,
                "delta" => LiveInitialSessionAudioOutputParamVoiceVariant1.Delta,
                "echo" => LiveInitialSessionAudioOutputParamVoiceVariant1.Echo,
                "gleam" => LiveInitialSessionAudioOutputParamVoiceVariant1.Gleam,
                "marin" => LiveInitialSessionAudioOutputParamVoiceVariant1.Marin,
                "meridian" => LiveInitialSessionAudioOutputParamVoiceVariant1.Meridian,
                "quartz" => LiveInitialSessionAudioOutputParamVoiceVariant1.Quartz,
                "ripple" => LiveInitialSessionAudioOutputParamVoiceVariant1.Ripple,
                "sage" => LiveInitialSessionAudioOutputParamVoiceVariant1.Sage,
                "shimmer" => LiveInitialSessionAudioOutputParamVoiceVariant1.Shimmer,
                "stone" => LiveInitialSessionAudioOutputParamVoiceVariant1.Stone,
                "tempo" => LiveInitialSessionAudioOutputParamVoiceVariant1.Tempo,
                "verse" => LiveInitialSessionAudioOutputParamVoiceVariant1.Verse,
                "vesper" => LiveInitialSessionAudioOutputParamVoiceVariant1.Vesper,
                "willow" => LiveInitialSessionAudioOutputParamVoiceVariant1.Willow,
                _ => null,
            };
        }
    }
}