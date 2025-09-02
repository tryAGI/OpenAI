#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The error from the tool call, if any.
    /// </summary>
    public readonly partial struct Error2 : global::System.IEquatable<Error2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeMCPProtocolError? RealtimeMCPProtocolError { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeMCPProtocolError? RealtimeMCPProtocolError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeMCPProtocolError))]
#endif
        public bool IsRealtimeMCPProtocolError => RealtimeMCPProtocolError != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error2(global::tryAGI.OpenAI.RealtimeMCPProtocolError value) => new Error2((global::tryAGI.OpenAI.RealtimeMCPProtocolError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeMCPProtocolError?(Error2 @this) => @this.RealtimeMCPProtocolError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::tryAGI.OpenAI.RealtimeMCPProtocolError? value)
        {
            RealtimeMCPProtocolError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeMCPToolExecutionError? RealtimeMCPToolExecutionError { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeMCPToolExecutionError? RealtimeMCPToolExecutionError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeMCPToolExecutionError))]
#endif
        public bool IsRealtimeMCPToolExecutionError => RealtimeMCPToolExecutionError != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error2(global::tryAGI.OpenAI.RealtimeMCPToolExecutionError value) => new Error2((global::tryAGI.OpenAI.RealtimeMCPToolExecutionError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeMCPToolExecutionError?(Error2 @this) => @this.RealtimeMCPToolExecutionError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::tryAGI.OpenAI.RealtimeMCPToolExecutionError? value)
        {
            RealtimeMCPToolExecutionError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeMCPHTTPError? RealtimeMCPHTError { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeMCPHTTPError? RealtimeMCPHTError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeMCPHTError))]
#endif
        public bool IsRealtimeMCPHTError => RealtimeMCPHTError != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Error2(global::tryAGI.OpenAI.RealtimeMCPHTTPError value) => new Error2((global::tryAGI.OpenAI.RealtimeMCPHTTPError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeMCPHTTPError?(Error2 @this) => @this.RealtimeMCPHTError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::tryAGI.OpenAI.RealtimeMCPHTTPError? value)
        {
            RealtimeMCPHTError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Error2(
            global::tryAGI.OpenAI.RealtimeMCPProtocolError? realtimeMCPProtocolError,
            global::tryAGI.OpenAI.RealtimeMCPToolExecutionError? realtimeMCPToolExecutionError,
            global::tryAGI.OpenAI.RealtimeMCPHTTPError? realtimeMCPHTError
            )
        {
            RealtimeMCPProtocolError = realtimeMCPProtocolError;
            RealtimeMCPToolExecutionError = realtimeMCPToolExecutionError;
            RealtimeMCPHTError = realtimeMCPHTError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RealtimeMCPHTError as object ??
            RealtimeMCPToolExecutionError as object ??
            RealtimeMCPProtocolError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RealtimeMCPProtocolError?.ToString() ??
            RealtimeMCPToolExecutionError?.ToString() ??
            RealtimeMCPHTError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeMCPProtocolError || IsRealtimeMCPToolExecutionError || IsRealtimeMCPHTError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeMCPProtocolError?, TResult>? realtimeMCPProtocolError = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeMCPToolExecutionError?, TResult>? realtimeMCPToolExecutionError = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeMCPHTTPError?, TResult>? realtimeMCPHTError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeMCPProtocolError && realtimeMCPProtocolError != null)
            {
                return realtimeMCPProtocolError(RealtimeMCPProtocolError!);
            }
            else if (IsRealtimeMCPToolExecutionError && realtimeMCPToolExecutionError != null)
            {
                return realtimeMCPToolExecutionError(RealtimeMCPToolExecutionError!);
            }
            else if (IsRealtimeMCPHTError && realtimeMCPHTError != null)
            {
                return realtimeMCPHTError(RealtimeMCPHTError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeMCPProtocolError?>? realtimeMCPProtocolError = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeMCPToolExecutionError?>? realtimeMCPToolExecutionError = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeMCPHTTPError?>? realtimeMCPHTError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeMCPProtocolError)
            {
                realtimeMCPProtocolError?.Invoke(RealtimeMCPProtocolError!);
            }
            else if (IsRealtimeMCPToolExecutionError)
            {
                realtimeMCPToolExecutionError?.Invoke(RealtimeMCPToolExecutionError!);
            }
            else if (IsRealtimeMCPHTError)
            {
                realtimeMCPHTError?.Invoke(RealtimeMCPHTError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RealtimeMCPProtocolError,
                typeof(global::tryAGI.OpenAI.RealtimeMCPProtocolError),
                RealtimeMCPToolExecutionError,
                typeof(global::tryAGI.OpenAI.RealtimeMCPToolExecutionError),
                RealtimeMCPHTError,
                typeof(global::tryAGI.OpenAI.RealtimeMCPHTTPError),
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
        public bool Equals(Error2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeMCPProtocolError?>.Default.Equals(RealtimeMCPProtocolError, other.RealtimeMCPProtocolError) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeMCPToolExecutionError?>.Default.Equals(RealtimeMCPToolExecutionError, other.RealtimeMCPToolExecutionError) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeMCPHTTPError?>.Default.Equals(RealtimeMCPHTError, other.RealtimeMCPHTError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Error2 obj1, Error2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Error2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Error2 obj1, Error2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Error2 o && Equals(o);
        }
    }
}
