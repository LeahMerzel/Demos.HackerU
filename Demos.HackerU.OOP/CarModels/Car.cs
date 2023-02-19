using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Demos.HackerU.OOP.CarModels.Enums;

namespace Demos.HackerU.OOP.CarModels
{
    public class Car
    {

         #region --fields--
        private string idNum;
        private string manufactor;
        private Colors color;
        private int model;
        private List<Wheel> Wheels;
        private Engine eng;
        #endregion

        #region --Constractor--


        //public Car()
        //{
        //    idNum = "000-00-000";
        //    manufactor = "";
        //    color = Colors.White;
        //    model = 23;
        //}


        public Car() : 
            this("00-000-00", "", Colors.White, 18)
        {
            
        }

       
        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="idNum"></param>
        /// <param name="manufactor"></param>
        /// <param name="color"></param>
        /// <param name="model"></param>
        public Car(string idNum, string manufactor, Colors color, int model)
        {
            this.idNum = Validation.ValidateSetIdNum(idNum);
            this.manufactor = manufactor;
            this.color = color;
            this.model = model;
            this.Wheels = new List<Wheel>();
            
        }



        #endregion

         #region --Props--
        public string IdNum { get => idNum; }
        public string Manufactor { get => manufactor; set => manufactor = value; }
        public Colors Color { get => color; set => color = value; }
        public int Model { get => model; set => model = value; }
        public Engine Eng { get => eng; set => eng = value; }
        #endregion


        public void  AddWheel(Wheel newWheel)
        {
            this.Wheels.Add(newWheel);
        }

        internal void DisplayToConsole()
        {
            //TODO WRITE TO CONSOLE
        }

        public string GetAsText()
        {
            string txt = "";
            foreach (Wheel item in this.Wheels)
            {
                txt += $"Koter:{item.Koter},Year:{item.Year}\n";
            }

            return txt;
        }



        internal void SaveToFile(string file)
        {
           //TODO
        }

        public override string ToString()
        {
            return idNum +" "+ Manufactor+" " + " "+color;
        }



    }
}
