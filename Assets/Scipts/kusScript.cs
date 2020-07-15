using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kusScript : MonoBehaviour
{
    private Rigidbody2D fizik_karakter;
    private float ziplama_gucu, egim;
    public Text puanText, puanText2, BestTxt;
    private int puan, bestpuan;
    public static bool GameOver, start;
    public GameObject message, gameoverPanel;
    public AudioSource kanatSesi, puanSesi, CarpmaSesi;
    // Start is called before the first frame update
    void Start()
    {
        gameoverPanel.SetActive(false);
        bestpuan = 0;
        bestpuan = PlayerPrefs.GetInt("skor");
        message.SetActive(true);
        start = false;
        GameOver = false;
        ziplama_gucu = 200f;
        fizik_karakter = GetComponent<Rigidbody2D>();
        fizik_karakter.Sleep();
        puan = 0;
        puanText.text = puan.ToString();
        BestTxt.text = bestpuan.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, -egim);
        //egim += .5f;
        if (Input.GetKeyDown(KeyCode.Mouse0) && start == false)
        {
            start = true;
            message.SetActive(false);
            fizik_karakter.WakeUp();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && GameOver == false)
        {
            fizik_karakter.velocity = Vector2.zero;
            fizik_karakter.AddForce(new Vector2(0, ziplama_gucu));
            kanatSesi.Play();
        }
        
           
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "puan")
        {
            puanSesi.Play();
            puan += 1;
            puanText.text = puan.ToString();
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "engel" || coll.gameObject.tag == "zemin")
        {
            CarpmaSesi.Play();
            GameOver = true;
            puanText.enabled = false;
            gameoverPanel.SetActive(true);
            if (puan > bestpuan)
            {
                bestpuan = puan;
                PlayerPrefs.SetInt("skor", bestpuan);
                BestTxt.text = bestpuan.ToString();
            }
            else
                puanText2.text = puan.ToString();
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
