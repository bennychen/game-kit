﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Beetle23
{
    public abstract class ScriptableItem : ScriptableObject, IItem
    {
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        [SerializeField]
        private string _name;

        [SerializeField]
        private string _description;

        [SerializeField]
        private string _id;
    }
}
