using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.CarModels
{
    public class Car
    {
        private string idNum;
        private string manufactor;
        private Colors color;
        private int model;

        /// <summary>
        /// Default Empty Constructor
        /// </summary>
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
            this.idNum = idNum;
            this.manufactor = manufactor;
            this.color = color;
            this.model = model;
        }
    }
}
