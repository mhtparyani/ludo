using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

	public static Dice instance;
    // Array of dice sides sprites to load from Resources folder
    private Sprite[] diceSides;

    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;
	void Awake(){
		instance = this;
	}
	// Use this for initialization
	private void Start () {

        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
	}
	
    // If you left click over the dice then RollTheDice coroutine is started
	public void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }

	public void  rollIt (){
		rend = GetComponent<SpriteRenderer>();
		diceSides = Resources.LoadAll<Sprite>("DiceSides/");
		StartCoroutine("RollTheDice");
	}

    // Coroutine that rolls the dice
	public IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        int randomDiceSide = 0;

        // Final side or value that dice reads in the end of coroutine
        int finalSide = 0;

        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 5);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = diceSides[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.1f);
        }

        // Assigning final side so you can use this value later in your game
        // for player movement for example
        finalSide = randomDiceSide + 1;


		GameObject.Find ("pCube1").GetComponent<Gamer> ().showTheMagic (finalSide);

        // Show final dice value in Console
        Debug.Log(finalSide);
    }
		
}
