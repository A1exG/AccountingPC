using Accounting.Model.EntityLibrary.Entityes.Computers;
using Accounting.WebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Accounting.WebAPI.Controllers
{
    /// <summary>
    /// Контроллер для обработки компьютеров
    /// </summary>
    public class ComputerController : ApiController
    {
        private readonly ComputerRepository _computerRepository = new ComputerRepository();

        /// <summary>
        /// Получить список всех компьютеров
        /// </summary>
        /// <returns>Список всех компьютеров</returns>
        public List<Computer> Get()
        {
            return _computerRepository.Get();
        }

        //[Route("api/Computer/GetComputerDisplayNames/{displayName:string}")]
        //[HttpGet]
        //public List<Computer> GetComputerDisplayNames(string displayName)
        //{
        //    List<Computer> output = new List<Computer>();
        //    foreach (var c in _computerRepository.Get())
        //    {
        //        output.Add(c);
        //    }
        //    return output;
        //}

        
            /// <summary>
            /// Компьютер по id
            /// </summary>
            /// <param name="id">Id компьютера</param>
            /// <returns>Компьютер</returns>
        public Computer Get(int id)
        {
            return _computerRepository.GetByID(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="comp"></param>
        public void Post(Computer comp)
        {
            _computerRepository.Post(comp);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            _computerRepository.Delete(id);
        }
    }
}
