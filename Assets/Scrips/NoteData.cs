using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class NoteData
{
    public float spawnTime;
    public int laneIndex;
}

[System.Serializable]
public class NoteChart
{
    public List<NoteData> notes;
}
