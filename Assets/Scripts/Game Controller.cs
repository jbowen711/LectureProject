using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject flag1;
    [SerializeField] GameObject flag2;
    [SerializeField] GameObject flag3;
    [SerializeField] GameObject flag4;

    Vector3 flagSpawn;

    public List<GameObject> fl1 = new List<GameObject>();
    public List<GameObject> fl2 = new List<GameObject>();
    public List<GameObject> fl3 = new List<GameObject>();
    public List<GameObject> fl4 = new List<GameObject>();

    private int maxFlags = 2;

    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        flagSpawn = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        flagSpawn.z = -.5f;

        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.Q) && fl1.Count < maxFlags)
        {
            SpawnFlag(flag1, fl1);

        }
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.W) && fl1.Count < maxFlags)
        {
            SpawnFlag(flag2, fl1);

        }
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.E) && fl1.Count < maxFlags)
        {
            SpawnFlag(flag3, fl3);

        }
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.R) && fl1.Count < maxFlags)
        {
            SpawnFlag(flag4, fl4);

        }

        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.Q) && fl1.Count == maxFlags)
        {
            MoveFlag(fl1);

        }
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.W) && fl1.Count == maxFlags)
        {
            MoveFlag(fl2);

        }
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.E) && fl1.Count == maxFlags)
        {
            MoveFlag(fl3);

        }
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.R) && fl1.Count == maxFlags)
        {
            MoveFlag(fl4);

        }

    }

    void SpawnFlag(GameObject fl, List<GameObject> flaglist) {
        GameObject flag = Instantiate(fl, flagSpawn, Quaternion.identity);
        flaglist.Add(flag);

    }

    void MoveFlag(List<GameObject> fl)
    {
        GameObject closestFlag = null;
        float closestDistance = float.MaxValue;
        foreach (GameObject flag in fl)
        {
            float distance = Vector3.Distance(flag.transform.position, flagSpawn);
            if (distance < closestDistance)
            {
                closestFlag = flag;
                closestDistance = distance;
            }
        }
        if (closestFlag != null)
        {
            closestFlag.transform.position = flagSpawn;
        }
    }

}
