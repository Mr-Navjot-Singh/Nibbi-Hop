using UnityEngine;

public class PenaltyDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            HealthBar.health--;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
