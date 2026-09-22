#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// One or more lifecycle statuses to include when listing vaults or credentials.
    /// </summary>
    public readonly partial struct VaultStatusFilterParam : global::System.IEquatable<VaultStatusFilterParam>
    {
        /// <summary>
        /// Whether a vault or credential is active or archived.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.VaultStatusParam? VaultStatusParam { get; init; }
#else
        public global::tryAGI.OpenAI.VaultStatusParam? VaultStatusParam { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultStatusParam))]
#endif
        public bool IsVaultStatusParam => VaultStatusParam != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVaultStatusParam(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.VaultStatusParam? value)
        {
            value = VaultStatusParam;
            return IsVaultStatusParam;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VaultStatusParam PickVaultStatusParam() => IsVaultStatusParam
            ? VaultStatusParam!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultStatusParam' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>? VaultStatusFilterParamVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>? VaultStatusFilterParamVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VaultStatusFilterParamVariant2))]
#endif
        public bool IsVaultStatusFilterParamVariant2 => VaultStatusFilterParamVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVaultStatusFilterParamVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>? value)
        {
            value = VaultStatusFilterParamVariant2;
            return IsVaultStatusFilterParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam> PickVaultStatusFilterParamVariant2() => IsVaultStatusFilterParamVariant2
            ? VaultStatusFilterParamVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VaultStatusFilterParamVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VaultStatusFilterParam(global::tryAGI.OpenAI.VaultStatusParam value) => new VaultStatusFilterParam((global::tryAGI.OpenAI.VaultStatusParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.VaultStatusParam?(VaultStatusFilterParam @this) => @this.VaultStatusParam;

        /// <summary>
        ///
        /// </summary>
        public VaultStatusFilterParam(global::tryAGI.OpenAI.VaultStatusParam? value)
        {
            VaultStatusParam = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VaultStatusFilterParam FromVaultStatusParam(global::tryAGI.OpenAI.VaultStatusParam? value) => new VaultStatusFilterParam(value);

        /// <summary>
        ///
        /// </summary>
        public VaultStatusFilterParam(
            global::tryAGI.OpenAI.VaultStatusParam? vaultStatusParam,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>? vaultStatusFilterParamVariant2
            )
        {
            VaultStatusParam = vaultStatusParam;
            VaultStatusFilterParamVariant2 = vaultStatusFilterParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            VaultStatusFilterParamVariant2 as object ??
            VaultStatusParam as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            VaultStatusParam?.ToValueString() ??
            VaultStatusFilterParamVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsVaultStatusParam && !IsVaultStatusFilterParamVariant2 || !IsVaultStatusParam && IsVaultStatusFilterParamVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.VaultStatusParam?, TResult>? vaultStatusParam = null,
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>, TResult>? vaultStatusFilterParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVaultStatusParam && vaultStatusParam != null)
            {
                return vaultStatusParam(VaultStatusParam!);
            }
            else if (IsVaultStatusFilterParamVariant2 && vaultStatusFilterParamVariant2 != null)
            {
                return vaultStatusFilterParamVariant2(VaultStatusFilterParamVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.VaultStatusParam?>? vaultStatusParam = null,

            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>>? vaultStatusFilterParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVaultStatusParam)
            {
                vaultStatusParam?.Invoke(VaultStatusParam!);
            }
            else if (IsVaultStatusFilterParamVariant2)
            {
                vaultStatusFilterParamVariant2?.Invoke(VaultStatusFilterParamVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.VaultStatusParam?>? vaultStatusParam = null,
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>>? vaultStatusFilterParamVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVaultStatusParam)
            {
                vaultStatusParam?.Invoke(VaultStatusParam!);
            }
            else if (IsVaultStatusFilterParamVariant2)
            {
                vaultStatusFilterParamVariant2?.Invoke(VaultStatusFilterParamVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VaultStatusParam,
                typeof(global::tryAGI.OpenAI.VaultStatusParam),
                VaultStatusFilterParamVariant2,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>),
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
        public bool Equals(VaultStatusFilterParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.VaultStatusParam?>.Default.Equals(VaultStatusParam, other.VaultStatusParam) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VaultStatusParam>?>.Default.Equals(VaultStatusFilterParamVariant2, other.VaultStatusFilterParamVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(VaultStatusFilterParam obj1, VaultStatusFilterParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VaultStatusFilterParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultStatusFilterParam obj1, VaultStatusFilterParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultStatusFilterParam o && Equals(o);
        }
    }
}
