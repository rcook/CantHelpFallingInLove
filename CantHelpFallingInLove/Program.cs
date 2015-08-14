namespace CantHelpFallingInLove
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public static class Program
    {
        public static void Main()
        {
            PlaySong(Songs.CantHelpFallingInLove);
        }

        private static void PlaySong(IEnumerable<Note> notes)
        {
            foreach (var note in notes)
            {
                if (note.Pitch == Pitch.Rest)
                {
                    Thread.Sleep(note.Duration);
                }
                else
                {
                    Console.Beep((int)note.Pitch, note.Duration);
                }
            }
        }
    }
}
