using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace RecordForTimeline.Timeline
{
    [Serializable]
    public class RecordingClip : PlayableAsset, ITimelineClipAsset
    {
        public RecordingBehaviour template = new RecordingBehaviour();

        public ClipCaps clipCaps
        {
            get { return ClipCaps.None; }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<RecordingBehaviour>.Create(graph, template);
            return playable;
        }
    }
}
