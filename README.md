# In-Class-PA-321

Simple C# strategy-pattern style pitching demo used for MIS 321 in-class practice.

## What was fixed

- Normalized all class/interface namespaces to `InClassPA`.
- Updated `Program.cs` to use `InClassPA`.

These updates are structural only and do not change program logic or expected console output.

## Files

- `Program.cs` - top-level execution flow
- `Pitcher.cs` - base pitcher behavior and pitch switching
- `Lefty.cs` - specialized pitcher implementation
- `IPitch.cs` - pitch behavior contract
- `Fastball.cs`, `Curveball.cs`, `Slider.cs` - concrete pitch behaviors

## GitHub Notes

- Keep this directory as the repository root for this assignment submission.
- If you add a project file later, use `InClassPA` as the root namespace to stay consistent.
