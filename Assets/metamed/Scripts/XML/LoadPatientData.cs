using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//By Stefan. Used to attach a patient script to the patient gameobjects. 

public class LoadPatientData : MonoBehaviour {
    public PatientPerson adult; //IF HAVING ERROR CHECK IF THESE ARE FILLED IN. 
    public PatientPerson child;
    public PatientPerson Adult;
    public PatientPerson senior;

    protected Patient patient;
    protected Patient unknownPatient;

    // Use this for initialization
    public void Start () {

        patient = XMLData.appData.mPatients[XMLData.scenario.mPatientID];
        adult.Reset();
        child.Reset();
        Adult.Reset();
        senior.Reset();

        switch (patient.mType)
        {
            case PatientType.adult:
                adult.patient = patient;
                break;
            case PatientType.child:
                child.patient = patient;
                break;
            case PatientType.Adult:
                Adult.patient = patient;
                break;
            case PatientType.senior:
                senior.patient = patient;
                break;
            default:
                Debug.Log("Unknown patienttype... Fix XML");
                break;
        }
	}
}
