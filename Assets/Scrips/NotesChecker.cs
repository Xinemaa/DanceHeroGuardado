using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;

public class NotesChecker : MonoBehaviour
{
 [SerializeField]
    private string animationName = "Check";
    [SerializeField]
    private UnityEvent onNoteChecked;
    [SerializeField]
    private UnityEvent onNoteMissed;
    private Animator animator;
    private List<GameObject> activeNotes = new List<GameObject>();
    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            activeNotes.Add(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
       if (collision.CompareTag("Note"))
        {
            if (activeNotes.Contains(collision.gameObject))
            {
               activeNotes.Remove(collision.gameObject);
            }
        }  
    }
    public void Check()
    {
        animator.Play(animationName, 0, 0f);
        if (activeNotes.Count > 0)
        {
            onNoteChecked.Invoke();
            GameObject currentNote = activeNotes[0];
            if(currentNote != null)
            {
                activeNotes.RemoveAt(0);
                Destroy(currentNote);
            }

        }
        else
        {
            onNoteMissed.Invoke();
        }
    
    }

}
