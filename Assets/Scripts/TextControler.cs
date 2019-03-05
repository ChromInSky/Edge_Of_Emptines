using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextControler : MonoBehaviour
{
     public Text text;
     public Text help;
     bool Starttext;

    public enum States
    {
        gamestart,
        platform,
        fall,
        cathecathedral,
        altar,
        slt,
        undergrounds,
        abattoir,
        catacombs,
        hole,
        darkroom,
        portals,
        portal1,
        portal2,
        portal3,
        maze,
        divinealtar,
        emptyroom,
        machine,
        _void,
        crush,
        good,
        pandemonium,
        necropolis,
    };

    States myState;



    void Start()
    {
        myState = States.gamestart;
        Starttext = true;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Return) && Starttext == true)
        {
            myState = States.platform;
            Starttext = false;
        }

        if(myState == States.gamestart)
        {
            state_gamestart();
        }
        else if(myState == States.platform)
        {

        }
        


    }

    void state_gamestart()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }

    void state_platform()
    {
        help.text = "WORK!";

        text.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur euismod eleifend feugiat. Quisque viverra porta turpis vehicula egestas. n/" +
            "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Fusce dictum ullamcorper orci vel efficitur. Nam tempor, nibh quis sagittis viverra, n/" +
            "ex tortor sollicitudin nisi, ut mattis metus sem quis quam. Sed porttitor vel ex vitae vestibulum. Vivamus elementum lacus id elit pretium, luctus luctus tortor tempus. n/" +
            "Aenean finibus felis sed neque gravida, eget dictum ex egestas. Sed viverra, diam placerat porta vulputate, ipsum ligula aliquet nunc, id commodo felis dui id neque.n/" +
            " Aenean efficitur convallis malesuada. Phasellus dui libero, suscipit eu tortor et, placerat placerat erat. Donec eget elit laoreet, semper sem ut, tempus ipsum. n/" +
            "Vestibulum vel suscipit tortor, eget tristique enim. In pharetra tortor bibendum hendrerit condimentum. Pellentesque ullamcorper magna sed tellus commodo, sed imperdiet ante semper.";

        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.cathecathedral;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.portals;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.fall;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.machine;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myState = States.cathecathedral;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myState = States.cathecathedral;
        }
    }

    void state_fall()
    {
        text.text = "Sapadłeś";

    }


        




   
}
