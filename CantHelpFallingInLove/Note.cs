namespace CantHelpFallingInLove
{
    public sealed class Note
    {
        public Note(decimal pitch, int duration)
        {
            m_pitch = pitch;
            m_duration = duration;
        }

        public decimal Pitch
        {
            get { return m_pitch; }
        }

        public int Duration
        {
            get { return m_duration; }
        }

        private readonly decimal m_pitch;
        private readonly int m_duration;
    }
}
