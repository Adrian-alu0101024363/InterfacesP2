using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typeB : MonoBehaviour
{
  private Transform playertransform;
  public GameObject cylynder;
  public GameObject Player;
    private void OnTriggerEnter(Collider other) {
      Debug.Log("Entre");
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
      Vector3 direction = Player.transform.position - transform.position;
      if (direction.z > -5.5 && direction.z < 5.5) {
        transform.position = new Vector3(transform.position.x + 5f, transform.position.y, transform.position.z + 5f);
      } 
    }
}
