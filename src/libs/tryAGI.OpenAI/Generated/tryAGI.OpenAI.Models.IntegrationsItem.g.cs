#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IntegrationsItem : global::System.IEquatable<IntegrationsItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.FineTuningIntegration? FineTuningIntegration { get; init; }
#else
        public global::tryAGI.OpenAI.FineTuningIntegration? FineTuningIntegration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FineTuningIntegration))]
#endif
        public bool IsFineTuningIntegration => FineTuningIntegration != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationsItem(global::tryAGI.OpenAI.FineTuningIntegration value) => new IntegrationsItem((global::tryAGI.OpenAI.FineTuningIntegration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.FineTuningIntegration?(IntegrationsItem @this) => @this.FineTuningIntegration;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsItem(global::tryAGI.OpenAI.FineTuningIntegration? value)
        {
            FineTuningIntegration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FineTuningIntegration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FineTuningIntegration?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFineTuningIntegration;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.FineTuningIntegration?, TResult>? fineTuningIntegration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFineTuningIntegration && fineTuningIntegration != null)
            {
                return fineTuningIntegration(FineTuningIntegration!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.FineTuningIntegration?>? fineTuningIntegration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFineTuningIntegration)
            {
                fineTuningIntegration?.Invoke(FineTuningIntegration!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FineTuningIntegration,
                typeof(global::tryAGI.OpenAI.FineTuningIntegration),
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
        public bool Equals(IntegrationsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.FineTuningIntegration?>.Default.Equals(FineTuningIntegration, other.FineTuningIntegration) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IntegrationsItem obj1, IntegrationsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IntegrationsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IntegrationsItem obj1, IntegrationsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IntegrationsItem o && Equals(o);
        }
    }
}
