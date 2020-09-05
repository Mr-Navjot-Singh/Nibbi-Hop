using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine;

public class GPGSAchievements : MonoBehaviour
{
   
    public void OpenAchievementsPanel()
    {
        //PlayGamesPlatform.Instance.ShowAchievementsUI();
        Social.ShowAchievementsUI();
        Debug.Log("Achievement Panel--------");
    }
    public void Start()
    {
        
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
