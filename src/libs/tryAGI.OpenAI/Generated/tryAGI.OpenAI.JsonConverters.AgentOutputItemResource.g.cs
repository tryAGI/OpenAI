#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class AgentOutputItemResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.AgentOutputItemResource>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.AgentOutputItemResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.AssistantMessageItemResource? message = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AssistantMessageItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AssistantMessageItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.AssistantMessageItemResource)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ReasoningItemResource? reasoning = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.Reasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ReasoningItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ReasoningItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ReasoningItemResource)}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.FunctionCallItemResource? functionCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.FunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionCallItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.FunctionCallItemResource)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.McpCallItemResource? mcpCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.McpCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpCallItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.McpCallItemResource)}");
                mcpCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ComputerUseCallItemResource? computerUseCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.ComputerUseCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseCallItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ComputerUseCallItemResource)}");
                computerUseCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource? computerUseApprovalRequest = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.ComputerUseApprovalRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource)}");
                computerUseApprovalRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.WebSearchCallItemResource? webSearchCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.WebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WebSearchCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WebSearchCallItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.WebSearchCallItemResource)}");
                webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.CommandExecutionItemResource? commandExecution = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.CommandExecution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CommandExecutionItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CommandExecutionItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CommandExecutionItemResource)}");
                commandExecution = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.CreateSubagentCallItemResource? createSubagentCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.CreateSubagentCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateSubagentCallItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateSubagentCallItemResource)}");
                createSubagentCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SendSubagentInputCallItemResource? sendSubagentInputCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.SendSubagentInputCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SendSubagentInputCallItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SendSubagentInputCallItemResource)}");
                sendSubagentInputCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ResumeSubagentCallItemResource? resumeSubagentCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.ResumeSubagentCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResumeSubagentCallItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ResumeSubagentCallItemResource)}");
                resumeSubagentCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.WaitForSubagentsCallItemResource? waitForSubagentsCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.WaitForSubagentsCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WaitForSubagentsCallItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResource)}");
                waitForSubagentsCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.InterruptSubagentCallItemResource? interruptSubagentCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.InterruptSubagentCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.InterruptSubagentCallItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.InterruptSubagentCallItemResource)}");
                interruptSubagentCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.CloseSubagentCallItemResource? closeSubagentCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType.CloseSubagentCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CloseSubagentCallItemResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CloseSubagentCallItemResource)}");
                closeSubagentCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.AgentOutputItemResource(
                discriminator?.Type,
                message,

                reasoning,

                functionCall,

                mcpCall,

                computerUseCall,

                computerUseApprovalRequest,

                webSearchCall,

                commandExecution,

                createSubagentCall,

                sendSubagentInputCall,

                resumeSubagentCall,

                waitForSubagentsCall,

                interruptSubagentCall,

                closeSubagentCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.AgentOutputItemResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AssistantMessageItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AssistantMessageItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AssistantMessageItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMessage(), typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ReasoningItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ReasoningItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ReasoningItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReasoning(), typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionCallItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionCallItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCall(), typeInfo);
            }
            else if (value.IsMcpCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpCallItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.McpCallItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMcpCall(), typeInfo);
            }
            else if (value.IsComputerUseCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseCallItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerUseCallItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerUseCall(), typeInfo);
            }
            else if (value.IsComputerUseApprovalRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BrowserAuthenticationRequestItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerUseApprovalRequest(), typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WebSearchCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WebSearchCallItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WebSearchCallItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWebSearchCall(), typeInfo);
            }
            else if (value.IsCommandExecution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CommandExecutionItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CommandExecutionItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CommandExecutionItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCommandExecution(), typeInfo);
            }
            else if (value.IsCreateSubagentCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateSubagentCallItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCreateSubagentCall(), typeInfo);
            }
            else if (value.IsSendSubagentInputCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SendSubagentInputCallItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSendSubagentInputCall(), typeInfo);
            }
            else if (value.IsResumeSubagentCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResumeSubagentCallItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResumeSubagentCall(), typeInfo);
            }
            else if (value.IsWaitForSubagentsCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WaitForSubagentsCallItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWaitForSubagentsCall(), typeInfo);
            }
            else if (value.IsInterruptSubagentCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.InterruptSubagentCallItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInterruptSubagentCall(), typeInfo);
            }
            else if (value.IsCloseSubagentCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CloseSubagentCallItemResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCloseSubagentCall(), typeInfo);
            }
        }
    }
}