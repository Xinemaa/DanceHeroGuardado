using UnityEngine;

public class Lane : MonoBehaviour
{
   [SerializeField]
    private Transform notesPivot;
    [SerializeField]
    private GameObject notePrefab;
    public Transform NotesPivot => notesPivot;
    public GameObject NotePrefab => notePrefab;
}
