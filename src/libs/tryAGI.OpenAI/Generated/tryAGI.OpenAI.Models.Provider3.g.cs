#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Provider3 : global::System.IEquatable<Provider3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams? Aws { get; init; }
#else
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams? Aws { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Aws))]
#endif
        public bool IsAws => Aws != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAws(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AwsExternalStorageProviderParams? value)
        {
            value = Aws;
            return IsAws;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderParams PickAws() => IsAws
            ? Aws!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aws' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams? Azure { get; init; }
#else
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams? Azure { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Azure))]
#endif
        public bool IsAzure => Azure != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAzure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.AzureExternalStorageProviderParams? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderParams PickAzure() => IsAzure
            ? Azure!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams? Gcp { get; init; }
#else
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams? Gcp { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gcp))]
#endif
        public bool IsGcp => Gcp != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.GcpExternalStorageProviderParams? value)
        {
            value = Gcp;
            return IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParams PickGcp() => IsGcp
            ? Gcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider3(global::tryAGI.OpenAI.AwsExternalStorageProviderParams value) => new Provider3((global::tryAGI.OpenAI.AwsExternalStorageProviderParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AwsExternalStorageProviderParams?(Provider3 @this) => @this.Aws;

        /// <summary>
        ///
        /// </summary>
        public Provider3(global::tryAGI.OpenAI.AwsExternalStorageProviderParams? value)
        {
            Aws = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider3 FromAws(global::tryAGI.OpenAI.AwsExternalStorageProviderParams? value) => new Provider3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider3(global::tryAGI.OpenAI.AzureExternalStorageProviderParams value) => new Provider3((global::tryAGI.OpenAI.AzureExternalStorageProviderParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AzureExternalStorageProviderParams?(Provider3 @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public Provider3(global::tryAGI.OpenAI.AzureExternalStorageProviderParams? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider3 FromAzure(global::tryAGI.OpenAI.AzureExternalStorageProviderParams? value) => new Provider3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider3(global::tryAGI.OpenAI.GcpExternalStorageProviderParams value) => new Provider3((global::tryAGI.OpenAI.GcpExternalStorageProviderParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GcpExternalStorageProviderParams?(Provider3 @this) => @this.Gcp;

        /// <summary>
        ///
        /// </summary>
        public Provider3(global::tryAGI.OpenAI.GcpExternalStorageProviderParams? value)
        {
            Gcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider3 FromGcp(global::tryAGI.OpenAI.GcpExternalStorageProviderParams? value) => new Provider3(value);

        /// <summary>
        ///
        /// </summary>
        public Provider3(
            global::tryAGI.OpenAI.CreateExternalStorageBodyProviderDiscriminatorType? type,
            global::tryAGI.OpenAI.AwsExternalStorageProviderParams? aws,
            global::tryAGI.OpenAI.AzureExternalStorageProviderParams? azure,
            global::tryAGI.OpenAI.GcpExternalStorageProviderParams? gcp
            )
        {
            Type = type;

            Aws = aws;
            Azure = azure;
            Gcp = gcp;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Gcp as object ??
            Azure as object ??
            Aws as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Aws?.ToString() ??
            Azure?.ToString() ??
            Gcp?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAws && !IsAzure && !IsGcp || !IsAws && IsAzure && !IsGcp || !IsAws && !IsAzure && IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AwsExternalStorageProviderParams, TResult>? aws = null,
            global::System.Func<global::tryAGI.OpenAI.AzureExternalStorageProviderParams, TResult>? azure = null,
            global::System.Func<global::tryAGI.OpenAI.GcpExternalStorageProviderParams, TResult>? gcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAws && aws != null)
            {
                return aws(Aws!);
            }
            else if (IsAzure && azure != null)
            {
                return azure(Azure!);
            }
            else if (IsGcp && gcp != null)
            {
                return gcp(Gcp!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AwsExternalStorageProviderParams>? aws = null,

            global::System.Action<global::tryAGI.OpenAI.AzureExternalStorageProviderParams>? azure = null,

            global::System.Action<global::tryAGI.OpenAI.GcpExternalStorageProviderParams>? gcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAws)
            {
                aws?.Invoke(Aws!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
            }
            else if (IsGcp)
            {
                gcp?.Invoke(Gcp!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AwsExternalStorageProviderParams>? aws = null,
            global::System.Action<global::tryAGI.OpenAI.AzureExternalStorageProviderParams>? azure = null,
            global::System.Action<global::tryAGI.OpenAI.GcpExternalStorageProviderParams>? gcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAws)
            {
                aws?.Invoke(Aws!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
            }
            else if (IsGcp)
            {
                gcp?.Invoke(Gcp!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Aws,
                typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderParams),
                Azure,
                typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderParams),
                Gcp,
                typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderParams),
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
        public bool Equals(Provider3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AwsExternalStorageProviderParams?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AzureExternalStorageProviderParams?>.Default.Equals(Azure, other.Azure) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GcpExternalStorageProviderParams?>.Default.Equals(Gcp, other.Gcp)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Provider3 obj1, Provider3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Provider3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Provider3 obj1, Provider3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Provider3 o && Equals(o);
        }
    }
}
