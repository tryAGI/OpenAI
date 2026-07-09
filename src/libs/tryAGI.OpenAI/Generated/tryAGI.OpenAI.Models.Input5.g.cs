#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Moderation for the response input.
    /// </summary>
    public readonly partial struct Input5 : global::System.IEquatable<Input5>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType? Type { get; }

        /// <summary>
        /// A moderation result produced for the response input or output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaModerationResultBody? ModerationResult { get; init; }
#else
        public global::tryAGI.OpenAI.BetaModerationResultBody? ModerationResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModerationResult))]
#endif
        public bool IsModerationResult => ModerationResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModerationResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaModerationResultBody? value)
        {
            value = ModerationResult;
            return IsModerationResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationResultBody PickModerationResult() => IsModerationResult
            ? ModerationResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModerationResult' but the value was {ToString()}.");

        /// <summary>
        /// An error produced while attempting moderation for the response input or output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaModerationErrorBody? Error { get; init; }
#else
        public global::tryAGI.OpenAI.BetaModerationErrorBody? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaModerationErrorBody? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaModerationErrorBody PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input5(global::tryAGI.OpenAI.BetaModerationResultBody value) => new Input5((global::tryAGI.OpenAI.BetaModerationResultBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaModerationResultBody?(Input5 @this) => @this.ModerationResult;

        /// <summary>
        /// 
        /// </summary>
        public Input5(global::tryAGI.OpenAI.BetaModerationResultBody? value)
        {
            ModerationResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Input5 FromModerationResult(global::tryAGI.OpenAI.BetaModerationResultBody? value) => new Input5(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input5(global::tryAGI.OpenAI.BetaModerationErrorBody value) => new Input5((global::tryAGI.OpenAI.BetaModerationErrorBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaModerationErrorBody?(Input5 @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public Input5(global::tryAGI.OpenAI.BetaModerationErrorBody? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Input5 FromError(global::tryAGI.OpenAI.BetaModerationErrorBody? value) => new Input5(value);

        /// <summary>
        /// 
        /// </summary>
        public Input5(
            global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaModerationResultBody? moderationResult,
            global::tryAGI.OpenAI.BetaModerationErrorBody? error
            )
        {
            Type = type;

            ModerationResult = moderationResult;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            ModerationResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ModerationResult?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsModerationResult && !IsError || !IsModerationResult && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaModerationResultBody, TResult>? moderationResult = null,
            global::System.Func<global::tryAGI.OpenAI.BetaModerationErrorBody, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationResult && moderationResult != null)
            {
                return moderationResult(ModerationResult!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaModerationResultBody>? moderationResult = null,

            global::System.Action<global::tryAGI.OpenAI.BetaModerationErrorBody>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationResult)
            {
                moderationResult?.Invoke(ModerationResult!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaModerationResultBody>? moderationResult = null,
            global::System.Action<global::tryAGI.OpenAI.BetaModerationErrorBody>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModerationResult)
            {
                moderationResult?.Invoke(ModerationResult!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModerationResult,
                typeof(global::tryAGI.OpenAI.BetaModerationResultBody),
                Error,
                typeof(global::tryAGI.OpenAI.BetaModerationErrorBody),
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
        public bool Equals(Input5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaModerationResultBody?>.Default.Equals(ModerationResult, other.ModerationResult) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaModerationErrorBody?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Input5 obj1, Input5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Input5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Input5 obj1, Input5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Input5 o && Equals(o);
        }
    }
}
