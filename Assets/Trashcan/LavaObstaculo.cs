using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaObstaculo : MonoBehaviour
{

   
    public Vector3 minScale;
    public Vector3 maxScale;
    public bool repeatable;
    public float speed = 2f;
    public float duration =5f;

    // Start is called before the first frame update
    IEnumerator Start (){
    minScale = transform.localScale;
    while (repeatable) {
        yield return RepeatLerp(minScale, maxScale, duration);
        }
    }
    public IEnumerator RepeatLerp(Vector3 a,Vector3 b,float time) {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        //Bucle para aumentar tamaño del sprite
        while (i < 1.0f){
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }
        //Bucle para disminuir tamaño del sprite
        while (i > 0f)
        {
            i -= Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }

    }

    
}
