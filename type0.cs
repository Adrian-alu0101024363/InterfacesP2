using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class type0 : MonoBehaviour
{
  private Transform playertransform;
  public GameObject cylynder;
  public GameObject Player;
    private void OnTriggerEnter(Collider other) {
      if (other.gameObject.tag == "Player") {
        playertransform.localScale += new Vector3(0.2f, 0.2f , 0.2f);
        GameObject players = GameObject.FindGameObjectWithTag("Player");
        players.GetComponent<player>().newscore();
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
