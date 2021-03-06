﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Graphics {
    /// <summary>
    /// Handles the slight moving HAL logo in the main menu.
    /// This isn't complicated enough to warrent additional documentation - it works!
    /// </summary>
    public class HoverText : MonoBehaviour {
        float startY;
        public float yRange;
        public float speed;
        bool goUp;

        // Start is called before the first frame update
        private void Start() {
            startY = transform.position.y;
            goUp = true;
        }

        // Update is called once per frame
        private void Update() {
            float tempSpeed;
            if (goUp) {
                tempSpeed = speed * ((startY + yRange) - transform.position.y);
                if (tempSpeed <= speed * 0.4f)
                    tempSpeed = speed * 0.4f;

                transform.Translate(tempSpeed * transform.up);
                if (transform.position.y > (startY + yRange)) {
                    goUp = false;
                }
            }
            else {
                tempSpeed = speed * (transform.position.y - (startY - yRange));
                if (tempSpeed <= speed * 0.4f)
                    tempSpeed = speed * 0.4f;

                transform.Translate(-tempSpeed * transform.up);
                if (transform.position.y < (startY - yRange)) {
                    goUp = true;
                }
            }
        }
    }
}
