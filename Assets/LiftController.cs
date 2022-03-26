using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiftController : MonoBehaviour
{
    float speed = 5f;
    public Transform pos1;
    public Transform pos2;
    bool trigger = false;
    public GameObject lift;

    bool targetPos = false;
    int count = 0;

    public Text score;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Invoke("Trigger", 2f);
            GameObject player = collision.collider.gameObject;
            player.transform.parent = transform;
            Debug.Log(trigger);
            targetPos = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            
            GameObject player = collision.collider.gameObject;
            player.transform.parent = null;
           
        }
    }

    void Trigger()
    {
        trigger = !trigger;
        count++;

        score.text = count.ToString();
    }

    private void Update()
    {
        if (targetPos)
        {
            if (trigger)
            {
                transform.DOMoveY(10f,5f);
                
            }
            else
            {
                transform.DOMoveY(0, 5f);
            }
        }
    }
}
