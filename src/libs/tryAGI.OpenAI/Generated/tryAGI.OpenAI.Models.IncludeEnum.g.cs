
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specify additional output data to include in the model response. Currently supported values are:<br/>
    /// - `web_search_call.results`: Include the search results of the web search tool call.<br/>
    /// - `web_search_call.action.sources`: Include the sources of the web search tool call.<br/>
    /// - `code_interpreter_call.outputs`: Includes the outputs of python code execution in code interpreter tool call items.<br/>
    /// - `computer_call_output.output.image_url`: Include image urls from the computer call output.<br/>
    /// - `file_search_call.results`: Include the search results of the file search tool call.<br/>
    /// - `message.input_image.image_url`: Include image urls from the input message.<br/>
    /// - `message.output_text.logprobs`: Include logprobs with assistant messages.<br/>
    /// - `reasoning.encrypted_content`: Includes an encrypted version of reasoning tokens in reasoning item outputs. This enables reasoning items to be used in multi-turn conversations when using the Responses API statelessly (like when the `store` parameter is set to `false`, or when an organization is enrolled in the zero data retention program).
    /// </summary>
    public enum IncludeEnum
    {
        /// <summary>
        /// Includes the outputs of python code execution in code interpreter tool call items.
        /// </summary>
        CodeInterpreterCallOutputs,
        /// <summary>
        /// Include image urls from the computer call output.
        /// </summary>
        ComputerCallOutputOutputImageUrl,
        /// <summary>
        /// Include the search results of the file search tool call.
        /// </summary>
        FileSearchCallResults,
        /// <summary>
        /// Include image urls from the input message.
        /// </summary>
        MessageInputImageImageUrl,
        /// <summary>
        /// Include logprobs with assistant messages.
        /// </summary>
        MessageOutputTextLogprobs,
        /// <summary>
        /// Includes an encrypted version of reasoning tokens in reasoning item outputs. This enables reasoning items to be used in multi-turn conversations when using the Responses API statelessly (like when the `store` parameter is set to `false`, or when an organization is enrolled in the zero data retention program).
        /// </summary>
        ReasoningEncryptedContent,
        /// <summary>
        /// Include the sources of the web search tool call.
        /// </summary>
        WebSearchCallActionSources,
        /// <summary>
        /// Include the search results of the web search tool call.
        /// </summary>
        WebSearchCallResults,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IncludeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IncludeEnum value)
        {
            return value switch
            {
                IncludeEnum.CodeInterpreterCallOutputs => "code_interpreter_call.outputs",
                IncludeEnum.ComputerCallOutputOutputImageUrl => "computer_call_output.output.image_url",
                IncludeEnum.FileSearchCallResults => "file_search_call.results",
                IncludeEnum.MessageInputImageImageUrl => "message.input_image.image_url",
                IncludeEnum.MessageOutputTextLogprobs => "message.output_text.logprobs",
                IncludeEnum.ReasoningEncryptedContent => "reasoning.encrypted_content",
                IncludeEnum.WebSearchCallActionSources => "web_search_call.action.sources",
                IncludeEnum.WebSearchCallResults => "web_search_call.results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IncludeEnum? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter_call.outputs" => IncludeEnum.CodeInterpreterCallOutputs,
                "computer_call_output.output.image_url" => IncludeEnum.ComputerCallOutputOutputImageUrl,
                "file_search_call.results" => IncludeEnum.FileSearchCallResults,
                "message.input_image.image_url" => IncludeEnum.MessageInputImageImageUrl,
                "message.output_text.logprobs" => IncludeEnum.MessageOutputTextLogprobs,
                "reasoning.encrypted_content" => IncludeEnum.ReasoningEncryptedContent,
                "web_search_call.action.sources" => IncludeEnum.WebSearchCallActionSources,
                "web_search_call.results" => IncludeEnum.WebSearchCallResults,
                _ => null,
            };
        }
    }
}