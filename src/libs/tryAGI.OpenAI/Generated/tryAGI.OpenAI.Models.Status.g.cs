#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Current status for the thread. Defaults to `active` for newly created threads.
    /// </summary>
    public readonly partial struct Status : global::System.IEquatable<Status>
    {
        /// <summary>
        /// Indicates that a thread is active.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ActiveStatus? Active { get; init; }
#else
        public global::tryAGI.OpenAI.ActiveStatus? Active { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Active))]
#endif
        public bool IsActive => Active != null;

        /// <summary>
        /// Indicates that a thread is locked and cannot accept new input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LockedStatus? Locked { get; init; }
#else
        public global::tryAGI.OpenAI.LockedStatus? Locked { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Locked))]
#endif
        public bool IsLocked => Locked != null;

        /// <summary>
        /// Indicates that a thread has been closed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ClosedStatus? Closed { get; init; }
#else
        public global::tryAGI.OpenAI.ClosedStatus? Closed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Closed))]
#endif
        public bool IsClosed => Closed != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Status(global::tryAGI.OpenAI.ActiveStatus value) => new Status((global::tryAGI.OpenAI.ActiveStatus?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ActiveStatus?(Status @this) => @this.Active;

        /// <summary>
        /// 
        /// </summary>
        public Status(global::tryAGI.OpenAI.ActiveStatus? value)
        {
            Active = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Status(global::tryAGI.OpenAI.LockedStatus value) => new Status((global::tryAGI.OpenAI.LockedStatus?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LockedStatus?(Status @this) => @this.Locked;

        /// <summary>
        /// 
        /// </summary>
        public Status(global::tryAGI.OpenAI.LockedStatus? value)
        {
            Locked = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Status(global::tryAGI.OpenAI.ClosedStatus value) => new Status((global::tryAGI.OpenAI.ClosedStatus?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ClosedStatus?(Status @this) => @this.Closed;

        /// <summary>
        /// 
        /// </summary>
        public Status(global::tryAGI.OpenAI.ClosedStatus? value)
        {
            Closed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Status(
            global::tryAGI.OpenAI.ActiveStatus? active,
            global::tryAGI.OpenAI.LockedStatus? locked,
            global::tryAGI.OpenAI.ClosedStatus? closed
            )
        {
            Active = active;
            Locked = locked;
            Closed = closed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Closed as object ??
            Locked as object ??
            Active as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Active?.ToString() ??
            Locked?.ToString() ??
            Closed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsActive && !IsLocked && !IsClosed || !IsActive && IsLocked && !IsClosed || !IsActive && !IsLocked && IsClosed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ActiveStatus?, TResult>? active = null,
            global::System.Func<global::tryAGI.OpenAI.LockedStatus?, TResult>? locked = null,
            global::System.Func<global::tryAGI.OpenAI.ClosedStatus?, TResult>? closed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActive && active != null)
            {
                return active(Active!);
            }
            else if (IsLocked && locked != null)
            {
                return locked(Locked!);
            }
            else if (IsClosed && closed != null)
            {
                return closed(Closed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ActiveStatus?>? active = null,
            global::System.Action<global::tryAGI.OpenAI.LockedStatus?>? locked = null,
            global::System.Action<global::tryAGI.OpenAI.ClosedStatus?>? closed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActive)
            {
                active?.Invoke(Active!);
            }
            else if (IsLocked)
            {
                locked?.Invoke(Locked!);
            }
            else if (IsClosed)
            {
                closed?.Invoke(Closed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Active,
                typeof(global::tryAGI.OpenAI.ActiveStatus),
                Locked,
                typeof(global::tryAGI.OpenAI.LockedStatus),
                Closed,
                typeof(global::tryAGI.OpenAI.ClosedStatus),
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
        public bool Equals(Status other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ActiveStatus?>.Default.Equals(Active, other.Active) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LockedStatus?>.Default.Equals(Locked, other.Locked) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ClosedStatus?>.Default.Equals(Closed, other.Closed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Status obj1, Status obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Status>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Status obj1, Status obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Status o && Equals(o);
        }
    }
}
