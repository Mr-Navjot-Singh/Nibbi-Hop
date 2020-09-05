using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    Height height;
    PlatsCount plats;
    float timeLapsed;
    Timer GetTimer;

    GameObject scoreDisplay;
    float score;
    // Start is called before the first frame update
    void Start()
    {
        height = FindObjectOfType<Height>();
        plats = FindObjectOfType<PlatsCount>();
        GetTimer = FindObjectOfType<Timer>();


    }
    private void Update()
    {
        timeLapsed = GetTimer.myTime;
        if (plats.platCount == 0 || timeLapsed == 0)
        {
            score = 0;
        }
        else
        {
            score = (int)(height.height * plats.platCount / timeLapsed);
        }
        
        scoreDisplay = GameObject.Find("Canvas/ScoreText");
        scoreDisplay.GetComponent<TextMeshProUGUI>().text = "" + score;
    }
}
