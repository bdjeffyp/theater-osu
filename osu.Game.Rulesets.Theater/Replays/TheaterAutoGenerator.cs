// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Replays;
using osu.Game.Rulesets.Theater.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.Theater.Replays
{
    public class TheaterAutoGenerator : AutoGenerator
    {
        protected Replay Replay;
        protected List<ReplayFrame> Frames => Replay.Frames;

        public new Beatmap<TheaterHitObject> Beatmap => (Beatmap<TheaterHitObject>)base.Beatmap;

        public TheaterAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
            Replay = new Replay();
        }

        public override Replay Generate()
        {
            Frames.Add(new TheaterReplayFrame());

            foreach (TheaterHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new TheaterReplayFrame
                {
                    Time = hitObject.StartTime
                    // todo: add required inputs and extra frames.
                });
            }

            return Replay;
        }
    }
}
