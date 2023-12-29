using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    bool flagText0 = false;
    bool flagText1 = false;
    bool flagText2 = false; 
    bool flagText3 = false; 
    bool flagText4 = false; 
    bool flagText5 = false; 
    bool flagText6 = false;
    bool flagText7 = false;
    bool flagText8 = false;
    bool flagText9 = false;
    bool flagText10 = false;

    public GameObject Text0;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public GameObject Text8;
    public GameObject Text9;
    public GameObject Text10;
  
    // Start is called before the first frame update
    void Start()
    {
        Text0.SetActive(false);
        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Text4.SetActive(false);
        Text5.SetActive(false);
        Text6.SetActive(false);
        Text7.SetActive(false);
        Text8.SetActive(false);
        Text9.SetActive(false);
        Text10.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float dis0 = (this.transform.position - Text0.transform.position).sqrMagnitude;
        if (!(flagText0) && dis0 <= 20.0f)
        {
            Text0.SetActive(true);
            flagText0 = true;
        }
        if (flagText0 && dis0 > 20.0f)
        {
            Text0.SetActive(false);
            flagText0 = false;
        }


        float dis1 = (this.transform.position - Text1.transform.position).sqrMagnitude;
        if (!(flagText1) && dis1 <= 20.0f)
        {
            Text1.SetActive(true);
            flagText0 = true;
        }
        if (flagText1 && dis1 > 20.0f)
        {
            Text1.SetActive(false);
            flagText0 = false;
        }

        float dis2 = (this.transform.position - Text2.transform.position).sqrMagnitude;
        if (!(flagText2) && dis2 <= 20.0f)
        {
            Text2.SetActive(true);
            flagText2 = true;
        }
        if (flagText2 && dis2 > 20.0f)
        {
            Text2.SetActive(false);
            flagText2 = false;
        }


        float dis3 = (this.transform.position - Text3.transform.position).sqrMagnitude;
        if (!(flagText3) && dis3 <= 20.0f)
        {
            Text3.SetActive(true);
            flagText3 = true;
        }
        if (flagText3 && dis3 > 20.0f)
        {
            Text3.SetActive(false);
            flagText3 = false;
        }


        float dis4 = (this.transform.position - Text4.transform.position).sqrMagnitude;
        if (!(flagText4) && dis4 <= 20.0f)
        {
            Text4.SetActive(true);
            flagText4 = true;
        }
        if (flagText4 && dis4 > 20.0f)
        {
            Text4.SetActive(false);
            flagText4 = false;
        }


        float dis5 = (this.transform.position - Text5.transform.position).sqrMagnitude;
        if (!(flagText5) && dis5 <= 20.0f)
        {
            Text5.SetActive(true);
            flagText5 = true;
        }
        if (flagText5 && dis5 > 20.0f)
        {
            Text5.SetActive(false);
            flagText5 = false;
        }


        float dis6 = (this.transform.position - Text6.transform.position).sqrMagnitude;
        if (!(flagText6) && dis6 <= 20.0f)
        {
            Text6.SetActive(true);
            flagText6 = true;
        }
        if (flagText6 && dis6 > 20.0f)
        {
            Text6.SetActive(false);
            flagText6 = false;
        }


        float dis7 = (this.transform.position - Text7.transform.position).sqrMagnitude;
        if (!(flagText7) && dis7 <= 20.0f)
        {
            Text7.SetActive(true);
            flagText7 = true;
        }
        if (flagText7 && dis7 > 20.0f)
        {
            Text7.SetActive(false);
            flagText7 = false;
        }


        float dis8 = (this.transform.position - Text8.transform.position).sqrMagnitude;
        if (!(flagText8) && dis8 <= 20.0f)
        {
            Text8.SetActive(true);
            flagText8 = true;
        }
        if (flagText8 && dis8 > 20.0f)
        {
            Text8.SetActive(false);
            flagText8 = false;
        }


        float dis9 = (this.transform.position - Text9.transform.position).sqrMagnitude;
        if (!(flagText9) && dis9 <= 20.0f)
        {
            Text9.SetActive(true);
            flagText9 = true;
        }
        if (flagText9 && dis9 > 20.0f)
        {
            Text9.SetActive(false);
            flagText9 = false;
        }


        float dis10 = (this.transform.position - Text10.transform.position).sqrMagnitude;
        if (!(flagText10) && dis10 <= 20.0f)
        {
            Text10.SetActive(true);
            flagText10 = true;
        }
        if (flagText10 && dis10 > 20.0f)
        {
            Text10.SetActive(false);
            flagText10 = false;
        }
       
    }
}
