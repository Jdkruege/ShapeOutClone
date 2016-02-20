using UnityEngine;
using System.Collections;

public class Falling : MonoBehaviour {

    public IEnumerator fall(float destY)
    {
        GetComponent<RotateOnClick>().ableToRotate = false;

        Vector3 pos = transform.position;
        while(transform.position.y != destY)
        {
            pos.y -= 1f;

            transform.position = pos;

            yield return new WaitForSeconds(0.5f);
        }

        GetComponent<RotateOnClick>().ableToRotate = true;
        yield break;
    }

    void fallTo(float destY)
    {
        StartCoroutine(fall(destY));
    }

    void Start()
    {
        fallTo(-3.5f);
    }
}
