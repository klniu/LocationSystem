﻿using LocationServices.Locations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Location.TModel.Location.Data;
using TEntity = Location.TModel.Location.Data.TagPosition;
using Location.TModel.LocationHistory.Data;

namespace WebApiService.Controllers
{
    [RoutePrefix("api/pos")]
    public class PosController : ApiController, IPosService
    {
        IPosService service;
        public PosController()
        {
            service = new PosService();
        }

        [Route("{id}")]
        public TEntity Delete(string id)
        {
            return service.Delete(id);
        }

        [Route("")]//area/?id=1
        [Route("{id}")]
        public TEntity GetEntity(string id)
        {
            return service.GetEntity(id);
        }

        [Route("")]
        [Route("list")]
        public List<TEntity> GetList()
        {
            return service.GetList();
        }

        [Route("")]//search/?name=主
        [Route("search/{tag}")]//search/1,直接中文不行
        public IList<TEntity> GetListByName(string tag)
        {
            return service.GetListByName(tag);
        }

        [Route("")]//search/?name=主
        [Route("search/{person}")]//search/1,直接中文不行
        public IList<TEntity> GetListByPerson(string person)
        {
            return service.GetListByPerson(person);
        }

        [Route("")]//search/?name=主
        [Route("search/{area}")]//search/1,直接中文不行
        public IList<TEntity> GetListByArea(string area)
        {
            return service.GetListByArea(area);
        }

        [Route]
        public TEntity Post(TEntity item)
        {
            return service.Post(item);
        }

        [Route]
        public TEntity Put(TEntity item)
        {
            return service.Put(item);
        }
    }
}
