using UnityEngine;
using System.Collections;

public class movementScript : MonoBehaviour
{
    public int qualObjeto;

	void Update ()
    {
        switch(qualObjeto)
        {
            case 1: // tiro player
                this.transform.Translate(Vector2.up * 5 * Time.deltaTime);
                break;

            case 2: // inimigo
                this.transform.Translate(-Vector2.up * 5 * Time.deltaTime);
                break;

            case 3: // tiro inmigo
                this.transform.Translate(-Vector2.up * 8 * Time.deltaTime);
                break;
        }
	}
}
