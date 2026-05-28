using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    [SerializeField]
    private Text titleText;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Animator animator;
    private bool isShowing = false;
    public void ShowWinSreen(string score)
    {
        titleText.text = "You Win!";
        ShowScreen(score);
    }
    public void ShowLoseSreen(string score)
    {
        titleText.text = "You Lose!";
        ShowScreen(score);
    }
    public void ShowScreen(string score)
    { 
        scoreText.text = score;
        animator.Play("Show");
        isShowing = true;
    }
    public void HideSreen()
    { 
        if (isShowing)
        {
        animator.Play("Hide");
        isShowing = false;
        }
    }
}
