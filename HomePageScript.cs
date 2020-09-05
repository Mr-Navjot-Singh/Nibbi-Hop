using UnityEngine;
using TMPro;

public class HomePageScript : MonoBehaviour
{
    Score score;
    [SerializeField]GameObject story;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void onQuit()
    {
        Application.Quit();
    }
    public void onShowInstructions()
    {
        story.SetActive(true);
    }
    public void onHideInstructions()
    {
        story.SetActive(false);
    }
}
