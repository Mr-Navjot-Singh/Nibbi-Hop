using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GPGSLeaderBoards : MonoBehaviour
{
    public void OpenLeaderBoard()
    {
        //PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGSIds.leaderboard_global_rankings);
        Social.ShowLeaderboardUI();
        Debug.Log("LeaderBoard Panel--------");
    }
    public void Start()
    {
        if(PlayerPrefs.GetInt("HighScore", 0) == 0)
        {
            return;
        }
        Social.ReportScore(PlayerPrefs.GetInt("HighScore", 0), GPGSIds.leaderboard_global_rankings, (bool success)=>
        {
            if (success)
            {
                
            }
        });
    }
}
