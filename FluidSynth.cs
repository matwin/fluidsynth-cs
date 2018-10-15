using System;
using System.Runtime.InteropServices;

namespace fluidsynthnet
{
    public static class FluidSynth
    {
        private const string nativeLibName = "libfluidsynth-2";

        public const int FLUID_FAILED = -1;

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe int fluid_synth_write_s16(
            IntPtr synth,
            int len,
            void* lout, int loff, int lincr,
            void* rout, int roff, int rincr);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int fluid_synth_all_sounds_off(IntPtr synth, int chan);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void fluid_settings_setnum(IntPtr settings,
            [MarshalAs(UnmanagedType.LPStr)] string name,
            double val);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void fluid_settings_setstr(IntPtr settings,
            [MarshalAs(UnmanagedType.LPStr)] string name,
            [MarshalAs(UnmanagedType.LPStr)] string str);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr new_fluid_synth(IntPtr fluidSettings);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int fluid_synth_sfload(IntPtr synth,
            [MarshalAs(UnmanagedType.LPStr)] string filename,
            int resetPresets);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr new_fluid_settings();

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int fluid_synth_cc(IntPtr fluidSynth, int channel, int num,
            int val);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int fluid_synth_program_change(IntPtr synth, int channel, int prognum);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int fluid_synth_noteon(IntPtr synth, int channel, int key,
            int vel);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int fluid_synth_noteoff(IntPtr synth, int channel, int vel);

        [DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int fluid_synth_pitch_bend(IntPtr fluidSynth, int channel, int i);


        public static void delete_fluid_synth(IntPtr fluidSynth)
        {
            throw new NotImplementedException();
        }

        public static void delete_fluid_settings(IntPtr fluidSettings)
        {
            throw new NotImplementedException();
        }

        public static void fluid_synth_sfunload(IntPtr fluidSynth, int soundFont, int i)
        {
            throw new NotImplementedException();
        }


    }

}