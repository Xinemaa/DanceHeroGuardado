using UnityEngine;

[CreateAssetMenu(fileName = "SoundData", menuName = "Scriptable Objects/SoundData")]
public class SoundData : ScriptableObject
{
   public string animationName;
   public string songName;
   public TextAsset noteChart;
   public float speed;
}
