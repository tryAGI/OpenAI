#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The execution context that produced this tool call.
    /// </summary>
    public readonly partial struct BetaToolCallCaller : global::System.IEquatable<BetaToolCallCaller>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaDirectToolCallCaller? Direct { get; init; }
#else
        public global::tryAGI.OpenAI.BetaDirectToolCallCaller? Direct { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Direct))]
#endif
        public bool IsDirect => Direct != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDirect(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaDirectToolCallCaller? value)
        {
            value = Direct;
            return IsDirect;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCaller PickDirect() => IsDirect
            ? Direct!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Direct' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaProgramToolCallCaller? Program { get; init; }
#else
        public global::tryAGI.OpenAI.BetaProgramToolCallCaller? Program { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Program))]
#endif
        public bool IsProgram => Program != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProgram(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaProgramToolCallCaller? value)
        {
            value = Program;
            return IsProgram;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCaller PickProgram() => IsProgram
            ? Program!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Program' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolCallCaller(global::tryAGI.OpenAI.BetaDirectToolCallCaller value) => new BetaToolCallCaller((global::tryAGI.OpenAI.BetaDirectToolCallCaller?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaDirectToolCallCaller?(BetaToolCallCaller @this) => @this.Direct;

        /// <summary>
        ///
        /// </summary>
        public BetaToolCallCaller(global::tryAGI.OpenAI.BetaDirectToolCallCaller? value)
        {
            Direct = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolCallCaller FromDirect(global::tryAGI.OpenAI.BetaDirectToolCallCaller? value) => new BetaToolCallCaller(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolCallCaller(global::tryAGI.OpenAI.BetaProgramToolCallCaller value) => new BetaToolCallCaller((global::tryAGI.OpenAI.BetaProgramToolCallCaller?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaProgramToolCallCaller?(BetaToolCallCaller @this) => @this.Program;

        /// <summary>
        ///
        /// </summary>
        public BetaToolCallCaller(global::tryAGI.OpenAI.BetaProgramToolCallCaller? value)
        {
            Program = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolCallCaller FromProgram(global::tryAGI.OpenAI.BetaProgramToolCallCaller? value) => new BetaToolCallCaller(value);

        /// <summary>
        ///
        /// </summary>
        public BetaToolCallCaller(
            global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaDirectToolCallCaller? direct,
            global::tryAGI.OpenAI.BetaProgramToolCallCaller? program
            )
        {
            Type = type;

            Direct = direct;
            Program = program;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Program as object ??
            Direct as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Direct?.ToString() ??
            Program?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDirect && !IsProgram || !IsDirect && IsProgram;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaDirectToolCallCaller, TResult>? direct = null,
            global::System.Func<global::tryAGI.OpenAI.BetaProgramToolCallCaller, TResult>? program = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDirect && direct != null)
            {
                return direct(Direct!);
            }
            else if (IsProgram && program != null)
            {
                return program(Program!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaDirectToolCallCaller>? direct = null,

            global::System.Action<global::tryAGI.OpenAI.BetaProgramToolCallCaller>? program = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDirect)
            {
                direct?.Invoke(Direct!);
            }
            else if (IsProgram)
            {
                program?.Invoke(Program!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaDirectToolCallCaller>? direct = null,
            global::System.Action<global::tryAGI.OpenAI.BetaProgramToolCallCaller>? program = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDirect)
            {
                direct?.Invoke(Direct!);
            }
            else if (IsProgram)
            {
                program?.Invoke(Program!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Direct,
                typeof(global::tryAGI.OpenAI.BetaDirectToolCallCaller),
                Program,
                typeof(global::tryAGI.OpenAI.BetaProgramToolCallCaller),
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
        public bool Equals(BetaToolCallCaller other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaDirectToolCallCaller?>.Default.Equals(Direct, other.Direct) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaProgramToolCallCaller?>.Default.Equals(Program, other.Program)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaToolCallCaller obj1, BetaToolCallCaller obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaToolCallCaller>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaToolCallCaller obj1, BetaToolCallCaller obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaToolCallCaller o && Equals(o);
        }
    }
}
