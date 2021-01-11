// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.Theater.Objects;
using osu.Game.Rulesets.Theater.Objects.Drawables;
using osu.Game.Rulesets.Theater.Replays;
using osu.Game.Rulesets.UI;
using osu.Game.Rulesets.UI.Scrolling;

namespace osu.Game.Rulesets.Theater.UI
{
    [Cached]
    public class DrawableTheaterRuleset : DrawableScrollingRuleset<TheaterHitObject>
    {
        public DrawableTheaterRuleset(TheaterRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
            Direction.Value = ScrollingDirection.Left;
            TimeRange.Value = 6000;
        }

        protected override Playfield CreatePlayfield() => new TheaterPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new TheaterFramedReplayInputHandler(replay);

        public override DrawableHitObject<TheaterHitObject> CreateDrawableRepresentation(TheaterHitObject h) => new DrawableTheaterHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new TheaterInputManager(Ruleset?.RulesetInfo);
    }
}
