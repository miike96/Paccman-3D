using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KonamiCode : MonoBehaviour
{
    private KeyCode[] konamiCode 
        = { 
        KeyCode.UpArrow, 
        KeyCode.UpArrow, 
        KeyCode.DownArrow, 
        KeyCode.DownArrow, 
        KeyCode.LeftArrow, 
        KeyCode.RightArrow, 
        KeyCode.LeftArrow, 
        KeyCode.RightArrow, 
        KeyCode.B, 
        KeyCode.A 
    };

    //Esta variable se utiliza para llevar la cuenta de la tecla que se espera presionar
    IEnumerator start()
    {
        float timer = 0f;
        int index = 0;

        while(true)
        {
            if (Input.GetKeyDown(konamiCode[index]))
            {
                index++;
                timer = 0.25f;

                if(index == konamiCode.Length)
                {
                    Debug.Log("Konami Code!");
                    index = 0;
                }
            }
            //Est� presionada la tecla actual?
            //      Incrementar el �ndice
            //      Reiniciar el temporizador
            //      Si el �ndice == longitud del c�digo
            //              �xito
            //
            //      Si el temporizador se acaba
            //      Establecer el �ndice a 0
            //      Reiniciar el temporizador

            yield return null;
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
