using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int count;
    public int ambulance;
    public Text text;
    
    private void Start()
    {
        count = 0;
        ambulance = 0;
    }

    // Update is called once per frame
    public void ButClick()
    {
        count ++;
        if (count == 1) {text.text = "Я буду вашим экзаменатором. Можете приступать. Помните, ваше время ограничено, важно успеть все до того, как таймер закончится.";};
        if (count == 2) {text.text = "Итак, вы врач своей специальности. Медсестра вызвала вас на помощь. Перед Вами пациент 45 лет (приблизительный вес 60 кг, рост 165 см). На этаже есть укладка экстренной медицинской помощи и мануальный дефибриллятор.";};
        if (count == 3) {text.text = "Медсестра – Ваш помощник, недавно приступила к работе, информации о причинах резкого ухудшения состояния пациента не имеет. Она будет выполнять по Вашему назначению манипуляции, входящие в её компетенцию.";};
        //Debug.Log(text.text);
    }

    public void Ambulance()
    {
        ambulance ++;
        if (ambulance == 1) {text.text = "Я буду выступать в качестве диспетчера скорой помощи. Итак, скорая помощь слушает, что у Вас случилось?";};
        if (ambulance == 2) {text.text = "Представиться, назвать должность.\bНазвать адрес.\bНазвать возраст и пол пациента.\bОпределить предварительный диагноз.\bУказать информацию об основных витальных функциях.";};
        //Debug.Log(text.text);
    }
}
