using System.Text.RegularExpressions;
using System;

namespace BankUI
{
    public class Validation
    {

        //Validating string input
        public bool ValString(string s)
        {
            var chars = s.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                if (!Char.IsLetter(chars[i]))
                {
                    return false;
                }
                else continue;
            }
            return true;
        }

        //Validating ID Card inputs
        public bool ValIDNum(string id)
        {
            /*
             * [0-9] checks if there are these characters first
             * {7} runs the previous command 7 times
             * [M|G|L|A] checks that the end of the string has one of these 4 characters
            */
            return Regex.IsMatch(id, "([0-9]{7}[M|G|L|A])");
        }

        //Valudating Int input
        public bool ValInt(string i)
        {
            return int.TryParse(i, out int result);
        }
        

        //Validating Float input 
        public bool ValFloat(string f)
        {
            //int result;
            //return float.TryParse(i, out result);
            return Regex.IsMatch(f, @"^[0-9]*(?:\.[0-9]*)?$");
        }

        //since the validation for ID Cards only accepts a list of characters having 7 integers and then one of four letters, this function will make sure that all valid ID Card numbers - before validating - have 7 integers preceeding the last character
        public string IDCardFixing(string id)
        {
            int idLen = id.Length - 1;
            string idNum = id;

            switch (idLen)
            {
                case 3:
                    idNum = id.Insert(0, "0000");
                    break;
                case 4:
                    idNum = id.Insert(0, "000");
                    break;
                case 5:
                    idNum = id.Insert(0, "00");
                    break;
                case 6:
                    idNum = id.Insert(0, "0");
                    break;
                default:
                    break;
            }

            return idNum;
        }
    }
}