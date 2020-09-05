using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.transform.position + new Vector3(0,-1f,0);
        gameObject.transform.localScale = new Vector3(0.001f, 1f, 1f);
    }
}
