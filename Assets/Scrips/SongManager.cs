using UnityEngine;
using UnityEngine.Events;

public class SongManager : MonoBehaviour
{
   [SerializeField]
    private Animator characterAnimator;
    [SerializeField]
    private UnityEvent onSongStart;
    [SerializeField]
    private UnityEvent onSongEnd;
    public void PlaySong(SoundData songData)
    {
        characterAnimator.Play(songData.animationName);
        SoundManager.instance.PlayMusic(songData.SongName);
        onSongStart?.Invoke();
    }
    public void StopSong()
    {
        SoundManager.instance.StopMusic();
        onSongEnd?.Invoke();
    }
}
