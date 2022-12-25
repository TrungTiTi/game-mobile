using RedRunner.Characters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIButtonJump : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public RedCharacter charecter;
    public bool isJump;
    public void OnPointerDown(PointerEventData eventData)
    {
        if(isJump)
        {
            charecter.Jump();
        }    
        else
        {
            charecter.Rolling();
        }    
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
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
