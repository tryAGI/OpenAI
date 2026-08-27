#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The execution context that produced this tool call.
    /// </summary>
    public readonly partial struct BetaToolCallCallerParam : global::System.IEquatable<BetaToolCallCallerParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? Direct { get; init; }
#else
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? Direct { get; }
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
            out global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? value)
        {
            value = Direct;
            return IsDirect;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaDirectToolCallCallerParam PickDirect() => IsDirect
            ? Direct!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Direct' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? Program { get; init; }
#else
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? Program { get; }
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
            out global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? value)
        {
            value = Program;
            return IsProgram;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaProgramToolCallCallerParam PickProgram() => IsProgram
            ? Program!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Program' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolCallCallerParam(global::tryAGI.OpenAI.BetaDirectToolCallCallerParam value) => new BetaToolCallCallerParam((global::tryAGI.OpenAI.BetaDirectToolCallCallerParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaDirectToolCallCallerParam?(BetaToolCallCallerParam @this) => @this.Direct;

        /// <summary>
        ///
        /// </summary>
        public BetaToolCallCallerParam(global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? value)
        {
            Direct = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolCallCallerParam FromDirect(global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? value) => new BetaToolCallCallerParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolCallCallerParam(global::tryAGI.OpenAI.BetaProgramToolCallCallerParam value) => new BetaToolCallCallerParam((global::tryAGI.OpenAI.BetaProgramToolCallCallerParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaProgramToolCallCallerParam?(BetaToolCallCallerParam @this) => @this.Program;

        /// <summary>
        ///
        /// </summary>
        public BetaToolCallCallerParam(global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? value)
        {
            Program = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolCallCallerParam FromProgram(global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? value) => new BetaToolCallCallerParam(value);

        /// <summary>
        ///
        /// </summary>
        public BetaToolCallCallerParam(
            global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaDirectToolCallCallerParam? direct,
            global::tryAGI.OpenAI.BetaProgramToolCallCallerParam? program
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
            global::System.Func<global::tryAGI.OpenAI.BetaDirectToolCallCallerParam, TResult>? direct = null,
            global::System.Func<global::tryAGI.OpenAI.BetaProgramToolCallCallerParam, TResult>? program = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaDirectToolCallCallerParam>? direct = null,

            global::System.Action<global::tryAGI.OpenAI.BetaProgramToolCallCallerParam>? program = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaDirectToolCallCallerParam>? direct = null,
            global::System.Action<global::tryAGI.OpenAI.BetaProgramToolCallCallerParam>? program = null,
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
                typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParam),
                Program,
                typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParam),
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
        public bool Equals(BetaToolCallCallerParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaDirectToolCallCallerParam?>.Default.Equals(Direct, other.Direct) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaProgramToolCallCallerParam?>.Default.Equals(Program, other.Program)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaToolCallCallerParam obj1, BetaToolCallCallerParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaToolCallCallerParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaToolCallCallerParam obj1, BetaToolCallCallerParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaToolCallCallerParam o && Equals(o);
        }
    }
}
