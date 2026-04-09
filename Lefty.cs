namespace InClassPA
{
    public class Lefty : Pitcher
    {
        public Lefty()
        {
            Throws = "Left";
            PitchBehavior = new Curveball();
        }
    }
}