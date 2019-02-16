using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPressed : MonoBehaviour
{
    string btnTag;
    void Start()
    {
        Debug.Log("created");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Debug.Log("touch");
            // Debug.Log(Camera.main.transform.position + "/" + this.gameObject.transform.position);
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            
            RaycastHit hit; 
            if (Physics.Raycast(ray, out hit))
            {
                // Debug.Log("Work dang it");
                btnTag = hit.transform.tag;
                Debug.Log(btnTag);
                switch (btnTag)
                {
                    case "QuestionMark":
                        Debug.Log("Tapping on: " + hit.transform.name);
                        break;
                    }
            }
        }
    }
}
