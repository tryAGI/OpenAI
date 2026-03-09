#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents either an exit outcome (with an exit code) or a timeout outcome for a shell call output chunk.
    /// </summary>
    public readonly partial struct Outcome : global::System.IEquatable<Outcome>
    {
        /// <summary>
        /// Indicates that the shell call exceeded its configured time limit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome? Timeout { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome? Timeout { get; }
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
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome? Exit { get; init; }
#else
        public global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome? Exit { get; }
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
        public static implicit operator Outcome(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome value) => new Outcome((global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome?(Outcome @this) => @this.Timeout;

        /// <summary>
        /// 
        /// </summary>
        public Outcome(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome? value)
        {
            Timeout = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Outcome(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome value) => new Outcome((global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome?(Outcome @this) => @this.Exit;

        /// <summary>
        /// 
        /// </summary>
        public Outcome(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome? value)
        {
            Exit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Outcome(
            global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome? timeout,
            global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome? exit
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
            global::System.Func<global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome?, TResult>? timeout = null,
            global::System.Func<global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome?, TResult>? exit = null,
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
            global::System.Action<global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome?>? timeout = null,
            global::System.Action<global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome?>? exit = null,
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
                typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome),
                Exit,
                typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome),
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
        public bool Equals(Outcome other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome?>.Default.Equals(Timeout, other.Timeout) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome?>.Default.Equals(Exit, other.Exit) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Outcome obj1, Outcome obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Outcome>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Outcome obj1, Outcome obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Outcome o && Equals(o);
        }
    }
}
