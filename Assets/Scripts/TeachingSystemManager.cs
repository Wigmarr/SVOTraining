using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeachingSystemManager : MonoBehaviour
{
    [SerializeField] private GameObject[] waterPipes;
    [SerializeField] private GateSystem gateSystem;
    [SerializeField] private GameObject pump;
    [SerializeField] private GameObject cooler;
    [SerializeField] private GameObject filter;
    [SerializeField] private GameObject comp;
    [SerializeField] private GameObject UIPanel;
    [SerializeField] private GameObject system;
   // [SerializeField] private GameObject resultPanel;
    [SerializeField] private bool practiceMode = true;

    private SystemMode systemMode = SystemMode.defaultMode;
    private void Start()
    {
        if (practiceMode)
        {
            system.SetActive(false);
            //modeSelectionPanel.SetActive(true);
            UIPanel.SetActive(false);
           // resultPanel.SetActive(false);
        }
    }
    public enum SystemMode
    {
        defaultMode,
        startMode,
        prepareMode,
        filterMode,
        exitMode
    }

    public void LoadStartMode()
    {
        //title.text = "Приведите систему в исходное состояние";
        systemMode = SystemMode.startMode;
        LoadDefaultMode();


    }

    public void LoadPrepareMode()
    {

        LoadDefaultMode();
        //title.text = "Подготовьте систему к вводу и введите ее в действие";
        systemMode = SystemMode.prepareMode;
        comp.GetComponent<ChangeColorOnClick>().isActive = true;
        comp.GetComponent<SpriteRenderer>().color = comp.GetComponent<ChangeColorOnClick>().color;
        filter.GetComponent<ChangeColorOnClick>().isActive = true;
        filter.GetComponent<SpriteRenderer>().color = filter.GetComponent<ChangeColorOnClick>().color;
        cooler.GetComponent<ChangeColorOnClick>().isActive = true;
        cooler.GetComponent<SpriteRenderer>().color = cooler.GetComponent<ChangeColorOnClick>().color;
        gateSystem.gate8.Activate();
        gateSystem.gate17.Activate();
        gateSystem.gate19.Activate();
        gateSystem.gate20.Activate();
        gateSystem.gate21.Activate();
        gateSystem.gate22.Activate();
        gateSystem.gate23.Activate();
        gateSystem.gate35.Activate();
        gateSystem.gate36.Activate();
        gateSystem.gate38.Activate();
        gateSystem.gate33.Activate();
        gateSystem.gate28.Activate();

    }

    public void LoadFilterMode()
    {

        LoadPrepareMode();
        //title.text = "Подключите ионо-обменный фильтр";
        systemMode = SystemMode.filterMode;
        gateSystem.gate15.Activate();
        gateSystem.gate16.Activate();
        pump.GetComponent<Pump>().Activate();

    }

    public void LoadExitMode()
    {

        LoadFilterMode();
        //title.text = "Выведите систему из действия";
        systemMode = SystemMode.exitMode;
        gateSystem.gate25.Activate();

    }

    public void LoadDefaultMode()
    {
        foreach (Gate gate in gateSystem.gates)
        {
            if (gate.IsOpen())
                gate.ChangeState();
        }
        pump.GetComponent<Pump>().DeActivate();
        comp.GetComponent<ChangeColorOnClick>().isActive = false;
        comp.GetComponent<SpriteRenderer>().color = Color.white;
        filter.GetComponent<ChangeColorOnClick>().isActive = false;
        filter.GetComponent<SpriteRenderer>().color = Color.white;

    }

}
