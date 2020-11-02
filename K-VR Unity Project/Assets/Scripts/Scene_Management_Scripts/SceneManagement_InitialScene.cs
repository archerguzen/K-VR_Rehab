using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class SceneManagement_InitialScene : MonoBehaviour
{
	
	public GameObject definedButton;
	public int sceneNumber;
    // public UnityEvent OnClick = new UnityEvent();
	
    void Start()
    {
        definedButton = this.gameObject;
    }
	
	// Update is called once per frame
    void Update () {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;
         
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                Debug.Log("Button Clicked");
				SceneManager.LoadScene(sceneNumber);
                // OnClick.Invoke();
            }
        }    
    }
}
