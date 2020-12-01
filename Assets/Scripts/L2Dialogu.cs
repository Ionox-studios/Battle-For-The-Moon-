using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class L2Dialogu : MonoBehaviour
{
    public DialogManager DialogManager;
    public GameObject DialogAsset;

    // Start is called before the first frame update
    void Start()
    {

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("So you are a moon goddess... and a cute one...what is that like?/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Uh..um... I... um/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Oh what, you are allowed to save me from death but I can't compliment you?/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("No... It's just I usually see humans while a divine being in visions is all and/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("NoOneICaredAboutEverCalledMeCuteOK/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("If you don't mind I am interrupt now./wait:1//close/ ", "Natalia"));


        dialogTexts.Add(new DialogData("Natalia? What are you doing here?/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Originally was to save you from Jeff's treachery./wait:1//close/ ", "Natalia"));


        dialogTexts.Add(new DialogData("and to get some of that fuel that you guys found in the moon’s surface./wait:1//close/ ", "Natalia"));


        dialogTexts.Add(new DialogData("Uh no can do, it'll break the moon./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Grace, hunny, I think this moon witch has taken your brain over, you are talking crazy./wait:1//close/ ", "Natalia"));


        dialogTexts.Add(new DialogData("I'll take her out, send down some mining gear and then we talk yea?/wait:1//close/ ", "Natalia"));


        dialogTexts.Add(new DialogData("HONEY?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("We broke up like a year ago, which someone can't get over./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Oh I'm soooo sorry for flying to the moon to save you from a moon witch and a murderous cowboy./wait:1//close/ ", "Natalia"));


        dialogTexts.Add(new DialogData("I. AM. NOT. A. WITCH. And you shall not reach my moon!/wait:1//close/ ", "Thoth"));

        DialogData LastDialogue = new DialogData("/wait:1//close/ ", "Thoth");
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
