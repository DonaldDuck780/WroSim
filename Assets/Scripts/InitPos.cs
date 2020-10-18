using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InitPos : MonoBehaviour
{
    Vector3[] GreenList1 = { new Vector3 { x = 11.109f, y = 1.877f, z = 19.461f }, new Vector3 { x = 6.47f, y = 1.877f, z = 19.461f }, new Vector3 { x = 1.729f, y = 1.877f, z = 19.461f }, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 11.109f, y = 1.877f, z = 19.461f }, new Vector3 { x = 1.729f, y = 1.877f, z = 19.461f }, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 0, y = 0, z = 0 } /*Starting for green cube 1 pos*/, new Vector3 { x = 0, y = 0, z = 0 } /* GreenCubeHelper pos */ };
    Vector3[] RedList1 = { new Vector3 {x = 0, y = 0, z = 0 }, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 11.135f, y = 1.877f, z = 22.554f }, new Vector3 { x = 6.43f, y = 1.877f, z = 22.554f }, new Vector3 { x = 1.74f, y = 1.877f, z = 22.554f }, new Vector3 { x = 1.74f, y = 1.877f, z = 22.554f }, new Vector3 { x = 11.135f, y = 1.877f, z = 22.554f }, new Vector3 { x = 0, y = 0, z = 0 }, new Vector3 { x = 0, y = 0, z = 0 } /*Starting for red cube 1 pos*/, new Vector3 { x = 0, y = 0, z = 0 } /* RedCubeHelper pos */ };



    /*
    Vector3[] GreenList2 = { new Vector3 { x = 17.383f, y = 1.877f, z = 6.938f }, new Vector3 { x = 17.383f, y = 1.877f, z = 11.621f }, new Vector3 { x = 17.383f, y = 1.877f, z = 16.307f } };
    Vector3[] RedList2 = { };
    Vector3[] GreenList3 = { new Vector3 { x = 1.792f, y = 1.877f, z = 0.656f }, new Vector3 { x = 6.43f, y = 1.877f, z = 0.656f }, new Vector3 { x = 11.119f, y = 1.877f, z = 0.656f } };
    Vector3[] RedList3 = { };
    Vector3[] GreenList4 = { new Vector3 { x = -4.472f, y = 1.877f, z = 16.313f }, new Vector3 { x = -4.472f, y = 1.877f, z = 11.636f }, new Vector3 { x = -1.372f, y = 1.877f, z = 6.928f } };
    Vector3[] RedList4 = { };
    */

    Vector3[] SameColourCubes = { new Vector3 { x = 11.109f, y = 1.877f, z = 19.461f } };


    public GameObject GreenCube1;
    public GameObject GreenCubeHelper;
    //public GameObject GreenCube2;
    //public GameObject GreenCube3;
    //public GameObject GreenCube4;
    public GameObject RedCube1;
    public GameObject RedCubeHelper;
    //public GameObject RedCube2;
    //public GameObject RedCube3;
    //public GameObject RedCube4;



    private void Start()
    {
        
        int index1 = UnityEngine.Random.Range(0, GreenList1.Length);
        int index2 = UnityEngine.Random.Range(0, GreenList1.Length);
        //int index3 = UnityEngine.Random.Range(0, GreenList1.Length);
        //int index4 = UnityEngine.Random.Range(0, GreenList1.Length);

        int identifier = UnityEngine.Random.Range(0, 1);
        
        
        if (index1 > GreenList1.Length - 4 || index2 > GreenList1.Length /*...*/)
        {
            
            switch (identifier)
            {
                case 0:
                    if (index1 > GreenList1.Length - 4)
                    {
                        GreenCube1.transform.position = GreenList1[10]; // wrong needs change
                        GreenCubeHelper.transform.position = GreenList1[11]; //needs to be changed
                                                                                 //...
                        break;
                    }
                    else if (index2 > GreenList1.Length /*...*/)
                    {
                        // GreenCube2.transform.position = GreenList2[index2]; 
                        // GreenHelper.tranform.position = GreenList2[index2 + 1];
                        break;
                    }
                    // ...
                    break;
                    
                case 1:
                    if (index1 > GreenList1.Length - 4)
                    {
                        RedCube1.transform.position = RedList1[10]; //needs to be changed
                        RedCubeHelper.transform.position = RedList1[11]; //needs to be changed
                        break;
                    }
                    else if (index2 > GreenList1.Length /*...*/)
                    {
                        // RedCube2.transform.position = GreenList2[index2]; 
                        // RedHelper.tranform.position = GreenList2[index2 + 1];
                        break;
                    }
                    // ...
                    break;
            }
        }
        else
        {
            GreenCube1.transform.position = GreenList1[index1];
            //GreenCube2.transform.position = GreenList2[index2];
            //GreenCube3.transform.position = GreenList3[index3];
            //GreenCube4.transform.position = GreenList4[index4];
            RedCube1.transform.position = RedList1[index1];
            //RedCube2.transform.position = RedList2[index2];
            //RedCube3.transform.position = RedList3[index3];
            //RedCube4.transform.position = RedList4[index4];
        }
        
    }
}
