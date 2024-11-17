
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if (whatDidIHit.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(7);
            Destroy(this.gameObject);
        }
        else if (whatDidIHit.tag == "Weapon")
        {
            Destroy(this.gameObject);
        }
    }
}
