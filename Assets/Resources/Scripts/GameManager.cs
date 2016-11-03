using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public int vida;
    public int pontos;
    public GameObject inimigo;
    private float tempoInimigo;

    public Text pontosUI;
    public Sprite[] numeros;
    public Image vidasUI;
    private float tempinho;


    public Canvas menu;

	void Start()
    {
        pontos = 0;
        vida = 3;
        tempinho = 1f;
        menu.enabled = false;
    }

	void Update ()
    {
        vida = PlayerScript.vida;
        pontos = PlayerScript.pontos;

        if (vida == 0)
        {
            menu.enabled = true;
            Time.timeScale = 0f;
        }

        if( pontos >= 10)
        {
            tempinho = 0.5f;
        }

        switch (vida)
        {
            case 0:
                vidasUI.GetComponent<Image>().sprite = numeros[0];
                break;

            case 1:
                vidasUI.GetComponent<Image>().sprite = numeros[1];
                break;

            case 2:
                vidasUI.GetComponent<Image>().sprite = numeros[2];
                break;

            case 3:
                vidasUI.GetComponent<Image>().sprite = numeros[3];
                break;
        }

        pontosUI.text = pontos.ToString();

        tempoInimigo += Time.deltaTime;

        if (tempoInimigo >= tempinho)
        {
            Instantiate(inimigo, new Vector2(Random.Range(-8.2f,9f), 6f), Quaternion.identity);
            tempoInimigo = 0;
        }
	}


    public void trocarCena(string cena)
    {
        Application.LoadLevel(cena);
    }
}
