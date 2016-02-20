using UnityEngine;
using System.Collections;

public class RotateOnClick : MonoBehaviour {

    public IEnumerator rotate()
    {
        for (int i = 0; i < 4; i++)
        {
            transform.Rotate(new Vector3(0, 0, 1), -30f);

            yield return new WaitForSeconds(0.125f);
        }

        yield break;
    }
    
    void OnMouseDown()
    {
        StartCoroutine(rotate());

        //GetComponent<Transform>().Rotate(new Vector3(0, 0, 1), -90f);
    }
}
