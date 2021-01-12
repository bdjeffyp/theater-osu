// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Input.Bindings;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Rulesets.Difficulty;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Theater.Beatmaps;
using osu.Game.Rulesets.Theater.Mods;
using osu.Game.Rulesets.Theater.UI;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Theater
{
    public class TheaterRuleset : Ruleset
    {
        public override string ShortName => "theater";
        
        public override string Description => "A ruleset based on the Theatrhythm games";

        public override string PlayingVerb => "Leveling up ... with music!";

        public override DrawableRuleset CreateDrawableRulesetWith(IBeatmap beatmap, IReadOnlyList<Mod> mods = null) => new DrawableTheaterRuleset(this, beatmap, mods);

        public override IBeatmapConverter CreateBeatmapConverter(IBeatmap beatmap) => new TheaterBeatmapConverter(beatmap, this);

        public override DifficultyCalculator CreateDifficultyCalculator(WorkingBeatmap beatmap) => new TheaterDifficultyCalculator(this, beatmap);

        public override IEnumerable<Mod> GetModsFor(ModType type)
        {
            switch (type)
            {
                case ModType.Automation:
                    return new[] { new TheaterModAutoplay() };

                default:
                    return new Mod[] { null };
            }
        }

        public override IEnumerable<KeyBinding> GetDefaultKeyBindings(int variant = 0) => new[]
        {
            new KeyBinding(InputKey.Joystick5, TheaterAction.LeftTapButton),
            new KeyBinding(InputKey.Joystick6, TheaterAction.RightTapButton),
            new KeyBinding(InputKey.JoystickAxis1Negative, TheaterAction.LeftAnalogLeftDirection),
            new KeyBinding(InputKey.JoystickAxis1Positive, TheaterAction.LeftAnalogRightDirection),
            new KeyBinding(InputKey.JoystickAxis2Negative, TheaterAction.LeftAnalogUpDirection),
            new KeyBinding(InputKey.JoystickAxis2Positive, TheaterAction.LeftAnalogDownDirection),
            new KeyBinding(InputKey.JoystickAxis4Negative, TheaterAction.RightAnalogLeftDirection),
            new KeyBinding(InputKey.JoystickAxis4Positive, TheaterAction.RightAnalogRightDirection),
            new KeyBinding(InputKey.JoystickAxis5Negative, TheaterAction.RightAnalogUpDirection),
            new KeyBinding(InputKey.JoystickAxis5Positive, TheaterAction.RightAnalogDownDirection),
        };

        public override Drawable CreateIcon() => new SpriteText
        {
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            Text = ShortName[0].ToString(),
            Font = OsuFont.Default.With(size: 18),
        };
    }
}
