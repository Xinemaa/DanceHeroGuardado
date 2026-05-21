using UnityEngine;

public class LaneManager : MonoBehaviour
{
   [SerializeField]
    private Lane[] lanes;
    public Lane GetLane(int index)
    {
        if (index < 0 || index >= lanes.Length)
        {
            Debug.LogWarning("Lane index out of range:" + index);
            return lanes [0];
        }
        return lanes [index];
    }
    public int GetLanesCount()
    {
        return lanes.Length;
    }
}
