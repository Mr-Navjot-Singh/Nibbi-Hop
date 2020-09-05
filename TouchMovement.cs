using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    Player player;
    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    public void PressLeft()
    {
        player.moveRight = false;
        player.moveLeft = true;
        player.catAnimator.SetBool("Walk", true);
        player.catAnimator.SetBool("Stop", false);
    }
    public void ReleaseLeft()
    {
        player.moveLeft = false;
        player.catAnimator.SetBool("Stop", true);
        player.catAnimator.SetBool("Walk", false);
    }
    public void PressRight()
    {
        player.moveLeft = false;
        player.moveRight = true;
        player.catAnimator.SetBool("Walk", true);
        player.catAnimator.SetBool("Stop", false);
    } 
    public void ReleaseRight()
    {
        player.moveRight = false;
        player.catAnimator.SetBool("Stop", true);
        player.catAnimator.SetBool("Walk", false);
    }
}
