using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class planecode : MonoBehaviour
{
    public AudioSource fall;
    public Rigidbody redapple;
    public Rigidbody greenapple;
    public Rigidbody pineapple;
    public Rigidbody eggplant;
    public Rigidbody pomegranate;
    public Rigidbody tomato;
    public Rigidbody orange;
    public GameObject redapplee;
    public GameObject greenapplee;
    public GameObject pineapplee;
    public GameObject eggplantt;
    public GameObject pomegranatee;
    public GameObject tomatoo;
    public GameObject orangee;

    int totalgame;
    public TMPro.TextMeshProUGUI totalgamee;

    public void Start()
    {
        totalgame = PlayerPrefs.GetInt("zzz");
        totalgamee.text = totalgame.ToString();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "redapple")
        {
            redapplee.SetActive(false);
            Invoke("callredapple",2f);
            fall.Play();
        }
        if (collision.collider.tag == "greenapple")
        {
            greenapplee.SetActive(false);
            Invoke("callgreenapple", 2.5f);
            fall.Play();
        }
        if (collision.collider.tag == "pineapple")
        {
            pineapplee.SetActive(false);
            Invoke("callpineapple", 3f);
            fall.Play();
        }
        if (collision.collider.tag == "eggplant")
        {
            eggplantt.SetActive(false);
            Invoke("calleggplant", 3.5f);
            fall.Play();
        }
        if (collision.collider.tag == "pomegranate")
        {
            pomegranatee.SetActive(false);
            Invoke("callpomegranate", 4f);
            fall.Play();
        }
        if (collision.collider.tag == "tomato")
        {
            tomatoo.SetActive(false);
            Invoke("calltomato", 4.5f);
            fall.Play();
        }
        if (collision.collider.tag == "orange")
        {
            orangee.SetActive(false);
            Invoke("callorange", 5f);
            fall.Play();
        }
        if(collision.collider.tag == "circlefortotalgame")
        {
            totalgame++;
            PlayerPrefs.SetInt("zzz", totalgame);
        }
    }

    public void callredapple()
    {
        redapplee.SetActive(true);
        float rastgele = Random.Range(-7.5f, 8.5f);
        redapple.transform.position = new Vector3(rastgele, 11, -3.3f);
    }
    public void callgreenapple()
    {
        greenapplee.SetActive(true);
        float rastgele = Random.Range(-7.5f, 8.5f);
        greenapple.transform.position = new Vector3(rastgele, 11, -3.3f);
    }
    public void callpineapple()
    {
        pineapplee.SetActive(true);
        float rastgele = Random.Range(-7.5f, 8.5f);
        pineapple.transform.position = new Vector3(rastgele, 11, -3.3f);
    }
    public void calleggplant()
    {
        eggplantt.SetActive(true);
        float rastgele = Random.Range(-7.5f, 8.5f);
        eggplant.transform.position = new Vector3(rastgele, 11, -3.3f);
    }
    public void callpomegranate()
    {
        pomegranatee.SetActive(true);
        float rastgele = Random.Range(-7.5f, 8.5f);
        pomegranate.transform.position = new Vector3(rastgele, 11, -3.3f);
    }
    public void calltomato()
    {
        tomatoo.SetActive(true);
        float rastgele = Random.Range(-7.5f, 8.5f);
        tomato.transform.position = new Vector3(rastgele, 11, -3.3f);
    }
    public void callorange()
    {
        orangee.SetActive(true);
        float rastgele = Random.Range(-7.5f, 8.5f);
        orange.transform.position = new Vector3(rastgele, 11, -3.3f);
    }
}