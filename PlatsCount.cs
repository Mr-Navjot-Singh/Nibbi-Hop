using TMPro;
using UnityEngine;

public class PlatsCount : MonoBehaviour
{
    GameObject plats;
    LevelGenerator lg;
    public uint platCount;
    // Start is called before the first frame update
    void Start()
    {
        lg = FindObjectOfType<LevelGenerator>();
        plats = GameObject.Find("Canvas/LeftSidePanel/Plats");
    }

    // Update is called once per frame
    void Update()
    {
        platCount = lg.platDestroyCount;
        plats.GetComponent<TextMeshProUGUI>().text = "Ladders: " + platCount;
    }
}
