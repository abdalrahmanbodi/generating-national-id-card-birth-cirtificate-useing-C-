using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    class customer
    {
        private string n_id,first_Name, second_Name, mother_Name, father_iD, mmother_iD, national, place, gender, religion, year,day, month;
        
        public customer()
        {   
            n_id="";
            first_Name = "";
            second_Name = "";
            mother_Name = "";
            father_iD = "";
            mmother_iD = "";
            national = "";
            place = "";
            gender = "";
            year = "";
            religion = "";
            day = "";
            month = "";
        }
        public customer(string i,string f, string s, string mN, string fd, string md, string n, string p, string g, string y, string r, string d, string m)
        {
            n_id = i;
            first_Name = f;
            second_Name = s;
            mother_Name = mN;
            father_iD = fd;
            mmother_iD = md;
            national = n;
            place = p;
            gender = g;
            year = y;
            religion = r;
            day = d;
            month = m;
        }

        public string N_id { get; set; }

        public string First
        {
            get{return first_Name;}
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    first_Name = "";
                }
                else { first_Name = value; }
            }
        }
        public string Second
        {
            get { return second_Name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    second_Name = "";
                }
                else { second_Name = value; }
            }
        }
        public string Mother
        {
            get { return mother_Name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    mother_Name = "";
                }
                else { mother_Name = value; }
            }
        }
        public string Father
        {
            get { return father_iD; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    father_iD = "";
                }
                else
                {
                    father_iD = value;
                }


            }
        }
        public string Mmother
        {
            get { return mmother_iD; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    mmother_iD = "";
                }
                else { mmother_iD = value; }
            }
        }
        public string National
        {
            get { return national; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    national = "";
                }
                else { national = value; }
            }
        }
        public string Place
        {
            get { return place; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    place = "";
                }
                else { place = value; }
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    gender = "";
                }
                else { gender = value; }
            }
        }
        public string Religion
        {
            get { return religion; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    religion = "";
                }
                else { religion = value; }
            }
        }
        public string Year
        {
            get { return year; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    year = "";
                }
                else { year = value; }
            }
        }
        public string Day
        {
            get { return day; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    day = "";
                }
                else { day = value; }
            }
        }
        public string Month
        {
            get { return month; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    month = "";
                }
                else { month = value; }
            }
        }
        //FUNCTION TO CHECK DEGIT
        public bool check_digit(string s)
        {
            bool check;
            long n;
            //if (!(int.TryParse(s, out n)))
            if (!(long.TryParse(s, out n)))
            {
                check = false;
            }
            else check = true;
            return check;
        }






    }



}