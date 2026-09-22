#nullable enable

using System.CommandLine;

namespace tryAGI.OpenAI.Cli.GeneratedApi.Commands;

internal sealed record LiveWebRTCTransportOptionSet(
    Option<global::tryAGI.OpenAI.LiveWebRTCTransportType> Type,
                     Option<string> Sdp)
{
    public static LiveWebRTCTransportOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new LiveWebRTCTransportOptionSet(
                        Type: new Option<global::tryAGI.OpenAI.LiveWebRTCTransportType>($"--{normalizedPrefix}type")
                {
                    Description = @"The transport used for the Live session. Always `webrtc`.",
                },
                Sdp: new Option<string>($"--{normalizedPrefix}sdp")
                {
                    Description = @"Session Description Protocol message for the WebRTC connection.",
                    Required = true,
                }
        );
    }
}