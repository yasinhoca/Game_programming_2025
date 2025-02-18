using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpma : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource ses;
    public int puan = 0;
    public GUIStyle stil;

    void Start()
    {
        ses = GetComponent<AudioSource>();
        stil.fontSize = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "altin") {
            Debug.Log("Çarpışma gerçekleşti!");
            puan += 10;
            Debug.Log(puan);
            ses.Play();
            Destroy(collision.gameObject);

        }
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Box(new Rect(20, 20, 100, 50), puan.ToString(),stil);
    }

}
