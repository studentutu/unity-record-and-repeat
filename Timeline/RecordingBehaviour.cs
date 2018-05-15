using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace RecordForTimeline.Timeline
{
    [Serializable]
    public class RecordingBehaviour : PlayableBehaviour
    {
        public Recording.Recording recording;

        public override void OnPlayableCreate(Playable playable)
        {

        }
    }
}
