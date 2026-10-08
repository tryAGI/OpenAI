#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Provider2 : global::System.IEquatable<Provider2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType? Type { get; }

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
        public global::tryAGI.OpenAI.AwsExternalStorageProviderResponse PickAws() => Aws is { } value
            ? value
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
        public global::tryAGI.OpenAI.AzureExternalStorageProviderResponse PickAzure() => Azure is { } value
            ? value
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
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponse PickGcp() => Gcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponse? Oci { get; init; }
#else
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponse? Oci { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oci))]
#endif
        public bool IsOci => Oci != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOci(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.OciExternalStorageProviderResponse? value)
        {
            value = Oci;
            return IsOci;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.OciExternalStorageProviderResponse PickOci() => Oci is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Oci' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider2(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse value) => new Provider2((global::tryAGI.OpenAI.AwsExternalStorageProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AwsExternalStorageProviderResponse?(Provider2 @this) => @this.Aws;

        /// <summary>
        ///
        /// </summary>
        public Provider2(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? value)
        {
            Aws = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider2 FromAws(global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? value) => new Provider2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider2(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse value) => new Provider2((global::tryAGI.OpenAI.AzureExternalStorageProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AzureExternalStorageProviderResponse?(Provider2 @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public Provider2(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider2 FromAzure(global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? value) => new Provider2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider2(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse value) => new Provider2((global::tryAGI.OpenAI.GcpExternalStorageProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GcpExternalStorageProviderResponse?(Provider2 @this) => @this.Gcp;

        /// <summary>
        ///
        /// </summary>
        public Provider2(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? value)
        {
            Gcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider2 FromGcp(global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? value) => new Provider2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Provider2(global::tryAGI.OpenAI.OciExternalStorageProviderResponse value) => new Provider2((global::tryAGI.OpenAI.OciExternalStorageProviderResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OciExternalStorageProviderResponse?(Provider2 @this) => @this.Oci;

        /// <summary>
        ///
        /// </summary>
        public Provider2(global::tryAGI.OpenAI.OciExternalStorageProviderResponse? value)
        {
            Oci = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Provider2 FromOci(global::tryAGI.OpenAI.OciExternalStorageProviderResponse? value) => new Provider2(value);

        /// <summary>
        ///
        /// </summary>
        public Provider2(
            global::tryAGI.OpenAI.ExternalStorageResponseProviderDiscriminatorType? type,
            global::tryAGI.OpenAI.AwsExternalStorageProviderResponse? aws,
            global::tryAGI.OpenAI.AzureExternalStorageProviderResponse? azure,
            global::tryAGI.OpenAI.GcpExternalStorageProviderResponse? gcp,
            global::tryAGI.OpenAI.OciExternalStorageProviderResponse? oci
            )
        {
            Type = type;

            Aws = aws;
            Azure = azure;
            Gcp = gcp;
            Oci = oci;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Oci as object ??
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
            Gcp?.ToString() ??
            Oci?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAws && !IsAzure && !IsGcp && !IsOci || !IsAws && IsAzure && !IsGcp && !IsOci || !IsAws && !IsAzure && IsGcp && !IsOci || !IsAws && !IsAzure && !IsGcp && IsOci;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AwsExternalStorageProviderResponse, TResult>? aws = null,
            global::System.Func<global::tryAGI.OpenAI.AzureExternalStorageProviderResponse, TResult>? azure = null,
            global::System.Func<global::tryAGI.OpenAI.GcpExternalStorageProviderResponse, TResult>? gcp = null,
            global::System.Func<global::tryAGI.OpenAI.OciExternalStorageProviderResponse, TResult>? oci = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0 && aws != null)
            {
                return aws(__value0);
            }
            else if (Azure is { } __value1 && azure != null)
            {
                return azure(__value1);
            }
            else if (Gcp is { } __value2 && gcp != null)
            {
                return gcp(__value2);
            }
            else if (Oci is { } __value3 && oci != null)
            {
                return oci(__value3);
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

            global::System.Action<global::tryAGI.OpenAI.OciExternalStorageProviderResponse>? oci = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0)
            {
                aws?.Invoke(__value0);
            }
            else if (Azure is { } __value1)
            {
                azure?.Invoke(__value1);
            }
            else if (Gcp is { } __value2)
            {
                gcp?.Invoke(__value2);
            }
            else if (Oci is { } __value3)
            {
                oci?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AwsExternalStorageProviderResponse>? aws = null,
            global::System.Action<global::tryAGI.OpenAI.AzureExternalStorageProviderResponse>? azure = null,
            global::System.Action<global::tryAGI.OpenAI.GcpExternalStorageProviderResponse>? gcp = null,
            global::System.Action<global::tryAGI.OpenAI.OciExternalStorageProviderResponse>? oci = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0)
            {
                aws?.Invoke(__value0);
            }
            else if (Azure is { } __value1)
            {
                azure?.Invoke(__value1);
            }
            else if (Gcp is { } __value2)
            {
                gcp?.Invoke(__value2);
            }
            else if (Oci is { } __value3)
            {
                oci?.Invoke(__value3);
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
                Oci,
                typeof(global::tryAGI.OpenAI.OciExternalStorageProviderResponse),
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
        public bool Equals(Provider2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AwsExternalStorageProviderResponse?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AzureExternalStorageProviderResponse?>.Default.Equals(Azure, other.Azure) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GcpExternalStorageProviderResponse?>.Default.Equals(Gcp, other.Gcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OciExternalStorageProviderResponse?>.Default.Equals(Oci, other.Oci)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Provider2 obj1, Provider2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Provider2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Provider2 obj1, Provider2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Provider2 o && Equals(o);
        }
    }
}
