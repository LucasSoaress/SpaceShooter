using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public GameObject tiro;
    public float velocidade;
    public static int vida;
    public static int pontos;
    
    void Start()
    {
        pontos = 0;
        vida = 3;
    }

	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            esquerda();
        }

        if (Input.GetKey(KeyCode.D))
        {
            direita();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            atirar();      
        }
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.gameObject.tag == "Inimigo" && vida >= 0|| Col.gameObject.tag == "TiroInimigo" && vida >= 0)
        {
            Col.gameObject.GetComponent<AudioSource>().Play();
            vida -= 1;
        }

        if (Col.gameObject.tag == "Inimigo" && vida == 0 || Col.gameObject.tag == "TiroInimigo" && vida == 0)
        {
            Destroy(gameObject);
            Destroy(Col.gameObject);
        }
    }

    public void direita()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
    }

    public void esquerda()
    {
        transform.Translate(-Vector2.right * velocidade * Time.deltaTime);
    }

    public void atirar()
    {
        Vector3 pos = transform.position;
        this.GetComponent<AudioSource>().Play();
        Instantiate(tiro, new Vector2(pos.x, pos.y), Quaternion.identity);
    }
}
