using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WSwitch : MonoBehaviour
{
    public int weaponActive = 0;
    public GameObject updateUIWeaponSelected;

    void Start()
    {
        SelectWeapon();
    }


    void Update()
    {
        int previousSelectedWeapon = weaponActive;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponActive = 0;
            GameObject.Find("FPSController").GetComponent<FiringPointGun1>().enabled = true;
            GameObject.Find("FPSController").GetComponent<FiringPointGun2>().enabled = false;
            GameObject.Find("FPSController").GetComponent<FiringPointGun3>().enabled = false;
            updateUIWeaponSelected.GetComponent<Text>().text = "Precision Rifle";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            weaponActive = 1;
            GameObject.Find("FPSController").GetComponent<FiringPointGun1>().enabled = false;
            GameObject.Find("FPSController").GetComponent<FiringPointGun2>().enabled = true;
            GameObject.Find("FPSController").GetComponent<FiringPointGun3>().enabled = false;
            updateUIWeaponSelected.GetComponent<Text>().text = "Mortar";
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            weaponActive = 2;
            GameObject.Find("FPSController").GetComponent<FiringPointGun1>().enabled = false;
            GameObject.Find("FPSController").GetComponent<FiringPointGun2>().enabled = false;
            GameObject.Find("FPSController").GetComponent<FiringPointGun3>().enabled = true;
            updateUIWeaponSelected.GetComponent<Text>().text = "Laser Rifle";
        }

        if (previousSelectedWeapon != weaponActive)
        {
            SelectWeapon();
        }
    }

    void SelectWeapon ()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == weaponActive)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
