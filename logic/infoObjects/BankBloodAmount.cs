using logic.infoObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class BankBloodAmount : SqlObject
    {
        public int Id { get; set; }
        public int Aplus { get; set; }
        public int Aminus { get; set; }
        public int Bplus { get; set; }
        public int Bminus { get; set; }
        public int ABplus { get; set; }
        public int ABminus { get; set; }
        public int Oplus { get; set; }
        public int Ominus { get; set; }
        
        public BankBloodAmount(int id)
        {
            this.Id = id;
            this.parameters.Add(new SqlParameter("@Place_id", this.Id));
            this.Aplus = 0;
            this.parameters.Add(new SqlParameter("@A_plus", this.Aplus));
            this.Aminus = 0;
            this.parameters.Add(new SqlParameter("@A_minus", this.Aminus));
            this.Bplus = 0;
            this.parameters.Add(new SqlParameter("@B_plus", this.Bplus));
            this.Bminus = 0;
            this.parameters.Add(new SqlParameter("@B_minus", this.Bminus));
            this.ABplus = 0;
            this.parameters.Add(new SqlParameter("@AB_plus", this.ABplus));
            this.ABminus = 0;
            this.parameters.Add(new SqlParameter("@AB_minus", this.ABminus));
            this.Oplus = 0;
            this.parameters.Add(new SqlParameter("@O_plus", this.Oplus));
            this.Ominus = 0;
            this.parameters.Add(new SqlParameter("@O_minus", this.Ominus));
        }
        public BankBloodAmount(Dictionary<string, object> data)
        {
            this.Id = int.Parse(data["Place_id"].ToString());
            this.Aplus = int.Parse(data["A_plus"].ToString());
            this.Aminus = int.Parse(data["A_minus"].ToString());
            this.Bplus = int.Parse(data["B_plus"].ToString());
            this.Bminus = int.Parse(data["B_minus"].ToString());
            this.ABplus = int.Parse(data["AB_plus"].ToString());
            this.ABminus = int.Parse(data["AB_minus"].ToString());
            this.Oplus = int.Parse(data["O_plus"].ToString());
            this.Ominus = int.Parse(data["O_minus"].ToString());
        }

        public (string, int) GetType(string raw)
        {
            string resultStr = "";
            int resultInt = 0;
            switch (raw)
            {
                case "A+":
                    resultStr = "A_plus";
                    resultInt = this.Aplus;
                    break;
                case "A-":
                    resultStr = "A_minus";
                    resultInt = this.Aminus;
                    break;
                case "B+":
                    resultStr = "B_plus";
                    resultInt= this.Bplus;
                    break;
                case "B-":
                    resultStr = "B_minus";
                    resultInt = this.Bminus;
                    break;
                case "AB+":
                    resultStr = "AB_plus";
                    resultInt = this.ABplus;
                    break;
                case "AB-":
                    resultStr = "AB_minus";
                    resultInt = this.ABminus;
                    break;
                case "O+":
                    resultStr = "O_plus";
                    resultInt = this.Oplus;
                    break;
                case "O-":
                    resultStr = "O_minus";
                    resultInt = this.Ominus;
                    break;
            }
            return (resultStr, resultInt);
        }
        public override int GetHashCode()
        {
            return 8;
        }
    }
}
