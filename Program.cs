using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;

namespace JsonWith.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>()
            {
                new Customer()
                {
                    CustomerName ="Micle",
                    CustomerEmail="micle@gmail.com",
                    Age=23,
                    TotalSales=2000,
                    FinalBranchDate=new DateTime(2023,7,31)

                },
                      new Customer()
                {
                    CustomerName ="Jone",
                    CustomerEmail="jone@gmail.com",
                    Age=25,
                    TotalSales=3000,
                    FinalBranchDate=new DateTime(2022,7,30)

                },
                            new Customer()
                {
                    CustomerName ="peter",
                    CustomerEmail="peter@gmail.com",
                    Age=30,
                    TotalSales=5000,
                    FinalBranchDate=new DateTime(2023,7,25)

                }

            };


            #region SerializeObject
            //SerializeObject
            //var CustomerJson =JsonConvert.SerializeObject(Customers);

            //Console.WriteLine(CustomerJson); 
            #endregion


            #region DeSerializeObject

            var jsonString = "[{\"Customer_Name\":\"Micle\",\"CustomerEmail\":\"micle@gmail.com\",\"Age\":23,\"TotalSales\":2000.0,\"FinalBranchDate\":\"2023-07-31T00:00:00\"},{\"Customer_Name\":\"Jone\",\"CustomerEmail\":\"jone@gmail.com\",\"Age\":25,\"TotalSales\":3000.0,\"FinalBranchDate\":\"2022-07-30T00:00:00\"},{\"Customer_Name\":\"peter\",\"CustomerEmail\":\"peter@gmail.com\",\"Age\":30,\"TotalSales\":5000.0,\"FinalBranchDate\":\"2023-07-25T00:00:00\"}]";

            var CustomersList = JsonConvert.DeserializeObject<List<Customer>>(jsonString);

            Console.WriteLine(CustomersList);
            Console.ReadKey();

            #endregion




        }


        [Serializable]
        private class Customer
        {
            [JsonProperty("Customer_Name")]
            public string CustomerName { get; set; }
            public string CustomerEmail { get; set; }
            public int Age { get; set; }
            public decimal TotalSales { get; set; }

            public DateTime FinalBranchDate { get; set; }
        }

    }
}
