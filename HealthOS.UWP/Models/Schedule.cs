/*
 * HealthOS.UWP
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 02/18/2017
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HealthOS.UWP;
using HealthOS.UWP.Utilities;

namespace HealthOS.UWP.Models
{
    public class Schedule : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string category;
        private string label;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("category")]
        public string Category 
        { 
            get 
            {
                return this.category; 
            } 
            set 
            {
                this.category = value;
                onPropertyChanged("Category");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("label")]
        public string Label 
        { 
            get 
            {
                return this.label; 
            } 
            set 
            {
                this.label = value;
                onPropertyChanged("Label");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 