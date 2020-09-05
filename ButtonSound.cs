
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public void PlayButtonSound()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}