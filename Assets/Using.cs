using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Using : VRTK_InteractableObject {
        
        public override void StartUsing(VRTK_InteractUse usingOject)
        {
        base.StartUsing(usingObject);
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
}
