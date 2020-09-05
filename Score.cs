using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    Height height;
    PlatsCount plats;
    float timeLapsed;
    Timer GetTimer;
    Player player;
    
    GameObject scoreDisplay, sessionResults, hightext, yourScore;

    int score;
    public int highScore;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("HighScore");
        player = FindObjectOfType<Player>();
        height = FindObjectOfType<Height>();
        plats = FindObjectOfType<PlatsCount>();
        GetTimer = FindObjectOfType<Timer>();
        highScore = PlayerPrefs.GetInt("HighScore", 0);                
    }
    private void Update()
    {
        scoreDisplay = GameObject.Find("Canvas/ScorePanel/Score");
        sessionResults = GameObject.Find("Canvas/ScorePanel/CurrentScore/SessionResult");
        hightext = GameObject.Find("Canvas/ScorePanel/HighScores/high");
        yourScore = GameObject.Find("Canvas/ScorePanel/Your Score");

        timeLapsed = GetTimer.myTime;
        if (plats.platCount == 0 || timeLapsed == 0)
        {
            score = 0;
        }
        else
        {
            score = (int)(height.height * plats.platCount / timeLapsed);
        }
        if (player.playerHasFallen)
        {
            if(score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("HighScore", highScore);
                yourScore.GetComponent<TextMeshProUGUI>().text = "Congratulations! You made New High Score";
            }
            
        }
        
        scoreDisplay.GetComponent<TextMeshProUGUI>().text = "" + score;
        sessionResults.GetComponent<TextMeshProUGUI>().text = "Height: "+height.height
            +"ft\nTime taken: "+timeLapsed+"sec";
        hightext.GetComponent<TextMeshProUGUI>().text = "" + highScore;



        if (PlayerPrefs.GetInt("HighScore", 0) >= 1000)
        {
            Social.ReportProgress(GPGSIds.achievement_daring_kitty, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 5000)
        {
            Social.ReportProgress(GPGSIds.achievement_competitor_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 10000)
        {
            Social.ReportProgress(GPGSIds.achievement_sub_lieutenant_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 20000)
        {
            Social.ReportProgress(GPGSIds.achievement_lieutenant_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 30000)
        {
            Social.ReportProgress(GPGSIds.achievement_lieutenant_commander_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 40000)
        {
            Social.ReportProgress(GPGSIds.achievement_commander_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 50000)
        {
            Social.ReportProgress(GPGSIds.achievement_captain_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 60000)
        {
            Social.ReportProgress(GPGSIds.achievement_commodore_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 70000)
        {
            Social.ReportProgress(GPGSIds.achievement_rear_admiral_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 80000)
        {
            Social.ReportProgress(GPGSIds.achievement_vice_admiral_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 100000)
        {
            Social.ReportProgress(GPGSIds.achievement_admiral_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 150000)
        {
            Social.ReportProgress(GPGSIds.achievement_admiral_of_the_fleet_shield, 100f, null);
        }
        if (PlayerPrefs.GetInt("HighScore", 0) >= 200000)
        {
            Social.ReportProgress(GPGSIds.achievement_invincible_player_award, 100f, null);
        }
    }
}
