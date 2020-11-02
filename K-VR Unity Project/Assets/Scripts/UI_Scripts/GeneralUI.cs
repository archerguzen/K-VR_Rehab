using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralUI : MonoBehaviour
{

    public bool isReady = false;
    public static GeneralUI Instance;

    private Camera cam;

    void Awake()
    {
        Instance = this;
        cam = Camera.main;
        Vector3 targetPostition = new Vector3(cam.transform.position.x,
                                       this.transform.position.y,
                                      cam.transform.position.z);

        this.transform.LookAt(targetPostition);

    }

    void Start()
    {
        isReady = true;
    }

    void Update()
    {
        Vector3 targetPostition = new Vector3(cam.transform.position.x,
                                       this.transform.position.y,
                                      cam.transform.position.z);

        this.transform.LookAt(targetPostition);
    }
}
