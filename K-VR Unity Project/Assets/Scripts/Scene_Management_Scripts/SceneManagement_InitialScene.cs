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
		
		Text t = definedButton.GetComponentInChildren(typeof(Text)) as Text;
		Canvas can = definedButton.GetComponentInChildren(typeof(Canvas)) as Canvas;
		if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
        {
            //Debug.Log("Hovering");
            // OnClick.Invoke();
			// definedButton.transform.position += new Vector3(0,0.05f,0);
			t.color = Color.red;
			
			if(sceneNumber != 1){
				
				definedButton.transform.Rotate(0.0f, 0.5f, 0.0f, Space.Self);
				can.transform.Rotate(0.0f, -0.5f, 0.0f, Space.Self);
			}
			
        }
		else{
			
			t.color = Color.black;
			definedButton.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
			can.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
		}
         
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
