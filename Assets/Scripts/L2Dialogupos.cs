using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class L2Dialogupos : MonoBehaviour
{
    public DialogManager DialogManager;
    public GameObject DialogAsset;

    // Start is called before the first frame update
    void Start()
    {

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("So you guys dated?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Yea until she shot me, it was actually my fault we were drunk and shooting squirrels/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("and I tried to soccer kick one at her while she was lining up a shot./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("I thought it was hilarious. And it wasn’t my first time getting shot./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("But she felt soooo guilty about it and wouldn't listen to me./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("It really made me realize the problem, she was stuck in her own head./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("You know I can still hear you./wait:1//close/ ", "Natalia"));


        dialogTexts.Add(new DialogData("Well you tried to invade my moon so this is your punishment./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("I will be back to save you Grace./wait:1//close/ ", "Natalia"));
        dialogTexts.Add(new DialogData("I. don't. need. saving./wait:1//close/ ", "Grace"));



        DialogData LastDialogue = new DialogData("/wait:1//close/ ", "Grace");
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
