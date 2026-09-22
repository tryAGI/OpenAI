
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AgentOutputCommandExecutionOutputDelta,
        /// <summary>
        ///
        /// </summary>
        AgentSessionCreated,
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentConnected,
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentDisconnected,
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentFailed,
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentPending,
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentReady,
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentReset,
        /// <summary>
        ///
        /// </summary>
        AgentSessionFailed,
        /// <summary>
        ///
        /// </summary>
        AgentSessionIdle,
        /// <summary>
        ///
        /// </summary>
        AgentSessionInProgress,
        /// <summary>
        ///
        /// </summary>
        AgentSessionRequiresAction,
        /// <summary>
        ///
        /// </summary>
        AgentSessionSubagentActive,
        /// <summary>
        ///
        /// </summary>
        AgentSessionSubagentClosed,
        /// <summary>
        ///
        /// </summary>
        AgentSessionSubagentCreated,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnCancelled,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnCompleted,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnContentPartAdded,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnContentPartDone,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnCreated,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnFailed,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnInProgress,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnItemAdded,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnItemDone,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnOutputTextDelta,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnOutputTextDone,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnReasoningSummaryPartAdded,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnReasoningSummaryPartDone,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnReasoningSummaryTextDelta,
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnReasoningSummaryTextDone,
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventDiscriminatorType value)
        {
            return value switch
            {
                SessionEventDiscriminatorType.AgentOutputCommandExecutionOutputDelta => "agent.output.command_execution_output.delta",
                SessionEventDiscriminatorType.AgentSessionCreated => "agent.session.created",
                SessionEventDiscriminatorType.AgentSessionEnvironmentConnected => "agent.session.environment.connected",
                SessionEventDiscriminatorType.AgentSessionEnvironmentDisconnected => "agent.session.environment.disconnected",
                SessionEventDiscriminatorType.AgentSessionEnvironmentFailed => "agent.session.environment.failed",
                SessionEventDiscriminatorType.AgentSessionEnvironmentPending => "agent.session.environment.pending",
                SessionEventDiscriminatorType.AgentSessionEnvironmentReady => "agent.session.environment.ready",
                SessionEventDiscriminatorType.AgentSessionEnvironmentReset => "agent.session.environment.reset",
                SessionEventDiscriminatorType.AgentSessionFailed => "agent.session.failed",
                SessionEventDiscriminatorType.AgentSessionIdle => "agent.session.idle",
                SessionEventDiscriminatorType.AgentSessionInProgress => "agent.session.in_progress",
                SessionEventDiscriminatorType.AgentSessionRequiresAction => "agent.session.requires_action",
                SessionEventDiscriminatorType.AgentSessionSubagentActive => "agent.session.subagent.active",
                SessionEventDiscriminatorType.AgentSessionSubagentClosed => "agent.session.subagent.closed",
                SessionEventDiscriminatorType.AgentSessionSubagentCreated => "agent.session.subagent.created",
                SessionEventDiscriminatorType.AgentSessionTurnCancelled => "agent.session.turn.cancelled",
                SessionEventDiscriminatorType.AgentSessionTurnCompleted => "agent.session.turn.completed",
                SessionEventDiscriminatorType.AgentSessionTurnContentPartAdded => "agent.session.turn.content_part.added",
                SessionEventDiscriminatorType.AgentSessionTurnContentPartDone => "agent.session.turn.content_part.done",
                SessionEventDiscriminatorType.AgentSessionTurnCreated => "agent.session.turn.created",
                SessionEventDiscriminatorType.AgentSessionTurnFailed => "agent.session.turn.failed",
                SessionEventDiscriminatorType.AgentSessionTurnInProgress => "agent.session.turn.in_progress",
                SessionEventDiscriminatorType.AgentSessionTurnItemAdded => "agent.session.turn.item.added",
                SessionEventDiscriminatorType.AgentSessionTurnItemDone => "agent.session.turn.item.done",
                SessionEventDiscriminatorType.AgentSessionTurnOutputTextDelta => "agent.session.turn.output_text.delta",
                SessionEventDiscriminatorType.AgentSessionTurnOutputTextDone => "agent.session.turn.output_text.done",
                SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryPartAdded => "agent.session.turn.reasoning_summary_part.added",
                SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryPartDone => "agent.session.turn.reasoning_summary_part.done",
                SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryTextDelta => "agent.session.turn.reasoning_summary_text.delta",
                SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryTextDone => "agent.session.turn.reasoning_summary_text.done",
                SessionEventDiscriminatorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent.output.command_execution_output.delta" => SessionEventDiscriminatorType.AgentOutputCommandExecutionOutputDelta,
                "agent.session.created" => SessionEventDiscriminatorType.AgentSessionCreated,
                "agent.session.environment.connected" => SessionEventDiscriminatorType.AgentSessionEnvironmentConnected,
                "agent.session.environment.disconnected" => SessionEventDiscriminatorType.AgentSessionEnvironmentDisconnected,
                "agent.session.environment.failed" => SessionEventDiscriminatorType.AgentSessionEnvironmentFailed,
                "agent.session.environment.pending" => SessionEventDiscriminatorType.AgentSessionEnvironmentPending,
                "agent.session.environment.ready" => SessionEventDiscriminatorType.AgentSessionEnvironmentReady,
                "agent.session.environment.reset" => SessionEventDiscriminatorType.AgentSessionEnvironmentReset,
                "agent.session.failed" => SessionEventDiscriminatorType.AgentSessionFailed,
                "agent.session.idle" => SessionEventDiscriminatorType.AgentSessionIdle,
                "agent.session.in_progress" => SessionEventDiscriminatorType.AgentSessionInProgress,
                "agent.session.requires_action" => SessionEventDiscriminatorType.AgentSessionRequiresAction,
                "agent.session.subagent.active" => SessionEventDiscriminatorType.AgentSessionSubagentActive,
                "agent.session.subagent.closed" => SessionEventDiscriminatorType.AgentSessionSubagentClosed,
                "agent.session.subagent.created" => SessionEventDiscriminatorType.AgentSessionSubagentCreated,
                "agent.session.turn.cancelled" => SessionEventDiscriminatorType.AgentSessionTurnCancelled,
                "agent.session.turn.completed" => SessionEventDiscriminatorType.AgentSessionTurnCompleted,
                "agent.session.turn.content_part.added" => SessionEventDiscriminatorType.AgentSessionTurnContentPartAdded,
                "agent.session.turn.content_part.done" => SessionEventDiscriminatorType.AgentSessionTurnContentPartDone,
                "agent.session.turn.created" => SessionEventDiscriminatorType.AgentSessionTurnCreated,
                "agent.session.turn.failed" => SessionEventDiscriminatorType.AgentSessionTurnFailed,
                "agent.session.turn.in_progress" => SessionEventDiscriminatorType.AgentSessionTurnInProgress,
                "agent.session.turn.item.added" => SessionEventDiscriminatorType.AgentSessionTurnItemAdded,
                "agent.session.turn.item.done" => SessionEventDiscriminatorType.AgentSessionTurnItemDone,
                "agent.session.turn.output_text.delta" => SessionEventDiscriminatorType.AgentSessionTurnOutputTextDelta,
                "agent.session.turn.output_text.done" => SessionEventDiscriminatorType.AgentSessionTurnOutputTextDone,
                "agent.session.turn.reasoning_summary_part.added" => SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryPartAdded,
                "agent.session.turn.reasoning_summary_part.done" => SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryPartDone,
                "agent.session.turn.reasoning_summary_text.delta" => SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryTextDelta,
                "agent.session.turn.reasoning_summary_text.done" => SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryTextDone,
                "error" => SessionEventDiscriminatorType.Error,
                _ => null,
            };
        }
    }
}