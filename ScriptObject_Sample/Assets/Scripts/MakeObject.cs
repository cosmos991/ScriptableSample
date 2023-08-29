using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObject : MonoBehaviour
{
    public ObjScriptableObject TestData;
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Capsule;

    // Start is called before the first frame update
    void Start()
    {
        Cube.SetActive(false);
        Sphere.SetActive(false);
        Capsule.SetActive(false);

        GameObject resultObj = null;

        if (TestData.type == OBJ_TYPE.CUBE)
        {
            Cube.SetActive(true);
            resultObj = Cube;
        }
        else if (TestData.type == OBJ_TYPE.CAPSULE)
        {
            Capsule.SetActive(true);
            resultObj = Capsule;

        }
        else if (TestData.type == OBJ_TYPE.SPHERE)
        {
            Sphere.SetActive(true);
            resultObj = Sphere;
        }


        for(int i=0;i<TestData.MakeCount;i++)
        {
            GameObject temp = Instantiate(resultObj);
            temp.transform.position = new Vector3(2f * i, 0, 0);

        }
    }

}
