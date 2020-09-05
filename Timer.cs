using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [HideInInspector] public float timer;
    GameObject timeLapsed;
    [HideInInspector] public float myTime;
    Player player;
    [SerializeField] GameObject wood;
    void Start()
    {
        timeLapsed = GameObject.Find("Canvas/RightSidePanel/Time");
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(myTime <= 0)
        {
            HealthBar.health = 20;
        }
        if(myTime > 3)
        {
            Destroy(wood);
        }
        if (player.playerHasFallen)
        {            
            myTime = (float)Mathf.Round(timer * 10f) / 10f;
            timeLapsed.GetComponent<TextMeshProUGUI>().text = "Time: \n" + myTime;            
        }
        else
        {
            timer += Time.deltaTime;
            myTime = (float)Mathf.Round(timer * 10f) / 10f;
            timeLapsed.GetComponent<TextMeshProUGUI>().text = "Time: \n" + myTime;
        }
        
    }
}
