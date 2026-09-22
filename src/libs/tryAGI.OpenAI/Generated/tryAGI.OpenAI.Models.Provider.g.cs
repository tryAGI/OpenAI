#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Provider : global::System.IEquatable<Provider>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ProviderDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? Aws { get; init; }
#else
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? Aws { get; }
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
            out global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? value)
        {
            value = Aws;
            return IsAws;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponse PickAws() => IsAws
            ? Aws!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aws' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? Azure { get; init; }
#else
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? Azure { get; }
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
            out global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponse PickAzure() => IsAzure
            ? Azure!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? Gcp { get; init; }
#else
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? Gcp { get; }
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
            out global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? value)
        {
            value = Gcp;
            return IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponse PickGcp() => IsGcp
            ? Gcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse value) => new Provider((global::tryAGI.OpenAI.AwsExternalStorageProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AwsExternalStorageProviderResponse?(Provider @this) => @this.Aws;

        /// <summary>
        ///
        /// </summary>
        public Provider(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? value)
        {
            Aws = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider FromAws(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? value) => new Provider(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse value) => new Provider((global::tryAGI.OpenAI.AzureExternalStorageProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AzureExternalStorageProviderResponse?(Provider @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public Provider(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider FromAzure(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? value) => new Provider(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse value) => new Provider((global::tryAGI.OpenAI.GcpExternalStorageProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GcpExternalStorageProviderResponse?(Provider @this) => @this.Gcp;

        /// <summary>
        ///
        /// </summary>
        public Provider(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? value)
        {
            Gcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider FromGcp(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? value) => new Provider(value);

        /// <summary>
        ///
        /// </summary>
        public Provider(
            global::tryAGI.OpenAI.ProviderDiscriminatorType? type,
            global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? aws,
            global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? azure,
            global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? gcp
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
            global::System.Func<global::tryAGI.OpenAI.AwsExternalStorageProviderResponse, TResult>? aws = null,
            global::System.Func<global::tryAGI.OpenAI.AzureExternalStorageProviderResponse, TResult>? azure = null,
            global::System.Func<global::tryAGI.OpenAI.GcpExternalStorageProviderResponse, TResult>? gcp = null,
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
            global::System.Action<global::tryAGI.OpenAI.AwsExternalStorageProviderResponse>? aws = null,

            global::System.Action<global::tryAGI.OpenAI.AzureExternalStorageProviderResponse>? azure = null,

            global::System.Action<global::tryAGI.OpenAI.GcpExternalStorageProviderResponse>? gcp = null,
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
            global::System.Action<global::tryAGI.OpenAI.AwsExternalStorageProviderResponse>? aws = null,
            global::System.Action<global::tryAGI.OpenAI.AzureExternalStorageProviderResponse>? azure = null,
            global::System.Action<global::tryAGI.OpenAI.GcpExternalStorageProviderResponse>? gcp = null,
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
                typeof(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse),
                Azure,
                typeof(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse),
                Gcp,
                typeof(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse),
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
        public bool Equals(Provider other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AwsExternalStorageProviderResponse?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AzureExternalStorageProviderResponse?>.Default.Equals(Azure, other.Azure) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GcpExternalStorageProviderResponse?>.Default.Equals(Gcp, other.Gcp)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Provider obj1, Provider obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Provider>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Provider obj1, Provider obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Provider o && Equals(o);
        }
    }
}
