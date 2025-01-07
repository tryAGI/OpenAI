﻿// using System.Security.Authentication;
// using System.Text.Json.Serialization;
//
// namespace tryAGI.OpenAI;
//
// internal class AuthInfo
// {
//     internal const string SecretKeyPrefix = "sk-";
//     internal const string SessionKeyPrefix = "sess-";
//     internal const string OrganizationPrefix = "org-";
//
//     [JsonConstructor]
//     public AuthInfo(string apiKey, string? organizationId = null)
//     {
//         ApiKey = apiKey;
//
//         if (organizationId != null && !string.IsNullOrWhiteSpace(organizationId))
//         {
//             if (!organizationId.Contains(OrganizationPrefix))
//             {
//                 throw new InvalidCredentialException($"{nameof(organizationId)} must start with '{OrganizationPrefix}'");
//             }
//
//             OrganizationId = organizationId;
//         }
//     }
//
//     [JsonPropertyName("apiKey")]
//     public string ApiKey { get; }
//
//     [JsonPropertyName("organization")]
//     public string? OrganizationId { get; }
// }