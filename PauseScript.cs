using UnityEngine;

public class PauseScript : MonoBehaviour
{
    bool isPaused = false;
    [SerializeField] GameObject pausePanel;
   // [SerializeField] GameObject AdverstisementObject;
    public void PauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            Camera.main.GetComponent<AudioSource>().Play();
            Debug.Log("Pause button clicked.....");
            pausePanel.SetActive(false);
            //AdverstisementObject.SetActive(false);
            //Invoke("setAdObjectActive", 1f);
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            Camera.main.GetComponent<AudioSource>().Stop();
            Debug.Log("Pause button released....");
            pausePanel.SetActive(true);
            
        }
    }
    //void setAdObjectActive()
    //{
    //    AdverstisementObject.SetActive(true);
    //}
}
