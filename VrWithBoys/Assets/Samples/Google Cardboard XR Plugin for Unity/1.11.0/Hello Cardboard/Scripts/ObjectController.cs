using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ObjectController : MonoBehaviour
{   
    private Canvas can;
    private Button butt;
    private EventSystem eve;
    

    public void Start()
    {
        can = GetComponent<Canvas>();
        butt = GetComponent<Button>();
        eve = GetComponent<EventSystem>();
        can.enabled=true;
        
        
    }
    public void OnPointerEnter()
    {
        butt.Select();
    }

    public void OnPointerExit()
    {
         EventSystem.current.SetSelectedGameObject(null);
    }

    public void OnPointerClick()
    {
        
       ExecuteEvents.Execute(butt.gameObject, new BaseEventData(eve), ExecuteEvents.submitHandler);
    }

    
    
}
