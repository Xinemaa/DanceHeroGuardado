using UnityEngine;
using UnityEngine.Events;

public class SongManager : MonoBehaviour
{
   [SerializeField]
    private Animator characterAnimator;
    [SerializeField]
    private UnityEvent onSongStart;
     [SerializeField]
    private UnityEvent onSongSelected;
    [SerializeField]
    private UnityEvent onSongEnd;
    [SerializeField]
    private NotesManager notesManager;
    private SoundData currentSoundData;
    public void SelectedSong(SoundData songData)
    {
        currentSoundData = songData;
        onSongSelected?.Invoke();
    }
    public void StopSong()
    {
        SoundManager.instance.StopMusic();
        onSongEnd?.Invoke();
    }
     public void StartSong()
    {
        characterAnimator.Play(currentSoundData.animationName);
        SoundManager.instance.PlayMusic(currentSoundData.songName);
        notesManager.StartNoteChart(currentSoundData.noteChart, currentSoundData.speed);
        onSongStart?.Invoke();
    }
}
