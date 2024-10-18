
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModifyAssistantRequestToolDiscriminatorType
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
    public static class ModifyAssistantRequestToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyAssistantRequestToolDiscriminatorType value)
        {
            return value switch
            {
                ModifyAssistantRequestToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                ModifyAssistantRequestToolDiscriminatorType.FileSearch => "file_search",
                ModifyAssistantRequestToolDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyAssistantRequestToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => ModifyAssistantRequestToolDiscriminatorType.CodeInterpreter,
                "file_search" => ModifyAssistantRequestToolDiscriminatorType.FileSearch,
                "function" => ModifyAssistantRequestToolDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}