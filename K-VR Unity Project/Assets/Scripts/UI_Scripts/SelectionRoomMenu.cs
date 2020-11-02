using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class SelectionRoomMenu : MonoBehaviour
{
    private string ballType;
    private string[] footballMovements;
    private string[] volleyballMovements;
    private string[] basketballMovements;

    private VideoPlayer videoPlayer;

    public void Awake()
    {
        footballMovements = new string[] { "Yön Değiştirmeli Dribling", "Engelli Pas Çalışması" };
        volleyballMovements = new string[] { "Pas Manşet", "Smaç Sıçraması" };
        basketballMovements = new string[] { "Bacak Arası Crossover Sıçraması", "Top Sürme ve Durma" };
    }

    public void Update()
    {
        
    }

    public void setBallType(string bType)
    {
        addBallType(bType);
        GameObject.Find("SportName").GetComponent<TextMeshProUGUI>().SetText(ballType.ToUpper() + " HAREKETLERİ");
        initializeMovements(0);
    }

    private void initializeMovements(int movementIndex) 
    {
        //videoPlayer = GetComponent<VideoPlayer>();
        // videoPlayer.clip = videoC

        switch (ballType) {
            case "Futbol":
                GameObject.Find("ExerciseTitle").GetComponent<TextMeshProUGUI>().SetText(footballMovements[movementIndex].ToUpper());
                break;
            case "Voleybol":
                GameObject.Find("ExerciseTitle").GetComponent<TextMeshProUGUI>().SetText(volleyballMovements[movementIndex].ToUpper());
                break;
            case "Basketbol":
                GameObject.Find("ExerciseTitle").GetComponent<TextMeshProUGUI>().SetText(basketballMovements[movementIndex].ToUpper());
                break;
        }

        
    }

    private void videoFunction(VideoPlayer videoPlayer)
    {
        
    }

    private void addBallType(string bType) 
    {
        switch (bType)
        {
            case "Football_Cart":
                this.ballType = "Futbol";
                break;
            case "Volleyball_Cart":
                this.ballType = "Voleybol";
                break;
            case "Basketball_Cart":
                this.ballType = "Basketbol";
                break;
        }
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
     * ORTAK HAREKETLER
     * 
     * TEK BACAK TEMASLI AĞIRLIK AKTARMA
     * YÜKSEKLİK ÜZERİNDEN YANA ÇİFT VACAK SIÇRAMALI BURPEE
     * İKİ YANLI KARELAJ ZIPLAMA    
     * TEK YANLI SOL AYAK KARELAJ ZIPLAMA
     * TEK YANLI SAĞ AK KARELAJ ZIPLAMA
     * DÖNMELİ YATAY SIÇRAMA
     *  
     *  
     *  
     *  
     *  
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */

}
