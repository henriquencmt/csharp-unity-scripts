using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    private GameObject button;

    private bool buttonPressed;
    private bool buttonAlreadyPressed;

    [SerializeField]
    private Sprite[] switchSprites;

    private Image buttonImage;

    private string number;
    private KeyCode key;


    // Start is called before the first frame update
    void Start()
    {
        buttonPressed = false;

        buttonImage = GetComponent<Button>().image;
        buttonImage.sprite = switchSprites[0];

        number = gameObject.tag;
        switch (number)
        {
            case "Zero":
                key = KeyCode.Keypad0;
                break;
            case "One":
                key = KeyCode.Keypad1;
                break;
            case "Two":
                key = KeyCode.Keypad2;
                break;
            case "Three":
                key = KeyCode.Keypad3;
                break;
            case "Four":
                key = KeyCode.Keypad4;
                break;
            case "Five":
                key = KeyCode.Keypad5;
                break;
            case "Six":
                key = KeyCode.Keypad6;
                break;
            case "Seven":
                key = KeyCode.Keypad7;
                break;
            case "Eight":
                key = KeyCode.Keypad8;
                break;
            case "Nine":
                key = KeyCode.Keypad9;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(key) || buttonPressed)
        {
            if (buttonAlreadyPressed) return;
            buttonImage.sprite = switchSprites[1];
            buttonAlreadyPressed = true;
            AddNumberToScreen();
            return;
        }
        buttonAlreadyPressed = false;
        buttonImage.sprite = switchSprites[0];
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    void AddNumberToScreen()
    {
        Debug.Log("Number " + number + " pressed down");
    }
}
