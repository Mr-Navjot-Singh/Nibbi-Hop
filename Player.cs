using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public Animator catAnimator;
    [HideInInspector] public bool moveRight, moveLeft;
    Rigidbody2D rb;
    float movement = 0f;
    public float movementSpeed;
    public float force;
    [HideInInspector] public float ypos = 0f;
    [SerializeField] GameObject scoreCard;
    [SerializeField] GameObject cameraSound;
    [SerializeField] GameObject afterFallSound;
    public bool playerHasFallen;
    HealthBar healthBar;
    [SerializeField] GameObject movements;
    InterstitialAdScene interstitialAd;
    void Start()
    {
        interstitialAd = FindObjectOfType<InterstitialAdScene>();
        catAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        healthBar = FindObjectOfType<HealthBar>();
    }

    // Update is called once per frame
    void Update()
    {        
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        if (ypos < gameObject.transform.position.y)
        {
            ypos = gameObject.transform.position.y;           
        }
        if (healthBar.isCatDied)
        {
            cameraSound.GetComponent<AudioSource>().Stop();
            Debug.Log("----CAT DEAD!----");
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            catAnimator.SetBool("Death", true);
            catAnimator.SetBool("Walk", false);
            movements.SetActive(false);
        }
    }
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
        if (moveRight)
        {
            //rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
            rb.AddForce(new Vector2(force*Time.deltaTime,0 ));
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0); // For animation
            Debug.Log("RIGHT");
        }
        if (moveLeft)
        {
            //rb.velocity = new Vector2(-movementSpeed, rb.velocity.y);
            rb.AddForce(new Vector2(-force*Time.deltaTime, 0));
            gameObject.transform.localScale = new Vector3(-0.5f, 0.5f, 0);
            Debug.Log("lEFT");
            
        }
        if (gameObject.transform.position.y + 10 < ypos)
        {
            playerHasFallen = true;
            Invoke("loadScoreCard", 3f); //Loading ScoreCard panel
            cameraSound.GetComponent<AudioSource>().Stop();
            afterFallSound.SetActive(true);            
        }        
    }
    void loadScoreCard()
    {
        scoreCard.SetActive(true);
        interstitialAd.ShowInterstitial();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Fish" && collision.relativeVelocity.y >= 0f)
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
