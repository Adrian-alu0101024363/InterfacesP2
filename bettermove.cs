using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bettermove : MonoBehaviour
{
  public float speed = 0.01f;
  private Transform playertransform;
    // Start is called before the first frame update
    void Start()
    {
      playertransform = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal2") * speed;
        float vertical = Input.GetAxis("Vertical2") * speed;
        playertransform.Translate(new Vector3(horizontal, 0f, vertical));
    }
}
