using InClassPA;

IPitch fastball = new Fastball();

IPitch curve = new Curveball();

IPitch slider = new Slider();

Pitcher craftyLefty = new Lefty() { Name = "Krafty", Team = "Mets", Throws = "Left" };

craftyLefty.PitchBehavior.Pitch();
Console.WriteLine("That was a strike!");

craftyLefty.SetPitchBehavior(fastball);
craftyLefty.PitchBehavior.Pitch();
Console.WriteLine("That was a strike!");

craftyLefty.SetPitchBehavior(slider);
craftyLefty.PitchBehavior.Pitch();
Console.WriteLine("That was a ball :(");

craftyLefty.SetPitchBehavior(curve);
craftyLefty.PitchBehavior.Pitch();
Console.WriteLine("Strike 3, batters out!!");
