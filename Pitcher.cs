namespace InClassPA
{
    public class Pitcher
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Throws { get; set; }        
        public IPitch PitchBehavior;
        public Pitcher()
        {
            PitchBehavior = new Fastball();
        }

        public void SetPitchBehavior(IPitch newPitch)
        {
            PitchBehavior = newPitch;
        }
    }
}