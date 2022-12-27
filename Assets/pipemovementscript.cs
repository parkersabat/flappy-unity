using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovementscript : MonoBehaviour
{
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
    }
}
