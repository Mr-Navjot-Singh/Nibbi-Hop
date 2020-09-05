using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine;

public class AuthenticationGPGS : MonoBehaviour
{
    public static PlayGamesPlatform platform;
    // Start is called before the first frame update
    void Start()
    {
        if(platform == null)
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;

            platform = PlayGamesPlatform.Activate();
        }
        Social.Active.localUser.Authenticate(success =>{
            if (success)
            {
                Debug.Log("Logged in successfully!");
            }
            else
            {
                Debug.Log("Failed to login!");
            }
        });
    }

    public void OnAuthenticate()
    {
        if (platform == null)
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;

            platform = PlayGamesPlatform.Activate();
        }
        Social.Active.localUser.Authenticate(success => {
            if (success)
            {
                Debug.Log("Logged in successfully!");
            }
            else
            {
                Debug.Log("Failed to login!");
            }
        });
    }
}
