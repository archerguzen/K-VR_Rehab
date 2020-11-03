using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement_WorkoutScenes : MonoBehaviour
{
	
	public GameObject definedButton;
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
		if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
        {
            // Debug.Log("Hovering");
            // OnClick.Invoke();
			// definedButton.transform.position += new Vector3(0,0.05f,0);
			t.color = Color.red;
        }
		else{
			
			t.color = Color.black;
        }
		
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                Debug.Log("Button Clicked");
				SceneManager.LoadScene(0);
                // OnClick.Invoke();
            }
        }    
    }
}
