using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour, Compoment
{
	public int state;
    // Start is called before the first frame update
    void Start()
    {
        state = 0;
    }

	void OnMouseDown() 
	{
		operation();
	}

    // Update is called once per frame
    void Update()
    {
        state = state % 3;
		gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("circle"+(state+1).ToString());
    }
	
	public void operation(){
		state++;
	}
}
