using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class maincode : MonoBehaviour
{
    public GameObject orangescene;
    public AudioSource ham;
    public float time = 60;
    public int fruits_orangescene = 0;
    public int pickedredapples = 0;
    public int pickedgreenapples = 0;
    public int pickedpineapples = 0;
    public int pickedeggplants = 0;
    public int pickedpomegranates = 0;
    public int pickedtomatoes = 0;
    public int pickedoranges = 0;
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
    public TextMeshProUGUI fruitscore;
    public TextMeshProUGUI redapplescore;
    public TextMeshProUGUI greenapplescore;
    public TextMeshProUGUI pineapplescore;
    public TextMeshProUGUI eggplantscore;
    public TextMeshProUGUI pomegranatescore;
    public TextMeshProUGUI tomatoscore;
    public TextMeshProUGUI orangescore;
    public TextMeshProUGUI timescore;
    public Image clock;
    private float bullshit = 0;


    void Start()
    {
        time = 60;
        fruits_orangescene = 0;
        pickedredapples = 0;
        pickedgreenapples = 0;
        pickedpineapples = 0;
        pickedeggplants = 0;
        pickedpomegranates = 0;
        pickedtomatoes = 0;
        pickedoranges = 0;
    }

    public void FixedUpdate()
    {
        if(time==0)
        {
            Time.timeScale = 0f;
            orangescene.SetActive(true);
        }

        else
        { 
            bullshit++;
            if (bullshit % 50 == 0)
            {
                time--;
                timescore.text = time.ToString();
                clock.fillAmount = time / 60;
            }

            redapple.transform.Rotate(0, 3, 0);
            greenapple.transform.Rotate(0, 3, 0);
            pineapple.transform.Rotate(0, 3, 0);
            eggplant.transform.Rotate(0, 3, 0);
            pomegranate.transform.Rotate(0, 3, 0);
            tomato.transform.Rotate(0, 3, 0);
            orange.transform.Rotate(0, 3, 0);


            if (Input.GetKey(KeyCode.RightArrow)  ||  Input.GetKey(KeyCode.D))
            {
                GetComponent<Rigidbody>().AddForce(200000, 0, 0);
                GetComponent<Rigidbody>().transform.rotation = Quaternion.Euler(0, 110, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow)  ||  Input.GetKey(KeyCode.A))
            {
                GetComponent<Rigidbody>().AddForce(-200000, 0, 0);
                GetComponent<Rigidbody>().transform.rotation = Quaternion.Euler(0, -110, 0);
            }
            if (Input.GetKey(KeyCode.Space)  ||  Input.GetKey(KeyCode.W)  ||  Input.GetKey(KeyCode.UpArrow))
            {
                if (GetComponent<Rigidbody>().position.y < 2.4f)
                {
                    GetComponent<Rigidbody>().AddForce(0, 3000000, 0);
                }
                else
                {
                    GetComponent<Rigidbody>().AddForce(0, 0, 0);
                }
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "redapple")
        {
            redapplee.SetActive(false);
            Invoke("callredapple", 2f);
            pickedredapples++;
            fruits_orangescene++;
            redapplescore.text = pickedredapples.ToString();
            fruitscore.text = fruits_orangescene.ToString();
            ham.Play();
        }
        if (collision.collider.tag == "greenapple")
        {
            greenapplee.SetActive(false);
            Invoke("callgreenapple", 2.5f);
            pickedgreenapples++;
            fruits_orangescene++;
            greenapplescore.text = pickedgreenapples.ToString();
            fruitscore.text = fruits_orangescene.ToString();
            ham.Play();
        }
        if (collision.collider.tag == "pineapple")
        {
            pineapplee.SetActive(false);
            Invoke("callpineapple", 3f);
            pickedpineapples++;
            fruits_orangescene++;
            pineapplescore.text = pickedpineapples.ToString();
            fruitscore.text = fruits_orangescene.ToString();
            ham.Play();
        }
        if (collision.collider.tag == "eggplant")
        {
            eggplantt.SetActive(false);
            Invoke("calleggplant", 3.5f);
            pickedeggplants++;
            fruits_orangescene++;
            eggplantscore.text = pickedeggplants.ToString();
            fruitscore.text = fruits_orangescene.ToString();
            ham.Play();
        }
        if (collision.collider.tag == "pomegranate")
        {
            pomegranatee.SetActive(false);
            Invoke("callpomegranate", 4f);
            pickedpomegranates++;
            fruits_orangescene++;
            pomegranatescore.text = pickedpomegranates.ToString();
            fruitscore.text = fruits_orangescene.ToString();
            ham.Play();
        }
        if (collision.collider.tag == "tomato")
        {
            tomatoo.SetActive(false);
            Invoke("calltomato", 4.5f);
            pickedtomatoes++;
            fruits_orangescene++;
            tomatoscore.text = pickedtomatoes.ToString();
            fruitscore.text = fruits_orangescene.ToString();
            ham.Play();
        }
        if (collision.collider.tag == "orange")
        {
            orangee.SetActive(false);
            Invoke("callorange", 5f);
            pickedoranges++;
            fruits_orangescene++;
            orangescore.text = pickedoranges.ToString();
            fruitscore.text = fruits_orangescene.ToString();
            ham.Play();
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
