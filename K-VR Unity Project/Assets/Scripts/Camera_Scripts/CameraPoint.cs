using System.Collections;
using UnityEngine;

public class CameraPoint : MonoBehaviour
{


    public Transform crosshair;
    public Camera cam;
    public GameObject UI_prefab;

    private string volleyball = "Volleyball", football = "Football", basketball = "Basketball";
    private bool ballSelected = false;
    private GameObject uiMenu;
    private string prevBallName = "none";


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            crosshair.position = hit.point + hit.normal * 0.01f;
            crosshair.transform.LookAt(hit.point + hit.normal);

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (hit.transform.gameObject.tag == "Ball")
                {
                    string ballName = hit.transform.name;
                    if (prevBallName == ballName)
                    {
                        Destroy(uiMenu);
                        prevBallName = "none";
                        ballSelected = false;
                    }
                    else
                    {
                        prevBallName = ballName;
                        StartCoroutine(CreateUIMenu(ballName, hit));
                    }
                }
                else
                {
                    Destroy(uiMenu);
                    prevBallName = "none";
                    ballSelected = false;
                }

            }

        }
    }
    private IEnumerator CreateUIMenu(string ballName, RaycastHit hitParam)
    {
        if (ballSelected && uiMenu != null)
            Destroy(uiMenu);

        GameObject ballObj = hitParam.transform.gameObject;
        this.uiMenu = (GameObject)Instantiate(UI_prefab, ballObj.transform.position + new Vector3(0, 0.75f, 0), cam.transform.rotation);
        yield return new WaitUntil(Waiting);

        SelectionRoomMenu uiMenuClass = uiMenu.transform.GetComponent<SelectionRoomMenu>();
        if (uiMenuClass != null)
            uiMenuClass.setBallType(ballName);

        this.ballSelected = true;
        bool Waiting() => GeneralUI.Instance.isReady;
    }
}
