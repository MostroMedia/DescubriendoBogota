using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour
{

    bool shouldBeMoved = false;
    float currentPosition = 0f;
    public float maxPossiblePosition;
    public bool shouldGoBack;

    // Start is called before the first frame update
    void Start()
    {
       Button startButton = gameObject.GetComponent<Button>();
       startButton.onClick.AddListener(() =>
       {
           shouldBeMoved = true;
       });
        
    }

    // Update is called once per frame
    void Update()
    {
       if(shouldBeMoved)
       {
            currentPosition = Camera.main.gameObject.transform.position.x;

            if (shouldGoBack)
            {
                
               if (currentPosition > maxPossiblePosition)
               {
                    Camera.main.gameObject.transform.Translate(-0.51f, 0, 0);
                }
                else
                {
                    shouldBeMoved = false;
                }

            }
            else
            {

                if (currentPosition <= maxPossiblePosition)
                {
                    Camera.main.gameObject.transform.Translate(0.3f, 0, 0);

                }
                else
                {
                    shouldBeMoved = false;
                }

            }

        }
    }
}
