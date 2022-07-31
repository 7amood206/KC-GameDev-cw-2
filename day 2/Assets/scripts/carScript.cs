using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    string heroName = "gon";
    int heroHeight = 154;
    int heroAge = 12;
    string heroSuperPower = "Super speed";

    string villianName = "hisoka";
    int villianHeight = 187;
    int villianAge = 28;
    string villianSuperPower = "fights with cards";
    int ageDifference = villianAge - heroAge;
    print(ageDifference);
    print("hero info:");
    print("hero name:" + heroName);
    print("hero height:" + heroHeight);
    print("hero age:" + heroAge);
    print("hero SuperPower:" + heroSuperPower);


    print("villian info:");
    print("villian name:" + villianName);
    print("villian hieght:" + villianHeight);
    print("villian age:" + villianAge);
    print("villian SuperPower:" + villianSuperPower);

    heroHeight = heroHeight + 5;
    villianSuperPower = "None";

    print(ageDifference);
    print("hero info:");
    print("hero name:" + heroName);
    print("hero height:" + heroHeight);
    print("hero age:" + heroAge);
    print("hero SuperPower:" + heroSuperPower);


    print("villian info:");
    print("villian name:" + villianName);
    print("villian hieght:" + villianHeight);
    print("villian age:" + villianAge);
    print("villian SuperPower:" + villianSuperPower);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
