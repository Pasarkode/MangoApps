using MangoApps.Application;
using MangoApps.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps.UI.ConsoleApplication
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World :D");
        }
        static void MainTestDeleteEntity(string[] args)
        {
            CustomerService srvc = new CustomerService("Customer");
            CustomerBase data = null;
            try
            {
                data = srvc.GetById(4);
                srvc.Delete(data);
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void MainTestSearch(string[] args)
        {
            CustomerService srvc = new CustomerService("Customer");
            CustomerBase data = null;
            try
            {
                var ListCust = srvc.Search("Nurul Hadi");
                //var ListCust = srvc.Search("PKP");
                foreach (var item in ListCust)
                {
                    Console.WriteLine("Customer Name => {0} PKPStatus => {1}", item.CustomerName, item.PKPStatus);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void MainTestSearchCustomerNonPKP(string[] args)
        {
            CustomerService srvc = new CustomerService("Customer");
            CustomerBase data = null;
            try
            {
                var ListCust = srvc.SearchCustNonPkp("Nurul Hadi");
                foreach (var item in ListCust)
                {
                    Console.WriteLine("Customer Name => {0} PKPStatus => {1}", item.CustomerName, item.PKPStatus);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void MainTestSearchCustomerPKP(string[] args)
        {
            CustomerService srvc = new CustomerService("Customer");
            CustomerBase data = null;
            try
            {
                var ListCust = srvc.SearchCustPkp("Nurul Hadi");
                foreach (var item in ListCust)
                {
                    Console.WriteLine("Customer Name => {0} PKPStatus => {1}", item.CustomerName, item.PKPStatus);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void MainTestGetAll(string[] args)
        {
            CustomerService srvc = new CustomerService("Customer");
            try
            {
                var ListCust = srvc.GetAll();
                foreach (var item in ListCust)
                {
                    Console.WriteLine("Customer Name => {0} PKPStatus => {1}", item.CustomerName, item.PKPStatus);
                }
                //Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void MainTestSaveCustomerNonPKP(string[] args)
        {
            CustomerService srvc = new CustomerService("Customer");
            CustomerBase data = null;
            try
            {
                data = srvc.Instance("NonPKP");
                data.CustomerName = "Nurul Hadi";
                data.Gender = "Laki laki";
                data.Address = "jl Raya pamayahan, Indramayu";
                data.PKPStatus = "NonPKP";
                //data.Tempo = 40; Temp Can't more than 30 in PKP
                data.Tempo = 5;
                data.Validate();
                srvc.Save(data);
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void MainTestSaveCustomerPKP(string[] args)
        {
            CustomerService srvc = new CustomerService("Customer");
            CustomerBase data = null;
            try
            {
                data = srvc.Instance("PKP");
                data.CustomerName = "Nurul Hadi";
                data.Gender = "Laki laki";
                data.Address = "jl Raya pamayahan, Indramayu";
                data.PKPStatus = "PKP";
                //data.Tempo = 10; Temp Can't more than 10 in NonPKP
                data.Tempo = 20;
                data.Validate();
                srvc.Save(data);
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void MainTestUpdateEntity(string[] args)
        {
            CustomerService srvc = new CustomerService("Customer");
            CustomerBase data = null;
            try
            {
                data = srvc.GetById(1);
                data.Address = "Test";
                srvc.Save(data);
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void MainTestValidationForCustomerNonPKP(string[] args)
        {
            CustomerService srvc = new CustomerService("Customer");
            CustomerBase data = null;
            try
            {
                data = srvc.Instance("NonPKP");
                data.CustomerName = "Nurul Hadi";
                data.Gender = "Laki laki";
                data.Address = "jl Raya pamayahan, Indramayu";
                data.PKPStatus = "NonPKP";
                //data.Tempo = 10; Temp Can't more than 10 in NonPKP
                data.Tempo = 12;
                data.Validate();
                Console.WriteLine("Success validate");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void MainTestValidationForCustomerPKP(string[] args)
        {
            CustomerService srvc = new CustomerService("Customer");
            CustomerBase data = null;
            try
            {
                data = srvc.Instance("PKP");
                data.CustomerName = "Nurul Hadi";
                data.Gender = "Laki laki";
                data.Address = "jl Raya pamayahan, Indramayu";
                data.PKPStatus = "PKP";
                //data.Tempo = 40; Temp Can't more than 30 in PKP
                data.Tempo = 30;
                data.Validate();
                Console.WriteLine("Success validate");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
