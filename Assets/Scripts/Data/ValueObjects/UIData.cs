using System;

namespace Data.ValueObjects
{
    [Serializable]
    public struct UIData
    {
        public ScoreData scoreData;

    }

    [Serializable]
    public struct ScoreData
    {
        public int score;
    }
}