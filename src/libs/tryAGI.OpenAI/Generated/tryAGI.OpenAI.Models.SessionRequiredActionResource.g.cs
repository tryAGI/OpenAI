#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An action that must be completed before a session can continue.
    /// </summary>
    public readonly partial struct SessionRequiredActionResource : global::System.IEquatable<SessionRequiredActionResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Run a function tool and submit its result.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? FunctionCall { get; init; }
#else
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? FunctionCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall PickFunctionCall() => FunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// Reconnect a session environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? EnvironmentConnection { get; init; }
#else
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? EnvironmentConnection { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentConnection))]
#endif
        public bool IsEnvironmentConnection => EnvironmentConnection != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnvironmentConnection(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? value)
        {
            value = EnvironmentConnection;
            return IsEnvironmentConnection;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection PickEnvironmentConnection() => EnvironmentConnection is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentConnection' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionRequiredActionResource(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall value) => new SessionRequiredActionResource((global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall?(SessionRequiredActionResource @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public SessionRequiredActionResource(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionRequiredActionResource FromFunctionCall(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? value) => new SessionRequiredActionResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SessionRequiredActionResource(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection value) => new SessionRequiredActionResource((global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection?(SessionRequiredActionResource @this) => @this.EnvironmentConnection;

        /// <summary>
        ///
        /// </summary>
        public SessionRequiredActionResource(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? value)
        {
            EnvironmentConnection = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SessionRequiredActionResource FromEnvironmentConnection(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? value) => new SessionRequiredActionResource(value);

        /// <summary>
        ///
        /// </summary>
        public SessionRequiredActionResource(
            global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall? functionCall,
            global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection? environmentConnection
            )
        {
            Type = type;

            FunctionCall = functionCall;
            EnvironmentConnection = environmentConnection;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EnvironmentConnection as object ??
            FunctionCall as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            FunctionCall?.ToString() ??
            EnvironmentConnection?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunctionCall && !IsEnvironmentConnection || !IsFunctionCall && IsEnvironmentConnection;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall, TResult>? functionCall = null,
            global::System.Func<global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection, TResult>? environmentConnection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (FunctionCall is { } __value0 && functionCall != null)
            {
                return functionCall(__value0);
            }
            else if (EnvironmentConnection is { } __value1 && environmentConnection != null)
            {
                return environmentConnection(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall>? functionCall = null,

            global::System.Action<global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection>? environmentConnection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (FunctionCall is { } __value0)
            {
                functionCall?.Invoke(__value0);
            }
            else if (EnvironmentConnection is { } __value1)
            {
                environmentConnection?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall>? functionCall = null,
            global::System.Action<global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection>? environmentConnection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (FunctionCall is { } __value0)
            {
                functionCall?.Invoke(__value0);
            }
            else if (EnvironmentConnection is { } __value1)
            {
                environmentConnection?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FunctionCall,
                typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall),
                EnvironmentConnection,
                typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection),
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
        public bool Equals(SessionRequiredActionResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection?>.Default.Equals(EnvironmentConnection, other.EnvironmentConnection)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SessionRequiredActionResource obj1, SessionRequiredActionResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SessionRequiredActionResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SessionRequiredActionResource obj1, SessionRequiredActionResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SessionRequiredActionResource o && Equals(o);
        }
    }
}
