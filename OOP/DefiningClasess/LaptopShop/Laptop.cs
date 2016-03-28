using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private double price;
        private Battery battery = new Battery();

        public Laptop(string model, double price) 
            : this(model, null, null, null, null, null, null, price, null, null)
        {
        }

        public Laptop
            (string model, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen, double price, string batteryInfo, string battetyLife)
        {
            this.Model = model;
            this.manufacturer = Manufacturer;
            this.processor = Processor;
            this.ram = Ram;
            this.graphicsCard = GraphicsCard;
            this.hdd = Hdd;
            this.screen = Screen;
            this.price = Price;
            this.Battery.GeneralInfo = batteryInfo;
            this.Battery.Life = battetyLife;
        }
        public string Model
        { 
            get 
        {
            return this.model;
        } 
            set
            {
                if (value == "") { throw new ArgumentException("The value should be a non-empty string.", "Model"); }
            }
        }
        public string Manufacturer 
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == "") {throw new ArgumentException("The value should be a non-empty string", "Manufacturer");}
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value == "") { throw new ArgumentException("The value should be a non-empty string", "Processor"); }
                this.processor = value;
            }
        }
        public string Ram
        {
            get
            {
                return this.ram;
            }
            set 
            {
                if (value == "") { throw new ArgumentException("The value should be a non-empty string", "Ram"); }
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value == "") { throw new ArgumentException("The value should be a non-empty string", "GraphicsCard"); }
                this.graphicsCard = value;
            } 
        }
        public string Hdd
        { 
            get 
            { 
            return this.hdd; 
            }
            set
            {
                if (value == "") { throw new ArgumentException("The value should be a non-empty string", "Hdd"); }
                this.hdd = value;
            }
        }
        public string Screen 
        {
            get
            {
                return this.screen;
            }
            set 
            {
                if (value == "") { throw new ArgumentException("The value should be a non-empty string", "Screen"); }
                this.screen = value;
            }
        }
        public double Price 
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0) { throw new ArgumentException("The value should be a non-empty string", "Price"); }
                this.price = value;
            }
        }
        public Battery Battery 
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public override string ToString()
        {
            string info = "Laptop info:\n";
            if (Model != null) { info += "Model: " + Model; }
            if (Manufacturer != null) { info += "\nManufacturer: " + Manufacturer; }
            if (Processor != null) { info += "\nProcessor: " + Processor; }
            if (Ram != null) { info += "\nRAM: " + Ram; }
            if (GraphicsCard != null) { info += "\nGraphicsCard: " + GraphicsCard; }
            if (Hdd != null) { info += "\nHDD: " + Hdd; }
            if (Screen != null) { info += "\nScreen: " + Screen; }
            if (Battery.GeneralInfo != null) { info += "\nBattery GeneralInfo: " + Battery.GeneralInfo; }
            if (Battery.Life != null) { info += "\nBattery Life: " + Battery.Life; }
            if (Price != 0) { info += "\nPrice: " + Price + " lv."; }
            return info;
        }
    }
}
