using UnityEngine;
using System.Collections;

public class RotateOnClick : MonoBehaviour {

    public bool ableToRotate;

    public IEnumerator rotate()
    {
        for (int i = 0; i < 5; i++)
        {
            transform.Rotate(new Vector3(0, 0, 1), -18f);

            yield return new WaitForSeconds(0.10f);
        }

        yield break;
    }
    
    void OnMouseDown()
    {
        if(ableToRotate) StartCoroutine(rotate());
    }
}
