using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float speed = 5f;

    float hm, vm;

    private void Update()
    {
        vm = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        hm = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(-vm, 0, hm);
    }
}
