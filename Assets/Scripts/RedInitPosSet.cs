using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedInitPosSet : MonoBehaviour
{

    Vector3[] RedList1 = { new Vector3 { x = 11.135f, y = 1.877f, z = 22.554f }, new Vector3 { x = 6.43f, y = 1.877f, z = 22.554f }, new Vector3 { x = 1.74f, y = 1.877f, z = 22.554f } };
    Vector3[] RedList2 = { new Vector3 { x = 17.383f, y = 1.877f, z = 6.938f }, new Vector3 { x = 17.383f, y = 1.877f, z = 11.621f }, new Vector3 { x = 17.383f, y = 1.877f, z = 16.307f } };
    Vector3[] RedList3 = { new Vector3 { x = 1.792f, y = 1.877f, z = 0.656f }, new Vector3 { x = 6.43f, y = 1.877f, z = 0.656f }, new Vector3 { x = 11.119f, y = 1.877f, z = 0.656f } };
    Vector3[] RedList4 = { new Vector3 { x = -4.472f, y = 1.877f, z = 16.313f }, new Vector3 { x = -4.472f, y = 1.877f, z = 11.636f }, new Vector3 { x = -1.372f, y = 1.877f, z = 6.928f } };

    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;



    private void Start()
    {
        int index1 = UnityEngine.Random.Range(0, 3);
        int index2 = UnityEngine.Random.Range(0, 3);
        int index3 = UnityEngine.Random.Range(0, 3);
        int index4 = UnityEngine.Random.Range(0, 3);

        Cube1.transform.position = RedList1[index1];
        Cube2.transform.position = RedList2[index2];
        Cube3.transform.position = RedList3[index3];
        Cube4.transform.position = RedList4[index4];
    }

}
