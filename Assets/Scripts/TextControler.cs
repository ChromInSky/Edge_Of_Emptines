using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController: MonoBehaviour
{
     

     public Text text;
     public Text help;
     bool Starttext;

    //ITEMS//
    bool Soul_Crystal;
    bool Key;
    bool bottle;
    bool bottle_of_blood;
    bool broken_crystal;
    bool crystal;
    bool note;

    //ITEMS//

    public enum States
    {
        gamestart,
        starthistory,
        platform,
        fall,
        cathedral,
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
        mr1,
        mr2,
        mr3,
        ml1,
        ml2,
        ml3,
        wrong,
    };

    States myState;

    // A - , S - , D - , F - , G - 

    void Start()
    {
        
        myState = States.gamestart;
        Starttext = true;
        bool Soul_Crystal = false;
        bool Key = false;
        bool bottle = false;
        bool bottle_of_blood = false;
        bool broken_crystal = false;
        bool crystal = false;
        bool note = false;
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
        else if (myState == States.starthistory)
        {
            state_starthistory();
        }
        else if (myState == States.platform)
        {
            state_platform();
        }
        else if (myState == States.fall)
        {
            state_fall();
        }
        else if (myState == States.cathedral)
        {
            state_cathedral();
        }
        else if (myState == States.altar)
        {
            state_altar();
        }
        else if (myState == States.slt)
        {
            state_slt();
        }
        else if (myState == States.undergrounds)
        {
            state_platform();
        }
        else if (myState == States.abattoir)
        {
            state_abattoir();
        }
        else if (myState == States.catacombs)
        {
            state_catacombs();
        }
        else if (myState == States.hole)
        {
            state_hole();
        }
        else if (myState == States.darkroom)
        {
            state_darkroom();
        }
        else if (myState == States.portals)
        {
            state_portals();
        }
        else if (myState == States.portal1)
        {
            state_portal1();
        }
        else if (myState == States.portal2)
        {
            state_portal2();
        }
        else if (myState == States.portal3)
        {
            state_portal3();
        }
        else if (myState == States.maze)
        {
            state_maze();
        }
        else if (myState == States.mr1)
        {
            state_mr1();
        }
        else if (myState == States.mr2)
        {
            state_mr2();
        }
        else if (myState == States.mr3)
        {
            state_mr3();
        }
        else if (myState == States.ml1)
        {
            state_ml1();
        }
        else if (myState == States.ml2)
        {
            state_ml2();
        }
        else if (myState == States.ml3)
        {
            state_ml3();
        }
        else if (myState == States.wrong)
        {
            state_wrong();
        }
        else if (myState == States.divinealtar)
        {
            state_divinealtar();
        }
        else if (myState == States.emptyroom)
        {
            state_emptyroom();
        }
        else if (myState == States.machine)
        {
            state_machine();
        }
        else if (myState == States._void)
        {
            state__void();
        }
        else if (myState == States.crush)
        {
            state_crush();
        }
        else if (myState == States.good)
        {
            state_good();
        }
        else if (myState == States.pandemonium)
        {
            state_pandemonium();
        }
        else if (myState == States.necropolis)
        {
            state_necropolis();
        }
    }
    
    //All Game States

    void state_gamestart()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_platform()
    {
        

        help.text = "WORK!";

        text.text = "";

        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.cathedral;
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
            myState = States.cathedral;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myState = States.cathedral;
        }
    }
    void state_starthistory()
    {
        text.text = "Press ENTER to START";
        help.text = "";
    }
    void state_fall()
    {
        text.text = "Sapadłeś";
        help.text = "Press BACKSPACE to RESTART";

    }
    void state_cathedral()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_altar()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_slt()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_undergrounds()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_abattoir()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_catacombs()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_hole()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_darkroom()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_portals()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_portal1()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_portal2()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_portal3()
    {
        text.text = "Press ENTER to START";
        help.text = "Press BACKSPACE to RESTART";

    }
    void state_maze()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_divinealtar()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_emptyroom()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_machine()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state__void()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_crush()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_good()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_pandemonium()
    {
        text.text = "Press ENTER to START";
        help.text = "Press BACKSPACE to RESTART";

    }
    void state_necropolis()
    {
        text.text = "Press ENTER to START";
        help.text = "Press BACKSPACE to RESTART";

    }
    void state_mr1()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_mr2()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_mr3()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_ml1()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_ml2()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_ml3()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
    void state_wrong()
    {
        text.text = "Press ENTER to START";
        help.text = "";

    }
}
