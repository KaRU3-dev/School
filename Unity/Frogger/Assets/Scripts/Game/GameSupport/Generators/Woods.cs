using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FloggerGame.Generators
{
    public class Woods : MonoBehaviour
    {
        // Wood objects
        [Header("Woods")]
        [Tooltip("Short Left to Right")][SerializeField] GameObject Woods1;
        [Tooltip("Long Left to Right")][SerializeField] GameObject Woods2;
        [Tooltip("Short Right to Left")][SerializeField] GameObject Woods3;
        [Tooltip("Long Right to Left")][SerializeField] GameObject Woods4;

        // Clav objects
        [Header("Clabs")]
        [Tooltip("Short Left to Right")][SerializeField] GameObject Clab1;
        [Tooltip("Long Left to Right")][SerializeField] GameObject Clab2;
        [Tooltip("Short Right to Left")][SerializeField] GameObject Clab3;
        [Tooltip("Long Right to Left")][SerializeField] GameObject Clab4;

        // Generate pos
        [Header("Generate position")]
        [Tooltip("Left upper")][SerializeField] GameObject pos1;
        [Tooltip("Left lower")][SerializeField] GameObject pos2;
        [Tooltip("Right upper")][SerializeField] GameObject pos3;
        [Tooltip("Right lower")][SerializeField] GameObject pos4;


        public void Generator()
        {
            int posSelect = wood_support.Selector(5);

            int objSelect = wood_support.Selector(3);

            if (objSelect == 1)
            {
                // Wood
                switch (posSelect)
                {
                    case 1:
                        int i1 = wood_support.Selector(2);
                        GameObject genObj1 = null;

                        if (i1 == 1)
                        {
                            genObj1 = Instantiate(Woods1);
                        }
                        else if (i1 == 2)
                        {
                            genObj1 = Instantiate(Woods2);
                        }

                        genObj1.transform.position = pos1.transform.position;

                        break;
                    case 2:
                        int i2 = wood_support.Selector(2);
                        GameObject genObj2 = null;

                        if (i2 == 1)
                        {
                            genObj2 = Instantiate(Woods1);
                        }
                        else if (i2 == 2)
                        {
                            genObj2 = Instantiate(Woods2);
                        }

                        genObj2.transform.position = pos2.transform.position;

                        break;
                    case 3:
                        int i3 = wood_support.Selector(2);
                        GameObject genObj3 = null;

                        if (i3 == 1)
                        {
                            genObj3 = Instantiate(Woods3);
                        }
                        else if (i3 == 2)
                        {
                            genObj3 = Instantiate(Woods4);
                        }

                        genObj3.transform.position = pos2.transform.position;

                        break;
                    case 4:
                        int i4 = wood_support.Selector(2);
                        GameObject genObj4 = null;

                        if (i4 == 1)
                        {
                            genObj4 = Instantiate(Woods3);
                        }
                        else if (i4 == 2)
                        {
                            genObj4 = Instantiate(Woods4);
                        }

                        genObj4.transform.position = pos2.transform.position;

                        break;
                    default:
                        break;
                }

            }
            else if (objSelect == 2)
            {
                // Clab
                switch (posSelect)
                {
                    case 1:
                        int i1 = wood_support.Selector(2);
                        GameObject genObj1 = null;

                        if (i1 == 1)
                        {
                            genObj1 = Instantiate(Clab1);
                        }
                        else if (i1 == 2)
                        {
                            genObj1 = Instantiate(Clab2);
                        }

                        genObj1.transform.position = pos1.transform.position;

                        break;
                    case 2:
                        int i2 = wood_support.Selector(2);
                        GameObject genObj2 = null;

                        if (i2 == 1)
                        {
                            genObj2 = Instantiate(Clab1);
                        }
                        else if (i2 == 2)
                        {
                            genObj2 = Instantiate(Clab2);
                        }

                        genObj2.transform.position = pos2.transform.position;

                        break;
                    case 3:
                        int i3 = wood_support.Selector(2);
                        GameObject genObj3 = null;

                        if (i3 == 1)
                        {
                            genObj3 = Instantiate(Clab3);
                        }
                        else if (i3 == 2)
                        {
                            genObj3 = Instantiate(Clab4);
                        }

                        genObj3.transform.position = pos2.transform.position;

                        break;
                    case 4:
                        int i4 = wood_support.Selector(2);
                        GameObject genObj4 = null;

                        if (i4 == 1)
                        {
                            genObj4 = Instantiate(Woods3);
                        }
                        else if (i4 == 2)
                        {
                            genObj4 = Instantiate(Woods4);
                        }

                        genObj4.transform.position = pos2.transform.position;

                        break;
                    default:
                        break;
                }
            }
            else
            {
                // Wood
            }
        }
    }
}
