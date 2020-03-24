using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatSwitch : MonoBehaviour
{

    public Material redMat;
    public Material purpMat;
    public Material yellowMat;
    public Material blueMat;
    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToPurple()
    {
        meshRenderer.material = purpMat;
    }

    public void ToBlue()
    {
        meshRenderer.material = blueMat;
    }

    public void ToRed()
    {
        meshRenderer.material = redMat;
    }

    public void ToYellow()
    {
        meshRenderer.material = yellowMat;
    }

    
}

