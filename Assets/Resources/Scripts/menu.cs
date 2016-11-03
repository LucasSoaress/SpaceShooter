using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{
    public void trocarCena(string cena)
    {
        Application.LoadLevel(cena);
    }

    public void fechar()
    {
        Application.Quit();
    }
}
