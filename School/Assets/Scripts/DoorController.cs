using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    bool flagdoor01 = false;
    bool flagdoor02 = false;
    bool flagdoorLQ = false;
    bool flagdoorLQ1 = false;
    bool flagdoorKitchen = false;
    public GameObject door01;
    public GameObject door02;
    public GameObject doorLQ;
    public GameObject doorLQ1;
    public GameObject doorKitchen;
    void Update()
    {
        float dis01 = (this.transform.position - door01.transform.position).sqrMagnitude;
        if (!(flagdoor01) && dis01 <= 20.0f)
        {
            door01.GetComponent<Animation>().Play("DoorOpen01");
            flagdoor01 = true;
        }
        if (flagdoor01 && dis01 > 20.0f)
        {
            door01.GetComponent<Animation>().Play("DoorClose01");
            flagdoor01 = false;
        }


        float dis02 = (this.transform.position - door02.transform.position).sqrMagnitude;
        if (!(flagdoor02) && dis02 <= 20.0f)
        {
            door02.GetComponent<Animation>().Play("DoorOpen02");
            flagdoor02 = true;
        }
        if (flagdoor02 && dis02 > 20.0f)
        {
            _ = door02.GetComponent<Animation>().Play("DoorClose02");
            flagdoor02 = false;
        }


        float disLQ = (this.transform.position - doorLQ.transform.position).sqrMagnitude;
        if (!(flagdoorLQ) && disLQ <= 20.0f)
        {
            doorLQ.GetComponent<Animation>().Play("DoorOpenLQ");
            flagdoorLQ = true;
        }
        if (flagdoorLQ && disLQ > 20.0f)
        {
            _ = doorLQ.GetComponent<Animation>().Play("DoorCloseLQ");
            flagdoorLQ = false;
        }

        float disLQ1 = (this.transform.position - doorLQ1.transform.position).sqrMagnitude;
        if (!(flagdoorLQ1) && disLQ1 <= 20.0f)
        {
            doorLQ1.GetComponent<Animation>().Play("DoorClose02");
            flagdoorLQ1 = true;
        }
        if (flagdoorLQ1 && disLQ1 > 20.0f)
        {
            _ = doorLQ1.GetComponent<Animation>().Play("DoorOpen02");
            flagdoorLQ1 = false;
        }

        float disKitchen = (this.transform.position - doorKitchen.transform.position).sqrMagnitude;
        if (!(flagdoorKitchen) && disKitchen <= 20.0f)
        {
            doorKitchen.GetComponent<Animation>().Play("DoorOpen(kitchen)");
            flagdoorKitchen = true;
        }
        if (flagdoorKitchen && disKitchen > 20.0f)
        {
            _ = doorKitchen.GetComponent<Animation>().Play("DoorClose(kitchen)");
            flagdoorKitchen = false;
        }
    }
}

