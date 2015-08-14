namespace CantHelpFallingInLove
{
    public sealed class Note
    {
        public Note(Pitch pitch, int duration)
        {
            m_pitch = pitch;
            m_duration = duration;
        }

        public Pitch Pitch
        {
            get { return m_pitch; }
        }

        public int Duration
        {
            get { return m_duration; }
        }

        private readonly Pitch m_pitch;
        private readonly int m_duration;
    }
}
