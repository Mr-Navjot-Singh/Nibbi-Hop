using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] platform = new GameObject[16];
    [SerializeField] private GameObject[] envi = new GameObject[6];
    [SerializeField] private GameObject[] clouds = new GameObject[5];

    private GameObject myPlat;
    private GameObject myCloud;
    private GameObject myEnvironment;
    [SerializeField] float cloudPos;
    [SerializeField] float cloudOffset;
    [SerializeField] float envPos;
    [SerializeField] float envOffset;
    float platPos = 2.0f;
    [SerializeField] float platOffset;

    [SerializeField] GameObject mrCat;

    public float levelWidth;
    [HideInInspector] public uint platDestroyCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Meat" || collision.tag == "Fish" || collision.tag == "Eggs" ||
            collision.tag == "Omlette" || collision.tag == "Anchovies" || collision.tag == "Platform"
            || collision.tag == "Penalty")
        {
            int randCategory = Random.Range(1, 4);

            if (randCategory == 1)// Simple Platforms
            {
                int platCategory = Random.Range(1, 3);
                for (int i = 1; i <= 2; i++)
                {
                    if (platCategory == i)
                    {
                        myPlat = (GameObject)Instantiate(platform[i - 1], new Vector2(Random.Range(-levelWidth, levelWidth),
                        platPos), Quaternion.identity);
                        platPos = myPlat.transform.position.y + platOffset;
                    }
                }
            }
            else if (randCategory == 2) // Food Platforms
            {
                int itemPlat = Random.Range(1, 7);
                for (int i = 1; i <= 6; i++)
                {
                    if (itemPlat == i)
                    {
                        myPlat = (GameObject)Instantiate(platform[i + 1], new Vector2(Random.Range(-levelWidth, levelWidth),
                        platPos), Quaternion.identity);
                        platPos = myPlat.transform.position.y + platOffset;
                    }
                }


            }
            else if (randCategory == 3) // Penalties platform
            {
                int itemPlat = Random.Range(1, 5);
                for (int i = 1; i <= 4; i++)
                {
                    if (itemPlat == i)
                    {
                        myPlat = (GameObject)Instantiate(platform[i + 7], new Vector2(Random.Range(-levelWidth, levelWidth),
                        platPos), Quaternion.identity);
                        platPos = myPlat.transform.position.y + platOffset;
                    }
                }


            }

            Destroy(collision.gameObject);
            platDestroyCount++;
        }

        // Environment and clouds
        if (collision.tag == "Environment")
        {
            int platCategory = Random.Range(1, 7);
            for (int i = 1; i <= 6; i++)
            {
                if (platCategory == i)
                {
                    int randomPosition = Random.Range(1, 4);
                    float position;
                    if (randomPosition == 1)
                    {
                        position = -levelWidth;
                    }
                    else if (randomPosition == 2)
                    {
                        position = 0;
                    }
                    else
                    {
                        position = levelWidth;
                    }

                    myEnvironment = (GameObject)Instantiate(envi[i - 1], new Vector2(position, envPos),
                        Quaternion.identity);
                    envPos = myEnvironment.transform.position.y + envOffset;
                }
            }
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Clouds")
        {
            int platCategory = Random.Range(1, 6);
            for (int i = 1; i <= 5; i++)
            {
                if (platCategory == i)
                {
                    myCloud = (GameObject)Instantiate(clouds[i - 1], new Vector2(Random.Range(-levelWidth, levelWidth),
                    cloudPos), Quaternion.identity);
                    cloudPos = myCloud.transform.position.y + cloudOffset;
                }
            }
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Environment")
        {
            Destroy(collision.gameObject);
            int platCategory = Random.Range(1, 7);
            for (int i = 1; i <= 6; i++)
            {
                if (platCategory == i)
                {
                    int randomPosition = Random.Range(1, 4);
                    float position;
                    if (randomPosition == 1)
                    {
                        position = -levelWidth;
                    }
                    else if (randomPosition == 2)
                    {
                        position = 0;
                    }
                    else
                    {
                        position = levelWidth;
                    }

                    myEnvironment = (GameObject)Instantiate(envi[i - 1], new Vector2(position, envPos),
                        Quaternion.identity);
                    envPos = myEnvironment.transform.position.y + envOffset;
                }
            }

        }
        if (collision.tag == "Clouds")
        {
            Destroy(collision.gameObject);
            int platCategory = Random.Range(1, 6);
            for (int i = 1; i <= 5; i++)
            {
                if (platCategory == i)
                {
                    myCloud = (GameObject)Instantiate(clouds[i - 1], new Vector2(Random.Range(-levelWidth, levelWidth),
                    cloudPos), Quaternion.identity);
                    cloudPos = myCloud.transform.position.y + cloudOffset;
                }
            }

        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Environment")
        {
            Destroy(collision.gameObject);
            int platCategory = Random.Range(1, 7);
            for (int i = 1; i <= 6; i++)
            {
                if (platCategory == i)
                {
                    int randomPosition = Random.Range(1, 4);
                    float position;
                    if (randomPosition == 1)
                    {
                        position = -levelWidth;
                    }
                    else if (randomPosition == 2)
                    {
                        position = 0;
                    }
                    else
                    {
                        position = levelWidth;
                    }

                    myEnvironment = (GameObject)Instantiate(envi[i - 1], new Vector2(position, envPos),
                        Quaternion.identity);
                    envPos = myEnvironment.transform.position.y + envOffset;
                }
            }

        }
        if (collision.tag == "Clouds")
        {

            Destroy(collision.gameObject);
            int platCategory = Random.Range(1, 6);
            for (int i = 1; i <= 5; i++)
            {
                if (platCategory == i)
                {
                    myCloud = (GameObject)Instantiate(clouds[i - 1], new Vector2(Random.Range(-levelWidth, levelWidth),
                    cloudPos), Quaternion.identity);
                    cloudPos = myCloud.transform.position.y + cloudOffset;
                }
            }

        }
    }

}
