
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Stable public categories for session request failures.
    /// </summary>
    public enum SessionTurnErrorCodeResource
    {
        /// <summary>
        ///
        /// </summary>
        ActiveTurnNotSteerable,
        /// <summary>
        ///
        /// </summary>
        AuthenticationError,
        /// <summary>
        ///
        /// </summary>
        ConnectionFailed,
        /// <summary>
        ///
        /// </summary>
        ContextLengthExceeded,
        /// <summary>
        ///
        /// </summary>
        CreditBalanceExhausted,
        /// <summary>
        ///
        /// </summary>
        CyberPolicy,
        /// <summary>
        ///
        /// </summary>
        ExecutorVersionIncompatible,
        /// <summary>
        ///
        /// </summary>
        InternalError,
        /// <summary>
        ///
        /// </summary>
        InvalidRequest,
        /// <summary>
        ///
        /// </summary>
        MisalignmentPolicyViolation,
        /// <summary>
        ///
        /// </summary>
        RateLimitExceeded,
        /// <summary>
        ///
        /// </summary>
        RequestTimeout,
        /// <summary>
        ///
        /// </summary>
        ResourceNotFound,
        /// <summary>
        ///
        /// </summary>
        SandboxError,
        /// <summary>
        ///
        /// </summary>
        ServerError,
        /// <summary>
        ///
        /// </summary>
        ServerOverloaded,
        /// <summary>
        ///
        /// </summary>
        SessionBudgetExceeded,
        /// <summary>
        ///
        /// </summary>
        UsageLimitExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionTurnErrorCodeResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionTurnErrorCodeResource value)
        {
            return value switch
            {
                SessionTurnErrorCodeResource.ActiveTurnNotSteerable => "active_turn_not_steerable",
                SessionTurnErrorCodeResource.AuthenticationError => "authentication_error",
                SessionTurnErrorCodeResource.ConnectionFailed => "connection_failed",
                SessionTurnErrorCodeResource.ContextLengthExceeded => "context_length_exceeded",
                SessionTurnErrorCodeResource.CreditBalanceExhausted => "credit_balance_exhausted",
                SessionTurnErrorCodeResource.CyberPolicy => "cyber_policy",
                SessionTurnErrorCodeResource.ExecutorVersionIncompatible => "executor_version_incompatible",
                SessionTurnErrorCodeResource.InternalError => "internal_error",
                SessionTurnErrorCodeResource.InvalidRequest => "invalid_request",
                SessionTurnErrorCodeResource.MisalignmentPolicyViolation => "misalignment_policy_violation",
                SessionTurnErrorCodeResource.RateLimitExceeded => "rate_limit_exceeded",
                SessionTurnErrorCodeResource.RequestTimeout => "request_timeout",
                SessionTurnErrorCodeResource.ResourceNotFound => "resource_not_found",
                SessionTurnErrorCodeResource.SandboxError => "sandbox_error",
                SessionTurnErrorCodeResource.ServerError => "server_error",
                SessionTurnErrorCodeResource.ServerOverloaded => "server_overloaded",
                SessionTurnErrorCodeResource.SessionBudgetExceeded => "session_budget_exceeded",
                SessionTurnErrorCodeResource.UsageLimitExceeded => "usage_limit_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionTurnErrorCodeResource? ToEnum(string value)
        {
            return value switch
            {
                "active_turn_not_steerable" => SessionTurnErrorCodeResource.ActiveTurnNotSteerable,
                "authentication_error" => SessionTurnErrorCodeResource.AuthenticationError,
                "connection_failed" => SessionTurnErrorCodeResource.ConnectionFailed,
                "context_length_exceeded" => SessionTurnErrorCodeResource.ContextLengthExceeded,
                "credit_balance_exhausted" => SessionTurnErrorCodeResource.CreditBalanceExhausted,
                "cyber_policy" => SessionTurnErrorCodeResource.CyberPolicy,
                "executor_version_incompatible" => SessionTurnErrorCodeResource.ExecutorVersionIncompatible,
                "internal_error" => SessionTurnErrorCodeResource.InternalError,
                "invalid_request" => SessionTurnErrorCodeResource.InvalidRequest,
                "misalignment_policy_violation" => SessionTurnErrorCodeResource.MisalignmentPolicyViolation,
                "rate_limit_exceeded" => SessionTurnErrorCodeResource.RateLimitExceeded,
                "request_timeout" => SessionTurnErrorCodeResource.RequestTimeout,
                "resource_not_found" => SessionTurnErrorCodeResource.ResourceNotFound,
                "sandbox_error" => SessionTurnErrorCodeResource.SandboxError,
                "server_error" => SessionTurnErrorCodeResource.ServerError,
                "server_overloaded" => SessionTurnErrorCodeResource.ServerOverloaded,
                "session_budget_exceeded" => SessionTurnErrorCodeResource.SessionBudgetExceeded,
                "usage_limit_exceeded" => SessionTurnErrorCodeResource.UsageLimitExceeded,
                _ => null,
            };
        }
    }
}