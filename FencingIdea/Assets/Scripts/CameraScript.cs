using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    public Transform cameraPos;

    // Update is called once per frame
    public void FixedUpdate()
    {
        cameraPos.transform.position = new Vector3 (player.transform.position.x, cameraPos.transform.position.y, player.transform.position.z);
    }
}
