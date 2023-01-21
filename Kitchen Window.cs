using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenWindow : MonoBehaviour
{
    //List of buttons in the kitchen window
    public GameObject bowl;
    public GameObject mixer;
    
    //Creating an array of ingredients
    public Button[] ingredients;
    public RecTransform[] newPositions;
    //ing1-5 are the 5 ingredients available for cooking


    // Start is called before the first frame update
    void Start()
    {
        //loop over the buttons and check if clicked
        for(int i =0; i < ingredients.length; i++) {
            ingredients[i].onClick.AddListener(()=> ingChosen(i));

        }
        
        
    }

    // Update is called once per frame
    void ingChosen(int position)
    {
        ingredients[position].GameComponent<RecTransform>().anchoredPosition = newPositions[index].anchoredPosition;
        //we need to define the anchored Positions and new Positions in Unity
    }
}
