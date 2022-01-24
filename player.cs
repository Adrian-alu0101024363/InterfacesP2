using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
  public float speed = 0.01f;
  private int score = 0;
  private Transform playertransform;
    // Start is called before the first frame update
    void Start()
    {
        playertransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        float vertical = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Rotation") * speed;
        playertransform.Translate(new Vector3(horizontal, 0f, vertical));
        playertransform.Rotate(new Vector3(0f, rotation, 0f));
    }
    public void newscore() {
      score++;
      Debug.Log(score);
    }
}
