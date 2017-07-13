using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, string> stocks = new Dictionary <string, string>();
            stocks.Add("AAPL", "Apple");
            stocks.Add("MSFT", "Microsoft");
            stocks.Add("SNAP", "Snap Inc.");
            stocks.Add("AMZN", "Amazon Inc.");
            stocks.Add("WMT", "Walmart Stores Inc.");

            List <(string ticker, int shares, double price)> purchases = new List <(string, int, double)>();
            purchases.Add((ticker: "AAPL", shares: 10, price: 1000.21));
            purchases.Add((ticker: "MSFT", shares: 150, price: 220.51));
            purchases.Add((ticker: "MSFT", shares: 500, price: 224.98));
            purchases.Add((ticker: "SNAP", shares: 1000, price: 30.90));
            purchases.Add((ticker: "AMZN", shares: 160, price: 286.17));
            purchases.Add((ticker: "AAPL", shares: 110, price: 998.11));
            purchases.Add((ticker: "WMT", shares: 50, price: 50.21));
            purchases.Add((ticker: "WMT", shares: 250, price: 51.88));
            purchases.Add((ticker: "AAPL", shares: 150, price: 1021.88));
            purchases.Add((ticker: "AMZN", shares: 19, price: 290.56));

            Dictionary <string, double> valuations = new Dictionary <string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases) 
            {
                string companyName = stocks[purchase.ticker];
                if (!valuations.ContainsKey(companyName)) 
                {
                    double companyValuation = purchase.shares * purchase.price;
                    valuations.Add(companyName, companyValuation);
                } 
                else 
                {
                    valuations[companyName] = valuations[companyName] + (purchase.shares * purchase.price);
                }
            }
            foreach (KeyValuePair<string, double> valuation in valuations)
            {
                Console.WriteLine("The value of {0} is ${1}", valuation.Key, valuation.Value);
            }
        }
    }
}
