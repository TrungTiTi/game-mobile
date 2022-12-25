using RedRunner.Characters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIButtonHor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public RedCharacter charecter;
    public bool isLeft;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(isLeft)
        {
            charecter.isHorLeft = true;
        }
        else
        {
            charecter.isHorRight = true;
        }
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        if (isLeft)
        {
            charecter.isHorLeft = false;
        }
        else
        {
            charecter.isHorRight = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
