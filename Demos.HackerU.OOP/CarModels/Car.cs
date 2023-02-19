using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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
        #endregion


        public void  AddWheel(Wheel newWheel)
        {
            this.Wheels.Add(newWheel);
        }


    }
}
