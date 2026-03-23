
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
        Au,
        /// <summary>
        /// 
        /// </summary>
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        Jp,
        /// <summary>
        /// 
        /// </summary>
        Kr,
        /// <summary>
        /// 
        /// </summary>
        Sg,
        /// <summary>
        /// 
        /// </summary>
        Us,
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
                ProjectCreateRequestGeography.Au => "AU",
                ProjectCreateRequestGeography.Ca => "CA",
                ProjectCreateRequestGeography.Eu => "EU",
                ProjectCreateRequestGeography.In => "IN",
                ProjectCreateRequestGeography.Jp => "JP",
                ProjectCreateRequestGeography.Kr => "KR",
                ProjectCreateRequestGeography.Sg => "SG",
                ProjectCreateRequestGeography.Us => "US",
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
                "AU" => ProjectCreateRequestGeography.Au,
                "CA" => ProjectCreateRequestGeography.Ca,
                "EU" => ProjectCreateRequestGeography.Eu,
                "IN" => ProjectCreateRequestGeography.In,
                "JP" => ProjectCreateRequestGeography.Jp,
                "KR" => ProjectCreateRequestGeography.Kr,
                "SG" => ProjectCreateRequestGeography.Sg,
                "US" => ProjectCreateRequestGeography.Us,
                _ => null,
            };
        }
    }
}