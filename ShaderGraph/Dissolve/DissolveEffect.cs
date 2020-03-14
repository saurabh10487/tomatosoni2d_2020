using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveEffect : MonoBehaviour
{
    Material material;

    bool isDissolving = false;
    float fade = 0f;

    void Start()
    {
        // Get a reference to the material
        material = GetComponent<SpriteRenderer>().material;


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            isDissolving = true;
        }

        if (isDissolving)
        {
            fade -= Time.deltaTime;

            if (fade <= 0f)
            {
                fade = 0f;

                isDissolving = false;
            }
            Debug.Log("fade: " + fade);

            // Set the property

        }
        else
        {




            if (fade <= 1f)
            {

                fade += Time.deltaTime;

            }
        }
        material.SetFloat("_Fade", fade);
    }
}