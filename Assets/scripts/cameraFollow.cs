using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject follow;
    public Vector2 minCamPos, maxCamPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (follow == true)
        {
            float posX = follow.transform.position.x;
            float posY = follow.transform.position.y;

            transform.position = new Vector3(
                Mathf.Clamp(posX, minCamPos.x, maxCamPos.x),
                Mathf.Clamp(posY, minCamPos.y, maxCamPos.x),
                transform.position.z);
        }
    }
}
