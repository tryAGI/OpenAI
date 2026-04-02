#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ComputerToolCallOutputResource : global::System.IEquatable<ComputerToolCallOutputResource>
    {
        /// <summary>
        /// The output of a computer tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerToolCallOutput? ComputerToolCallOutput { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerToolCallOutput? ComputerToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCallOutput))]
#endif
        public bool IsComputerToolCallOutput => ComputerToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2? ComputerToolCallOutputResourceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2? ComputerToolCallOutputResourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCallOutputResourceVariant2))]
#endif
        public bool IsComputerToolCallOutputResourceVariant2 => ComputerToolCallOutputResourceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerToolCallOutputResource(global::tryAGI.OpenAI.ComputerToolCallOutput value) => new ComputerToolCallOutputResource((global::tryAGI.OpenAI.ComputerToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCallOutput?(ComputerToolCallOutputResource @this) => @this.ComputerToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ComputerToolCallOutputResource(global::tryAGI.OpenAI.ComputerToolCallOutput? value)
        {
            ComputerToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerToolCallOutputResource(global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2 value) => new ComputerToolCallOutputResource((global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2?(ComputerToolCallOutputResource @this) => @this.ComputerToolCallOutputResourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ComputerToolCallOutputResource(global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2? value)
        {
            ComputerToolCallOutputResourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ComputerToolCallOutputResource(
            global::tryAGI.OpenAI.ComputerToolCallOutput? computerToolCallOutput,
            global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2? computerToolCallOutputResourceVariant2
            )
        {
            ComputerToolCallOutput = computerToolCallOutput;
            ComputerToolCallOutputResourceVariant2 = computerToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ComputerToolCallOutputResourceVariant2 as object ??
            ComputerToolCallOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ComputerToolCallOutput?.ToString() ??
            ComputerToolCallOutputResourceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsComputerToolCallOutput && IsComputerToolCallOutputResourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCallOutput?, TResult>? computerToolCallOutput = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2?, TResult>? computerToolCallOutputResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComputerToolCallOutput && computerToolCallOutput != null)
            {
                return computerToolCallOutput(ComputerToolCallOutput!);
            }
            else if (IsComputerToolCallOutputResourceVariant2 && computerToolCallOutputResourceVariant2 != null)
            {
                return computerToolCallOutputResourceVariant2(ComputerToolCallOutputResourceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCallOutput?>? computerToolCallOutput = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2?>? computerToolCallOutputResourceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComputerToolCallOutput)
            {
                computerToolCallOutput?.Invoke(ComputerToolCallOutput!);
            }
            else if (IsComputerToolCallOutputResourceVariant2)
            {
                computerToolCallOutputResourceVariant2?.Invoke(ComputerToolCallOutputResourceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ComputerToolCallOutput,
                typeof(global::tryAGI.OpenAI.ComputerToolCallOutput),
                ComputerToolCallOutputResourceVariant2,
                typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2),
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
        public bool Equals(ComputerToolCallOutputResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCallOutput?>.Default.Equals(ComputerToolCallOutput, other.ComputerToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2?>.Default.Equals(ComputerToolCallOutputResourceVariant2, other.ComputerToolCallOutputResourceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ComputerToolCallOutputResource obj1, ComputerToolCallOutputResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputerToolCallOutputResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ComputerToolCallOutputResource obj1, ComputerToolCallOutputResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputerToolCallOutputResource o && Equals(o);
        }
    }
}
