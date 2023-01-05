using System;
using System.Collections.Generic;
using System.Linq;
using Theatr.DAL.EF;
using Theatr.DAL.Entities;
using Theatr.DAL.Interfaces;
using Theatr.DAL.Repositories;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            EFUnitOfWork unitOfWork = new EFUnitOfWork();
            Performance p = unitOfWork.Perfomances.Get(2);
            Genre a = unitOfWork.Genres.GetById(1);
            Genre b = unitOfWork.Genres.GetById(2);
            Performance c = unitOfWork.Perfomances.Get(1);
            Genre f = unitOfWork.Genres.GetById(3);
            p.Genres.Add(a);
            p.Genres.Add(b);
            c.Genres.Add(f);
            unitOfWork.Perfomances.Update(p);
            unitOfWork.Perfomances.Update(c);
            unitOfWork.Save();

            Console.WriteLine(p.Genres.First().Name);
            
            Console.ReadLine();

        }
    }
}