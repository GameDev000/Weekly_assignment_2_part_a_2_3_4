using UnityEngine;
using UnityEngine.InputSystem; //for InputAction

public class Display : MonoBehaviour{
    [SerializeField] private GameObject targetObject; //link to object- square
    [SerializeField] private InputAction swichAction; 
    private bool isHidden = false;
    private float lastSwich = -1; //last time KeyCode.Space from Time.time

    //make swich
    private void SwichOn(InputAction.CallbackContext ctx){
         if(Time.time- lastSwich< 0.4f)
            return;
        isHidden = !isHidden; 
        targetObject.SetActive(!isHidden); //square
        lastSwich = Time.time;
    }

    //SetActive(true)
    void OnEnable()
    {
        swichAction.performed += SwichOn;
        swichAction.Enable();
    }

    //SetActive(false)
    void OnDisable()
    {
        swichAction.performed -= SwichOn;
        swichAction.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){ 
    }

    // Update is called once per frame
    void Update()
    {
    }
}
