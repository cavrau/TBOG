using System;
using DDDWebapi.Application.DTO;
using DDDWebapi.Application.Interfaces;
using DDDWebapi.Domain.Core.Interfaces.Services;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DDDWebapi.Application.Services
{
    public class ApplicationServiceUser : IApplicationServiceUser
    {
        private readonly IServiceUser _serviceUser;
        // private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceUser(IServiceUser serviceUser)

        {
            _serviceUser = serviceUser;
        }


        public void Add(UserDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceUser.Add(objCliente);
        }

        public void Dispose()
        {
            _serviceUser.Dispose();
        }

        public IEnumerable<UserDTO> GetAll()
        {
            var objProdutos = _serviceUser.GetAll();
            //return _mapperCliente.MapperListClientes(objProdutos);
        }

        public UserDTO GetById(int id)
        {
            var objcliente = _serviceUser.GetById(id);
            //return _mapperCliente.MapperToDTO(objcliente);
        }

        public void Remove(UserDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceUser.Remove(objCliente);
        }

        public void Update(UserDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceUser    .Update(objCliente);
        }
    }
}