using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelSpawn : MonoBehaviour
{
    private float zaman;
    public GameObject engeller;
    private Vector2 konum;
    // Start is called before the first frame update
    void Start()
    {
        zaman = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        zaman -= Time.deltaTime;
        if(kusScript.GameOver == false && zaman < 0 && kusScript.start == true)
        {
            konum = new Vector2(5, Random.Range(1.6f, -2.1f));
            Instantiate(engeller, konum, engeller.transform.rotation);
            zaman = 1f;
        }
    }
}
