#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput : global::System.IEquatable<RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput>
    {
        /// <summary>
        /// Text output from the Code Interpreter tool call as part of a run step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? Logs { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? Logs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Logs))]
#endif
        public bool IsLogs => Logs != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject value) => new RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput((global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject?(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput @this) => @this.Logs;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? value)
        {
            Logs = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? Image { get; init; }
#else
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject value) => new RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput((global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject?(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(
            global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? logs,
            global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? image
            )
        {
            Logs = logs;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Logs as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Logs?.ToString() ??
            Image?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLogs || IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject?, TResult>? logs = null,
            global::System.Func<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject?, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogs && logs != null)
            {
                return logs(Logs!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject?>? logs = null,
            global::System.Action<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject?>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogs)
            {
                logs?.Invoke(Logs!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Logs,
                typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject),
                Image,
                typeof(global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RunStepDetailsToolCallsCodeOutputImageObject?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj1, RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj1, RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput o && Equals(o);
        }
    }
}
