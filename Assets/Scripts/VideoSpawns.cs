using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;

public class VideoSpawns : MonoBehaviour
{
    public GameObject line;
    VideoPlayer vid;
    GameObject line_Inst;
    // Start is called before the first frame update
    void Start()
    {
        //line = GameObject.Find("Line");
        //line1 = GameObject.Find("Line1");
        //line2 = GameObject.Find("Line2");
        vid = GetComponent<VideoPlayer>();
        Debug.Log("SPAWN!!!!!!!!!!!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        if (vid.time==4)
        {
            Destroy(line_Inst);
            Vector3 lineposition = new Vector3(transform.position.x,transform.position.y,transform.position.z +0.12f);
            //Debug.Log("x"+transform.position.x+"y"+transform.position.y+ "z"+transform.position.z);
            Debug.Log("HEEERRRREEEEE");
            //Instantiate(line, new Vector3(0.003900268f, -0.032f, 0.199f),Quaternion.Euler(0,0,0));
            line_Inst =Instantiate(line, lineposition, Quaternion.Euler(0, 0, 0));
            //line.SetActive(true);
            //line2.SetActive(false);
        }
        else if (vid.time == 9)
        {
            Destroy(line_Inst);
            Vector3 lineposition1 = new Vector3(transform.position.x, transform.position.y , transform.position.z-0.12f );
            line_Inst=Instantiate(line, lineposition1, Quaternion.Euler(180, 0, 0));
            //line1.SetActive(true);
           // line.SetActive(false);
        }
        else if (vid.time == 12)
        {
            Destroy(line_Inst);
            Vector3 lineposition2 = new Vector3(transform.position.x+0.12f, transform.position.y, transform.position.z);
            line_Inst=Instantiate(line, lineposition2, Quaternion.Euler(0, 90, 0));
            //line2.SetActive(true);
            //line1.SetActive(false);
        }
    }
}
