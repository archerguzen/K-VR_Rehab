using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Script : MonoBehaviour
{
	
	public Text hudElement1;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
		hudElement1.text = "Workout Time: " + (int) Time.timeSinceLevelLoad + " second(s)";
		
    }
}
