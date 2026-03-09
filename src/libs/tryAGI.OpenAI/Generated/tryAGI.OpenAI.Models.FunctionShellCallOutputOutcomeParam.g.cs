#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The exit or timeout outcome associated with this shell call.
    /// </summary>
    public readonly partial struct FunctionShellCallOutputOutcomeParam : global::System.IEquatable<FunctionShellCallOutputOutcomeParam>
    {
        /// <summary>
        /// Indicates that the shell call exceeded its configured time limit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam? Timeout { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam? Timeout { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Timeout))]
#endif
        public bool IsTimeout => Timeout != null;

        /// <summary>
        /// Indicates that the shell commands finished and returned an exit code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam? Exit { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam? Exit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Exit))]
#endif
        public bool IsExit => Exit != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionShellCallOutputOutcomeParam(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam value) => new FunctionShellCallOutputOutcomeParam((global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam?(FunctionShellCallOutputOutcomeParam @this) => @this.Timeout;

        /// <summary>
        /// 
        /// </summary>
        public FunctionShellCallOutputOutcomeParam(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam? value)
        {
            Timeout = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionShellCallOutputOutcomeParam(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam value) => new FunctionShellCallOutputOutcomeParam((global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam?(FunctionShellCallOutputOutcomeParam @this) => @this.Exit;

        /// <summary>
        /// 
        /// </summary>
        public FunctionShellCallOutputOutcomeParam(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam? value)
        {
            Exit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionShellCallOutputOutcomeParam(
            global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam? timeout,
            global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam? exit
            )
        {
            Timeout = timeout;
            Exit = exit;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Exit as object ??
            Timeout as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Timeout?.ToString() ??
            Exit?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTimeout && !IsExit || !IsTimeout && IsExit;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam?, TResult>? timeout = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam?, TResult>? exit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTimeout && timeout != null)
            {
                return timeout(Timeout!);
            }
            else if (IsExit && exit != null)
            {
                return exit(Exit!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam?>? timeout = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam?>? exit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTimeout)
            {
                timeout?.Invoke(Timeout!);
            }
            else if (IsExit)
            {
                exit?.Invoke(Exit!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Timeout,
                typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam),
                Exit,
                typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam),
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
        public bool Equals(FunctionShellCallOutputOutcomeParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam?>.Default.Equals(Timeout, other.Timeout) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam?>.Default.Equals(Exit, other.Exit) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionShellCallOutputOutcomeParam obj1, FunctionShellCallOutputOutcomeParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionShellCallOutputOutcomeParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionShellCallOutputOutcomeParam obj1, FunctionShellCallOutputOutcomeParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionShellCallOutputOutcomeParam o && Equals(o);
        }
    }
}
