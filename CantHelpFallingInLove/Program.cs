namespace CantHelpFallingInLove
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    public static class Program
    {
        public static void Main()
        {
            PlaySong(Songs.CantHelpFallingInLove);
        }

        private static void PlaySong(IEnumerable<Note> notes)
        {
            var offset = (int)notes.Min(x => x.Pitch);

            foreach (var note in notes)
            {
                if (note.Pitch == Pitch.Rest)
                {
                    Thread.Sleep(note.Duration);
                }
                else
                {
                    Console.WriteLine("{0}#", new String('.', (int)note.Pitch - offset));
                    Console.Beep((int)Constants.Frequencies[note.Pitch], note.Duration);
                }
            }
        }
    }
}
