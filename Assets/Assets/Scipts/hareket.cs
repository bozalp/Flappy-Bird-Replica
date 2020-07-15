using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (kusScript.GameOver == false && kusScript.start == true)
        {
            transform.Translate(new Vector3(-5f, 0, 0) * 1f * Time.deltaTime);
        }
    }
}
