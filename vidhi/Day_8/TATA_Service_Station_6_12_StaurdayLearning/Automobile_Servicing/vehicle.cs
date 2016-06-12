using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;

namespace Automobile_Servicing
{
    public class Vehicle
    {
        private string number;
        private string manufacturer;
        private DateTime man_date;
        private string model;
        public CRM.Customer Owner;
        static int count;
        public Vehicle()
        {
            count++;
        }//Ctor Called

        public Vehicle(string num,string man,DateTime time,string mod,CRM.Customer cust)
        {
            this.number = num;
            this.manufacturer = man;
            this.man_date = time;
            this.model = mod;
            CRM.Customer Owner = cust;
            count++;

        }//End of parameterized ctor
       
        public static int GetCountVehicle()
        {
            return count;
        }//End of static int GetCountVehicle

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }//property of Manufacurer

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }//Propery of Model

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value != "TATA")
                    throw new ArgumentException("INVALID NAME");
                else
                    this.model = value;}
        }//Propery of Model

        public override string ToString()
        {
            return number + " " + manufacturer + " " + man_date + " " + model;

        }//
        //Static variable
        ~Vehicle()
        {
            count--;
        }//End of dtor

    }//End of vehicle 
}//End of Automoble_Servicing
