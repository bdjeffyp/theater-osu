// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.Theater.Replays
{
    public class TheaterReplayFrame : ReplayFrame
    {
        public List<TheaterAction> Actions = new List<TheaterAction>();

        public TheaterReplayFrame(TheaterAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
