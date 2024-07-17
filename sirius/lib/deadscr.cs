/*
    MIT License
    https://github.com/LumaTechnologies/SphereOS/blob/master/SphereOS/Core/CrashScreen.cs
*/

using Cosmos.Core;
using Cosmos.HAL;
using System;
using System.IO;

namespace Sirius.lib
{
    public static class CrashScreen
    {
        private static string messageLoading = @"
 :-(

 Generating crash log, please wait...";

        private static string message = @"
 :-(

 Something went wrong, and SiriusOS must reboot.

 SiriusOS has generated a crash log, which you can view by pressing 'V'.
 This crash log has also been saved to 0:\crash.log.

                                             [V] View Log   [Esc] Reboot";

        private static string messageNoLogDump = @"
 :-(

 Something went wrong, and SiriusOS must reboot.

 SiriusOS has generated a crash log, which you can view by pressing 'V'.

                                            [V] View Log   [Esc] Reboot";

        private static bool? logDumpSuccess;

        private static string log = string.Empty;

        private static void ShowMessageFullScreen(string text)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;

            Console.Write(text);
        }

        private static void ShowCrashLog()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            Console.WriteLine("[i] Press any key to go back.");
            Console.WriteLine("Crash log:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(log);

            Console.ReadKey(true);
        }

        private static void GenerateCrashLog(Exception exception)
        {
            log = "[SiriusOS Crash]\n" +
                exception.ToString() +
                "\nDate: " + DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm:ss");
            try
            {
                File.WriteAllText(@"0:\crash.log", log);
                logDumpSuccess = true;
            }
            catch
            {
                logDumpSuccess = false;
            }
        }

        public static void ShowCrashScreen(Exception exception)
        {
            try
            {
                ShowMessageFullScreen(messageLoading);
                GenerateCrashLog(exception);
                while (true)
                {
                    ShowMessageFullScreen((bool)logDumpSuccess ? message : messageNoLogDump);
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.Escape:
                            Cosmos.System.Power.Reboot();
                            break;
                        case ConsoleKey.V:
                            ShowCrashLog();
                            break;
                        default:
                            break;
                    }
                    Cosmos.Core.Memory.Heap.Collect();
                }
            }
            catch
            {
                ShowMessageFullScreen("Fatal: Double fault.");
            }
        }
    }
}