using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float jumpForce = 10f;
        
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                gameObject.GetComponent<AudioSource>().Play();
                if (gameObject.tag == "Fish")
                {
                    Vector2 velocity = rb.velocity;
                    velocity.y = 40
                        ;
                    rb.velocity = velocity;
                }
                
                else if (gameObject.tag == "Eggs")
                {
                    Vector2 velocity = rb.velocity;
                    velocity.y = 20;
                    rb.velocity = velocity;
                }
                else if (gameObject.tag == "Omlette")// for milk
                {                    
                    Vector2 velocity = rb.velocity;
                    velocity.y = jumpForce;
                    rb.velocity = velocity;

                    if (HealthBar.health <= 15)
                    {
                        HealthBar.health += 5;
                    }
                    else if(HealthBar.health > 15)
                    {
                        HealthBar.health = 20;
                    }
                    
                }
                
                else if (gameObject.tag == "Platform")
                {
                    Vector2 velocity = rb.velocity;
                    velocity.y = jumpForce;
                    rb.velocity = velocity;
                }
                else if (gameObject.tag == "Penalty")
                {
                    
                    Vector2 velocity = rb.velocity;
                    velocity.y = jumpForce;
                    rb.velocity = velocity;
                    
                }
            }
        }        
        
    }
}
