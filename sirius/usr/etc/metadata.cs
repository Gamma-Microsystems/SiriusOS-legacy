using System;
using Sys = Cosmos.System;
using Cosmos.System.Audio.IO;
using IL2CPU.API.Attribs;

namespace sirius.etc
{
    public class MetaData
    {
        [ManifestResourceStream(ResourceName = "Sirius.etc.sfx.startup.wav")] public static byte[] StartupB;
        [ManifestResourceStream(ResourceName = "Sirius.etc.sfx.shutdown.wav")] public static byte[] ShutdownB;
        [ManifestResourceStream(ResourceName = "Sirius.etc.sfx.error.wav")] public static byte[] ErrorB;

	    public static MemoryAudioStream Shutdown = MemoryAudioStream.FromWave(ShutdownB);
	    public static MemoryAudioStream Startup = MemoryAudioStream.FromWave(StartupB);
        public static MemoryAudioStream Error = MemoryAudioStream.FromWave(ErrorB);
    }
}