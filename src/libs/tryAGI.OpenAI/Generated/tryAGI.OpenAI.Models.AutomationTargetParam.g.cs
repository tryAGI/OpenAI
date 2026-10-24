#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The session an automation invocation targets.
    /// </summary>
    public readonly partial struct AutomationTargetParam : global::System.IEquatable<AutomationTargetParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Create a session for each invocation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationTargetParamNewSession? NewSession { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationTargetParamNewSession? NewSession { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NewSession))]
#endif
        public bool IsNewSession => NewSession != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNewSession(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AutomationTargetParamNewSession? value)
        {
            value = NewSession;
            return IsNewSession;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamNewSession PickNewSession() => NewSession is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NewSession' but the value was {ToString()}.");

        /// <summary>
        /// Deliver instructions to an existing session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationTargetParamExistingSession? ExistingSession { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationTargetParamExistingSession? ExistingSession { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExistingSession))]
#endif
        public bool IsExistingSession => ExistingSession != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExistingSession(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AutomationTargetParamExistingSession? value)
        {
            value = ExistingSession;
            return IsExistingSession;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetParamExistingSession PickExistingSession() => ExistingSession is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExistingSession' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationTargetParam(global::tryAGI.OpenAI.AutomationTargetParamNewSession value) => new AutomationTargetParam((global::tryAGI.OpenAI.AutomationTargetParamNewSession?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationTargetParamNewSession?(AutomationTargetParam @this) => @this.NewSession;

        /// <summary>
        ///
        /// </summary>
        public AutomationTargetParam(global::tryAGI.OpenAI.AutomationTargetParamNewSession? value)
        {
            NewSession = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationTargetParam FromNewSession(global::tryAGI.OpenAI.AutomationTargetParamNewSession? value) => new AutomationTargetParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationTargetParam(global::tryAGI.OpenAI.AutomationTargetParamExistingSession value) => new AutomationTargetParam((global::tryAGI.OpenAI.AutomationTargetParamExistingSession?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationTargetParamExistingSession?(AutomationTargetParam @this) => @this.ExistingSession;

        /// <summary>
        ///
        /// </summary>
        public AutomationTargetParam(global::tryAGI.OpenAI.AutomationTargetParamExistingSession? value)
        {
            ExistingSession = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationTargetParam FromExistingSession(global::tryAGI.OpenAI.AutomationTargetParamExistingSession? value) => new AutomationTargetParam(value);

        /// <summary>
        ///
        /// </summary>
        public AutomationTargetParam(
            global::tryAGI.OpenAI.AutomationTargetParamDiscriminatorType? type,
            global::tryAGI.OpenAI.AutomationTargetParamNewSession? newSession,
            global::tryAGI.OpenAI.AutomationTargetParamExistingSession? existingSession
            )
        {
            Type = type;

            NewSession = newSession;
            ExistingSession = existingSession;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ExistingSession as object ??
            NewSession as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            NewSession?.ToString() ??
            ExistingSession?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNewSession && !IsExistingSession || !IsNewSession && IsExistingSession;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AutomationTargetParamNewSession, TResult>? newSession = null,
            global::System.Func<global::tryAGI.OpenAI.AutomationTargetParamExistingSession, TResult>? existingSession = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NewSession is { } __value0 && newSession != null)
            {
                return newSession(__value0);
            }
            else if (ExistingSession is { } __value1 && existingSession != null)
            {
                return existingSession(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AutomationTargetParamNewSession>? newSession = null,

            global::System.Action<global::tryAGI.OpenAI.AutomationTargetParamExistingSession>? existingSession = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NewSession is { } __value0)
            {
                newSession?.Invoke(__value0);
            }
            else if (ExistingSession is { } __value1)
            {
                existingSession?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AutomationTargetParamNewSession>? newSession = null,
            global::System.Action<global::tryAGI.OpenAI.AutomationTargetParamExistingSession>? existingSession = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NewSession is { } __value0)
            {
                newSession?.Invoke(__value0);
            }
            else if (ExistingSession is { } __value1)
            {
                existingSession?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NewSession,
                typeof(global::tryAGI.OpenAI.AutomationTargetParamNewSession),
                ExistingSession,
                typeof(global::tryAGI.OpenAI.AutomationTargetParamExistingSession),
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
        public bool Equals(AutomationTargetParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationTargetParamNewSession?>.Default.Equals(NewSession, other.NewSession) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationTargetParamExistingSession?>.Default.Equals(ExistingSession, other.ExistingSession)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutomationTargetParam obj1, AutomationTargetParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutomationTargetParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutomationTargetParam obj1, AutomationTargetParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutomationTargetParam o && Equals(o);
        }
    }
}
