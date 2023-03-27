using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    bool hasTouched=false;
    public GameObject smallWood;
    public GameObject Woodpoints;
    public GameObject PigPoints;
    public GameObject Woodblast;
    public GameObject PigBlast;
    public GameObject birdFeathers;

    private AudioClip pigDead;
    public AudioSource pigdeadSource;

    private AudioClip woodBlast;
    public AudioSource woodBlastSource;

    //public float timeLimitForBird = 30f;  
    //private float Birdtimer;

    //public float timeLimitForFeathers = 29f;
    //private float FeatherTimer;

    //private void Update()
    //{
    //    Birdtimer += Time.deltaTime;
    //    FeatherTimer += Time.deltaTime;

    //    if (FeatherTimer >= timeLimitForBird)
    //    {
    //        for (int i = 0; i < 7; i++)
    //        {
    //            GameObject newfeathers = Instantiate(birdFeathers, transform.position, Quaternion.identity);

    //            newfeathers.transform.position = transform.position;
    //            newfeathers.transform.rotation = new Quaternion(Random.Range(0, 3), Random.Range(0, 3), 0, 0);
    //        }

    //    }
    //    if (Birdtimer >= timeLimitForBird)
    //    {
            
    //        Destroy(gameObject);
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!hasTouched && collision.gameObject!=null)
        {
            if(collision.gameObject.CompareTag("Wood"))
            {
                woodBlastSource.Play();
                GameObject woodBlast = Instantiate(Woodblast, collision.gameObject.transform.position, Quaternion.identity);
                woodBlast.transform.position = collision.gameObject.transform.position;
                for (int i = 0; i < 10; i++)
                {
                    GameObject woods= Instantiate(smallWood, collision.gameObject.transform.position, Quaternion.identity);
                    woods.transform.position = collision.gameObject.transform.position;
                    woods.transform.rotation = new Quaternion(Random.Range(0, 3), Random.Range(0, 3), 0, 0);

                }
                GameObject woodPoints = Instantiate(Woodpoints, collision.gameObject.transform.position, Quaternion.identity);
                woodPoints.transform.position = collision.gameObject.transform.position;
                GameObject.Destroy(collision.gameObject);
                hasTouched = true;

            }
        }

        if(collision.gameObject.CompareTag("Pig"))
        {
            pigdeadSource.Play();
            GameObject pigBlasted = Instantiate(PigBlast, collision.gameObject.transform.position, Quaternion.identity);
            pigBlasted.transform.position = collision.gameObject.transform.position;

            GameObject pigPoints = Instantiate(PigPoints, collision.gameObject.transform.position, Quaternion.identity);
            pigPoints.transform.position = collision.gameObject.transform.position;
            GameObject.Destroy(collision.gameObject);
        }

       
    }
}
