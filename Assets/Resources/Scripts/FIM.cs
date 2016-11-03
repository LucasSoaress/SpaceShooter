using UnityEngine;
using System.Collections;

public class FIM : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag != "Player")
        {
            Destroy(Col.gameObject);
        }
    }
}
