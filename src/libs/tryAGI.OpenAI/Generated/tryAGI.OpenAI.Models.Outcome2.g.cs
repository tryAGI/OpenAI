#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents either an exit outcome (with an exit code) or a timeout outcome for a shell call output chunk.
    /// </summary>
    public readonly partial struct Outcome2 : global::System.IEquatable<Outcome2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType? Type { get; }

        /// <summary>
        /// Indicates that the shell call exceeded its configured time limit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? Timeout { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? Timeout { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Timeout))]
#endif
        public bool IsTimeout => Timeout != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimeout(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? value)
        {
            value = Timeout;
            return IsTimeout;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome PickTimeout() => IsTimeout
            ? Timeout!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Timeout' but the value was {ToString()}.");

        /// <summary>
        /// Indicates that the shell commands finished and returned an exit code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? Exit { get; init; }
#else
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? Exit { get; }
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
        public bool TryPickExit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? value)
        {
            value = Exit;
            return IsExit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome PickExit() => IsExit
            ? Exit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Exit' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Outcome2(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome value) => new Outcome2((global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome?(Outcome2 @this) => @this.Timeout;

        /// <summary>
        ///
        /// </summary>
        public Outcome2(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? value)
        {
            Timeout = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Outcome2 FromTimeout(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? value) => new Outcome2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Outcome2(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome value) => new Outcome2((global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome?(Outcome2 @this) => @this.Exit;

        /// <summary>
        ///
        /// </summary>
        public Outcome2(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? value)
        {
            Exit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Outcome2 FromExit(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? value) => new Outcome2(value);

        /// <summary>
        ///
        /// </summary>
        public Outcome2(
            global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome? timeout,
            global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome? exit
            )
        {
            Type = type;

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
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome, TResult>? timeout = null,
            global::System.Func<global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome, TResult>? exit = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome>? timeout = null,

            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome>? exit = null,
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
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome>? timeout = null,
            global::System.Action<global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome>? exit = null,
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
                typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome),
                Exit,
                typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome),
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
        public bool Equals(Outcome2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome?>.Default.Equals(Timeout, other.Timeout) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome?>.Default.Equals(Exit, other.Exit)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Outcome2 obj1, Outcome2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Outcome2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Outcome2 obj1, Outcome2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Outcome2 o && Equals(o);
        }
    }
}
