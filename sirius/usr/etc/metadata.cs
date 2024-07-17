using System;
using Sys = Cosmos.System;
using Cosmos.System.Audio.IO;
using IL2CPU.API.Attribs;
//using Cosmos.System.Graphics.Fonts;

namespace Sirius.etc
{
    public class MetaData
    {
        [ManifestResourceStream(ResourceName = "Sirius.etc.sfx.startup.wav")] public static byte[] StartupB;
        [ManifestResourceStream(ResourceName = "Sirius.etc.sfx.shutdown.wav")] public static byte[] ShutdownB;
        [ManifestResourceStream(ResourceName = "Sirius.etc.sfx.error.wav")] public static byte[] ErrorB;
        [ManifestResourceStream(ResourceName = "Sirius.etc.assets.Cursor.bmp")] public static byte[] CursorB;
        [ManifestResourceStream(ResourceName = "Sirius.etc.assets.bg.bmp")] public static byte[] bgB;
        //[ManifestResourceStream(ResourceName = "Sirius.etc.fonts.Unifont15.psf")] public static byte[] UnifontB;

        //public static Font Unifont = new(UnifontB, 32);

	    public static MemoryAudioStream Shutdown = MemoryAudioStream.FromWave(ShutdownB);
	    public static MemoryAudioStream Startup = MemoryAudioStream.FromWave(StartupB);
        public static MemoryAudioStream Error = MemoryAudioStream.FromWave(ErrorB);
    }
}