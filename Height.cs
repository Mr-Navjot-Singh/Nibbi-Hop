using TMPro;
using UnityEngine;

public class Height : MonoBehaviour
{
    public float height;
    GameObject playerHeight;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        playerHeight = GameObject.Find("Canvas/LeftSidePanel/Height");
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        height = (float)decimal.Truncate((decimal)player.ypos);
        playerHeight.GetComponent<TextMeshProUGUI>().text = "Height: " + height;
    }
}
