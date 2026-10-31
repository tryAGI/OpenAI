#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct V1OrganizationExternalKeysPostRequest : global::System.IEquatable<V1OrganizationExternalKeysPostRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.V1OrganizationExternalKeysPostRequestDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AwsExternalKeyParams? Aws { get; init; }
#else
        public global::tryAGI.OpenAI.AwsExternalKeyParams? Aws { get; }
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
            out global::tryAGI.OpenAI.AwsExternalKeyParams? value)
        {
            value = Aws;
            return IsAws;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AwsExternalKeyParams PickAws() => Aws is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aws' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.GcpExternalKeyParams? Gcp { get; init; }
#else
        public global::tryAGI.OpenAI.GcpExternalKeyParams? Gcp { get; }
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
            out global::tryAGI.OpenAI.GcpExternalKeyParams? value)
        {
            value = Gcp;
            return IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.GcpExternalKeyParams PickGcp() => Gcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.AzureExternalKeyParams? Azure { get; init; }
#else
        public global::tryAGI.OpenAI.AzureExternalKeyParams? Azure { get; }
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
            out global::tryAGI.OpenAI.AzureExternalKeyParams? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.AzureExternalKeyParams PickAzure() => Azure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator V1OrganizationExternalKeysPostRequest(global::tryAGI.OpenAI.AwsExternalKeyParams value) => new V1OrganizationExternalKeysPostRequest((global::tryAGI.OpenAI.AwsExternalKeyParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AwsExternalKeyParams?(V1OrganizationExternalKeysPostRequest @this) => @this.Aws;

        /// <summary>
        ///
        /// </summary>
        public V1OrganizationExternalKeysPostRequest(global::tryAGI.OpenAI.AwsExternalKeyParams? value)
        {
            Aws = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static V1OrganizationExternalKeysPostRequest FromAws(global::tryAGI.OpenAI.AwsExternalKeyParams? value) => new V1OrganizationExternalKeysPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator V1OrganizationExternalKeysPostRequest(global::tryAGI.OpenAI.GcpExternalKeyParams value) => new V1OrganizationExternalKeysPostRequest((global::tryAGI.OpenAI.GcpExternalKeyParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.GcpExternalKeyParams?(V1OrganizationExternalKeysPostRequest @this) => @this.Gcp;

        /// <summary>
        ///
        /// </summary>
        public V1OrganizationExternalKeysPostRequest(global::tryAGI.OpenAI.GcpExternalKeyParams? value)
        {
            Gcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static V1OrganizationExternalKeysPostRequest FromGcp(global::tryAGI.OpenAI.GcpExternalKeyParams? value) => new V1OrganizationExternalKeysPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator V1OrganizationExternalKeysPostRequest(global::tryAGI.OpenAI.AzureExternalKeyParams value) => new V1OrganizationExternalKeysPostRequest((global::tryAGI.OpenAI.AzureExternalKeyParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.AzureExternalKeyParams?(V1OrganizationExternalKeysPostRequest @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public V1OrganizationExternalKeysPostRequest(global::tryAGI.OpenAI.AzureExternalKeyParams? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static V1OrganizationExternalKeysPostRequest FromAzure(global::tryAGI.OpenAI.AzureExternalKeyParams? value) => new V1OrganizationExternalKeysPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public V1OrganizationExternalKeysPostRequest(
            global::tryAGI.OpenAI.V1OrganizationExternalKeysPostRequestDiscriminatorType? type,
            global::tryAGI.OpenAI.AwsExternalKeyParams? aws,
            global::tryAGI.OpenAI.GcpExternalKeyParams? gcp,
            global::tryAGI.OpenAI.AzureExternalKeyParams? azure
            )
        {
            Type = type;

            Aws = aws;
            Gcp = gcp;
            Azure = azure;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Azure as object ??
            Gcp as object ??
            Aws as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Aws?.ToString() ??
            Gcp?.ToString() ??
            Azure?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAws && !IsGcp && !IsAzure || !IsAws && IsGcp && !IsAzure || !IsAws && !IsGcp && IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.AwsExternalKeyParams, TResult>? aws = null,
            global::System.Func<global::tryAGI.OpenAI.GcpExternalKeyParams, TResult>? gcp = null,
            global::System.Func<global::tryAGI.OpenAI.AzureExternalKeyParams, TResult>? azure = null,
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
            else if (Gcp is { } __value1 && gcp != null)
            {
                return gcp(__value1);
            }
            else if (Azure is { } __value2 && azure != null)
            {
                return azure(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.AwsExternalKeyParams>? aws = null,

            global::System.Action<global::tryAGI.OpenAI.GcpExternalKeyParams>? gcp = null,

            global::System.Action<global::tryAGI.OpenAI.AzureExternalKeyParams>? azure = null,
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
            else if (Gcp is { } __value1)
            {
                gcp?.Invoke(__value1);
            }
            else if (Azure is { } __value2)
            {
                azure?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.AwsExternalKeyParams>? aws = null,
            global::System.Action<global::tryAGI.OpenAI.GcpExternalKeyParams>? gcp = null,
            global::System.Action<global::tryAGI.OpenAI.AzureExternalKeyParams>? azure = null,
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
            else if (Gcp is { } __value1)
            {
                gcp?.Invoke(__value1);
            }
            else if (Azure is { } __value2)
            {
                azure?.Invoke(__value2);
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
                typeof(global::tryAGI.OpenAI.AwsExternalKeyParams),
                Gcp,
                typeof(global::tryAGI.OpenAI.GcpExternalKeyParams),
                Azure,
                typeof(global::tryAGI.OpenAI.AzureExternalKeyParams),
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
        public bool Equals(V1OrganizationExternalKeysPostRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AwsExternalKeyParams?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.GcpExternalKeyParams?>.Default.Equals(Gcp, other.Gcp) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.AzureExternalKeyParams?>.Default.Equals(Azure, other.Azure)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(V1OrganizationExternalKeysPostRequest obj1, V1OrganizationExternalKeysPostRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V1OrganizationExternalKeysPostRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(V1OrganizationExternalKeysPostRequest obj1, V1OrganizationExternalKeysPostRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V1OrganizationExternalKeysPostRequest o && Equals(o);
        }
    }
}
