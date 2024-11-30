using System.Runtime.InteropServices;
using PortAudioSharp;

namespace OpenAI;

/// <summary>
/// Implements a Microphone using PortAudio
/// </summary>
public sealed class Microphone : IDisposable
{
    /// <summary>
    /// 
    /// </summary>
    static Microphone()
    {
        PortAudio.Initialize();
    }

    /// <summary>
    /// 
    /// </summary>
    public static void Terminate()
    {
        PortAudio.Terminate();
    }

    /// <summary>
    /// 
    /// </summary>
    public Action<byte[], int>? PushCallback { get; set; }

    /// <summary>
    /// Sample rate
    /// </summary>
    public int SampleRate { get; set; } = 48_000;
    
    /// <summary>
    /// Chunk size
    /// </summary>
    public int ChunkSize { get; set; } = 32_000;
    
    /// <summary>
    /// Number of channels
    /// </summary>
    public int Channels { get; set; } = 1;
    
    /// <summary>
    /// Input device index
    /// </summary>
    public int DeviceIndex { get; set; } = PortAudio.NoDevice;
    
    /// <summary>
    /// Sample Format
    /// </summary>
    public SampleFormat SampleFormat { get; set; } = SampleFormat.Int16;
    
    /// <summary>
    /// 
    /// </summary>
    public bool IsMuted { get; private set; }

    private PortAudioSharp.Stream? _stream;
    private CancellationTokenSource? _exitToken;

    /// <summary>
    /// Start begins the listening on the microphone
    /// </summary>
    /// <returns></returns>
    public bool Start()
    {
        if (_stream != null)
        {
            return false;
        }

        // reset exit token
        _exitToken?.Dispose();
        _exitToken = new CancellationTokenSource();

        // Get the device info
        if (DeviceIndex == PortAudio.NoDevice)
        {
            DeviceIndex = PortAudio.DefaultInputDevice;
            if (DeviceIndex == PortAudio.NoDevice)
            {
                return false;
            }
        }

        DeviceInfo info = PortAudio.GetDeviceInfo(DeviceIndex);

        // Create the stream
        _stream = new PortAudioSharp.Stream(
            inParams: new StreamParameters
            {
                device = DeviceIndex,
                channelCount = Channels,
                sampleFormat = SampleFormat,
                suggestedLatency = info.defaultLowInputLatency,
                hostApiSpecificStreamInfo = IntPtr.Zero,
            },
            outParams: null,
            sampleRate: SampleRate,
            framesPerBuffer: (uint)ChunkSize,
            streamFlags: StreamFlags.ClipOff,
            callback: Сallback,
            userData: IntPtr.Zero
            );

        // Start the stream
        _stream.Start();
        return true;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Stop()
    {
        // Check if we have a stream
        if (_stream == null)
        {
            return;
        }

        // signal stop
        _exitToken?.Cancel();

        // Stop the stream
        _stream.Stop();
        
        _stream.Dispose();
        _stream = null;
        _exitToken?.Dispose();
        _exitToken = null;
    }

    private StreamCallbackResult Сallback(
        nint input,
        nint output,
        uint frameCount,
        ref StreamCallbackTimeInfo timeInfo,
        StreamCallbackFlags statusFlags,
        nint userDataPtr)
    {
        // Check if the input is null
        if (input == IntPtr.Zero)
        {
            return StreamCallbackResult.Continue;
        }

        // Check if the exit token is set
        if (_exitToken is { IsCancellationRequested: true })
        {
            return StreamCallbackResult.Abort;
        }

        // copy and send the data
        byte[] buf = new byte[frameCount * sizeof(Int16)];

        if (IsMuted)
        {
            buf = new byte[buf.Length];
        }
        else
        {
            Marshal.Copy(input, buf, 0, buf.Length);
        }

        PushCallback?.Invoke(buf, buf.Length);

        return StreamCallbackResult.Continue;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Mute()
    {
        if (_stream != null)
        {
            return;
        }

        IsMuted = true;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Unmute()
    {
        if (_stream != null)
        {
            return;
        }

        IsMuted = false;
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        Stop();
    }
}
