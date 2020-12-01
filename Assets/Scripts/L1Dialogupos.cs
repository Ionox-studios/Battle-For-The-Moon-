using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class L1Dialogupos : MonoBehaviour
{
    public DialogManager DialogManager;
    public GameObject DialogAsset;

    // Start is called before the first frame update
    void Start()
    {

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Dog my cat y'all fighting for real./wait:1//close/ ", "Jeff"));


        dialogTexts.Add(new DialogData("Seeeaaaatttttllleeeeee./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("You know what Grace, most people don't get shot by their friends as often as you do.../wait:1//close/ ", "Jeff"));
        dialogTexts.Add(new DialogData("...think your bad attitude might have something to do with that?/wait:1//close/ ", "Jeff"));


        dialogTexts.Add(new DialogData("Often?/wait:1//close/ ", "Thoth"));
        dialogTexts.Add(new DialogData("Uh like six times but as of earlier today two are Jeff so that doesn't count./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Grace, I like that name/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("I mean it's servicable is all uhhh/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Radio... cuttin... out, I'll be back missy..../wait:1//close/ ", "Jeff"));
        dialogTexts.Add(new DialogData("Gonna... kill... both.. y'all./wait:1//close/ ", "Jeff"));


        DialogData LastDialogue = new DialogData("/wait:1//close/ ", "Jeff");
        LastDialogue.Callback = () => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        dialogTexts.Add(LastDialogue);
        DialogManager.Show(dialogTexts);


    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Select"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
