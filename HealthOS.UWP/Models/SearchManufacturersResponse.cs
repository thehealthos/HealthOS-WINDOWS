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
    public class SearchManufacturersResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int manufacturerId;
        private string name;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("manufacturer_id")]
        public int ManufacturerId 
        { 
            get 
            {
                return this.manufacturerId; 
            } 
            set 
            {
                this.manufacturerId = value;
                onPropertyChanged("ManufacturerId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
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