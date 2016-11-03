using UnityEngine;
using System.Collections;

public class tiroInimigo : MonoBehaviour
{
    private float tempoTiro;
    public GameObject tiro;

    void Update ()
    {
        tempoTiro += Time.deltaTime;

        if (tempoTiro > 0.5f)
        {
            Instantiate(tiro, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            tempoTiro = 0;
        }
	}

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "TiroPlayer")
        {
            PlayerScript.pontos += 1;
            Destroy(gameObject);
            Destroy(Col.gameObject);
        }
    }
}
