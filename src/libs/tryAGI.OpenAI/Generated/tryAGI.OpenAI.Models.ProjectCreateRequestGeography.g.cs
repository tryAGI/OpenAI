
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Create the project with the specified data residency region. Your organization must have access to Data residency functionality in order to use. See [data residency controls](/docs/guides/your-data#data-residency-controls) to review the functionality and limitations of setting this field.
    /// </summary>
    public enum ProjectCreateRequestGeography
    {
        /// <summary>
        /// 
        /// </summary>
        Us,
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Jp,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        Kr,
        /// <summary>
        /// 
        /// </summary>
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Au,
        /// <summary>
        /// 
        /// </summary>
        Sg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectCreateRequestGeographyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectCreateRequestGeography value)
        {
            return value switch
            {
                ProjectCreateRequestGeography.Us => "US",
                ProjectCreateRequestGeography.Eu => "EU",
                ProjectCreateRequestGeography.Jp => "JP",
                ProjectCreateRequestGeography.In => "IN",
                ProjectCreateRequestGeography.Kr => "KR",
                ProjectCreateRequestGeography.Ca => "CA",
                ProjectCreateRequestGeography.Au => "AU",
                ProjectCreateRequestGeography.Sg => "SG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectCreateRequestGeography? ToEnum(string value)
        {
            return value switch
            {
                "US" => ProjectCreateRequestGeography.Us,
                "EU" => ProjectCreateRequestGeography.Eu,
                "JP" => ProjectCreateRequestGeography.Jp,
                "IN" => ProjectCreateRequestGeography.In,
                "KR" => ProjectCreateRequestGeography.Kr,
                "CA" => ProjectCreateRequestGeography.Ca,
                "AU" => ProjectCreateRequestGeography.Au,
                "SG" => ProjectCreateRequestGeography.Sg,
                _ => null,
            };
        }
    }
}