using UnityEngine;
using UnityEngine.Events;

public class NotesLimit : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onNotesLimitReached;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            onNotesLimitReached?.Invoke();
            Destroy(collision.gameObject);
        }
    } // Start is called once before the first execution of Update after the MonoBehaviour is created
}
