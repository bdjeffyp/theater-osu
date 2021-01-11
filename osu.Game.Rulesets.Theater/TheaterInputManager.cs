// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;
using osu.Framework.Input.Bindings;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Theater
{
    public class TheaterInputManager : RulesetInputManager<TheaterAction>
    {
        public TheaterInputManager(RulesetInfo ruleset)
            : base(ruleset, 0, SimultaneousBindingMode.Unique)
        {
        }
    }

    public enum TheaterAction
    {
        [Description("Left Tap Button")]
        LeftTapButton,

        [Description("Right Tap Button")]
        RightTapButton,

        [Description("Left Direction Stick")]
        LeftStick,

        [Description("Right Direction Stick")]
        RightStick,
    }
}
