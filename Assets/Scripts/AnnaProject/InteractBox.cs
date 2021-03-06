using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class InteractBox : MonoBehaviour
{
    public GameObject openGate;
    public GameObject closeGate;
    public TMP_Text openText;
    public GameObject player;
    public float interactionDistance;
    private Keyboard keyboard;
   public bool isOpen;


    public void Start()
    {
        keyboard = Keyboard.current;
        
    }

    public void Update()
    {
        if (isOpen == false && Vector3.Distance(player.transform.position, transform.position) < interactionDistance)
        {
            openText.gameObject.SetActive(true);

            if (keyboard.fKey.isPressed) 
            {
                closeGate.SetActive(false);
                openGate.SetActive(true);
                isOpen = true;
            }

        }
        else
        {
            openText.gameObject.SetActive(false);  
        }
    }
}
