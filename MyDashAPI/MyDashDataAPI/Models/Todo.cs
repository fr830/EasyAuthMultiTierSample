﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace MyDashDataAPI.Models
{
    public partial class Todo
    {
        private string _description;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _owner;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Todo class.
        /// </summary>
        public Todo()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken descriptionValue = inputObject["Description"];
                if (descriptionValue != null && descriptionValue.Type != JTokenType.Null)
                {
                    this.Description = ((string)descriptionValue);
                }
                JToken idValue = inputObject["ID"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.ID = ((int)idValue);
                }
                JToken ownerValue = inputObject["Owner"];
                if (ownerValue != null && ownerValue.Type != JTokenType.Null)
                {
                    this.Owner = ((string)ownerValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Todo
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Description != null)
            {
                outputObject["Description"] = this.Description;
            }
            if (this.ID != null)
            {
                outputObject["ID"] = this.ID.Value;
            }
            if (this.Owner != null)
            {
                outputObject["Owner"] = this.Owner;
            }
            return outputObject;
        }
    }
}
