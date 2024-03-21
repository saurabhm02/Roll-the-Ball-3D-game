using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            GameObject.Find("Point System").GetComponent<PointSystem>().Points += 1;
            GameObject.Find("Sound Management").GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
        }
    }
}