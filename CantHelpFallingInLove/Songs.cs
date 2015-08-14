namespace CantHelpFallingInLove
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Songs
    {
        private static readonly IEnumerable<Note> s_cantHelpFallingInLoveShared = new[]
        {
            // Wise men / Shall I / Take my
            Note(Pitch.F5, Duration.Half),
            Note(Pitch.C6, Duration.Half),

            // say only / stay? Would it / hand, take my
            Note(Pitch.F5, Duration.Half + Duration.Quarter),
            Note(Pitch.G5, Duration.Eighth),
            Note(Pitch.A5, Duration.Eighth),

            // fools rush / be a / whole life
            Note(Pitch.ASharp5, Duration.Half),
            Note(Pitch.A5, Duration.Half),

            // in, But / sin if / too. For
            Note(Pitch.G5, Duration.Half + Duration.Quarter + Duration.Eighth),
            Note(Pitch.C5, Duration.Eighth),

            // I can't / I can't / I can't
            Note(Pitch.D5, Duration.Half),
            Note(Pitch.E5, Duration.Half),

            // help falling in / help falling in / help falling in
            Note(Pitch.F5, Duration.Half),
            Note(Pitch.G5, Duration.Half / 3),
            Note(Pitch.A5, Duration.Half / 3),
            Note(Pitch.ASharp5, Duration.Half / 3),

            // love with / love with / love with
            Note(Pitch.A5, Duration.Half),
            Note(Pitch.G5, Duration.Half)
        };

        private static readonly IEnumerable<Note> s_cantHelpFallingInLoveVerse =
            s_cantHelpFallingInLoveShared.Concat(new[]
            {
                // you. / you?
                Note(Pitch.F5, Duration.Whole)
            });

        private static readonly Note[] s_cantHelpFallingInLoveBridge = new[]
        {
            // Live a river flows
            Note(Pitch.E5, Duration.Eighth),
            Note(Pitch.A5, Duration.Eighth),
            Note(Pitch.C6, Duration.Eighth),
            Note(Pitch.E6, Duration.Eighth),
            Note(Pitch.D6, Duration.Half),

            // surely to the sea,
            Note(Pitch.E5, Duration.Eighth),
            Note(Pitch.A5, Duration.Eighth),
            Note(Pitch.C6, Duration.Eighth),
            Note(Pitch.E6, Duration.Eighth),
            Note(Pitch.D6, Duration.Half),

            // Darling, so it goes.
            Note(Pitch.E5, Duration.Eighth),
            Note(Pitch.A5, Duration.Eighth),
            Note(Pitch.C6, Duration.Eighth),
            Note(Pitch.E6, Duration.Eighth),
            Note(Pitch.D6, Duration.Half),

            // Some things are meant to
            Note(Pitch.C6, Duration.Quarter),
            Note(Pitch.C6, Duration.Quarter + Duration.Eighth),
            Note(Pitch.A5, Duration.Eighth),
            Note(Pitch.C6, Duration.Eighth),
            Note(Pitch.A5, Duration.Eighth),

            // be.
            Note(Pitch.ASharp5, Duration.Whole)
        };

        private static readonly IEnumerable<Note> s_cantHelpFallingInLoveEnding =
            s_cantHelpFallingInLoveShared.Concat(new[]
            {
                // you. For
                Note(Pitch.F5, Duration.Half + Duration.Quarter + Duration.Eighth),
                Note(Pitch.C5, Duration.Eighth),

                // I can't
                Note(Pitch.D5, Duration.Half),
                Note(Pitch.E5, Duration.Half),

                // help falling in
                Note(Pitch.F5, Duration.Half),
                Note(Pitch.G5, Duration.Half / 3),
                Note(Pitch.A5, Duration.Half / 3),
                Note(Pitch.ASharp5, Duration.Half / 3),

                // love with
                Note(Pitch.A5, Duration.Half),
                Note(Pitch.G5, Duration.Half),

                // you.
                Note(Pitch.F5, Duration.Whole + Duration.Whole)
            });

        private static readonly IEnumerable<Note> s_cantHelpFallingInLove =
            s_cantHelpFallingInLoveVerse
            .Concat(s_cantHelpFallingInLoveVerse)
            .Concat(s_cantHelpFallingInLoveBridge)
            .Concat(s_cantHelpFallingInLoveEnding);

        public static IEnumerable<Note> CantHelpFallingInLove
        {
            get { return s_cantHelpFallingInLove; }
        }

        private static Note Note(decimal pitch, int duration)
        {
            return new Note(pitch, duration);
        }
    }
}
