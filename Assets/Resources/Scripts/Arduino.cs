using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Arduino: MonoBehaviour
{
    SerialPort porta = new SerialPort("COM5", 9600);
    public GameObject tiro;

    
    void Start ()
    {
        porta.Open();
        porta.ReadTimeout = 1;
	}
	
	void Update ()
    {
	    if (porta.IsOpen)
        {
            try
            {
                action(porta.ReadByte());
            }
            catch(System.Exception)
            {

            }
        }
	}

    void action(int actionNumber)
    {
        if (actionNumber == 1)
        {
            Vector3 pos = transform.position;
            this.GetComponent<AudioSource>().Play();
            Instantiate(tiro, new Vector2(pos.x, pos.y), Quaternion.identity);
        }

        if (actionNumber == 2)
        {
            this.transform.Translate(Vector2.right * 5 * Time.deltaTime);
        }

        if (actionNumber == 3)
        {
            this.transform.Translate(-Vector2.right * 5 * Time.deltaTime);
        }
    }
}
