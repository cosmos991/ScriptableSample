using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    (int a, float b) c = (1, 2.4f);

    (int, float, double) test_1 = (3, 8.6f, 8.77);

    private void Start()
    {
        Debug.Log($"{c.a} {c.b}");
        Debug.Log($"{test_1.Item1}  {test_1.Item2} {test_1.Item3}");


        Debug.Log(GetTestValue().sum);
        Debug.Log(GetTestValue().multi_float);
    }


    public (int sum, float multi_float) GetTestValue()
    {
        int sum = c.a + test_1.Item1;
        float multi_float = c.b * test_1.Item1;

        return (sum, multi_float);
    }
}
