using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainstuff : MonoBehaviour
{

    public GameObject myPrefab;
    public CapsuleCollider2D prefcol;

    // there are better ways to do this, but I don't have the time to learn right now
    public SpriteRenderer tank;
   // public ParticleSystem tankpart;
    public Animator tankanim;

    public SpriteRenderer thethingy;
    public  Sprite img1;
    public  Sprite img2;
    public Sprite img3;

    public Collider2D tankcol;

    public double life = 100;
    public SpriteRenderer lbar;

    public ParticleSystem batparts;

    public SpriteRenderer plantlol;

    public int tanklives = 10;

    public Animator sunlol;

    public double water = 10.0;
    public SpriteRenderer bar;

    public ParticleSystem partgisk;

    public int tool = 1;
    // 1 - giess
    // 2 - crosshair

    public double time = 0;

    public void setTool(int a)
    {
        tool = a;
        partgisk.enableEmission = false;
        if (tool == 1)
        {
            thethingy.sprite = img1;
        }
        else if(tool == 2)
        {
            thethingy.sprite = img2;
          //  tankanim.Play("attack");
        }
        else
        {
            thethingy.sprite = img3;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

       
       // a.set

        Time.timeScale = 1;
       // tankpart.enableEmission = false;
    }

    public void makediver()
    {
        GameObject a = Instantiate(myPrefab);
        a.name = "mypref";
    }

    public void lose()
    {

    }

    public void tankattack() // lives?
    {
        // assume in base state...
        // reset position?
        tank.transform.SetPositionAndRotation(new Vector3(-15,-1.85f,0), Quaternion.identity);
        tankanim.Play("attack");
        tanklives = 11;
    }

    public void remLife(int some)
    {
        life -= some;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            setTool(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            setTool(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            setTool(3);
        }

        //print(tankanim.GetCurrentAnimatorStateInfo(0).is);
        if (tankanim.GetCurrentAnimatorStateInfo(0).IsName("firefire"))
        {
            //tankpart.enableEmission = true; // no worky no clue why
            print("not good tnaky");
            life -= Time.deltaTime * 20;
        }
        
        if(time > (17340/60))
        {
            print("win");
            SceneManager.LoadScene("winner", LoadSceneMode.Single);
        }
        if(water < 0.01)
        {
            print("lose");
            SceneManager.LoadScene("loser", LoadSceneMode.Single);
        }
        if (life < 0)
        {
            SceneManager.LoadScene("loser", LoadSceneMode.Single);
        }

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //print(water);
        water -= Time.deltaTime * 0.1; // much faster if sun angry

        if(sunlol.GetCurrentAnimatorStateInfo(0).IsName("angry"))
        {
            water -= Time.deltaTime * 0.4;
        }

        if (tool ==1 )
        {
            if (Input.GetMouseButton(0))
            {
                if(mousePosition.x > -2 && mousePosition.x < 7)
                {
                    water += Time.deltaTime * 0.7;

                }
            }

            partgisk.enableEmission = Input.GetMouseButton(0);
            // ultra unclean yuck

        }
        if(tool == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 argh = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                GameObject a = GameObject.Find("mypref");

                if(a != null)
                {
                    CapsuleCollider2D col = a.GetComponent<CapsuleCollider2D>();

                  if (col.OverlapPoint(argh))
                 {
                      print("hmm");
                    
                      a.SendMessage("endit");
                  }
                }
                

            }
        }
        if(tool == 3)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Vector2 argh = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if (tankcol.OverlapPoint(argh))
                {
                    batparts.Emit(200);
                    tanklives -= 1;
                    if(tanklives == 0)
                    {
                        tankanim.Play("retreat");
                    }
                }
                
            }
        }
        //print(life);
        lbar.transform.localScale = new Vector3((float)(2*(life/100)), 1.4f, 1);

        water = Mathf.Clamp((float)water, 0, 10);
        bar.transform.localScale = new Vector3(0.2f, (float)water, 0);
    }
}
