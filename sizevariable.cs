using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizevariable : MonoBehaviour
{
    public GameObject Player;
    public GameObject Playertwo;
    private Transform playertransform;
    private void OnTriggerEnter(Collider other) {
      if (other.gameObject.tag == "Player") {
        playertransform.localScale += new Vector3(0.2f, 0.2f , 0.2f);
      } else if (other.gameObject.tag == "Player2" && playertransform.localScale.x >= 0f) {
        playertransform.localScale -= new Vector3(0.2f, 0.2f , 0.2f);
      }
    }
    // Start is called before the first frame update
    void Start()
    {
      playertransform = GetComponent<Transform>();  
    }

    // Update is called once per frame
    void Update()
    {
    }
}
