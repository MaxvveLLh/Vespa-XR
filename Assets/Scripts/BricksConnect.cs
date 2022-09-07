using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksConnect : MonoBehaviour
{
    public GameObject Preview;
    void BricksFixedConnect()
    {
        //get male and female
        //get preview postion
        //if blue
            //if no connection locator
                //declare new gameobject as locator
                //assign male and female as children of locator
                //fixedhinge both to locator                        //if want to disconnect, assign disconnected objects together to a new locator, or to be itself
                //configure hinge with position 
            //else 
                //assign female as child of existing locator
                //assign female to locator
                //configure hinge with position                     //store them in data structure in future to represent "who connects whoms"
        
        //destory preview
        //set preview to null in male bricks
        //clear lists if possible
        //diabled connected studs (both male and female)            //what is not all studs connected when SelectExited?
    }
}
