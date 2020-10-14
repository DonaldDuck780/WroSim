using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GreenInitPosSet : MonoBehaviour
{
    
    Vector3[] GreenList1 = {new Vector3 { x = 11.109f, y = 1.877f, z = 19.461f}, new Vector3 { x = 6.47f, y = 1.877f, z = 19.461f}, new Vector3 { x = 1.729f, y = 1.877f, z = 19.461f}};
    Vector3[] GreenList2 = { new Vector3 { x = 14.279f, y = 1.877f, z = 6.95f }, new Vector3 { x = 14.279f, y = 1.877f, z = 11.639f }, new Vector3 { x = 14.279f, y = 1.877f, z = 16.349f } };
    Vector3[] GreenList3 = { new Vector3 { x = 1.782f, y = 1.877f, z = 3.779f }, new Vector3 { x = 6.48f, y = 1.877f, z = 3.779f }, new Vector3 { x = 11.11f, y = 1.877f, z = 3.779f } };
    Vector3[] GreenList4 = { new Vector3 { x = -1.372f, y = 1.877f, z = 16.32f }, new Vector3 { x = -1.372f, y = 1.877f, z = 11.61f }, new Vector3 { x = -1.372f, y = 1.877f, z = 6.98f } };

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

        Cube1.transform.position = GreenList1[index1];
        Cube2.transform.position = GreenList2[index2];
        Cube3.transform.position = GreenList3[index3];
        Cube4.transform.position = GreenList4[index4];
    }

}
