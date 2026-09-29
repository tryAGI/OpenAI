
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteContainerResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        ContainerDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteContainerResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteContainerResponseObject value)
        {
            return value switch
            {
                DeleteContainerResponseObject.ContainerDeleted => "container.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteContainerResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "container.deleted" => DeleteContainerResponseObject.ContainerDeleted,
                _ => null,
            };
        }
    }
}