using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCollisionHandler : MonoBehaviour
{
    public List<GameObject> MaleList = new List<GameObject>();
    public List<GameObject> FemaleList = new List<GameObject>();
    private Transform Parent; //must destoryed its instance when Select Exited is called from female brick
    public GameObject Preview = null; //must set to null when Select Exited is called from  female brick

    void InitiatePreview(GameObject female)
    {
        Parent = female.transform.parent;
        Preview = Instantiate(Parent.Find("mesh").gameObject);
        Preview.transform.name = "Preview";
        Preview.transform.localScale += new Vector3(-0.8f, -0.8f, -0.8f);
        Preview.GetComponent<MeshRenderer>().material = Resources.Load("Materials/MaterialPreview") as Material;
        Preview.GetComponent<MeshRenderer>().enabled = false;
        
        Debug.Log("Preview Loaded: " +  Parent.name);
    }
    Vector3 GetPreviewPosition()
    {
        //need to update this function to get correct position
        Vector3 Position = Parent.transform.position;
        return Position;
    }
    void TransformPreview(GameObject female)
    {
        Preview.GetComponent<MeshRenderer>().enabled = true;
        Vector3 Position = GetPreviewPosition(); 
        Quaternion Rotation = this.transform.rotation;
        Preview.transform.position = Position;
        Preview.transform.rotation = Rotation;
        Debug.Log("Preview Postion: " + Position);
        Debug.Log("Preview Rotation: " + Rotation);

    }

    public void OnTriggerEnterMaleStud(GameObject male, GameObject female)
    {
        MaleList.Add(male);
        FemaleList.Add(female);
        male.GetComponent<MeshRenderer>().enabled = true;
        //generate preview
        if(Preview == null)
        {
            InitiatePreview(female);
        }
        //translate & rotate preview
        TransformPreview(female);
    }
    public void OnTriggerExitMaleStud(GameObject male, GameObject female)
    {
        MaleList.Remove(male);
        FemaleList.Remove(female);
        male.GetComponent<MeshRenderer>().enabled = false;

        //disable preview
        Preview.GetComponent<MeshRenderer>().enabled = false;
    }

    public void OnTriggerEnterFemaleStud(GameObject male, GameObject female)
    {
        
        female.GetComponent<MeshRenderer>().enabled = true;
    }
    public void OnTriggerExitFemaleStud(GameObject male, GameObject female)
    {
        
        female.GetComponent<MeshRenderer>().enabled = false;
    }
}
