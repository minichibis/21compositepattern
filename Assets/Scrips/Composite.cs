using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Composite : MonoBehaviour, Compoment
{
	public List<Compoment> l;
	public List<GameObject> g;
	int state = 0;
	
    // Start is called before the first frame update
    void Start()
    {
		state = 0;
		l = new List<Compoment>();
		foreach(GameObject k in g){
			Compoment c = k.GetComponent<Compoment>();
			add(c);
		}
    }

    // Update is called once per frame
    void Update()
    {
        state = state % 3;
		gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("circle"+(state+1).ToString());
		if(Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }
	
	public void operation(){
		state++;
		foreach (Compoment c in l){
			c.operation();
		}
	}
	
	void OnMouseDown() 
	{
		operation();
	}
	
	public void add(Compoment c){
		l.Add(c);
	}
	
	public void remove(Compoment c){
		l.Remove(c);
	}
	
	public Compoment getchild(int i){
		return l[i];
	}
}
