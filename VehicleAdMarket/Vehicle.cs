using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAdMarket
{
    class Vehicle
    {
        private string title;
        private string description;
        private string imgPath;
        private DateTime publishDate = DateTime.Now;
        private string brand;
        private string category;
        private int productionYear;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }   
        public string ImgPath
        {
            get { return imgPath; }
            set { imgPath = value; }
        }
        
        public DateTime PublishDate
        {
            get { return publishDate; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int ProductionYear
        {
            get { return productionYear; }
            set
            {
                if ( value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Year must be between 1900 and " + DateTime.Now.Year);
                }
                productionYear = value;
            }
        }
    }
}
