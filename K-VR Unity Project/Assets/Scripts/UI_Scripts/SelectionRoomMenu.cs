using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectionRoomMenu : MonoBehaviour
{
    private string ballType;

    public void setBallType(string bType)
    {
        this.ballType = bType;
        GameObject.Find("SportName").GetComponent<TextMeshProUGUI>().SetText(ballType.ToUpper() + " EXERCISES");
        Debug.Log(GameObject.Find("SportName").GetComponent<TextMeshProUGUI>().text);
    }



    //Volleyball Movements:

    /*
     * 
     * Pas Manşet - Pass Bump
     * Smaç Sıçraması - Spike Jump
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */

    //Football Movements:

    /*
     * 
     * Yön değiştirmeli dribbling - Cutting / Changing Direction
     * Engelli Pas Çalışması - Obstacle Pass Exercise
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */

    //Basketball Movements:

    /*
     * 
     * Between Legs Crossover Jump
     * Dribbling and Stop
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */

}
