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
    public bool Soul_Crystal;
    public bool Key;
    public bool bottle;
    public bool bottle_of_blood;
    public bool broken_crystal;
    public bool crystal;
    public bool note;
    //end ITEMS//

    public enum States
    {
        gamestart,
        starthistory,
        platform,
        fall,
        cathedral,
        altar,
        book,
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
        demonsaltar,
        demonsaltarwrong,
    };

    States myState;

    // A - , S - , D - , F - , G - 

   public void Start()
    {
        
        myState = States.gamestart;
        Starttext = true;
        
    }


   public void Update()
    {
        if (Input.GetKey(KeyCode.Return) && Starttext == true)
        {
            myState = States.starthistory;
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
        else if (myState == States.book)
        {
            state_book();
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
        else if (myState == States.demonsaltar)
        {
            state_demonsaltar();
        }
        else if (myState == States.demonsaltarwrong)
        {
            state_demonsaltarwrong();
        }
    }
    
    //All Game States

    void state_gamestart()
    {
        text.text = "Press ENTER to START";
        help.text = "press BACKSPACE to restart";
        bool Soul_Crystal = false;
        bool Key = false;
        bool bottle = false;
        bool bottle_of_blood = false;
        bool broken_crystal = false;
        bool crystal = false;
        bool note = false;
    }
    void state_starthistory()
    {
        text.text = "You wake up in a strange silence, you hear only the noise of empty space, strange purple haze around, you do not know what kind of place this is or how you got here, you know one thing must be some way out of here.";
        help.text = "Press SPACE to skip";
        if(Input.GetKeyDown(KeyCode.Space))
        {
            myState = States.platform;
        }
         
    }
    void state_platform()
    {


        help.text = "A - cathedral, Q - Platform Edge , W - PORTALS, E - The Machine, D - Maze, S - Demon's Altar";

        text.text = "You stand on a strange platform suspended in infinite space, the platform seems stable";

        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.cathedral;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            myState = States.fall;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.portals;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.machine;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.maze;
        }

        if (Input.GetKeyDown(KeyCode.S) && Key == true)
        {
            myState = States.demonsaltar;
        }
        if(Input.GetKeyDown(KeyCode.S) && Key == false)
        {
            myState = States.demonsaltarwrong;
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            myState = States.gamestart;
        }
    }
    void state_fall()
    {
        text.text = "You stumbled and fell into the abyss";
        help.text = "Press BACKSPACE to RESTART";

    }
    void state_cathedral()
    {
        text.text = "You are in a strange building reminiscent of the cathedral, the only thing in it is an altar and descent down to the underground ";
        help.text = "A - undergrounds , S - altar , D - platform";
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.undergrounds;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.altar;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.platform;
        }
    }
    void state_altar()
    {
        text.text = "You went to the altar, you saw a strange book on it";
        help.text = "A - look at book , S - back to cathedra's center";
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.book;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.cathedral;
        }
    }
    void state_book()
    {
        text.text = "You look at the book but you can not read the strange letters it has been written";
        help.text = "S - to stop looking at the book";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.altar;
        }
    }
    void state_undergrounds()
    {
        text.text = "W podziemiach jest cimno, zimno i wilgotnie";
        help.text = "A - abattoir, S - back to cathedral D - catacombs";
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.abattoir;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.cathedral;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.catacombs;
        }
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
    void state_demonsaltar()
    {
        text.text = "Press ENTER to START";
        help.text = "";
    }
    void state_demonsaltarwrong()
    {
        text.text = "unfortunately I have to have a key to go there";
        help.text = "S - to back on platform";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.platform;
        }

    }
}
