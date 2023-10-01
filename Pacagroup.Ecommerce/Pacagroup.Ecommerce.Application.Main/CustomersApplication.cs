using System;
using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.internalinterface;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Transversal.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Pacagroup.Ecommerce.Application.Main
{
    public class CustomersApplication : ICustomerApplication
    {
        private readonly ICustomerDomain _customerDomain;
        private readonly IMapper _mapper;

        public CustomersApplication(IMapper mapper, ICustomerDomain customerDomain)
        {
            _customerDomain = customerDomain;
            _mapper = mapper;
        }

        #region Metodos Sincronos
        public Response<bool> Insert(CustomersDto customersDto)
        {
            var response = new Response<bool>();

            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = _customerDomain.Insert(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public Response<bool> Update(CustomersDto customersDto)
        {
            var response = new Response<bool>();

            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = _customerDomain.Update(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacion Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public Response<bool> Delete(string customerId)
        {
            var response = new Response<bool>();

            try
            {
                response.Data = _customerDomain.Delete(customerId);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminacion Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<CustomersDto> Get(string customerId)
        {
            var response = new Response<CustomersDto>();

            try
            {
                var customers = _customerDomain.Get(customerId);
                response.Data = _mapper.Map<CustomersDto>(customers);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<IEnumerable<CustomersDto>> GetAll()
        {
            var response = new Response<IEnumerable<CustomersDto>>();

            try
            {
                var customers = _customerDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CustomersDto>>(customers);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        #endregion

        #region Metodos Asincronos
        public async Task<Response<bool>> InsertAsync(CustomersDto customersDto)
        {
            {
                var response = new Response<bool>();

                try
                {
                    var customer = _mapper.Map<Customers>(customersDto);
                    response.Data = await _customerDomain.InsertAsync(customer);

                    if (response.Data)
                    {
                        response.IsSuccess = true;
                        response.Message = "Registro Exitoso!!!";
                    }
                }
                catch (Exception e)
                {
                    response.Message = e.Message;
                }
                return response;
            }
        }
        public async Task<Response<bool>> UpdateAsync(CustomersDto customersDto)
        {
            var response = new Response<bool>();

            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = await _customerDomain.UpdateAsync(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacion Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public async Task<Response<bool>> DeleteAsync(string customerId)
        {
            {
                var response = new Response<bool>();

                try
                {
                    response.Data = await _customerDomain.DeleteAsync(customerId);

                    if (response.Data)
                    {
                        response.IsSuccess = true;
                        response.Message = "Eliminacion Exitosa!!!";
                    }
                }
                catch (Exception e)
                {
                    response.Message = e.Message;
                }
                return response;
            }
        }
        public async Task<Response<CustomersDto>> GetAsync(string customerId)
        {
            var response = new Response<CustomersDto>();

            try
            {
                var customers = await _customerDomain.GetAsync(customerId);
                response.Data = _mapper.Map<CustomersDto>(customers);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public async Task<Response<IEnumerable<CustomersDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomersDto>>();

            try
            {
                var customers = await _customerDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CustomersDto>>(customers);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        #endregion

    }
}