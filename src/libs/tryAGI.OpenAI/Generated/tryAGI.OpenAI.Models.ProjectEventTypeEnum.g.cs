
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectEventTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        BatchCancelled,
        /// <summary>
        ///
        /// </summary>
        BatchCompleted,
        /// <summary>
        ///
        /// </summary>
        BatchExpired,
        /// <summary>
        ///
        /// </summary>
        BatchFailed,
        /// <summary>
        ///
        /// </summary>
        EvalRunCanceled,
        /// <summary>
        ///
        /// </summary>
        EvalRunFailed,
        /// <summary>
        ///
        /// </summary>
        EvalRunSucceeded,
        /// <summary>
        ///
        /// </summary>
        FineTuningJobCancelled,
        /// <summary>
        ///
        /// </summary>
        FineTuningJobFailed,
        /// <summary>
        ///
        /// </summary>
        FineTuningJobSucceeded,
        /// <summary>
        ///
        /// </summary>
        RealtimeCallIncoming,
        /// <summary>
        ///
        /// </summary>
        ResponseCancelled,
        /// <summary>
        ///
        /// </summary>
        ResponseCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseFailed,
        /// <summary>
        ///
        /// </summary>
        ResponseIncomplete,
        /// <summary>
        ///
        /// </summary>
        SafetyAlertCreated,
        /// <summary>
        ///
        /// </summary>
        VideoCompleted,
        /// <summary>
        ///
        /// </summary>
        VideoFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectEventTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectEventTypeEnum value)
        {
            return value switch
            {
                ProjectEventTypeEnum.BatchCancelled => "batch.cancelled",
                ProjectEventTypeEnum.BatchCompleted => "batch.completed",
                ProjectEventTypeEnum.BatchExpired => "batch.expired",
                ProjectEventTypeEnum.BatchFailed => "batch.failed",
                ProjectEventTypeEnum.EvalRunCanceled => "eval.run.canceled",
                ProjectEventTypeEnum.EvalRunFailed => "eval.run.failed",
                ProjectEventTypeEnum.EvalRunSucceeded => "eval.run.succeeded",
                ProjectEventTypeEnum.FineTuningJobCancelled => "fine_tuning.job.cancelled",
                ProjectEventTypeEnum.FineTuningJobFailed => "fine_tuning.job.failed",
                ProjectEventTypeEnum.FineTuningJobSucceeded => "fine_tuning.job.succeeded",
                ProjectEventTypeEnum.RealtimeCallIncoming => "realtime.call.incoming",
                ProjectEventTypeEnum.ResponseCancelled => "response.cancelled",
                ProjectEventTypeEnum.ResponseCompleted => "response.completed",
                ProjectEventTypeEnum.ResponseFailed => "response.failed",
                ProjectEventTypeEnum.ResponseIncomplete => "response.incomplete",
                ProjectEventTypeEnum.SafetyAlertCreated => "safety.alert.created",
                ProjectEventTypeEnum.VideoCompleted => "video.completed",
                ProjectEventTypeEnum.VideoFailed => "video.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectEventTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "batch.cancelled" => ProjectEventTypeEnum.BatchCancelled,
                "batch.completed" => ProjectEventTypeEnum.BatchCompleted,
                "batch.expired" => ProjectEventTypeEnum.BatchExpired,
                "batch.failed" => ProjectEventTypeEnum.BatchFailed,
                "eval.run.canceled" => ProjectEventTypeEnum.EvalRunCanceled,
                "eval.run.failed" => ProjectEventTypeEnum.EvalRunFailed,
                "eval.run.succeeded" => ProjectEventTypeEnum.EvalRunSucceeded,
                "fine_tuning.job.cancelled" => ProjectEventTypeEnum.FineTuningJobCancelled,
                "fine_tuning.job.failed" => ProjectEventTypeEnum.FineTuningJobFailed,
                "fine_tuning.job.succeeded" => ProjectEventTypeEnum.FineTuningJobSucceeded,
                "realtime.call.incoming" => ProjectEventTypeEnum.RealtimeCallIncoming,
                "response.cancelled" => ProjectEventTypeEnum.ResponseCancelled,
                "response.completed" => ProjectEventTypeEnum.ResponseCompleted,
                "response.failed" => ProjectEventTypeEnum.ResponseFailed,
                "response.incomplete" => ProjectEventTypeEnum.ResponseIncomplete,
                "safety.alert.created" => ProjectEventTypeEnum.SafetyAlertCreated,
                "video.completed" => ProjectEventTypeEnum.VideoCompleted,
                "video.failed" => ProjectEventTypeEnum.VideoFailed,
                _ => null,
            };
        }
    }
}