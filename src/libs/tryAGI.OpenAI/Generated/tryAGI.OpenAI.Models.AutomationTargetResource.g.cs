#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Saved target configuration, excluding confidential request-only values.
    /// </summary>
    public readonly partial struct AutomationTargetResource : global::System.IEquatable<AutomationTargetResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationTargetResourceNewSession? NewSession { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationTargetResourceNewSession? NewSession { get; }
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
            out global::tryAGI.OpenAI.AutomationTargetResourceNewSession? value)
        {
            value = NewSession;
            return IsNewSession;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceNewSession PickNewSession() => NewSession is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NewSession' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AutomationTargetResourceExistingSession? ExistingSession { get; init; }
#else
        public global::tryAGI.OpenAI.AutomationTargetResourceExistingSession? ExistingSession { get; }
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
            out global::tryAGI.OpenAI.AutomationTargetResourceExistingSession? value)
        {
            value = ExistingSession;
            return IsExistingSession;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AutomationTargetResourceExistingSession PickExistingSession() => ExistingSession is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExistingSession' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationTargetResource(global::tryAGI.OpenAI.AutomationTargetResourceNewSession value) => new AutomationTargetResource((global::tryAGI.OpenAI.AutomationTargetResourceNewSession?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationTargetResourceNewSession?(AutomationTargetResource @this) => @this.NewSession;

        /// <summary>
        ///
        /// </summary>
        public AutomationTargetResource(global::tryAGI.OpenAI.AutomationTargetResourceNewSession? value)
        {
            NewSession = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationTargetResource FromNewSession(global::tryAGI.OpenAI.AutomationTargetResourceNewSession? value) => new AutomationTargetResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutomationTargetResource(global::tryAGI.OpenAI.AutomationTargetResourceExistingSession value) => new AutomationTargetResource((global::tryAGI.OpenAI.AutomationTargetResourceExistingSession?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AutomationTargetResourceExistingSession?(AutomationTargetResource @this) => @this.ExistingSession;

        /// <summary>
        ///
        /// </summary>
        public AutomationTargetResource(global::tryAGI.OpenAI.AutomationTargetResourceExistingSession? value)
        {
            ExistingSession = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutomationTargetResource FromExistingSession(global::tryAGI.OpenAI.AutomationTargetResourceExistingSession? value) => new AutomationTargetResource(value);

        /// <summary>
        ///
        /// </summary>
        public AutomationTargetResource(
            global::tryAGI.OpenAI.AutomationTargetResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.AutomationTargetResourceNewSession? newSession,
            global::tryAGI.OpenAI.AutomationTargetResourceExistingSession? existingSession
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
            global::System.Func<global::tryAGI.OpenAI.AutomationTargetResourceNewSession, TResult>? newSession = null,
            global::System.Func<global::tryAGI.OpenAI.AutomationTargetResourceExistingSession, TResult>? existingSession = null,
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
            global::System.Action<global::tryAGI.OpenAI.AutomationTargetResourceNewSession>? newSession = null,

            global::System.Action<global::tryAGI.OpenAI.AutomationTargetResourceExistingSession>? existingSession = null,
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
            global::System.Action<global::tryAGI.OpenAI.AutomationTargetResourceNewSession>? newSession = null,
            global::System.Action<global::tryAGI.OpenAI.AutomationTargetResourceExistingSession>? existingSession = null,
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
                typeof(global::tryAGI.OpenAI.AutomationTargetResourceNewSession),
                ExistingSession,
                typeof(global::tryAGI.OpenAI.AutomationTargetResourceExistingSession),
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
        public bool Equals(AutomationTargetResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationTargetResourceNewSession?>.Default.Equals(NewSession, other.NewSession) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AutomationTargetResourceExistingSession?>.Default.Equals(ExistingSession, other.ExistingSession)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutomationTargetResource obj1, AutomationTargetResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutomationTargetResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutomationTargetResource obj1, AutomationTargetResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutomationTargetResource o && Equals(o);
        }
    }
}
