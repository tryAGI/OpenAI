
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateThreadAndRunRequestToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateThreadAndRunRequestToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateThreadAndRunRequestToolDiscriminatorType value)
        {
            return value switch
            {
                CreateThreadAndRunRequestToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                CreateThreadAndRunRequestToolDiscriminatorType.FileSearch => "file_search",
                CreateThreadAndRunRequestToolDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateThreadAndRunRequestToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => CreateThreadAndRunRequestToolDiscriminatorType.CodeInterpreter,
                "file_search" => CreateThreadAndRunRequestToolDiscriminatorType.FileSearch,
                "function" => CreateThreadAndRunRequestToolDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}